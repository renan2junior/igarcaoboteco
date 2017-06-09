using Prism.Unity;
using iGarcaoBoteco.Views;

namespace iGarcaoBoteco
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync(nameof(MainPage));
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<ContentTabbedPage>();
		}
	}
}

