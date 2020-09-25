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

		public megrendeles(string datum, string rszama, string email)
		{
			this.datum = datum;
			this.rszama = rszama;
			this.email = email;
			
		}

	}
}
