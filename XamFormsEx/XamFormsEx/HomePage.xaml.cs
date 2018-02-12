
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamFormsEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : MasterDetailPage
	{
		public HomePage ()
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