namespace agenciaViaje
{
    partial class Form1
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
            this.cbHotel = new System.Windows.Forms.CheckBox();
            this.cbViaje = new System.Windows.Forms.CheckBox();
            this.cbSeguros = new System.Windows.Forms.CheckBox();
            this.cbGuia = new System.Windows.Forms.CheckBox();
            this.cbTransporte = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbHotel
            // 
            this.cbHotel.AutoSize = true;
            this.cbHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHotel.Location = new System.Drawing.Point(23, 83);
            this.cbHotel.Name = "cbHotel";
            this.cbHotel.Size = new System.Drawing.Size(66, 24);
            this.cbHotel.TabIndex = 0;
            this.cbHotel.Text = "Hotel";
            this.cbHotel.UseVisualStyleBackColor = true;
            // 
            // cbViaje
            // 
            this.cbViaje.AutoSize = true;
            this.cbViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbViaje.Location = new System.Drawing.Point(23, 43);
            this.cbViaje.Name = "cbViaje";
            this.cbViaje.Size = new System.Drawing.Size(63, 24);
            this.cbViaje.TabIndex = 0;
            this.cbViaje.Text = "Viaje";
            this.cbViaje.UseVisualStyleBackColor = true;
            this.cbViaje.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbSeguros
            // 
            this.cbSeguros.AutoSize = true;
            this.cbSeguros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeguros.Location = new System.Drawing.Point(23, 218);
            this.cbSeguros.Name = "cbSeguros";
            this.cbSeguros.Size = new System.Drawing.Size(88, 24);
            this.cbSeguros.TabIndex = 0;
            this.cbSeguros.Text = "Seguros";
            this.cbSeguros.UseVisualStyleBackColor = true;
            // 
            // cbGuia
            // 
            this.cbGuia.AutoSize = true;
            this.cbGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGuia.Location = new System.Drawing.Point(23, 173);
            this.cbGuia.Name = "cbGuia";
            this.cbGuia.Size = new System.Drawing.Size(121, 24);
            this.cbGuia.TabIndex = 0;
            this.cbGuia.Text = "Guía turística";
            this.cbGuia.UseVisualStyleBackColor = true;
            // 
            // cbTransporte
            // 
            this.cbTransporte.AutoSize = true;
            this.cbTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransporte.Location = new System.Drawing.Point(23, 132);
            this.cbTransporte.Name = "cbTransporte";
            this.cbTransporte.Size = new System.Drawing.Size(105, 24);
            this.cbTransporte.TabIndex = 0;
            this.cbTransporte.Text = "Transporte";
            this.cbTransporte.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contenido del Paquete";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(245, 123);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 270);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTransporte);
            this.Controls.Add(this.cbSeguros);
            this.Controls.Add(this.cbGuia);
            this.Controls.Add(this.cbViaje);
            this.Controls.Add(this.cbHotel);
            this.Name = "Form1";
            this.Text = "Agencia de Viajes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbHotel;
        private System.Windows.Forms.CheckBox cbViaje;
        private System.Windows.Forms.CheckBox cbSeguros;
        private System.Windows.Forms.CheckBox cbGuia;
        private System.Windows.Forms.CheckBox cbTransporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContinuar;
    }
}

