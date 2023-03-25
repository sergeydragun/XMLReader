using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json;
using XMLReader.Models;

namespace XMLReader.ViewModels
{
    public class OfferViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        OffersListViewModel olvm;
        public yml_catalogShopOffer Offer { get; private set; }
        

        public OfferViewModel()
        {
            Offer = new yml_catalogShopOffer();
        }

        public OffersListViewModel ListViewModel
        {
            get { return olvm; }
            set
            {
                if (olvm != value)
                {
                    olvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }

        public ushort Id
        {
            get { return Offer.id; }
        }

        public string JsonData
        {
            get
            {
                return JsonSerializer.Serialize<yml_catalogShopOffer>(Offer);
            }
        }

        protected virtual void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public yml_catalogShopOffer SetOffer
        {
            set { Offer = value; }
        }
    }
}