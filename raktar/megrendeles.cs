using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raktar
{
    class megrendeles
    {
		private string datum;

		public string Datum
		{
			get { return datum; }
			set { datum = value; }
		}

		private string rszama;

		public string Rszama
		{
			get { return rszama; }
			set { rszama = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private int osszeg;

		public int Osszeg
		{
			get { return osszeg; }
			set { osszeg = value; }
		}


		private List<tetel> tetelek;

		public void TetelHozzaad(string kod, int db)
		{
			tetelek.Add(new tetel(kod, db));
		}

		private int Ara(string kod, List<termek> termekek)
		{
			int i = 0;
			while (termekek[i].Kod !=kod)
			{
				i++;
			}
			return termekek[i].Ar;
		}

		public void Szamolas()
		{
			// kód alapján megkeresni a terméket -> ár

			// szum += ár * db (ahány termék van)
			int szum = 0;
			for (int i = 0; i < tetelek.Count; i++)
			{
				int ar = Ara(tetelek[i].Kod, termekek);
				szum += ar * tetelek[i].DB;
			}

		}

		public megrendeles(string datum, string rszama, string email)
		{
			this.datum = datum;
			this.rszama = rszama;
			this.email = email;

			tetelek = new List<tetel>();
			
		}

	}
}
