using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class Compte
    {
        private int numero;
        private string nom;
        private double solde;
        private double decouvert;

		public Compte ()
        {
			int numero = 0;
			string nom = "";
			double solde = 0;
			double decouvert = 0;
        }
        public Compte (int numero , string nom , double solde , double decouvert)
        {
            this.numero = numero;
            this.nom = nom;
            this.solde = solde;
            this.decouvert = decouvert;
        }

		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}

		public string Nom
		{
			get { return nom; }
			set { nom = value; }
		}

		public double Solde
		{
			get { return solde; }
			set { solde = value; }
		}

		public double Decouvert
		{
			get { return decouvert; }
			set { decouvert = value; }
		}

		public void Crediter(double montant)
        {
			this.solde = this.solde + montant;
        }

		public bool Debiter(double montant)
		{
			bool res = false;
			this.solde = this.solde - montant;

			if (this.solde >= this.decouvert)
            {
				res = true;
            }
			return res;
		}

		public bool Transferer(double montant , Compte c)
        {
			bool res = false;
			this.solde = this.solde - montant;

			if(this.solde >= this.decouvert)
            {
				res = true;
				c.Crediter(montant);
            }
			return res;
        }

		public bool superieur(Compte c)
        {
			bool res = false;
			if(this.solde > c.solde)
            {
				res = true;
            }
			return res;
        }

		public bool Inferieur(Compte c)
		{
			bool res = false;
			if (this.solde < c.solde)
			{
				res = true;
			}
			return res;
		}

		public void ToString()
        {
			Console.WriteLine("Numero : " + this.numero + " Nom : " + this.nom + " Solde : "+this.solde + " Découvert autorisé : "+this.decouvert);
        }
	}
}
