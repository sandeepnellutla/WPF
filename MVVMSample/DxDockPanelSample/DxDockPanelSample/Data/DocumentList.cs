using System.Collections.ObjectModel;
using DxDockPanelSample.ViewModel;

namespace DxDockPanelSample.Data
{
    public class DocumentList : ObservableCollection<DocumentItem>
    {
        public DocumentList()
        {
            //Add(new DxDocumentPanelViewModel("Document 1"));
            //Add(new DxDocumentPanelViewModel("Document 2"));
            //Add(new DxDocumentPanelViewModel("Document 3"));
            //Add(new DxDocumentPanelViewModel("Document 4"));

            Add(new DocumentItem("Document 1"));
            Add(new DocumentItem("Document 2"));
            Add(new DocumentItem("Document 3"));
            Add(new DocumentItem("Document 4"));
        }        
    }
}
