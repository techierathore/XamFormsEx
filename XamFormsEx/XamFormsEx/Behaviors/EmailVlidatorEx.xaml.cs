﻿
using Xamarin.Forms;

namespace XamFormsEx.Behaviors
{
    public partial class EmailVlidatorEx : ContentPage
	{
		public EmailVlidatorEx()
		{
			InitializeComponent ();
		}
	}

    public class EmailVlidator : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }
        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            if (!args.NewTextValue.Contains("@"))
            {
                ((Entry)sender).TextColor = Color.Red;
            }
            else ((Entry)sender).TextColor = Color.Default;
        }

    }
}