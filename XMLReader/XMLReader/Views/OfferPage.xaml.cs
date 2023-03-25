using XMLReader.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XMLReader.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfferPage : ContentPage
    {
        public OfferViewModel ViewModel { get; private set; }
        public OfferPage(OfferViewModel ovm)
        {
            InitializeComponent();
            ViewModel = ovm;
            BindingContext = ViewModel;
        }
    }
}