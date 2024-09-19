namespace Evaluacion_Parcial_2.Views
{
    partial class frm_Aeropuertos
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
            this.txt_pais_aeropuerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_guardar_aeropuerto = new System.Windows.Forms.Button();
            this.txt_ciudad_aeropuerto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_pais_aeropuerto
            // 
            this.txt_pais_aeropuerto.Location = new System.Drawing.Point(273, 168);
            this.txt_pais_aeropuerto.Name = "txt_pais_aeropuerto";
            this.txt_pais_aeropuerto.Size = new System.Drawing.Size(292, 22);
            this.txt_pais_aeropuerto.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Pais:";
            // 
            // btn_guardar_aeropuerto
            // 
            this.btn_guardar_aeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_aeropuerto.Location = new System.Drawing.Point(351, 224);
            this.btn_guardar_aeropuerto.Name = "btn_guardar_aeropuerto";
            this.btn_guardar_aeropuerto.Size = new System.Drawing.Size(128, 42);
            this.btn_guardar_aeropuerto.TabIndex = 25;
            this.btn_guardar_aeropuerto.Text = "Guardar";
            this.btn_guardar_aeropuerto.UseVisualStyleBackColor = true;
            this.btn_guardar_aeropuerto.Click += new System.EventHandler(this.btn_guardar_aeropuerto_Click);
            // 
            // txt_ciudad_aeropuerto
            // 
            this.txt_ciudad_aeropuerto.Location = new System.Drawing.Point(273, 128);
            this.txt_ciudad_aeropuerto.Name = "txt_ciudad_aeropuerto";
            this.txt_ciudad_aeropuerto.Size = new System.Drawing.Size(292, 22);
            this.txt_ciudad_aeropuerto.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ciudad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "AGREGAR NUEVO  AEROPUERTO";
            // 
            // frm_Aeropuertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 320);
            this.Controls.Add(this.txt_pais_aeropuerto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_guardar_aeropuerto);
            this.Controls.Add(this.txt_ciudad_aeropuerto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Aeropuertos";
            this.Text = "frm_Aeropuertos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pais_aeropuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_guardar_aeropuerto;
        private System.Windows.Forms.TextBox txt_ciudad_aeropuerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}