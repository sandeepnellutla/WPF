using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DxGroupBox.Data;
using DevExpress.Mvvm.POCO;

namespace DxGroupBox.ViewModels
{
    [POCOViewModel]
    public class GroupViewModel
    {
        public virtual DataRepository GroupContainer { get; set; }

        protected GroupViewModel()
        {
            GroupContainer = new DataRepository(10);
        }

        public static GroupViewModel Create()
        {
            return ViewModelSource.Create(() => new GroupViewModel());
        }
    }
}