using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AssignmentTask.MarkupExtensions
{
    [ContentProperty(nameof(Source))]
    public class PlatformResourceImageExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrWhiteSpace(Source)) return null;

            string imageSource = String.Empty;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    {
                        imageSource = Source;
                        break;
                    }
                case Device.Android:
                    {
                        imageSource = Source;
                        break;
                    }
                case Device.UWP:
                    {
                        imageSource = String.Concat("Resource/", Source);
                        break;
                    }
            }
            return ImageSource.FromFile(imageSource);
        }
    }
}