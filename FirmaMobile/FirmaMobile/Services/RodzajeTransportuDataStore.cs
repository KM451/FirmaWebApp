using FirmaMobile.Models;
using FirmaMobile.ServiceReference;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirmaMobile.Services
{
    public class RodzajeTransportuDataStore : ADataStore, IDataStore<RodzajeTransportuForView>
    {
        public List<RodzajeTransportuForView> Items { get; set; }

        public RodzajeTransportuDataStore() => RefreshList();
        public async Task RefreshList()
        {
            var itemsFromService = firmaMobileService.RodzajTransportuAllAsync().Result;
            Items = new List<RodzajeTransportuForView>();
            Items = itemsFromService.Select(rodzajTransportu => new RodzajeTransportuForView(rodzajTransportu)).ToList();
        }
        public async Task<bool> AddItemAsync(RodzajeTransportuForView item)
        {
            var itemToAdd = new RodzajTransportu()
            {
                Nazwa = item.Nazwa,
                Uwagi = item.Uwagi,
                CzyAktywny = true,
            };
            var itemFromService = new RodzajeTransportuForView(firmaMobileService.RodzajTransportuPOSTAsync(itemToAdd).Result);
            RefreshList();
            return await Task.FromResult(true);
        }
        public async Task<bool> DeleteItemAsync(RodzajeTransportuForView item)
        {
            await firmaMobileService.RodzajTransportuDELETEAsync(item.IdRodzajuTransportu);
            RefreshList();
            return await Task.FromResult(true); 
        }

        public async Task<RodzajeTransportuForView> GetItemAsync(int id) => await Task.FromResult(Items.FirstOrDefault(s => s.IdRodzajuTransportu == id));

        public async Task<IEnumerable<RodzajeTransportuForView>> GetItemsAsync(bool forceRefresh = false) => await Task.FromResult(Items);

        public async Task<bool> UpdateItemAsync(RodzajeTransportuForView item)
        {
            var oldItem = Items.Where((RodzajeTransportuForView arg) => arg.IdRodzajuTransportu == item.IdRodzajuTransportu).FirstOrDefault();
            Items.Remove(oldItem);
            Items.Add(item);
            return await Task.FromResult(true);
        }

    }
}
