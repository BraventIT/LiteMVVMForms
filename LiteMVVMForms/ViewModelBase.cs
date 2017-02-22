using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteMVVMForms
{
    public abstract class ViewModelBase : BaseNotifyProperty, IViewModel
    {

        public ViewModelBase()
        {


        }

        public INavigator Navigation { get; set; }


        #region IsBusy

        private bool _isBusy;

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            {
                Set(ref _isBusy, value);
            }
        }

        #endregion

        #region Title

        private string _title;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                Set(ref _title, value);
            }
        }

        #endregion

        public virtual Task InitAsync()
        {
            return null;
        }

        public virtual void View_Appearing(object sender, EventArgs e)
        {

        }

        public virtual void View_Disappearing(object sender, EventArgs e)
        {

        }
    }
}
