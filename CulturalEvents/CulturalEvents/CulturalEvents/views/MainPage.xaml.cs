using CulturalEvents.model;
using CulturalEvents.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CulturalEvents
{
    public partial class MainPage : ContentPage
    {
        MainViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();

            viewModel = new MainViewModel();
            BindingContext = viewModel;
        }

        private void EventsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Event selectedEvent = eventsListView.SelectedItem as Event;
            Navigation.PushAsync(new EventDetailPage(selectedEvent));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewEventPage(viewModel.Events));
        }
    }
}
