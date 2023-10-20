using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App {
	public static class Output {

		public static void Line (string msg ) {
			Message ( msg + '\n' );
		}

		public static void Message ( string msg ) {
			Console.Write(msg);
		}

	}
}
