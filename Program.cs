using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico3
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Chip chip1 = new Chip("Ancel", 091111111);
         Chip chip2 = new Chip("Claro", 092222222);
         Chip chip3 = new Chip("Movistar", 093333333);
         SmartPhone android = new SmartPhone("xiaomi", 2400, "BateriaXioami");

         Console.WriteLine(android.agregarChip(chip1));
         Console.WriteLine(android.agregarChip(chip2));
         Console.WriteLine(android.agregarChip(chip3));

         Console.ReadKey();
      }
   }


}
