using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LiteMVVMForms
{
    [Obsolete("Use the static class ViewFactory. This interface is no longer available", true)]
    public interface IViewFactory
    {
        void Register<TViewModel, TView>()
            where TViewModel : class, IViewModel
            where TView : Page;


        Page Resolve<TViewModel>(TViewModel viewModel)
            where TViewModel : class, IViewModel;


    }
}
