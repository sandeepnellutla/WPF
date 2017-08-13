using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxGroupBox.Data
{
    public class DataRepository : ObservableCollection<GroupRepository>
    {
        public DataRepository()
        {

        }
        public DataRepository(int numberOfResults)
        {
            for (int i = 1; i < numberOfResults + 1; i++)
            {
                ObservableCollection<GroupItemRepository> groupItems = new ObservableCollection<GroupItemRepository>();

                for (int j = 1; j < 5; j++)
                {
                    groupItems.Add(new GroupItemRepository($"Content Item {j}"));
                }
                Add(new GroupRepository($"Group {i}", groupItems));
            }
        }
    }

    public class GroupRepository 
    {
        private string _headerName;
        private ObservableCollection<GroupItemRepository> _groupItems;

        public string HeaderName
        {
            get { return _headerName; }
            set { _headerName = value; }
        }

        public ObservableCollection<GroupItemRepository> GroupItems
        {
            get { return _groupItems; }
            set { _groupItems = value; }
        }
        public GroupRepository() { }
        public GroupRepository(string headerName) : this(headerName, new ObservableCollection<GroupItemRepository>())
        {
        }
        public GroupRepository(string headerName, ObservableCollection<GroupItemRepository> list)
        {
            HeaderName = headerName;
            GroupItems = list;
        }
    }

    public class GroupItemRepository
    {
        private string _contentName;

        public string ContentName
        {
            get { return _contentName; }
            set { _contentName = value; }
        }

        public GroupItemRepository()
        {
        }

        public GroupItemRepository(string contentName)
        {
            ContentName = contentName;
        }
    }

}
