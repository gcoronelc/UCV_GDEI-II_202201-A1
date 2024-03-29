﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaServicios;
using CapaModelo;

namespace EurekaApp
{
   public partial class FormLogin : Form
   {
      public FormLogin()
      {
         InitializeComponent();
         txtClave.UseSystemPasswordChar = true;
      }

      private void btnSalir_Click(object sender, EventArgs e)
      {
          Application.Exit();
      }

      private void btnIngresar_Click(object sender, EventArgs e)
      {
         // Datos
         string usuario = txtUsuario.Text;
         string clave = txtClave.Text;
         // Proceso
         if(usuario=="" || clave == "")
         {
            lblError.Text = "    Faltan datos.";
            lblError.Visible = true;
            return;
         }
         LogonService service = new LogonService();
         EmpleadoModel empleado = service.validarUsuario(usuario, clave);
         if (service.Estado == 1)
         {
            FormularioPrincipal fp = new FormularioPrincipal();
            fp.Show();
            this.Hide();
            Cache.UserLoginCache.Codigo = empleado.Codigo;
            Cache.UserLoginCache.Paterno = empleado.Paterno;
            Cache.UserLoginCache.Materno = empleado.Materno;
            Cache.UserLoginCache.Nombre = empleado.Nombre;
            Cache.UserLoginCache.Usuario = empleado.Usuario;
         } else
         {
            lblError.Text = "    " + service.Mensaje;
            lblError.Visible = true;
         }
      }
   }
}
