using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XMLReader.ViewModels;

namespace XMLReader.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OffersListPage : ContentPage
    {
        public OffersListPage()
        {
            InitializeComponent();
            BindingContext = new OffersListViewModel() { Navigation = this.Navigation };
        }
    }
}