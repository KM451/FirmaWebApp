using FirmaMobile.Models;
using FirmaMobile.ServiceReference;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirmaMobile.Services
{
    public class SposobyDostawyDataStore : ADataStore, IDataStore<SposobyDostawyForView>
    {
        public List<SposobyDostawyForView> Items { get; set; }
        public SposobyDostawyDataStore() => RefreshList();
        public async Task RefreshList()
        {
            var itemsFromService = firmaMobileService.SposobDostawyAllAsync().Result;
            Items = new List<SposobyDostawyForView>();
            Items = itemsFromService.Select(sposobDostawy => new SposobyDostawyForView(sposobDostawy)).ToList();
        }
        public async Task<bool> AddItemAsync(SposobyDostawyForView item)
        {
            var itemToAdd = new SposobDostawy()
            {
                Nazwa = item.Nazwa,
                Uwagi = item.Uwagi,
                CzyAktywny = true,
            };
            var itemFromService = new SposobyDostawyForView(firmaMobileService.SposobDostawyPOSTAsync(itemToAdd).Result);
            RefreshList();
            return await Task.FromResult(true);
        }
        public async Task<bool> DeleteItemAsync(SposobyDostawyForView item)
        {
            await firmaMobileService.SposobDostawyDELETEAsync(item.IdSposobuDostawy);
            RefreshList();
            return await Task.FromResult(true);
        }

        public async Task<SposobyDostawyForView> GetItemAsync(int id) => await Task.FromResult(Items.FirstOrDefault(s => s.IdSposobuDostawy == id));

        public async Task<IEnumerable<SposobyDostawyForView>> GetItemsAsync(bool forceRefresh = false) => await Task.FromResult(Items);

        public async Task<bool> UpdateItemAsync(SposobyDostawyForView item)
        {
            var oldItem = Items.Where((SposobyDostawyForView arg) => arg.IdSposobuDostawy == item.IdSposobuDostawy).FirstOrDefault();
            Items.Remove(oldItem);
            Items.Add(item);
            return await Task.FromResult(true);
        }
 
    }
}
