using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
	internal class Personne
	{
		public string Nom { get; set; }
		public string Prenom { get; set; }
		public DateOnly Ddn { get; set; }

		public string MajPrenom()
		{
			Prenom = Prenom.ToUpper();
			return Prenom;
		}

		public static string Test { get; set; } = "RANTANPLAN";
		
	}
}
