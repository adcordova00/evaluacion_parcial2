namespace Evaluacion_Parcial_2.Views
{
    partial class frm_Vuelos
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
            this.dtp_fecha_vuelo = new System.Windows.Forms.DateTimePicker();
            this.cb_avion = new System.Windows.Forms.ComboBox();
            this.cb_aeropuerto_destino = new System.Windows.Forms.ComboBox();
            this.cb_aeropuerto_origen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_guardar_vuelo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_fecha_vuelo
            // 
            this.dtp_fecha_vuelo.Location = new System.Drawing.Point(282, 200);
            this.dtp_fecha_vuelo.Name = "dtp_fecha_vuelo";
            this.dtp_fecha_vuelo.Size = new System.Drawing.Size(303, 22);
            this.dtp_fecha_vuelo.TabIndex = 31;
            // 
            // cb_avion
            // 
            this.cb_avion.FormattingEnabled = true;
            this.cb_avion.Location = new System.Drawing.Point(282, 157);
            this.cb_avion.Name = "cb_avion";
            this.cb_avion.Size = new System.Drawing.Size(303, 24);
            this.cb_avion.TabIndex = 30;
            // 
            // cb_aeropuerto_destino
            // 
            this.cb_aeropuerto_destino.FormattingEnabled = true;
            this.cb_aeropuerto_destino.Location = new System.Drawing.Point(282, 115);
            this.cb_aeropuerto_destino.Name = "cb_aeropuerto_destino";
            this.cb_aeropuerto_destino.Size = new System.Drawing.Size(303, 24);
            this.cb_aeropuerto_destino.TabIndex = 29;
            // 
            // cb_aeropuerto_origen
            // 
            this.cb_aeropuerto_origen.FormattingEnabled = true;
            this.cb_aeropuerto_origen.Location = new System.Drawing.Point(282, 74);
            this.cb_aeropuerto_origen.Name = "cb_aeropuerto_origen";
            this.cb_aeropuerto_origen.Size = new System.Drawing.Size(303, 24);
            this.cb_aeropuerto_origen.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Avion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Aeropuerto Destino:";
            // 
            // btn_guardar_vuelo
            // 
            this.btn_guardar_vuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_vuelo.Location = new System.Drawing.Point(318, 267);
            this.btn_guardar_vuelo.Name = "btn_guardar_vuelo";
            this.btn_guardar_vuelo.Size = new System.Drawing.Size(128, 42);
            this.btn_guardar_vuelo.TabIndex = 24;
            this.btn_guardar_vuelo.Text = "Guardar";
            this.btn_guardar_vuelo.UseVisualStyleBackColor = true;
            this.btn_guardar_vuelo.Click += new System.EventHandler(this.btn_guardar_vuelo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Aeropuerto Origen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(179, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "AGREGAR NUEVO VUELO";
            // 
            // frm_Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 366);
            this.Controls.Add(this.dtp_fecha_vuelo);
            this.Controls.Add(this.cb_avion);
            this.Controls.Add(this.cb_aeropuerto_destino);
            this.Controls.Add(this.cb_aeropuerto_origen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_guardar_vuelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "frm_Vuelos";
            this.Text = "frm_Vuelos";
            this.Load += new System.EventHandler(this.frm_Vuelos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_fecha_vuelo;
        private System.Windows.Forms.ComboBox cb_avion;
        private System.Windows.Forms.ComboBox cb_aeropuerto_destino;
        private System.Windows.Forms.ComboBox cb_aeropuerto_origen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_guardar_vuelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}