using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class Contact : INotifyPropertyChanged
    {
        #region fields
        private string _name;
        private bool _online;

        #endregion

        #region properties
        public int ID { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public bool Online
        {
            get { return _online; }
            set
            {
                _online = value;
                OnPropertyChanged("Online");
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
