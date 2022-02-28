using AssignmentTask.Custom;
using AssignmentTask.UWP.CustomRendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
[assembly: ExportRenderer(typeof(BorderLessPicker), typeof(BorderLessPickerRender))]
namespace AssignmentTask.UWP.CustomRendering
{
    public class BorderLessPickerRender : PickerRenderer
    {
        public static void Init() { }
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
                Control.Margin = new Windows.UI.Xaml.Thickness(0);
                Control.Padding = new Windows.UI.Xaml.Thickness(0);
                Control.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Transparent);
                Control.Foreground= new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.White);
                Control.FocusVisualSecondaryBrush= new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Transparent);
   
         
            }
             Control.Style = (Windows.UI.Xaml.Style)App.Current.Resources["pickerstyle"];

        }
}

}
