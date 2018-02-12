using System;
using Xamarin.Forms;

namespace XamFormsEx.Layouts
{
    public partial class LayoutHome : ContentPage
	{
		public LayoutHome ()
		{
			InitializeComponent ();
		}

        public void OnStackComplexClicked(object sender, EventArgs args)
        {

            Navigation.PushAsync(new StackComplexEx());

        }
        public void OnStackSimpleClicked(object sender, EventArgs args)
        {

            Navigation.PushAsync(new StackEx());

        }
        public void OnGridClicked(object sender, EventArgs args)
        {

            Navigation.PushAsync(new GridEx());

        }
        public void OnRelativeSimpClicked(object sender, EventArgs args)
        {

            Navigation.PushAsync(new RelSimpleEx());

        }
        public void OnRelativeCompClicked(object sender, EventArgs args)
        {

            Navigation.PushAsync(new RelComplexEx());

        }
        public void OnAbsCompClicked(object sender, EventArgs args)
        {

            Navigation.PushAsync(new AbsComplexEx());

        }
        public void OnAbsSimpleClicked(object sender, EventArgs args)
        {

            Navigation.PushAsync(new AbsSimpleEx());

        }
        public void OnFrameClicked(object sender, EventArgs args)
        {

            Navigation.PushAsync(new FramesEx());

        }

    }
}