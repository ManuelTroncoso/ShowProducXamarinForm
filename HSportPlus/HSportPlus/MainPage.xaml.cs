using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HSportPlus
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductDetail());
        }
    }
}
