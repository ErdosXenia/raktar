using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raktar
{
    class tetel
    {
		private string kod;

		public string Kod
		{
			get { return kod; }
			set { kod = value; }
		}

		private int db;

		public int DB
		{
			get { return db; }
			set { db = value; }
		}

		

		public tetel(string kod, int db)
		{
			this.kod = kod;
			this.db = db;
		}


	}
}
