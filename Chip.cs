using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico3
{
   internal class Chip
   {
      private string empresa;
      private int numero;

      public Chip(string empresa, int numero)
      {
         this.empresa = empresa;
         this.numero = numero;
      }

      public string getEmpresa() { return empresa; }
      public void setEmpresa(string empresa) {  this.empresa = empresa;}

      public int getNumero() { return numero; }
      public void setNumero(int numero) { this.numero = numero;}

      public string Mostrar()
      {
         return $"Nro: {numero}\nEmpresa: {empresa}";
      }
   }
}
