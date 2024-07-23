using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ArenaTracker.Classes;

public class BasePropertyChanged : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChange([CallerMemberName] string propertyName = "")
    {
        if (String.IsNullOrEmpty(propertyName))
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    
}