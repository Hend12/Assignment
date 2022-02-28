using AssignmentTask.MarkupExtensions;
using AssignmentTask.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AssignmentTask.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        #region properties
        private ObservableCollection<MonitorClass> _monitors;
        public ObservableCollection<MonitorClass> monitors
        {
            get { return _monitors; }
            set { SetProperty(ref _monitors, value); }
        }
        private DateTime _MyDate;
        public DateTime MyDate
        {
            get { return _MyDate; }
            set { SetProperty(ref _MyDate, value); }
        }
        
        private string _SearchText;
        public string SearchText
        {
            get { return _SearchText; }
            set { SetProperty(ref _SearchText, value); }
        }
        private bool _FilterVisible;
        public bool FilterVisible
        {
            get { return _FilterVisible; }
            set { SetProperty(ref _FilterVisible, value); }
        }
        private bool _ToolbarVisible;
        public bool ToolbarVisible
        {
            get { return _ToolbarVisible; }
            set { SetProperty(ref _ToolbarVisible, value); }
        }
        private bool _SearchVisible;
        public bool SearchVisible
        {
            get { return _SearchVisible; }
            set { SetProperty(ref _SearchVisible, value); }
        }
        #endregion
        #region Commands
        public ICommand FilterCommand { get; set; }
        public ICommand ToolbarCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand HideExtention { get; set; }
        #endregion
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Monitor";
            MyDate = DateTime.Now;
            //Commands 
            FilterCommand = new Command(FilterCommandExcute);
            ToolbarCommand = new Command(ToolbarCommandExcute);
            SearchCommand = new Command(SearchCommandExcute);
            HideExtention = new Command<object>(HideExtentionExcute);
            monitors = new ObservableCollection<MonitorClass>()
            {
                new MonitorClass(){ Title="Wanted Thief",Name="Malak Hassan",CardColor=Color.Red,ImagePath="Resource/UserB1.jpg",Speed=0,
                    SpeedMeasurement="kmh",Time=new DateTime(2022, 2, 26, 14, 23, 00),TimeFormat ="AM",License="Resource/License1.jpg"},
                new MonitorClass(){ Title="Request to Authorities",Name="Mitsubishi Pajerp",CardColor=Color.Orange,ImagePath="Resource/SuperCar.jpg",Speed=220,
                    SpeedMeasurement="kmh",Time=new DateTime(2022, 2, 26, 14, 23, 00),TimeFormat="AM",License="Resource/LicenseBack2.jpg"},
                new MonitorClass(){ Title="Wanted Thief",Name="Fernado Tominos",CardColor=Color.Red,ImagePath="Resource/User2.jpg",Speed=220,
                    SpeedMeasurement="kmh",Time=new DateTime(2022, 2, 26, 14, 23, 00),TimeFormat="AM",License="Resource/License1.jpg"},
                new MonitorClass(){ Title="Clean",Name="Status Detail to be Mentioned Here",CardColor=Color.Green,ImagePath="Resource/ManiCar.jpg",Speed=220,
                    SpeedMeasurement="kmh",Time= new DateTime(2022, 2, 26, 14, 23, 00),TimeFormat="AM",License="Resource/Licenseback.jpg"},

                new MonitorClass(){ Title="Wanted Thief",Name="Malak Hassan",CardColor=Color.Red,ImagePath="Resource/UserB1.jpg",Speed=0,
                                    SpeedMeasurement="kmh",Time=new DateTime(2022, 2, 26, 14, 23, 00),TimeFormat="AM",License="Resource/License1.jpg"},
                new MonitorClass(){ Title="Request to Authorities",Name="Mitsubishi Pajerp",CardColor=Color.Orange,ImagePath="Resource/SuperCar.jpg",Speed=220,
                                    SpeedMeasurement="kmh",Time=new DateTime(2022, 2, 26, 14, 23, 00),TimeFormat="AM",License="Resource/LicenseBack2.jpg"},
                new MonitorClass(){ Title="Wanted Thief",Name="Fernado Tominos",CardColor=Color.Red,ImagePath="Resource/User2.jpg",Speed=220,
                                    SpeedMeasurement="kmh",Time=new DateTime(2022, 2, 26, 14, 23, 00),TimeFormat="AM",License="Resource/License1.jpg"},
                new MonitorClass(){ Title="Clean",Name="Status Detail to be Mentioned Here",CardColor=Color.Green,ImagePath="Resource/ManiCar.jpg",Speed=220,
                                    SpeedMeasurement="kmh",Time=new DateTime(2022, 2, 26, 14, 23, 00),TimeFormat="AM",License="Resource/Licenseback.jpg"},

               new MonitorClass(){ Title="Wanted Thief",Name="Malak Hassan",CardColor=Color.Red,ImagePath="Resource/UserB1.jpg",Speed=0,
                    SpeedMeasurement="kmh",Time=new DateTime(2022, 2, 26, 14, 23, 00),TimeFormat="AM",License="Resource/License1.jpg"},
                new MonitorClass(){ Title="Request to Authorities",Name="Mitsubishi Pajerp",CardColor=Color.Orange,ImagePath="Resource/SuperCar.jpg",Speed=220,
                    SpeedMeasurement="kmh",Time=new DateTime(2022, 2, 26, 14, 23, 00),TimeFormat="AM",License="Resource/LicenseBack2.jpg"},
                new MonitorClass(){ Title="Wanted Thief",Name="Fernado Tominos",CardColor=Color.Red,ImagePath="Resource/User2.jpg",Speed=220,
                    SpeedMeasurement="kmh",Time=new DateTime(2022, 2, 26, 14, 23, 00),TimeFormat="AM",License="Resource/License1.jpg"},
                new MonitorClass(){ Title="Clean",Name="Status Detail to be Mentioned Here",CardColor=Color.Green,ImagePath="Resource/ManiCar.jpg",Speed=220,
                    SpeedMeasurement="kmh",Time=new DateTime(2022, 2, 26, 14, 23, 00),TimeFormat="AM",License="Resource/Licenseback.jpg"},


            };
        }
        #region methods
        private void HideExtentionExcute(object obj)
        {
            string parmeter = obj.ToString();
            if (parmeter == "Search")
            {
                SearchVisible = false;
                SearchText = string.Empty;
            }
            else if (parmeter == "ToolBar")
                ToolbarVisible = false;
            else if (parmeter == "Filter")
                FilterVisible = false;
        }
        private void SearchCommandExcute(object obj)
        {
            SearchVisible = true;
        }

        private void ToolbarCommandExcute(object obj)
        {
            ToolbarVisible = true;
        }
        private void FilterCommandExcute(object obj)
        {
            FilterVisible = true;
        }
        #endregion
    }
}
