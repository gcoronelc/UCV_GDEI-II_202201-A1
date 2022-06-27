namespace EurekaApp
{
   partial class FormLogin
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.txtUsuario = new System.Windows.Forms.TextBox();
         this.txtClave = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.lblError = new System.Windows.Forms.Label();
         this.btnSalir = new System.Windows.Forms.Button();
         this.btnIngresar = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.label1.Location = new System.Drawing.Point(101, 71);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(114, 37);
         this.label1.TabIndex = 0;
         this.label1.Text = "Usuario:";
         // 
         // txtUsuario
         // 
         this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.txtUsuario.Location = new System.Drawing.Point(292, 68);
         this.txtUsuario.Name = "txtUsuario";
         this.txtUsuario.Size = new System.Drawing.Size(270, 43);
         this.txtUsuario.TabIndex = 1;
         // 
         // txtClave
         // 
         this.txtClave.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.txtClave.Location = new System.Drawing.Point(292, 135);
         this.txtClave.Name = "txtClave";
         this.txtClave.Size = new System.Drawing.Size(270, 43);
         this.txtClave.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.label2.Location = new System.Drawing.Point(101, 138);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(88, 37);
         this.label2.TabIndex = 2;
         this.label2.Text = "Clave:";
         // 
         // lblError
         // 
         this.lblError.AutoSize = true;
         this.lblError.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.lblError.ForeColor = System.Drawing.Color.Crimson;
         this.lblError.Image = global::EurekaApp.Properties.Resources.alerta;
         this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.lblError.Location = new System.Drawing.Point(110, 216);
         this.lblError.Name = "lblError";
         this.lblError.Size = new System.Drawing.Size(224, 32);
         this.lblError.TabIndex = 4;
         this.lblError.Text = "    Mensaje de error";
         this.lblError.Visible = false;
         // 
         // btnSalir
         // 
         this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.btnSalir.Location = new System.Drawing.Point(332, 294);
         this.btnSalir.Name = "btnSalir";
         this.btnSalir.Size = new System.Drawing.Size(191, 66);
         this.btnSalir.TabIndex = 5;
         this.btnSalir.Text = "Salir";
         this.btnSalir.UseVisualStyleBackColor = true;
         this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
         // 
         // btnIngresar
         // 
         this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
         this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.btnIngresar.Location = new System.Drawing.Point(135, 294);
         this.btnIngresar.Name = "btnIngresar";
         this.btnIngresar.Size = new System.Drawing.Size(191, 66);
         this.btnIngresar.TabIndex = 6;
         this.btnIngresar.Text = "Ingresar";
         this.btnIngresar.UseVisualStyleBackColor = false;
         this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
         // 
         // FormLogin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(726, 416);
         this.Controls.Add(this.btnIngresar);
         this.Controls.Add(this.btnSalir);
         this.Controls.Add(this.lblError);
         this.Controls.Add(this.txtClave);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtUsuario);
         this.Controls.Add(this.label1);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FormLogin";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "INGRESO AL SISTEMA";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtUsuario;
      private System.Windows.Forms.TextBox txtClave;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label lblError;
      private System.Windows.Forms.Button btnSalir;
      private System.Windows.Forms.Button btnIngresar;
   }
}