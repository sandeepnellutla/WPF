using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;

namespace DXSample.ViewModels
{
    [POCOViewModel]
    public class TrackViewModel
    {
        public virtual TrackInfo Track { get; set; }

        protected TrackViewModel()
        {
            Track = new TrackList()[15];
        }
        protected TrackViewModel (TrackInfo trackobj)
        {
            if (trackobj == null)
                throw new ArgumentNullException("trackobj", "track is null");
            Load(trackobj);
        }

        public static TrackViewModel Create()
        {
            return ViewModelSource.Create(() => new TrackViewModel());
        }

        public static TrackViewModel Create(TrackInfo track)
        {
            return ViewModelSource.Create(() => new TrackViewModel(track));
        }
        
        public bool CanResetName()
        {
            return Track != null && !string.IsNullOrEmpty(Track.Name);
        }

        public void ResetName()
        {
            if (Track != null)
            {
                if (MessageBoxService.ShowMessage("Are you sure you want to reset?"
                    , "Question"
                    , MessageButton.YesNo
                    , MessageIcon.Question
                    , MessageResult.No) == MessageResult.Yes)
                {
                    Track.Name = "";
                }
            }
        }

        [ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
        protected virtual IMessageBoxService MessageBoxService { get { return null; } }

        private void Load(TrackInfo track)
        {
            this.Track = track;
        }
    }
}