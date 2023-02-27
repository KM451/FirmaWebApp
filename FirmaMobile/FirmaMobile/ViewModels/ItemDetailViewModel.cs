using FirmaMobile.Models;
using FirmaMobile.Services;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel<Item>
    {
        private int itemId;
        private string text;
        private string description;
        public int Id { get; set; }
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public int ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(int itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
