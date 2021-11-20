using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class ContactGroup : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region fields
        private string _name;
        #endregion

        #region properties

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public ObservableCollection<Contact> Members { get; set; } = new ObservableCollection<Contact>();
        public int ID { get; set; }
        #endregion

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
