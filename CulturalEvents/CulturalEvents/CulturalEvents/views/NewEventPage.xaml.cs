using CulturalEvents.model;
using CulturalEvents.viewmodels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CulturalEvents.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewEventPage : ContentPage
	{

        public NewEventPage(ObservableCollection<Event> events)
		{
			InitializeComponent();

            NewEventViewModel viewModel = new NewEventViewModel(events);
            BindingContext = viewModel;
		}
	}
}