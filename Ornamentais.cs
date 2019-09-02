using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantas_Rodrigo_1600176.Classes
{
    public class Ornamentais : Plantas
    {
        public string Beleza { get; set; }
		public string GerarHash()
		{
			return "";
		}
		public Ornamentais()
        {

        }
        public Ornamentais(string _beleza)
        {
            Beleza = _beleza;
        }
        public List<object> GerarLista()
        {
            List<object> listaPlantas = new List<object>();
            listaPlantas.Add(new Ornamentais("Flor Branca"));
			return listaPlantas;
		}
		
    }
}
