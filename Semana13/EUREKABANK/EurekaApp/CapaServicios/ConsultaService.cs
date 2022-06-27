using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace CapaServicios
{
   public class ConsultaService
   {

      public DataTable traerPersonas()
      {
         // Variables
         DataTable result = new DataTable();
         // Definir columnas
         result.Columns.Add("ID",typeof(int));
         result.Columns.Add("NOMBRE",typeof(string));
         result.Columns.Add("EDAD",typeof (int));
         // Datos
         result.Rows.Add(1, "Gustavo", 50);
         result.Rows.Add(2, "Karla", 30);
         result.Rows.Add(3, "Sergio", 40);
         result.Rows.Add(4, "Daniela", 28);
         result.Rows.Add(5, "Pedro", 34);
         result.Rows.Add(6, "Alejandra", 41);
         result.Rows.Add(7, "Manuel", 38);
         // Reporte
         return result;
      }


   }
}
