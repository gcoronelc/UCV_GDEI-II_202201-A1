﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaServicios;

namespace EurekaApp
{
   public partial class FormConsultarMovimientos : Form
   {
      private static FormConsultarMovimientos instancia = null;
      public static FormConsultarMovimientos GetInstance()
      {
         if (((instancia == null) || (instancia.IsDisposed == true)))
         {
            instancia = new FormConsultarMovimientos();
         }
         instancia.BringToFront();
         return instancia;
      }

      private FormConsultarMovimientos()
      {
         InitializeComponent();
      }

      private void btnConsultar_Click(object sender, EventArgs e)
      {
         // Variables
         string cuenta;
         // Dato
         cuenta = txtCuenta.Text;
         // Proceso
         lblMensaje.Text = "";
         dataGridView1.DataSource = "";
         ConsultaService service = new ConsultaService(); 
         DataTable dt = service.traerMovimientos(cuenta);
         // Reporte
         dataGridView1.DataSource = dt;
         if(service.Estado == -1)
         {
            lblMensaje.Text = service.Mensaje;
         }
      }
   }
}
