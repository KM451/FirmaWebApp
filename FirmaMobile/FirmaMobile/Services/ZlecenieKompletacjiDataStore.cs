using Firma.Utils.Extensions;
using FirmaMobile.ServiceReference;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirmaMobile.Services
{
    public class ZlecenieKompletacjiDataStore : ADataStore, IDataStore<ZleceniaKompletacjiForView>
    {
        public List<ZleceniaKompletacjiForView> Items { get; set; }
        public ZlecenieKompletacjiDataStore() => RefreshList();
        public async Task RefreshList()
        {
            var itemsFromService = firmaMobileService.ZlecenieKompletacjiAllAsync().Result;
            Items = itemsFromService.ToList();
        }
        public async Task<bool> AddItemAsync(ZleceniaKompletacjiForView item)
        {
            var itemToAdd = new ZlecenieKompletacji
            {
                DataWystawienia = item.DataWystawienia,
                OczekiwanaDataRealizacji = item.OczekiwanaDataRealizacji,
                PotwierdzonaDataRealizacji = item.PotwierdzonaDataRealizacji,
                Ilosc = item.Ilosc,
                Priorytet = item.Priorytet,
                Status = item.Status,
                CzyAktywne = item.CzyAktywne,
                CzasZlecenia = item.CzasZlecenia
            };
            itemToAdd.CopyPropertiesExtension(item);
            var itemFromService = firmaMobileService.ZlecenieKompletacjiPOSTAsync(itemToAdd).Result;
            RefreshList();
            return await Task.FromResult(true);
        }
        public async Task<bool> DeleteItemAsync(ZleceniaKompletacjiForView item)
        {
            await firmaMobileService.ZlecenieKompletacjiDELETEAsync(item.IdZleceniaKompletacji);
            RefreshList();
            return await Task.FromResult(true);
        }

        public async Task<ZleceniaKompletacjiForView> GetItemAsync(int id)
        {
            return await Task.FromResult(Items.FirstOrDefault(item => item.IdZleceniaKompletacji == id));
        }

        public async Task<IEnumerable<ZleceniaKompletacjiForView>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(Items);
        }

        public async Task<bool> UpdateItemAsync(ZleceniaKompletacjiForView item)
        {
            var oldItem = Items.Where((ZleceniaKompletacjiForView arg) => arg.IdZleceniaKompletacji == item.IdZleceniaKompletacji).FirstOrDefault();
            Items.Remove(oldItem);
            Items.Add(item);
            return await Task.FromResult(true);
        }
    }
}
