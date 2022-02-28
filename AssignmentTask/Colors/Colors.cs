using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AssignmentTask.Colors
{
    public class Colors : INotifyPropertyChanged
    {
        private static Colors instasnce;
        public static Colors Instasnce
        {
            get
            {
                if (instasnce == null)
                    return instasnce = new Colors();
                return instasnce;
            }
        }
        private static Color _BlackColor = Color.Black;
        public Color BlackColor { get { return _BlackColor; } set { _BlackColor = value; OnPropertyChanged(); } }
        private static Color _VeryLightBlackColor = ColorConverters.FromHex("#161616");
        public Color VeryLightBlackColor { get { return _VeryLightBlackColor; } set { _VeryLightBlackColor = value; OnPropertyChanged(); } }
        private static Color _DarkGrayColor = ColorConverters.FromHex("#686868");
        public Color DarkGrayColor { get { return _DarkGrayColor; } set { _DarkGrayColor = value; OnPropertyChanged(); } }
        private static Color _LightGrayColor = ColorConverters.FromHex("#DCDCDC");
        public Color LightGrayColor { get { return _LightGrayColor; } set { _LightGrayColor = value; OnPropertyChanged(); } }

        private static Color _LightBlackColor = ColorConverters.FromHex("#262525");
        public Color LightBlackColor { get { return _LightBlackColor; } set { _LightBlackColor = value; OnPropertyChanged(); } }
        private static Color _WhiteColor = Color.White;
        public Color WhiteColor { get { return _WhiteColor; } set { _WhiteColor = value; OnPropertyChanged(); } }
        private static Color _RedColor = Color.Red;
        public Color RedColor { get { return _RedColor; } set { _RedColor = value; OnPropertyChanged(); } }
        private static Color _GreenColor = ColorConverters.FromHex("#4CD964");
        public Color GreenColor { get { return _GreenColor; } set { _GreenColor = value; OnPropertyChanged(); } }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
