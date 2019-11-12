using System;
using System.Collections.Generic;
using System.Text;
using static CulturalEvents.model.EventEnum;

namespace CulturalEvents.model
{
    public class Event : ObservableObject
    {
        private EventType type;
        public EventType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                INotifyPropertyChanged();
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                INotifyPropertyChanged();
            }
        }

        private DateTime date;
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                INotifyPropertyChanged();
            }
        }

        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                INotifyPropertyChanged();
            }
        }

        private string imagePath;
        public string ImagePath
        {
            get
            {
                return imagePath;
            }
            set
            {
                imagePath = value;
                INotifyPropertyChanged();
            }
        }

        public Event()
        {

        }

        public Event(string name, DateTime date, string description, string imagePath)
        {
            Name = name;
            Date = date;
            Description = description;
            ImagePath = imagePath;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
