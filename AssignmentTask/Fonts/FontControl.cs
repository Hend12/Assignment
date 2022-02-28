using Prism;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AssignmentTask.Fonts
{
    public class FontControl : Label
    {
        public FontControl()
        {
            FontFamily = DeviceInfo.Platform == DevicePlatform.Android ? "Font Awesome 5 Pro-Solid-900.ttf#Font Awesome 5 Pro-Solid-900":"";
            //: "Assets/Font Awesome 5 Pro-Solid-900.ttf#Font Awesome 5 Free";
        }
        private static FontControl instasnce;
        public static FontControl Instasnce
        {
            get
            {
                if (instasnce == null)
                    return instasnce = new FontControl();
                return instasnce;
            }
        }
    }
}
