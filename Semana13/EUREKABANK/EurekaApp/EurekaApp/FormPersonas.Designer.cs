namespace EurekaApp
{
   partial class FormPersonas
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
         this.btnConsultar = new System.Windows.Forms.Button();
         this.btnCerrar = new System.Windows.Forms.Button();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // btnConsultar
         // 
         this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.btnConsultar.Location = new System.Drawing.Point(12, 12);
         this.btnConsultar.Name = "btnConsultar";
         this.btnConsultar.Size = new System.Drawing.Size(327, 103);
         this.btnConsultar.TabIndex = 0;
         this.btnConsultar.Text = "Consultar personas";
         this.btnConsultar.UseVisualStyleBackColor = false;
         this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
         // 
         // btnCerrar
         // 
         this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.btnCerrar.Location = new System.Drawing.Point(362, 12);
         this.btnCerrar.Name = "btnCerrar";
         this.btnCerrar.Size = new System.Drawing.Size(327, 103);
         this.btnCerrar.TabIndex = 1;
         this.btnCerrar.Text = "Cerrar";
         this.btnCerrar.UseVisualStyleBackColor = true;
         this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(12, 134);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.RowTemplate.Height = 28;
         this.dataGridView1.Size = new System.Drawing.Size(994, 431);
         this.dataGridView1.TabIndex = 2;
         // 
         // FormPersonas
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1018, 577);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.btnCerrar);
         this.Controls.Add(this.btnConsultar);
         this.Name = "FormPersonas";
         this.Text = "FormPersonas";
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnConsultar;
      private System.Windows.Forms.Button btnCerrar;
      private System.Windows.Forms.DataGridView dataGridView1;
   }
}