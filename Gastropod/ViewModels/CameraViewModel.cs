using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Gastropod.ViewModels
{
    [QueryProperty("Payload", "payload")]
    public class CameraViewModel : INotifyPropertyChanged
    {
        public CameraViewModel()
        {
        }

        private string _payload;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Payload
        {
            get { return _payload; }
            set
            {
                SetAndRaisePropertyChanged(ref _payload, value);
            }
        }

        protected void SetAndRaisePropertyChanged<TRef>(
            ref TRef field, TRef value, [CallerMemberName] string propertyName = null)
        {
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetAndRaisePropertyChangedIfDifferentValues<TRef>(
            ref TRef field, TRef value, [CallerMemberName] string propertyName = null)
            where TRef : class
        {
            if (field == null || !field.Equals(value))
            {
                SetAndRaisePropertyChanged(ref field, value, propertyName);
            }
        }
    }
}
