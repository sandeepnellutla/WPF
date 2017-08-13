using System.ComponentModel;

namespace DXSample.Data
{
    public class TabMenuInfo : INotifyPropertyChanged
    {
        public TabMenuInfo() { }

        public TabMenuInfo(string menuName, string menuDescription)
        {
            MenuName = menuName;
            MenuDescription = menuDescription;
        }

        string menuName;

        public string MenuName
        {
            get { return menuName; }
            set
            {
                if (menuName == value)
                    return;
                menuName = value;
                OnPropertyChanged("MenuName");
            }
        }

        string menuDescription;
        public string MenuDescription
        {
            get { return menuDescription; }
            set
            {
                if (menuDescription == value)
                    return;
                menuDescription = value;
                OnPropertyChanged("MenuDescription");
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
