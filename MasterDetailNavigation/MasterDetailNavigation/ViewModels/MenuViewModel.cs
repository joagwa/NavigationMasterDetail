using MasterDetailNavigation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MasterDetailNavigation.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public Command SelectMenuItemCommand { get; set; }

        public MenuViewModel()
        {
            SelectMenuItemCommand = new Command(item =>
            {
                var page = item as Page;
                var pageType = page.GetType();
                var utilType = typeof(INavigationService);
                var baseMethod = utilType.GetMethod("NavigateToAsync", new Type[] { pageType });
                var typedViewModel = baseMethod.MakeGenericMethod(pageType.GetType());
                var viewModel = typedViewModel.Invoke(null, new[] { pageType });
            });
        }
    }
}
