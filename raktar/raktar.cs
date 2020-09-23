using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raktar
{


    class termek
    {
		private string kod;

		public string Kod
		{
			get { return kod; }
			set { kod = value; }
		}

		private string nev;

		public string Nev
		{
			get { return nev; }
			set { nev = value; }
		}

		private int ar;

		public int Ar
		{
			get { return ar; }
			set { ar = value; }
		}

		private int db;

		public int DB
		{
			get { return db; }
			set { db = value; }
		}

		public termek(string kod, string nev, int ar, int db)
		{
			this.kod = kod;
			this.nev = nev;
			this.ar = ar;
			this.db = db;
		}

	}
}
