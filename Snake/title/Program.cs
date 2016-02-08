using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace title
{
	class Program
	{
		static void Main(string[] args)
		{
				//Console.WriteLine("The current console title is: \"{0}\"",
								//  Console.Title);
				Console.WriteLine("  (Press any key to change the console title.)");
				Console.ReadKey(true);
				Console.Title = "The title has changed!";
				Console.WriteLine("Note that the new console title is \"{0}\"\n" +
								  "  (Press any key to quit.)", Console.Title);
				Console.ReadKey(true);
			}
		}
	}
