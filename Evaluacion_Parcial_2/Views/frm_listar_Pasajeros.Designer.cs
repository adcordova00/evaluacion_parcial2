namespace Evaluacion_Parcial_2.Views
{
    partial class frm_listar_Pasajeros
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
            this.btn_modificar_pasajero = new System.Windows.Forms.Button();
            this.btn_eliminar_pasajero = new System.Windows.Forms.Button();
            this.lst_pasajeros = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_modificar_pasajero
            // 
            this.btn_modificar_pasajero.Location = new System.Drawing.Point(501, 117);
            this.btn_modificar_pasajero.Name = "btn_modificar_pasajero";
            this.btn_modificar_pasajero.Size = new System.Drawing.Size(119, 55);
            this.btn_modificar_pasajero.TabIndex = 7;
            this.btn_modificar_pasajero.Text = "Modificar";
            this.btn_modificar_pasajero.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar_pasajero
            // 
            this.btn_eliminar_pasajero.Location = new System.Drawing.Point(501, 39);
            this.btn_eliminar_pasajero.Name = "btn_eliminar_pasajero";
            this.btn_eliminar_pasajero.Size = new System.Drawing.Size(119, 55);
            this.btn_eliminar_pasajero.TabIndex = 6;
            this.btn_eliminar_pasajero.Text = "Eliminar";
            this.btn_eliminar_pasajero.UseVisualStyleBackColor = true;
            // 
            // lst_pasajeros
            // 
            this.lst_pasajeros.FormattingEnabled = true;
            this.lst_pasajeros.ItemHeight = 16;
            this.lst_pasajeros.Location = new System.Drawing.Point(25, 39);
            this.lst_pasajeros.Name = "lst_pasajeros";
            this.lst_pasajeros.Size = new System.Drawing.Size(433, 452);
            this.lst_pasajeros.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de Pasajeros";
            // 
            // frm_listar_Pasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 512);
            this.Controls.Add(this.btn_modificar_pasajero);
            this.Controls.Add(this.btn_eliminar_pasajero);
            this.Controls.Add(this.lst_pasajeros);
            this.Controls.Add(this.label1);
            this.Name = "frm_listar_Pasajeros";
            this.Text = "frm_lista_Pasajeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modificar_pasajero;
        private System.Windows.Forms.Button btn_eliminar_pasajero;
        private System.Windows.Forms.ListBox lst_pasajeros;
        private System.Windows.Forms.Label label1;
    }
}