using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DXSample.Data;

namespace DXSample.ViewModels
{
    [POCOViewModel]
    public class DxGroupViewModel
    {

        public virtual GroupList DxGroupList { get; set; }

        protected DxGroupViewModel()
        {
            DxGroupList = new GroupList();
        }

        public static DxGroupViewModel Create()
        {
            return ViewModelSource.Create(() => new DxGroupViewModel());
        }
    }
}