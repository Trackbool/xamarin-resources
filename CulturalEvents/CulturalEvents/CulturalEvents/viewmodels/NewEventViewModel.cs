using CulturalEvents.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using static CulturalEvents.model.EventEnum;

namespace CulturalEvents.viewmodels
{
    class NewEventViewModel : BaseViewModel
    {
        private ObservableCollection<Event> events;
        private Event newEvent;
        private DelegateCommand addEvent;
        private EventType selectedEventType;

        public NewEventViewModel(ObservableCollection<Event> events)
        {
            this.events = events;
            newEvent = new Event();
        }

        public Event NewEvent
        {
            get
            {
                return newEvent;
            }
            set
            {
                newEvent = value;
                INotifyPropertyChanged();
            }
        }

        public EventType SelectedEventType
        {
            get { return selectedEventType; }
            set
            {
                selectedEventType = value;
                INotifyPropertyChanged();
            }
        }

        public IEnumerable<EventType> EventTypeValues
        {
            get
            {
                return Enum.GetValues(typeof(EventType)).Cast<EventType>();
            }
        }

        public ICommand AddEvent
        {
            get
            {
                return addEvent = addEvent ?? new DelegateCommand(AddEventCommand);
            }
        }

        private void AddEventCommand()
        {
            events.Add(newEvent);
            //Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
