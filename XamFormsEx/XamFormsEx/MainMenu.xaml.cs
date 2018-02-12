using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamFormsEx.Pages;

namespace XamFormsEx
{
    public partial class MainMenu : ContentPage
	{
        public ListView ListView { get { return lstMenuItems; } }
        public MainMenu()
        {
            InitializeComponent();

            var vMenuItems = new List<XamFormsMenuItem>();
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "Pages",
                IconSource = "contacts.png",
                TargetType = typeof(PagesHome)
            });
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "Layouts",
                IconSource = "todo.png",
                //TargetType = typeof(LayoutsHome)
            });
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "Views",
                IconSource = "reminders.png",
               // TargetType = typeof(XamFormsMenuItem)
            });
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "Styles",
                IconSource = "reminders.png",
                //TargetType = typeof(StylesHome)
            });
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "Triggers",
                IconSource = "reminders.png",
                //TargetType = typeof(TriggersHome)
            });
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "Behaviors",
                IconSource = "reminders.png",
                //TargetType = typeof(BehaviorsEx)
            });
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "Effects",
                IconSource = "reminders.png",
                //TargetType = typeof(EffectsHome)
            });
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "Control Templates",
                IconSource = "reminders.png",
                //TargetType = typeof(TemplatesHome)
            });
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "Controls Examples",
                IconSource = "reminders.png",
                //TargetType = typeof(ControlsExHome)
            });
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "Misc",
                IconSource = "reminders.png",
                //TargetType = typeof(MiscHome)
            });
            lstMenuItems.ItemsSource = vMenuItems;
        }
    }

    public class XamFormsMenuItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}