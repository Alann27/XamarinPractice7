using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinPractice7.Services;

namespace XamarinPractice7.ViewModels
{

    public class HomeViewModel : INotifyPropertyChanged
    {
        public string DependencyServiceTitle { get; } = "Dependency Service practice";
        public string Orientation { get; set; }


        public string CustomRendererTitle { get; } = "Custom Renderer practice";
        public string NormalEntryText { get; } = "This is a normal Entry";
        public string CustomEntryText { get; } = "Hello, this is a custom entry";

        public string Effects { get; } = "Effects practice";
        public string EntryWithoutEffect { get; } = "Entry without focus effect";
        public string EntryWithEffect { get; } = "Entry with focus effect";

        public string PlatformSpecificsTitle { get; } = " Platform Specific practice - NavigationBar";
        public ICommand GetOrientarionCommand { get; }
        public IDeviceOrientationService DeviceOrientationService { get; }
        public HomeViewModel(IDeviceOrientationService deviceOrientarionService)
        {
            DeviceOrientationService = deviceOrientarionService;

            var orientation = DeviceOrientationService.GetOrientation();

            Orientation = orientation.ToString();

            GetOrientarionCommand = new Command(OnGetOrientarion);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnGetOrientarion()
        {
            var orientation = DeviceOrientationService.GetOrientation();

            Orientation = orientation.ToString();
        }
    }
}
