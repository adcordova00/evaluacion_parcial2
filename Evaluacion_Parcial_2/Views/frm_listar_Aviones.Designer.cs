namespace Evaluacion_Parcial_2.Views
{
    partial class frm_listar_Aviones
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
            this.lst_aviones = new System.Windows.Forms.ListBox();
            this.btn_eliminar_avion = new System.Windows.Forms.Button();
            this.btn_modificar_avion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Aviones";
            // 
            // lst_aviones
            // 
            this.lst_aviones.FormattingEnabled = true;
            this.lst_aviones.ItemHeight = 16;
            this.lst_aviones.Location = new System.Drawing.Point(22, 41);
            this.lst_aviones.Name = "lst_aviones";
            this.lst_aviones.Size = new System.Drawing.Size(433, 452);
            this.lst_aviones.TabIndex = 1;
            // 
            // btn_eliminar_avion
            // 
            this.btn_eliminar_avion.Location = new System.Drawing.Point(498, 41);
            this.btn_eliminar_avion.Name = "btn_eliminar_avion";
            this.btn_eliminar_avion.Size = new System.Drawing.Size(119, 55);
            this.btn_eliminar_avion.TabIndex = 2;
            this.btn_eliminar_avion.Text = "Eliminar";
            this.btn_eliminar_avion.UseVisualStyleBackColor = true;
            this.btn_eliminar_avion.Click += new System.EventHandler(this.btn_eliminar_avion_Click);
            // 
            // btn_modificar_avion
            // 
            this.btn_modificar_avion.Location = new System.Drawing.Point(498, 119);
            this.btn_modificar_avion.Name = "btn_modificar_avion";
            this.btn_modificar_avion.Size = new System.Drawing.Size(119, 55);
            this.btn_modificar_avion.TabIndex = 3;
            this.btn_modificar_avion.Text = "Modificar";
            this.btn_modificar_avion.UseVisualStyleBackColor = true;
            this.btn_modificar_avion.Click += new System.EventHandler(this.btn_modificar_avion_Click);
            // 
            // frm_listar_Aviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 498);
            this.Controls.Add(this.btn_modificar_avion);
            this.Controls.Add(this.btn_eliminar_avion);
            this.Controls.Add(this.lst_aviones);
            this.Controls.Add(this.label1);
            this.Name = "frm_listar_Aviones";
            this.Text = "frm_listar_Aviones";
            this.Load += new System.EventHandler(this.frm_listar_Aviones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_aviones;
        private System.Windows.Forms.Button btn_eliminar_avion;
        private System.Windows.Forms.Button btn_modificar_avion;
    }
}