using System;
using Xamarin.Forms;

namespace XamFormsEx.Pages
{
    public partial class PagesHome : ContentPage
	{
		public PagesHome ()
		{
			InitializeComponent ();
		}

        public void OnContentClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ContentPageEx());
        }
        public void OnTabbedClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new TabbedPageEx());
        }
        public void OnCarsoulClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CarouselPageEx());
        }
        public void OnMasterClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MstrDetailEx());
        }
    }
}