using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AssignmentTask.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Picker.SelectedIndex != -1)
            {             
                PickerSelected.IsVisible = false;
                Picker.SelectedItem = Picker.Items[Picker.SelectedIndex];
            }

        }
    }
}