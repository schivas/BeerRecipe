using System.ComponentModel;

using System;
using System.Runtime.CompilerServices;

namespace BeerRecipe.Classes
{
   public abstract class BaseINPC : INotifyPropertyChanged
   {
      public event Action<string> KeyPropertyChanged;
      public event PropertyChangedEventHandler PropertyChanged;

      protected void RaisePropertyChanged(string propertyName)
      //protected void RaisePropertyChanged([CallerMemberName]string propertyName = "")
      {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }

      protected void RaiseKeyPropertyChanged(string propertyName)
      {
         KeyPropertyChanged?.Invoke(propertyName);
      }
   }

   public abstract class BaseINPC2 : INotifyPropertyChanged
   {
      public event Action<string> KeyPropertyChanged;
      public event PropertyChangedEventHandler PropertyChanged;

      // Denne syntaksen gjør at en ikke trenger å legge inn navnet på propertyen som kaller denne - kompileren finner ut av det ;-)
      protected void RaisePropertyChanged([CallerMemberName]string propertyName = "")
      {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }

      protected void RaiseKeyPropertyChanged([CallerMemberName]string propertyName = "")
      {
         KeyPropertyChanged?.Invoke(propertyName);
      }
   }
}
