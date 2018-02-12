
using System;
using Xamarin.Forms;

namespace XamFormsEx
{
    public partial class AppHome : MasterDetailPage
	{
		public AppHome()
		{
			InitializeComponent ();
            MenuPage.ListView.ItemSelected += OnItemSelected;

        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as XamFormsMenuItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                MenuPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}