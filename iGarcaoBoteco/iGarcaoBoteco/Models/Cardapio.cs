using System;
using System.Collections.Generic;

namespace iGarcaoBoteco.Models
{
    public class Cardapio
    {
        public Cardapio()
        {
        }

		public string Identificador { get; set; }
		public string Item { get; set; }
        public string Valor { get; set; }

        public Cardapio(string identificador, string item, string valor)
		{
			Identificador = identificador;
            Item = item;
            Valor = valor;
		}

        public List<Cardapio> LoadData()
		{

            var lista = new List<Cardapio>();

			lista.Add(new Cardapio("01", "Pastel", "R$ 10,00"));
			lista.Add(new Cardapio("02", "Bolinho de Bacalhau", "R$ 5,00"));
			lista.Add(new Cardapio("03", "Caldo de Feijão", "R$ 6,00"));
			lista.Add(new Cardapio("04", "Batata Frita", "R$ 15,00"));
			lista.Add(new Cardapio("05", "Empada", "R$ 5,00"));
			lista.Add(new Cardapio("06", "Cerveja", "R$ 8,00"));
			lista.Add(new Cardapio("07", "Refrigerante", "R$ 4,50"));
			lista.Add(new Cardapio("08", "Suco", "R$ 6,00"));
			lista.Add(new Cardapio("09", "Café", "R$ 2,00"));
			lista.Add(new Cardapio("10", "Vinho", "R$ 15,00"));
			lista.Add(new Cardapio("01", "Pastel", "R$ 10,00"));
			lista.Add(new Cardapio("02", "Bolinho de Bacalhau", "R$ 5,00"));
			lista.Add(new Cardapio("03", "Caldo de Feijão", "R$ 6,00"));
			lista.Add(new Cardapio("04", "Batata Frita", "R$ 15,00"));
			lista.Add(new Cardapio("05", "Empada", "R$ 5,00"));
			lista.Add(new Cardapio("06", "Cerveja", "R$ 8,00"));
			lista.Add(new Cardapio("07", "Refrigerante", "R$ 4,50"));
			lista.Add(new Cardapio("08", "Suco", "R$ 6,00"));
			lista.Add(new Cardapio("09", "Café", "R$ 2,00"));
			lista.Add(new Cardapio("10", "Vinho", "R$ 15,00"));
			lista.Add(new Cardapio("01", "Pastel", "R$ 10,00"));
			lista.Add(new Cardapio("02", "Bolinho de Bacalhau", "R$ 5,00"));
			lista.Add(new Cardapio("03", "Caldo de Feijão", "R$ 6,00"));
			lista.Add(new Cardapio("04", "Batata Frita", "R$ 15,00"));
			lista.Add(new Cardapio("05", "Empada", "R$ 5,00"));
			lista.Add(new Cardapio("06", "Cerveja", "R$ 8,00"));
			lista.Add(new Cardapio("07", "Refrigerante", "R$ 4,50"));
			lista.Add(new Cardapio("08", "Suco", "R$ 6,00"));
			lista.Add(new Cardapio("09", "Café", "R$ 2,00"));
			lista.Add(new Cardapio("10", "Vinho", "R$ 15,00"));

			return lista;
		}
    }
}
