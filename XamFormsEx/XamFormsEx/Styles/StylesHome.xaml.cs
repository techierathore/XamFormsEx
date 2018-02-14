using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamFormsEx.Styles
{

	public partial class StylesHome : ContentPage
	{
		public StylesHome ()
		{
			InitializeComponent ();
		}
        public void OnImplicitClicked(object sender, EventArgs args)
        {

            Navigation.PushAsync(new ImplicitEx());
        }

        public void OnExplicitClicked(object sender, EventArgs args)
        {

            Navigation.PushAsync(new ExplicitEx());

        }

        public void OnGlobalClicked(object sender, EventArgs args)
        {

            Navigation.PushAsync(new GlobalEx());

        }

        public void OnDynamicClicked(object sender, EventArgs args)
        {

            //Navigation.PushAsync(new TriggerEx());
            Navigation.PushAsync(new DynamicEx());

        }
    }
}