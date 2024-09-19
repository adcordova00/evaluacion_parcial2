namespace Evaluacion_Parcial_2.Views
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.avionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aeropuertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAvionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaAvionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listoAeropuertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avionesToolStripMenuItem,
            this.aeropuertosToolStripMenuItem,
            this.pasajerosToolStripMenuItem,
            this.vuelosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // avionesToolStripMenuItem
            // 
            this.avionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAvionToolStripMenuItem,
            this.listaAvionesToolStripMenuItem});
            this.avionesToolStripMenuItem.Name = "avionesToolStripMenuItem";
            this.avionesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.avionesToolStripMenuItem.Text = "Aviones";
            this.avionesToolStripMenuItem.Click += new System.EventHandler(this.avionesToolStripMenuItem_Click);
            // 
            // aeropuertosToolStripMenuItem
            // 
            this.aeropuertosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listoAeropuertosToolStripMenuItem});
            this.aeropuertosToolStripMenuItem.Name = "aeropuertosToolStripMenuItem";
            this.aeropuertosToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.aeropuertosToolStripMenuItem.Text = "Aeropuertos";
            this.aeropuertosToolStripMenuItem.Click += new System.EventHandler(this.aeropuertosToolStripMenuItem_Click);
            // 
            // pasajerosToolStripMenuItem
            // 
            this.pasajerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarPasajerosToolStripMenuItem});
            this.pasajerosToolStripMenuItem.Name = "pasajerosToolStripMenuItem";
            this.pasajerosToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.pasajerosToolStripMenuItem.Text = "Pasajeros";
            this.pasajerosToolStripMenuItem.Click += new System.EventHandler(this.pasajerosToolStripMenuItem_Click);
            // 
            // vuelosToolStripMenuItem
            // 
            this.vuelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarVuelosToolStripMenuItem,
            this.reporteVuelosToolStripMenuItem});
            this.vuelosToolStripMenuItem.Name = "vuelosToolStripMenuItem";
            this.vuelosToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.vuelosToolStripMenuItem.Text = "Vuelos";
            this.vuelosToolStripMenuItem.Click += new System.EventHandler(this.vuelosToolStripMenuItem_Click);
            // 
            // agregarAvionToolStripMenuItem
            // 
            this.agregarAvionToolStripMenuItem.Name = "agregarAvionToolStripMenuItem";
            this.agregarAvionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agregarAvionToolStripMenuItem.Text = "Agregar Avion";
            this.agregarAvionToolStripMenuItem.Click += new System.EventHandler(this.agregarAvionToolStripMenuItem_Click);
            // 
            // listaAvionesToolStripMenuItem
            // 
            this.listaAvionesToolStripMenuItem.Name = "listaAvionesToolStripMenuItem";
            this.listaAvionesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaAvionesToolStripMenuItem.Text = "Lista Aviones";
            this.listaAvionesToolStripMenuItem.Click += new System.EventHandler(this.listaAvionesToolStripMenuItem_Click);
            // 
            // listoAeropuertosToolStripMenuItem
            // 
            this.listoAeropuertosToolStripMenuItem.Name = "listoAeropuertosToolStripMenuItem";
            this.listoAeropuertosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listoAeropuertosToolStripMenuItem.Text = "Listo Aeropuertos";
            this.listoAeropuertosToolStripMenuItem.Click += new System.EventHandler(this.listoAeropuertosToolStripMenuItem_Click);
            // 
            // listarPasajerosToolStripMenuItem
            // 
            this.listarPasajerosToolStripMenuItem.Name = "listarPasajerosToolStripMenuItem";
            this.listarPasajerosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listarPasajerosToolStripMenuItem.Text = "Listar Pasajeros";
            this.listarPasajerosToolStripMenuItem.Click += new System.EventHandler(this.listarPasajerosToolStripMenuItem_Click);
            // 
            // listarVuelosToolStripMenuItem
            // 
            this.listarVuelosToolStripMenuItem.Name = "listarVuelosToolStripMenuItem";
            this.listarVuelosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listarVuelosToolStripMenuItem.Text = "Listar Vuelos";
            this.listarVuelosToolStripMenuItem.Click += new System.EventHandler(this.listarVuelosToolStripMenuItem_Click);
            // 
            // reporteVuelosToolStripMenuItem
            // 
            this.reporteVuelosToolStripMenuItem.Name = "reporteVuelosToolStripMenuItem";
            this.reporteVuelosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reporteVuelosToolStripMenuItem.Text = "Reporte Vuelos";
            this.reporteVuelosToolStripMenuItem.Click += new System.EventHandler(this.reporteVuelosToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem avionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAvionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaAvionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aeropuertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listoAeropuertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPasajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVuelosToolStripMenuItem;
    }
}