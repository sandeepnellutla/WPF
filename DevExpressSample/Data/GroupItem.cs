using System.ComponentModel;

namespace DXSample.Data
{
    public class GroupItem : INotifyPropertyChanged
    {
        public GroupItem() { }

        public GroupItem(string item)
        {
            Item = item;
        }

        string gitem;
        public string Item
        {
            get
            {
                return gitem;
            }
            set
            {
                if (gitem == value)
                    return;
                gitem = value;
                OnPropertyChanged("Item");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
