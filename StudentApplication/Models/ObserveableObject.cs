using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Models
{
    public class ObserveableObject : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void onPropertyChanged(string propertyNme)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyNme));
        }
    }
}
