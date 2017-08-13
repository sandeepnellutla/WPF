using System.Collections.ObjectModel;

namespace DXSample.Data
{
    public class GroupList : ObservableCollection<GroupItem>
    {
        public GroupList()
        {
            Add(new GroupItem("Kristina"));
            Add(new GroupItem("Nick"));
            Add(new GroupItem("John"));
            Add(new GroupItem("Cam"));
            Add(new GroupItem("Chris"));
            Add(new GroupItem("Sandeep"));
            Add(new GroupItem("Scott"));
            Add(new GroupItem("Nash"));
        }
    }
}
