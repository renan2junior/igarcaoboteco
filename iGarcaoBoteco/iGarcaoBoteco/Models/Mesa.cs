using System;
using System.Collections.Generic;

namespace iGarcaoBoteco.Models
{
    public class Mesa
    {

        public string Identificador { get; set; }
        public string CorSituacao { get; set; }


        public Mesa( string identificador, string corsituacao )
        {
            Identificador = identificador;
            CorSituacao = corsituacao;
        }

        public Mesa()
        {

        }

        public List<Mesa> LoadData(){

            var lista = new List<Mesa>();

            lista.Add(new Mesa("01", "Red"));
            lista.Add(new Mesa("02", "Green"));
            lista.Add(new Mesa("03", "Green"));
            lista.Add(new Mesa("04", "Green"));
            lista.Add(new Mesa("05", "Red"));
            lista.Add(new Mesa("06", "Red"));
            lista.Add(new Mesa("07", "Green"));
            lista.Add(new Mesa("08", "Red"));
            lista.Add(new Mesa("09", "Green"));
            lista.Add(new Mesa("10", "Red"));

            return lista;
        }
    }
}
