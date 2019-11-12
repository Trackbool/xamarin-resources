using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CulturalEvents.model
{
    public class ObservableObject : INotifyPropertyChanged
    {
        protected void INotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}