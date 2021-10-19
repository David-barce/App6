using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    public class PageHomeViewModel : BaseViewModel
    {
        Command _goToRoot;
        public PageHomeViewModel(INavigation navigation = null) : base(navigation)
        {

        }

        public Command GoToRootCommand
        {
            get => _goToRoot ?? (_goToRoot = new Command(GoToRootAction));
        }

        private void GoToRootAction()
        {
            Navigation.PopToRootAsync();
        }
    }
}
