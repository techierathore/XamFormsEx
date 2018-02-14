using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamFormsEx.MarkUpExtn
{
	public partial class TypeDemo : ContentPage
	{
		public TypeDemo ()
		{
			InitializeComponent ();
            CreateCommand = new Command<Type>((Type viewType) =>
            {
                View view = (View)Activator.CreateInstance(viewType);
                view.VerticalOptions = LayoutOptions.CenterAndExpand;
                stackLayout.Children.Add(view);
            });

            BindingContext = this;
        }
        public ICommand CreateCommand { private set; get; }
    }
}