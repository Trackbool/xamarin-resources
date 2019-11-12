using CulturalEvents.model;
using CulturalEvents.viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CulturalEvents.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventDetailPage : ContentPage
	{
		public EventDetailPage(Event selectedEvent)
		{
			InitializeComponent();

            EventDetailViewModel viewModel = new EventDetailViewModel(selectedEvent);
            BindingContext = viewModel;
		}
	}
}