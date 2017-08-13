using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DxDockPanelSample.Data;

namespace DxDockPanelSample.ViewModel
{
    [POCOViewModel]
    public class DxDockPanelViewModel
    {
        public virtual DocumentList DocumentContainer { get; set; }

        protected DxDockPanelViewModel()
        {
            DocumentContainer = new DocumentList();
        }

        public static DxDockPanelViewModel Create()
        {
            return ViewModelSource.Create(() => new DxDockPanelViewModel());
        }
    }
}