using Xamarin.Forms;
using XamFormsEx.CusRndrrs;
using XamFormsEx.Droid.Renderers;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderedEntry), typeof(BorderEntryRenderer))]

namespace XamFormsEx.Droid.Renderers
{
    public class BorderEntryRenderer : EntryRenderer
    {
        //public BorderEntryRenderer()
        //{
        //    Background = Android.Graphics.Drawables.Drawable.CreateFromPath("@drawable/EntryBorder.xml");
        //}
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
            }
        }
    }
}