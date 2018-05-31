using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using ItemsViewer.Model;
using ItemsViewer.SR_Items;

namespace ItemsViewer.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        ServiceItemsClient client = new ServiceItemsClient();
        private string _selectedCategory = "";
        public ObservableCollection<XItem> Items { get; set; }
        public ObservableCollection<XItem> FilteredItems { get; set; }
        public string[] Categories { get; set; }
        public RelayCommand ResetBtnClick { get; set; }

        public string SelectedCategory
        {
            get => _selectedCategory; set
            {
                _selectedCategory = value;
                Refresh(SelectedCategory);
            }
        }

        public MainViewModel()
        {
            Categories = client.GetCategories();
            Items = new ObservableCollection<XItem>(client.QueryAllItems());
            FilteredItems = new ObservableCollection<XItem>(Items);

            ResetBtnClick = new RelayCommand(() =>
            {
                FilteredItems.Clear();
                foreach (var item in Items)
                {
                    FilteredItems.Add(item);
                }
            });

            Task.Factory.StartNew(AutoRefresh);
        }

        private void AutoRefresh()
        {
            while (true)
            {
                App.Current.Dispatcher.Invoke(()=> 
                {
                    Items = null;
                    Items = new ObservableCollection<XItem>(client.QueryAllItems());
                    if(!SelectedCategory.Equals(""))Refresh(SelectedCategory);
                    RaisePropertyChanged("Items");
                });
                Thread.Sleep(5000);
            }
        }

        private void Refresh(string category)
        {
            FilteredItems.Clear();
            foreach (var item in Items)
            {
                if (item.Category.Equals(category))
                {
                    FilteredItems.Add(item);
                }
            }
        }
    }
}