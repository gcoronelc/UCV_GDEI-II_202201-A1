using System;
using System.Collections.Generic;
using System.Text;
using CapaModelo;

namespace CapaServicios
{
   public class LogonService:GeneralService
   {

      public EmpleadoModel validarUsuario(string usuario, string clave)
      {
         this.Estado = -1;
         this.Mensaje = "Probando el error";
         return null;
      }


   }
}
