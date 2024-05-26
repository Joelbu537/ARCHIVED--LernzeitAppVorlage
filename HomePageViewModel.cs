using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LernzeitApp
{
    public class YourEvent : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }
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
            //Remote Liste aus DB abrufen und verarbeiten
            YourEventList = new List<YourEvent>
            {
                new YourEvent { Name = "Schach-AG", StartTime = "09:00", Location = "Raum A"},
                new YourEvent { Name = "Schule ohne Rassismus", StartTime = "10:30", Location = "Raum B"},
                new YourEvent { Name= "Philosophie", StartTime = "15:00", Location = "Raum D"},
                new YourEvent { Name="Mathe-Lernzeit", StartTime = "12:55", Location = "Raum A"},
                new YourEvent { StartTime = "14:45", Location = "Raum D"},
                new YourEvent { StartTime = "12:4", Location = "Raum E"},
                new YourEvent { StartTime = "15:05", Location = "Raum A"},
                new YourEvent { StartTime = "17:30", Location = "Raum C"},
                new YourEvent { StartTime = "9:00", Location = "Raum D"},
                new YourEvent { StartTime = "15:05", Location = "Raum B"},
                new YourEvent { StartTime = "18:00", Location = "Raum B"},
                new YourEvent { StartTime = "16:50", Location = "Raum E"},
                new YourEvent { StartTime = "07:50", Location = "Raum A"},
                new YourEvent { StartTime = "12:30", Location = "Raum C"},
                new YourEvent { StartTime = "10:30", Location = "Raum E"}
            };
        }
    }
}
