using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamFormsEx.Behaviors;
using XamFormsEx.Pages;
using XamFormsEx.Styles;
using XamFormsEx.Templates;
using XamFormsEx.Triggers;

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
                TargetType = typeof(Layouts.LayoutHome)
            });
            //vMenuItems.Add(new XamFormsMenuItem
            //{
            //    Title = "Views",
            //    IconSource = "reminders.png",
            //    // TargetType = typeof(XamFormsMenuItem)
            //});
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "MarkUp Extensions",
                IconSource = "reminders.png",
               TargetType = typeof(MarkUpExtn.MarkUpExtHome)
            });
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "Styles",
                IconSource = "reminders.png",
                TargetType = typeof(StylesHome)
            });
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "Triggers",
                IconSource = "reminders.png",
                TargetType = typeof(TriggersHome)
            });
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "Templates",
                IconSource = "reminders.png",
                TargetType = typeof(TemplatesHome)
            });
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "Behaviors",
                IconSource = "reminders.png",
                TargetType = typeof(BehaviorsHome)
            });
            vMenuItems.Add(new XamFormsMenuItem
            {
                Title = "MVVM Ex",
                IconSource = "reminders.png",
                TargetType = typeof(MVVMEx.MvvmHome)
            });
            //vMenuItems.Add(new XamFormsMenuItem
            //{
            //    Title = "Effects",
            //    IconSource = "reminders.png",
            //    //TargetType = typeof(EffectsHome)
            //});
            //vMenuItems.Add(new XamFormsMenuItem
            //{
            //    Title = "Control Templates",
            //    IconSource = "reminders.png",
            //    //TargetType = typeof(TemplatesHome)
            //});
            //vMenuItems.Add(new XamFormsMenuItem
            //{
            //    Title = "Controls Examples",
            //    IconSource = "reminders.png",
            //    //TargetType = typeof(ControlsExHome)
            //});
            //vMenuItems.Add(new XamFormsMenuItem
            //{
            //    Title = "Misc",
            //    IconSource = "reminders.png",
            //    //TargetType = typeof(MiscHome)
            //});
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