namespace Evaluacion_Parcial_2.Views
{
    partial class frm_listar_Aeropuertos
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
            this.btn_modificar_aeropuerto = new System.Windows.Forms.Button();
            this.btn_eliminar_aeropuerto = new System.Windows.Forms.Button();
            this.lst_aeropuertos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_modificar_aeropuerto
            // 
            this.btn_modificar_aeropuerto.Location = new System.Drawing.Point(492, 118);
            this.btn_modificar_aeropuerto.Name = "btn_modificar_aeropuerto";
            this.btn_modificar_aeropuerto.Size = new System.Drawing.Size(119, 55);
            this.btn_modificar_aeropuerto.TabIndex = 11;
            this.btn_modificar_aeropuerto.Text = "Modificar";
            this.btn_modificar_aeropuerto.UseVisualStyleBackColor = true;
            this.btn_modificar_aeropuerto.Click += new System.EventHandler(this.btn_modificar_aeropuerto_Click);
            // 
            // btn_eliminar_aeropuerto
            // 
            this.btn_eliminar_aeropuerto.Location = new System.Drawing.Point(492, 40);
            this.btn_eliminar_aeropuerto.Name = "btn_eliminar_aeropuerto";
            this.btn_eliminar_aeropuerto.Size = new System.Drawing.Size(119, 55);
            this.btn_eliminar_aeropuerto.TabIndex = 10;
            this.btn_eliminar_aeropuerto.Text = "Eliminar";
            this.btn_eliminar_aeropuerto.UseVisualStyleBackColor = true;
            this.btn_eliminar_aeropuerto.Click += new System.EventHandler(this.btn_eliminar_aeropuerto_Click);
            // 
            // lst_aeropuertos
            // 
            this.lst_aeropuertos.FormattingEnabled = true;
            this.lst_aeropuertos.ItemHeight = 16;
            this.lst_aeropuertos.Location = new System.Drawing.Point(16, 40);
            this.lst_aeropuertos.Name = "lst_aeropuertos";
            this.lst_aeropuertos.Size = new System.Drawing.Size(433, 452);
            this.lst_aeropuertos.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lista de Aeropuertos";
            // 
            // frm_listar_Aeropuertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 506);
            this.Controls.Add(this.btn_modificar_aeropuerto);
            this.Controls.Add(this.btn_eliminar_aeropuerto);
            this.Controls.Add(this.lst_aeropuertos);
            this.Controls.Add(this.label1);
            this.Name = "frm_listar_Aeropuertos";
            this.Text = "frm_listar_Aeropuertos";
            this.Load += new System.EventHandler(this.frm_listar_Aeropuertos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modificar_aeropuerto;
        private System.Windows.Forms.Button btn_eliminar_aeropuerto;
        private System.Windows.Forms.ListBox lst_aeropuertos;
        private System.Windows.Forms.Label label1;
    }
}