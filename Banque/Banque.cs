using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class Banque
    {
        private List<Compte> mesComptes;
        public Banque()
        {
            mesComptes = new List<Compte>();
        }
		public List<Compte> MesComptes
		{
			get { return mesComptes; }
			set { mesComptes = value; }
		}

		public void AjouterCompte(Compte c )
		{
			mesComptes.Add(c);
		}

		public void AjouterCompte(int numero, string nom, double solde, double decouvert)
		{
			Compte c = new Compte(numero, nom, solde, decouvert);
			this.AjouterCompte(c);
		}

		public void RendCompte(int num)
        {
			 foreach (Compte c in mesComptes)
			{
				if(num == c.Numero)
                {
					c.ToString();
                }
			}
        }

		public void ToString()
        {
			foreach(Compte c in mesComptes)
            {
				c.ToString();
            }
        }
	}
}
