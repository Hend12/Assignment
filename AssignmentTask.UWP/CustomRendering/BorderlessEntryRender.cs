using AssignmentTask.Custom;
using AssignmentTask.UWP.CustomRendering;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
[assembly: ExportRenderer(typeof(BorderLessEntry), typeof(BorderlessEntryRender))]
namespace AssignmentTask.UWP.CustomRendering
{
    public class BorderlessEntryRender : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
                Control.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Transparent);
            }
        }


    }
}
