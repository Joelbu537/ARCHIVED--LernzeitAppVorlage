using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LernzeitApp
{
    public class YourEvent : INotifyPropertyChanged
    {
        private string _startTime;
        public string StartTime
        {
            get { return _startTime; }
            set { _startTime = value; OnPropertyChanged(); }
        }

        private string _location;
        public string Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class HomePageViewModel
    {
        public List<YourEvent> YourEventList { get; set; }

        public HomePageViewModel()
        {
            // Hier fügst du deine Ereignisse zur Liste hinzu
            YourEventList = new List<YourEvent>
            {
                new YourEvent { StartTime = "09:00", Location = "Raum A" },
                new YourEvent { StartTime = "10:30", Location = "Raum B" },
                // Weitere Ereignisse nach Bedarf hinzufügen
            };
        }
    }
}
