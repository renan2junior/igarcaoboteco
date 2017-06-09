using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using iGarcaoBoteco.Models;

namespace iGarcaoBoteco.ViewModels
{
    public class MesasPageViewModel : BindableBase
    {

		public ObservableCollection<Mesa> Lista { get; }


		public MesasPageViewModel()
        {
			Lista = new ObservableCollection<Mesa>();
            GetDados();
        }

		private void GetDados()
		{
            var mesa = new Mesa();
            foreach (var item in mesa.LoadData())
			{
				Lista.Add(item);
			}
		}
    }
}

