using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LiteMVVMForms
{
    public class LiteNavigationPageService<TViewModel> : ILitePageService where TViewModel : class, IViewModel
    {
        public Page Create(IViewModel vm)
        {
            var view = ViewFactory.Resolve<TViewModel>(vm as TViewModel);
            return new NavigationPage(view);
        }

        public Page Create()
        {
            var vm = Activator.CreateInstance<TViewModel>();
            var view = ViewFactory.Resolve<TViewModel>(vm);
            return new NavigationPage(view);
        }
    }
}
