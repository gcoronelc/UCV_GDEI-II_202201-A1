﻿
namespace AppDemo
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
         this.menuStrip = new System.Windows.Forms.MenuStrip();
         this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
         this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
         this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.printSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.registrarDepósitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.statusStrip = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolTip = new System.Windows.Forms.ToolTip(this.components);
         this.menuStrip.SuspendLayout();
         this.statusStrip.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip
         // 
         this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.procesosToolStripMenuItem,
            this.windowsMenu,
            this.helpMenu});
         this.menuStrip.Location = new System.Drawing.Point(0, 0);
         this.menuStrip.MdiWindowListItem = this.windowsMenu;
         this.menuStrip.Name = "menuStrip";
         this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
         this.menuStrip.Size = new System.Drawing.Size(843, 29);
         this.menuStrip.TabIndex = 0;
         this.menuStrip.Text = "MenuStrip";
         this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
         // 
         // fileMenu
         // 
         this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printSetupToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
         this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
         this.fileMenu.Name = "fileMenu";
         this.fileMenu.Size = new System.Drawing.Size(67, 23);
         this.fileMenu.Text = "&Archivo";
         // 
         // toolStripSeparator3
         // 
         this.toolStripSeparator3.Name = "toolStripSeparator3";
         this.toolStripSeparator3.Size = new System.Drawing.Size(229, 6);
         // 
         // toolStripSeparator4
         // 
         this.toolStripSeparator4.Name = "toolStripSeparator4";
         this.toolStripSeparator4.Size = new System.Drawing.Size(229, 6);
         // 
         // printToolStripMenuItem
         // 
         this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
         this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
         this.printToolStripMenuItem.Name = "printToolStripMenuItem";
         this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
         this.printToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
         this.printToolStripMenuItem.Text = "&Imprimir";
         // 
         // printPreviewToolStripMenuItem
         // 
         this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
         this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
         this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
         this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
         this.printPreviewToolStripMenuItem.Text = "&Vista previa de impresión";
         // 
         // printSetupToolStripMenuItem
         // 
         this.printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
         this.printSetupToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
         this.printSetupToolStripMenuItem.Text = "Configurar impresión";
         // 
         // toolStripSeparator5
         // 
         this.toolStripSeparator5.Name = "toolStripSeparator5";
         this.toolStripSeparator5.Size = new System.Drawing.Size(229, 6);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
         this.exitToolStripMenuItem.Text = "&Salir";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
         // 
         // procesosToolStripMenuItem
         // 
         this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarDepósitoToolStripMenuItem});
         this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
         this.procesosToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
         this.procesosToolStripMenuItem.Text = "Procesos";
         // 
         // registrarDepósitoToolStripMenuItem
         // 
         this.registrarDepósitoToolStripMenuItem.Name = "registrarDepósitoToolStripMenuItem";
         this.registrarDepósitoToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
         this.registrarDepósitoToolStripMenuItem.Text = "Registrar Depósito";
         this.registrarDepósitoToolStripMenuItem.Click += new System.EventHandler(this.registrarDepósitoToolStripMenuItem_Click);
         // 
         // windowsMenu
         // 
         this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
         this.windowsMenu.Name = "windowsMenu";
         this.windowsMenu.Size = new System.Drawing.Size(77, 23);
         this.windowsMenu.Text = "&Ventanas";
         // 
         // newWindowToolStripMenuItem
         // 
         this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
         this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
         this.newWindowToolStripMenuItem.Text = "&Nueva ventana";
         this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
         // 
         // cascadeToolStripMenuItem
         // 
         this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
         this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
         this.cascadeToolStripMenuItem.Text = "&Cascada";
         this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
         // 
         // tileVerticalToolStripMenuItem
         // 
         this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
         this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
         this.tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
         this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
         // 
         // tileHorizontalToolStripMenuItem
         // 
         this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
         this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
         this.tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
         this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
         // 
         // closeAllToolStripMenuItem
         // 
         this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
         this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
         this.closeAllToolStripMenuItem.Text = "C&errar todo";
         this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
         // 
         // arrangeIconsToolStripMenuItem
         // 
         this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
         this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
         this.arrangeIconsToolStripMenuItem.Text = "&Organizar iconos";
         this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
         // 
         // helpMenu
         // 
         this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
         this.helpMenu.Name = "helpMenu";
         this.helpMenu.Size = new System.Drawing.Size(60, 23);
         this.helpMenu.Text = "Ay&uda";
         // 
         // contentsToolStripMenuItem
         // 
         this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
         this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
         this.contentsToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
         this.contentsToolStripMenuItem.Text = "&Contenido";
         // 
         // indexToolStripMenuItem
         // 
         this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
         this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
         this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
         this.indexToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
         this.indexToolStripMenuItem.Text = "&Índice";
         // 
         // searchToolStripMenuItem
         // 
         this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
         this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
         this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
         this.searchToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
         this.searchToolStripMenuItem.Text = "&Buscar";
         // 
         // toolStripSeparator8
         // 
         this.toolStripSeparator8.Name = "toolStripSeparator8";
         this.toolStripSeparator8.Size = new System.Drawing.Size(195, 6);
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
         this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
         // 
         // statusStrip
         // 
         this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
         this.statusStrip.Location = new System.Drawing.Point(0, 379);
         this.statusStrip.Name = "statusStrip";
         this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
         this.statusStrip.Size = new System.Drawing.Size(843, 24);
         this.statusStrip.TabIndex = 2;
         this.statusStrip.Text = "StatusStrip";
         // 
         // toolStripStatusLabel
         // 
         this.toolStripStatusLabel.Name = "toolStripStatusLabel";
         this.toolStripStatusLabel.Size = new System.Drawing.Size(50, 19);
         this.toolStripStatusLabel.Text = "Estado";
         // 
         // FormularioPrincipal
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(843, 403);
         this.Controls.Add(this.statusStrip);
         this.Controls.Add(this.menuStrip);
         this.IsMdiContainer = true;
         this.MainMenuStrip = this.menuStrip;
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "FormularioPrincipal";
         this.Text = "FORMULARIO PRINCIPAL";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormularioPrincipal_FormClosed);
         this.menuStrip.ResumeLayout(false);
         this.menuStrip.PerformLayout();
         this.statusStrip.ResumeLayout(false);
         this.statusStrip.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem printSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDepósitoToolStripMenuItem;
    }
}



