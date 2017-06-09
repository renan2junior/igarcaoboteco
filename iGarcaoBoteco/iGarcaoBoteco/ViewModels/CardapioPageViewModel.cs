using Prism.Mvvm;
using iGarcaoBoteco.Models;
using System.Collections.ObjectModel;

namespace iGarcaoBoteco.ViewModels
{
    public class CardapioPageViewModel : BindableBase
    {

        public ObservableCollection<Cardapio> Lista { get; }
        public CardapioPageViewModel()
        {
            Lista = new ObservableCollection<Cardapio>();
			GetDados();
        }

		private void GetDados()
		{
            var cardapio = new Cardapio();
            foreach (var item in cardapio.LoadData())
			{
				Lista.Add(item);
			}
		}
    }
}
