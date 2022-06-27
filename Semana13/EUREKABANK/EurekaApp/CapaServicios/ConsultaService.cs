using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaServicios
{
   public class ConsultaService: GeneralService
   {

      public DataTable traerMovimientos(string cuenta)
      { 
         // Variables
         DataTable data = new DataTable();
         string sql = "select movinumero NUMERO, convert(varchar,movifecha,103) FECHA,"
            + "tiponombre TIPO, moviimporte IMPORTE "
            + "from v_movimiento where cuencodigo=@cuenta";
         // Mensaje por defecto
         this.Estado = 1;
         this.Mensaje = "Proceso ejecutado correctamente.";
         // PRoceso general
         using(SqlConnection con = new SqlConnection(CadenaConexion))
         {
            try
            {
               // Preparar el comando
               con.Open();
               SqlCommand cmd = new SqlCommand(sql,con);
               // Agregar parámetro
               cmd.Parameters.Add("@cuenta",SqlDbType.VarChar,10).Value = cuenta;
               // Ejecutar el comendo
               SqlDataReader reader = cmd.ExecuteReader();
               if (reader.HasRows)
               {
                  data.Load(reader);
               } else
               {
                  this.Estado = -1;
                  this.Mensaje = "Cuenta no existe.";
               }
            }
            catch (Exception e)
            {
               this.Estado = -1;
               this.Mensaje = e.Message;
            }
         }
         // Reporte
         return data;
      }

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
