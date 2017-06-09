using Xamarin.Forms;

namespace iGarcaoBoteco.Views
{
    public partial class ContentTabbedPage : TabbedPage
    {
        public ContentTabbedPage()
        {
            InitializeComponent();

            this.Children.Add(new MesasPage());
            this.Children.Add(new CardapioPage());
        }
    }
}

