namespace Evaluacion_Parcial_2.Views
{
    partial class frm_Aviones
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_modelo_avion = new System.Windows.Forms.TextBox();
            this.btn_guardar_avion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGAR NUEVO AVION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo: ";
            // 
            // txt_modelo_avion
            // 
            this.txt_modelo_avion.Location = new System.Drawing.Point(238, 126);
            this.txt_modelo_avion.Name = "txt_modelo_avion";
            this.txt_modelo_avion.Size = new System.Drawing.Size(292, 22);
            this.txt_modelo_avion.TabIndex = 2;
            // 
            // btn_guardar_avion
            // 
            this.btn_guardar_avion.Location = new System.Drawing.Point(316, 182);
            this.btn_guardar_avion.Name = "btn_guardar_avion";
            this.btn_guardar_avion.Size = new System.Drawing.Size(128, 42);
            this.btn_guardar_avion.TabIndex = 3;
            this.btn_guardar_avion.Text = "Guardar";
            this.btn_guardar_avion.UseVisualStyleBackColor = true;
            this.btn_guardar_avion.Click += new System.EventHandler(this.btn_guardar_avion_Click);
            // 
            // frm_Aviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 271);
            this.Controls.Add(this.btn_guardar_avion);
            this.Controls.Add(this.txt_modelo_avion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Aviones";
            this.Text = "frm_Aviones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_modelo_avion;
        private System.Windows.Forms.Button btn_guardar_avion;
    }
}