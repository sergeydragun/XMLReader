using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using XMLReader.Models;
using Xamarin.Forms;
using XMLReader;
using XMLReader.Views;
using System.Collections;
using System;

namespace XMLReader.ViewModels
{
    public class OffersListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<OfferViewModel> Offers { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public ICommand ChooseOfferCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }
        public ICommand GetOffersCommand { protected set; get; }
        public ICommand DeleteAllCommand { protected set; get; }

        OfferViewModel selectedOffer;
        private bool isEnabled;
        private bool isVisible;
        public INavigation Navigation { get; set; }

        public OffersListViewModel()
        {
            IsEnabled = true;
            Offers = new ObservableCollection<OfferViewModel>();
            ChooseOfferCommand = new Command(ChooseOffer);
            BackCommand = new Command(Back);
            GetOffersCommand = new Command(GetOffers);
            DeleteAllCommand = new Command(DeleteAll);
        }

        private void DeleteAll()
        {
            IsEnabled = true;
            Offers.DeleteAllObjects();
            IsVisible = false;
        }

        private async void GetOffers()
        {
            IsEnabled = false;
            var offers = await XMLGetter.GetXmlText("http://partner.market.yandex.ru/pages/help/YML.xml");

            foreach (yml_catalogShopOffer offer in offers)
            {
                Offers.Add(new OfferViewModel { SetOffer = offer, ListViewModel = this});
            }
            IsVisible = true;
        }

        public OfferViewModel SelectedOffer
        {
            get { return selectedOffer; }
            set
            {
                if (selectedOffer != value)
                {
                    OfferViewModel tempOffer = value;
                    selectedOffer = null;
                    OnPropertyChanged("SelectedOffer");
                    Navigation.PushAsync(new OfferPage(tempOffer));
                }
            }
        }
        private void Back()
        {
            Navigation.PopAsync();
        }

        private void ChooseOffer(object obj)
        {
            Navigation.PushAsync(new OfferPage(new OfferViewModel() { ListViewModel = this }));
        }

        public bool IsEnabled
        {
            get { return isEnabled; }
            set
            {
                isEnabled = value;
                OnPropertyChanged("IsEnabled");
            }
        }

        public bool IsVisible
        {
            get { return isVisible; }
            set
            {
                isVisible = value;
                OnPropertyChanged("IsVisible");
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}