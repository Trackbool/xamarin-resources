using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarRenting
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var carList = new List<CarViewModel>();
            CarViewModel car1 = new CarViewModel("Audi R5", "Esto es un Audi R5", 4, true, 20.4f);
            List<string> images = new List<string>();
            images.Add("coche1.jpg");
            images.Add("coche2.jpg");
            car1.Images = images;
            carList.Add(car1);

            CarViewModel car2 = new CarViewModel("Suzuki Baleno", "Suzuki Baleno descripción", 4, false, 50f);
            images = new List<string>();
            images.Add("coche2.jpg");
            images.Add("coche3.jpg");
            images.Add("coche1.jpg");
            car2.Images = images;
            carList.Add(car2);

            carList.Add(new CarViewModel("Ford GT", "Ejemplo de Ford GT", 2, true, 92.99f));
            carList.Add(new CarViewModel("Porche Cayane", "La descripción del Porche cayane", 5, false, 120.5f));
            carModelPicker.ItemsSource = carList;
        }

        private void CarModelPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarViewModel selectedItem = carModelPicker.SelectedItem as CarViewModel;
            if (selectedItem != null)
            {
                isFuelSwitch.IsToggled = selectedItem.IsFuel;
                rentButton.IsEnabled = true;
                ShowImages(selectedItem);
            }
        }

        private void ShowImages(CarViewModel carView)
        {
            photoGalleryContainer.Children.Clear();
            if (carView.Images.Count > 0)
            {
                foreach (string imagePath in carView.Images)
                {
                    photoGalleryContainer.Children.Add(new Image() { Source = imagePath });
                }
            }
            else
            {
                photoGalleryContainer.Children.Add(new Label()
                {
                    Text = "No hay imágenes disponibles",
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                });
            }
        }

        private void RentButton_Clicked(object sender, EventArgs e)
        {
            CarViewModel selectedItem = carModelPicker.SelectedItem as CarViewModel;
            Navigation.PushAsync(new RentCarPage(selectedItem));
        }
    }
}
