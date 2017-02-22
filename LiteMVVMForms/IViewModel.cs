using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteMVVMForms
{
    public interface IViewModel
    {
        INavigator Navigation { get; set; }
        void View_Appearing(object sender, EventArgs e);
        void View_Disappearing(object sender, EventArgs e);
        Task InitAsync();
    }
}
