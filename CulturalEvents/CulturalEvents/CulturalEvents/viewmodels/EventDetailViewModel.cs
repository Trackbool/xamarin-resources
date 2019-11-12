using CulturalEvents.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturalEvents.viewmodels
{
    class EventDetailViewModel : BaseViewModel
    {
        private Event currentEvent;

        public Event CurrentEvent
        {
            get
            {
                return currentEvent;
            }
            set
            {
                currentEvent = value;
                INotifyPropertyChanged();
            }
        }

        public EventDetailViewModel(Event currentEvent)
        {
            this.currentEvent = currentEvent;
        }
    }
}
