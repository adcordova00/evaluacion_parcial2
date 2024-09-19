namespace Evaluacion_Parcial_2.Views
{
    partial class frm_listar_Vuelos
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
            this.btn_modificar_vuelo = new System.Windows.Forms.Button();
            this.btn_eliminar_vuelo = new System.Windows.Forms.Button();
            this.lst_vuelos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_modificar_vuelo
            // 
            this.btn_modificar_vuelo.Location = new System.Drawing.Point(485, 121);
            this.btn_modificar_vuelo.Name = "btn_modificar_vuelo";
            this.btn_modificar_vuelo.Size = new System.Drawing.Size(119, 55);
            this.btn_modificar_vuelo.TabIndex = 15;
            this.btn_modificar_vuelo.Text = "Modificar";
            this.btn_modificar_vuelo.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar_vuelo
            // 
            this.btn_eliminar_vuelo.Location = new System.Drawing.Point(485, 43);
            this.btn_eliminar_vuelo.Name = "btn_eliminar_vuelo";
            this.btn_eliminar_vuelo.Size = new System.Drawing.Size(119, 55);
            this.btn_eliminar_vuelo.TabIndex = 14;
            this.btn_eliminar_vuelo.Text = "Eliminar";
            this.btn_eliminar_vuelo.UseVisualStyleBackColor = true;
            // 
            // lst_vuelos
            // 
            this.lst_vuelos.FormattingEnabled = true;
            this.lst_vuelos.ItemHeight = 16;
            this.lst_vuelos.Location = new System.Drawing.Point(9, 43);
            this.lst_vuelos.Name = "lst_vuelos";
            this.lst_vuelos.Size = new System.Drawing.Size(433, 452);
            this.lst_vuelos.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lista de Vuelos";
            // 
            // frm_listar_Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 519);
            this.Controls.Add(this.btn_modificar_vuelo);
            this.Controls.Add(this.btn_eliminar_vuelo);
            this.Controls.Add(this.lst_vuelos);
            this.Controls.Add(this.label1);
            this.Name = "frm_listar_Vuelos";
            this.Text = "frm_listar_Vuelos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modificar_vuelo;
        private System.Windows.Forms.Button btn_eliminar_vuelo;
        private System.Windows.Forms.ListBox lst_vuelos;
        private System.Windows.Forms.Label label1;
    }
}