using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AssignmentTask.Fonts
{
    public class RobotoFontControl : Label
    {
        public RobotoFontControl()
        {
            FontFamily = RegularFont;
        }
        private static RobotoFontControl instasnce;
        public static RobotoFontControl Instasnce
        {
            get
            {
                if (instasnce == null)
                    return instasnce = new RobotoFontControl();
                return instasnce;
            }
        }
        public string RegularFont
        {
            get { return "Roboto_Regular.ttf#Roboto_Regular"; }
        }
        public string MeduimFont
        {
            get { return "Roboto_Medium.ttf#Roboto_Medium"; }
        }
        public string BoldFont
        {
            get { return "Roboto_Bold.ttf#Roboto_Bold"; }
        }
    }

}
