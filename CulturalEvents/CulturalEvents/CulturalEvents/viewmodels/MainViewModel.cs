using CulturalEvents.model;
using CulturalEvents.views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CulturalEvents
{
    class MainViewModel : BaseViewModel
    {
        private ObservableCollection<Event> events = new ObservableCollection<Event>();

        public MainViewModel()
        {
            LoadEvents();
        }

        public ObservableCollection<Event> Events
        {
            get
            {
                return events;
            }
            set
            {
                events = value;
                INotifyPropertyChanged();
            }
        }

        public ICommand OpenNewEventWindowCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new NewEventPage(events));
                });
            }
        }

        private void LoadEvents()
        {
            Events.Clear();
            Events.Add(new Event("Partido futbol 1", DateTime.Now, "Primer partido futbol", "football1"));
            Events.Add(new Event("Salto a la comba", DateTime.Now, "Salto a la comba", "gaming1"));
            Events.Add(new Event("Cumpleaños Martín", DateTime.Now, "10º cumpleaños Martín", "gaming1"));
        }
    }
}
