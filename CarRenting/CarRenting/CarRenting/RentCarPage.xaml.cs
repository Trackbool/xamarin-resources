using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarRenting
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RentCarPage : ContentPage
    {
        public CarViewModel Car { set; get; }
        public RentCarPage(CarViewModel car)
        {
            Car = car;
            InitializeComponent();
            BindingContext = this;

            pickUpDatePicker.MinimumDate = DateTime.Now;
            returnDatePicker.MinimumDate = (pickUpDatePicker.Date).AddDays(1);
            birthDatePicker.MinimumDate = DateTime.Now.AddYears(-100);
            birthDatePicker.MaximumDate = DateTime.Now.AddYears(-18);
        }

        private void PickUpDatePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            returnDatePicker.MinimumDate = (pickUpDatePicker.Date).AddDays(1);
            UpdateTotalAmount(sender, e);
        }

        private void UpdateTotalAmount(object sender,
            System.ComponentModel.PropertyChangedEventArgs e)
        {
            totalAmountLabel.Text = CalculatePrice(Car.RentingPrice) + "€";
        }

        private float CalculatePrice(float amountPerDay)
        {
            float price = Convert.ToSingle(amountPerDay *
                (returnDatePicker.Date - pickUpDatePicker.Date).TotalDays);

            DateTime youngDate = DateTime.Now.AddYears(-25);
            if (birthDatePicker.Date > youngDate)
            {
                price += (price * 0.10f);
            }

            return price;
        }
    }
}