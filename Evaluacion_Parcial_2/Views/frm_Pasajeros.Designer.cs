﻿namespace Evaluacion_Parcial_2.Views
{
    partial class frm_Pasajeros
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
            this.btn_guardar_pasajero = new System.Windows.Forms.Button();
            this.txt_nombre_pasajero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_vuelo_pasajero = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_guardar_pasajero
            // 
            this.btn_guardar_pasajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_pasajero.Location = new System.Drawing.Point(331, 198);
            this.btn_guardar_pasajero.Name = "btn_guardar_pasajero";
            this.btn_guardar_pasajero.Size = new System.Drawing.Size(128, 42);
            this.btn_guardar_pasajero.TabIndex = 7;
            this.btn_guardar_pasajero.Text = "Guardar";
            this.btn_guardar_pasajero.UseVisualStyleBackColor = true;
            this.btn_guardar_pasajero.Click += new System.EventHandler(this.btn_guardar_pasajero_Click);
            // 
            // txt_nombre_pasajero
            // 
            this.txt_nombre_pasajero.Location = new System.Drawing.Point(253, 102);
            this.txt_nombre_pasajero.Name = "txt_nombre_pasajero";
            this.txt_nombre_pasajero.Size = new System.Drawing.Size(292, 22);
            this.txt_nombre_pasajero.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "AGREGAR NUEVO  PASAJERO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vuelo:";
            // 
            // cb_vuelo_pasajero
            // 
            this.cb_vuelo_pasajero.FormattingEnabled = true;
            this.cb_vuelo_pasajero.Location = new System.Drawing.Point(253, 143);
            this.cb_vuelo_pasajero.Name = "cb_vuelo_pasajero";
            this.cb_vuelo_pasajero.Size = new System.Drawing.Size(292, 24);
            this.cb_vuelo_pasajero.TabIndex = 9;
            // 
            // frm_Pasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 288);
            this.Controls.Add(this.cb_vuelo_pasajero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_guardar_pasajero);
            this.Controls.Add(this.txt_nombre_pasajero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Pasajeros";
            this.Text = "frm_Pasajeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar_pasajero;
        private System.Windows.Forms.TextBox txt_nombre_pasajero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_vuelo_pasajero;
    }
}