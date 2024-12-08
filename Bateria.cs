using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico3
{
   internal class Bateria
   {
      private int mAh;
      private string marca;

      public Bateria(int mAh, string marca)
      {
         this.mAh = mAh;
         this.marca = marca;
      }

      public int getmAh() { return  mAh; }
      public void setmAh(int mAh) { this.mAh = mAh; }

      public string getMarca() { return marca; }
      public void setMarca(string marca) { this.marca = marca; }  

      public string Mostrar()
      {
         return $"{mAh}mAh de la marca {marca}";
      }
   }
}
