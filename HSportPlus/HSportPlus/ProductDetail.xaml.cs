using HPlusSports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HSportPlus
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductDetail : ContentPage
	{
		public ProductDetail ()
		{
			InitializeComponent ();    
		}

        public ProductDetail(Product target)
        {
            InitializeComponent();
            BindingContext = target;

        }
    }
}