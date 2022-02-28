using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AssignmentTask.Models
{
    public class MonitorClass
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public double Speed { get; set; }
        public string SpeedMeasurement { get; set; }
        public DateTime Time { get; set; }
        public string TimeFormat { get; set; }
        public string License { get; set; }
        public Color CardColor { get; set; }
    }
}
