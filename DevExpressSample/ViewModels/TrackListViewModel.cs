using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DXSample.ViewModels
{
    [POCOViewModel]
    public class TrackListViewModel
    {
        public virtual TrackList Tracks { get; set; }

        protected TrackListViewModel()
        {
            Tracks = new TrackList();
        }

        public static TrackListViewModel Create()
        {
            return ViewModelSource.Create(() => new TrackListViewModel());
        }

        [ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
        protected virtual IDocumentManagerService DocumentMangerService { get { return null; } }

        public void EditTrack(object trackobj)
        {
            var track = trackobj as TrackInfo;
            var document = DocumentMangerService.CreateDocument("TrackView", TrackViewModel.Create(track));
            document.Show();
        }

        [ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
        protected virtual IDialogService DialogService { get { return null; } }
        public void ViewTrack(object trackobj)
        {
            var track = trackobj as TrackInfo;
            DialogService.ShowDialog(
                null
                , "Track Information"
                , "TrackView"
                , TrackViewModel.Create(track));            
        }
    }
}