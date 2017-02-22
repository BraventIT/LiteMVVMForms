using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LiteMVVMForms
{
    public class LiteMasterDetailPageService<TViewModelMenu, TViewModelDetail>
        where TViewModelMenu : class, IViewModel where TViewModelDetail : class, IViewModel
    {
        public MasterDetailPage Create(Page pageMenu, Page pageDetail, string icon = null)
        {
            var master = new MasterDetailPage();
            master.Master = pageMenu;
            if (icon != null) master.Icon = icon;
            master.Detail = pageDetail;
            return master;
        }
    }
}
