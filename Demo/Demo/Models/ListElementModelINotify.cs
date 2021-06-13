using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Demo.Models
{
    public class ListElementModelINotify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private string _name;
        public string Name
        {
            get => _name; 
            set
            {
                if (value != _name)
                {
                    _name = value;
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
                }
            }
        }

      

    }
}
