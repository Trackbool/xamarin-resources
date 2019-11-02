using System;
using System.Collections.Generic;
using System.Text;

namespace CarRenting
{
    public class CarViewModel
    {
        public string Model { set; get; }
        public string Description { set; get; }
        public int PlacesNumber { set; get; }
        public bool IsFuel { set; get; }
        public float RentingPrice { set; get; }
        public List<string> Images { set; get; }

        public CarViewModel(string model, string description, int placesNumber, bool isFuel, float rentingPrice)
        {
            Model = model;
            Description = description;
            PlacesNumber = placesNumber;
            IsFuel = isFuel;
            RentingPrice = rentingPrice;
            Images = new List<string>();
        }

        public override string ToString()
        {
            return Model;
        }
    }
}
