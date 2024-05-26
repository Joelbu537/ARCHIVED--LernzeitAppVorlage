using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LernzeitApp
{
    public class Ereigniss : INotifyPropertyChanged
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
        private string _freeSlots;
        public string FreeSlots
        {
            get
            {
                { return _freeSlots; }
            }
            set
            {
                _freeSlots = value; OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class HomePageViewModel
    {
        public List<Ereigniss> YourEventList { get; set; }

        public HomePageViewModel()
        {
            //Remote Liste aus DB abrufen und verarbeiten
            YourEventList = new List<Ereigniss>
            {
                new Ereigniss { Name = "Schach-AG", StartTime = "09:00", Location = "Raum A", FreeSlots = "8"},
                new Ereigniss { Name = "Schule ohne Rassismus", StartTime = "10:30", Location = "Raum B", FreeSlots = "3"},
                new Ereigniss { Name= "Philosophie", StartTime = "15:00", Location = "Raum D"},
                new Ereigniss { Name="Mathe-Lernzeit", StartTime = "12:55", Location = "Raum A"},
                new Ereigniss { StartTime = "14:45", Location = "Raum D"},
                new Ereigniss { StartTime = "12:4", Location = "Raum E"},
                new Ereigniss { StartTime = "15:05", Location = "Raum A"},
                new Ereigniss { StartTime = "17:30", Location = "Raum C"},
                new Ereigniss { StartTime = "9:00", Location = "Raum D"},
                new Ereigniss { StartTime = "15:05", Location = "Raum B"}
            };
        }
    }
}
