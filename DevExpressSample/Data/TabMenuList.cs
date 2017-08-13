using System.Collections.ObjectModel;

namespace DXSample.Data
{
    public class TabMenuList : ObservableCollection<TabMenuInfo>
    {
        public TabMenuList()
        {
            Add(new TabMenuInfo("Tab 1", "Tab Description One"));
            Add(new TabMenuInfo("Tab 2", "Tab Description Twp"));
            Add(new TabMenuInfo("Tab 3", "Tab Description Three"));
            Add(new TabMenuInfo("Tab 4", "Tab Description Four"));
            Add(new TabMenuInfo("Tab 5", "Tab Description Five"));
            Add(new TabMenuInfo("Tab 6", "Tab Description Six"));
            Add(new TabMenuInfo("Tab 7", "Tab Description Seven"));
            Add(new TabMenuInfo("Tab 8", "Tab Description Eigth"));
            Add(new TabMenuInfo("Tab 9", "Tab Description Nine"));
            Add(new TabMenuInfo("Tab 10", "Tab Description Ten"));
        }
    }
}
