using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DXSample.Data;

namespace DXSample.ViewModels
{
    [POCOViewModel]
    public class DxTabViewModel
    {
        public virtual TabMenuList TabContainer { get; set; }

        protected DxTabViewModel()
        {
            TabContainer = new TabMenuList();
        }

        public static DxTabViewModel Create()
        {
            return ViewModelSource.Create(() => new DxTabViewModel());
        }
    }
}