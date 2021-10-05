using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace App6.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        Command _goToViewHomeCommand;
        string username;
        string password;
        private bool isError;

        public MainPageViewModel(INavigation navigation) : base(navigation)
        {

        }

        public string Username
        {
            get => username;
            set
            {

                username = value;
                OnPropertyChanged();

            }
        }

        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }

        public Command GoToViewHomeCommand
        {
            get => _goToViewHomeCommand ?? (_goToViewHomeCommand = new Command(GoToViewHomeAction));
        }

        public bool IsError
        {
            get => isError;
            set 
            {
                isError = value;
                OnPropertyChanged();
            
            }

        }

        private void GoToViewHomeAction()
        {
            IsError = !(Username == "David" && Password == "123456");
            if (!IsError)
            {
                Navigation.PushAsync(new PageHome());
            }


        }
    }
}
