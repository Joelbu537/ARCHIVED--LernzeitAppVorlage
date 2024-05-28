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
        private string _endTime;
        public string EndTime//Not implemented
        {
            get
            {
                return _endTime;
            }
            set
            {
                _endTime = value; OnPropertyChanged();
            }
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
                return _freeSlots;
            }
            set
            {
                _freeSlots = value; OnPropertyChanged();
            }
        }
        private string _maxSlots;
        public string MaxSlots //Not implemented
        {
            get
            {
                return _maxSlots;
            }
            set
            {
                _maxSlots = value; OnPropertyChanged();
            }
        }
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value; OnPropertyChanged();
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
                new Ereigniss { Name= "Philosophie", StartTime = "15:00", Location = "Raum D", FreeSlots = "2"},
                new Ereigniss { Name="Mathe-Lernzeit", StartTime = "12:55", Location = "Raum A"},
                new Ereigniss { StartTime = "14:45", Location = "Raum D", Name = "Deutsch-Lernzeit", FreeSlots = "8"},
                new Ereigniss { StartTime = "12:4", Location = "Raum E", FreeSlots = "16", Name = "Latein-Lernzeit"},
                new Ereigniss { StartTime = "15:05", Location = "Raum A", Name = "Deutsch ?-Stunde", FreeSlots = "0"},
                new Ereigniss { StartTime = "17:30", Location = "Raum C", Name = "Roboter-AG", FreeSlots = "1"},
                new Ereigniss { StartTime = "9:00", Location = "Raum D", FreeSlots = "5", Name = "Kunst-AG"},
                new Ereigniss { StartTime = "15:05", Location = "Raum B", FreeSlots = "14", Name = "SV-Sitzung"}
            };
        }
    }
}
