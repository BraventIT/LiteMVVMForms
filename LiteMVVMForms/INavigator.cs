﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LiteMVVMForms
{
    public interface INavigator
    {
        INavigation Navigation { get; }

        Task<IViewModel> PopAsync();

        Task<IViewModel> PopModalAsync();

        Task PopToRootAsync();

        Task<TViewModel> PushAsync<TViewModel>(TViewModel viewModel)
            where TViewModel : class, IViewModel;

        Task<TViewModel> PushAsync<TViewModel>()
            where TViewModel : class, IViewModel;

        Task<TViewModel> PushModalAsync<TViewModel>(TViewModel viewModel)
            where TViewModel : class, IViewModel;

        Task<TViewModel> PushModalAsync<TViewModel>()
            where TViewModel : class, IViewModel;

        Task DisplayAlert(string title, string message, string okbutton);

        Task<bool> DisplayAlert(string title, string message, string okbutton, string cancelbutton);

        Task<string> DisplayActionSheet(string title, string cancel, string desctruction, string[] buttons);
    }
}
