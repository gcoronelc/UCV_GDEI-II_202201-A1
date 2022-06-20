using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaServicios;

namespace EurekaApp
{
   public partial class FormDeposito : Form
   {

      private static FormDeposito instancia = null;
      public static FormDeposito GetInstance()
      {
         if (((instancia == null) || (instancia.IsDisposed == true)))
         {
            instancia = new FormDeposito();
         }
         instancia.BringToFront();
         return instancia;
      }

      private FormDeposito()
      {
         InitializeComponent();
         txtEmpleado.Text = Cache.UserLoginCache.Usuario;
      }

      private void btnProcesar_Click(object sender, EventArgs e)
      {
         // Variables
         string empleado = Cache.UserLoginCache.Codigo;
         string cuenta = txtCuenta.Text;
         double importe = Double.Parse(txtImporte.Text);
         // Proceso
         EurekaService service = new EurekaService();
         service.RegistrarDeposito(cuenta, importe, empleado);
         lblMensaje.Text = service.Mensaje;
         if (service.Estado == 1)
         {
            EstadoEdicion(true);
         } else
         {
            lblMensaje.Visible = true;
         }
      }

      private void btnCerrar_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void EstadoEdicion(bool activo)
      {
         txtCuenta.Enabled = activo;
         txtImporte.Enabled = activo;
         btnProcesar.Enabled = activo;
         btnNuevo.Enabled = !activo;
      }

      private void btnNuevo_Click(object sender, EventArgs e)
      {
         EstadoEdicion(false);
         lblMensaje.Visible = false;
      }
   }
}
