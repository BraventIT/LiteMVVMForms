using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LiteMVVMForms
{
    public class ListView : Xamarin.Forms.ListView
    {
        public ListView()
        {
            this.ItemTapped += ListView_ItemTapped;
        }

        #region ItemSelectedCommand Bindable Property

        public static BindableProperty ItemSelectedCommandProperty =
            BindableProperty.Create<ListView, ICommand>(x => x.ItemSelectedCommand, null);

        public ICommand ItemSelectedCommand
        {
            get { return (ICommand)this.GetValue(ItemSelectedCommandProperty); }
            set { this.SetValue(ItemSelectedCommandProperty, value); }
        }

        #endregion

        void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null && this.ItemSelectedCommand != null && this.ItemSelectedCommand.CanExecute(e.Item))
            {
                this.ItemSelectedCommand.Execute(e.Item);
            }

            this.SelectedItem = null;
        }
    }
}
