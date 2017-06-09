using System;
using System.Diagnostics;
using iGarcaoBoteco.Helpers;
using iGarcaoBoteco.Views;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace iGarcaoBoteco.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {

        public Command LoginCommand { get; }
        public Command DoAtendimentoCommand { get; }
        readonly AzureService azureService = new AzureService();
        readonly INavigationService _navigationService;
        string _tituloBotaoLogar;
        bool _visibleButtonAtendimento;




        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            LoginCommand = new Command(LoginCommandExecuteAsync);
            DoAtendimentoCommand = new Command(DoAtendimentoCommandExecute);
            VisibleButtonAtendimento = false;
            if (Settings.IsLoggedIn){
                VisibleButtonAtendimento = true;
                _navigationService.NavigateAsync(nameof(ContentTabbedPage));
            }else{
                VisibleButtonAtendimento = false;    
            }
            DoTituloBotaoLogar();
        }

        private void DoAtendimentoCommandExecute(object obj)
        {
			_navigationService.NavigateAsync(nameof(ContentTabbedPage));
        }

        private async void LoginCommandExecuteAsync(object obj)
        {
            if (Settings.IsLoggedIn)
            {
                await azureService.Logout();
                VisibleButtonAtendimento = false;
            }else{
                var user = await azureService.LoginAsync();
                if (Settings.IsLoggedIn)
                {
                    VisibleButtonAtendimento = true;
                    _navigationService.NavigateAsync(nameof(ContentTabbedPage));
                }
            }
            DoTituloBotaoLogar();
        }

        private void DoTituloBotaoLogar(){
            TituloBotaoLogar = " Login com Facebook ";
            if (Settings.IsLoggedIn){
                TituloBotaoLogar = "Logout"; 
            }
        }

        public bool VisibleButtonAtendimento
        {
            get { return _visibleButtonAtendimento; }
            private set{SetProperty(ref _visibleButtonAtendimento, value);}
        }

        public string TituloBotaoLogar
        {
			get { return _tituloBotaoLogar; }
            set{ SetProperty(ref _tituloBotaoLogar, value);}
        }
 
        public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
		}
	}
}

