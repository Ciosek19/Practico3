using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico3
{
   internal class SmartPhone
   {
      private string modelo;
      private Bateria bateria;
      private int nroChips;
      private List<Chip> listaChips;

      public SmartPhone(string modelo, int mAh, string marcaBateria)
      {
         nroChips = 0;
         bateria = new Bateria(mAh, marcaBateria);
         listaChips = new List<Chip>();
      }

      public string agregarChip(Chip nuevoChip)
      {
         if (nroChips < 2)
         {
            listaChips.Add(nuevoChip);
            ++nroChips;
            return "Se introdujo el chip";
         }
         else
         {
            return "No hay mas espacio";
         }
      }

      public string Mostrar()
      {
         return $"Modelo: {modelo}\nBateria: {bateria.Mostrar()}";
      }

      public string getModelo() { return modelo; }
      public void setModelo(string modelo) { this.modelo = modelo; }

      public Bateria getBateria() { return bateria; }
      public void setBateria(Bateria bateria) { this.bateria = bateria; }

      public int getNroChips() { return nroChips; }
      public void setNroChips(int nrochips) { nroChips = nrochips; }

      public List<Chip> getChips() { return listaChips; }
      public void setChips(List<Chip> chips) { listaChips = chips; }

   }
}
