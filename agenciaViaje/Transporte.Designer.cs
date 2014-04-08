namespace agenciaViaje
{
    partial class Transporte
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
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.pbxImagenCarro = new System.Windows.Forms.PictureBox();
            this.gbxTipoCarro = new System.Windows.Forms.GroupBox();
            this.rdBtnTrabajo = new System.Windows.Forms.RadioButton();
            this.rdBtnCamioneta = new System.Windows.Forms.RadioButton();
            this.rdBtnSedan = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtReservacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenCarro)).BeginInit();
            this.gbxTipoCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(12, 247);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(133, 147);
            this.listBoxCarros.TabIndex = 2;
            this.listBoxCarros.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pbxImagenCarro
            // 
            this.pbxImagenCarro.BackColor = System.Drawing.Color.Transparent;
            this.pbxImagenCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxImagenCarro.Image = global::agenciaViaje.Properties.Resources.vw_clasico;
            this.pbxImagenCarro.Location = new System.Drawing.Point(179, 247);
            this.pbxImagenCarro.Name = "pbxImagenCarro";
            this.pbxImagenCarro.Size = new System.Drawing.Size(255, 147);
            this.pbxImagenCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenCarro.TabIndex = 4;
            this.pbxImagenCarro.TabStop = false;
            // 
            // gbxTipoCarro
            // 
            this.gbxTipoCarro.Controls.Add(this.rdBtnTrabajo);
            this.gbxTipoCarro.Controls.Add(this.rdBtnCamioneta);
            this.gbxTipoCarro.Controls.Add(this.rdBtnSedan);
            this.gbxTipoCarro.Location = new System.Drawing.Point(12, 12);
            this.gbxTipoCarro.Name = "gbxTipoCarro";
            this.gbxTipoCarro.Size = new System.Drawing.Size(200, 100);
            this.gbxTipoCarro.TabIndex = 5;
            this.gbxTipoCarro.TabStop = false;
            this.gbxTipoCarro.Text = "Selecciona tu tipo de Carro";
            // 
            // rdBtnTrabajo
            // 
            this.rdBtnTrabajo.AutoSize = true;
            this.rdBtnTrabajo.Location = new System.Drawing.Point(6, 65);
            this.rdBtnTrabajo.Name = "rdBtnTrabajo";
            this.rdBtnTrabajo.Size = new System.Drawing.Size(109, 17);
            this.rdBtnTrabajo.TabIndex = 6;
            this.rdBtnTrabajo.TabStop = true;
            this.rdBtnTrabajo.Text = "Carros de Trabajo";
            this.rdBtnTrabajo.UseVisualStyleBackColor = true;
            this.rdBtnTrabajo.CheckedChanged += new System.EventHandler(this.rdBtnTrabajo_CheckedChanged);
            // 
            // rdBtnCamioneta
            // 
            this.rdBtnCamioneta.AutoSize = true;
            this.rdBtnCamioneta.Location = new System.Drawing.Point(6, 42);
            this.rdBtnCamioneta.Name = "rdBtnCamioneta";
            this.rdBtnCamioneta.Size = new System.Drawing.Size(80, 17);
            this.rdBtnCamioneta.TabIndex = 5;
            this.rdBtnCamioneta.TabStop = true;
            this.rdBtnCamioneta.Text = "Camionetas";
            this.rdBtnCamioneta.UseVisualStyleBackColor = true;
            this.rdBtnCamioneta.CheckedChanged += new System.EventHandler(this.rdBtnCamioneta_CheckedChanged_1);
            // 
            // rdBtnSedan
            // 
            this.rdBtnSedan.AutoSize = true;
            this.rdBtnSedan.Location = new System.Drawing.Point(6, 19);
            this.rdBtnSedan.Name = "rdBtnSedan";
            this.rdBtnSedan.Size = new System.Drawing.Size(67, 17);
            this.rdBtnSedan.TabIndex = 4;
            this.rdBtnSedan.TabStop = true;
            this.rdBtnSedan.Text = "Sedanes";
            this.rdBtnSedan.UseVisualStyleBackColor = true;
            this.rdBtnSedan.CheckedChanged += new System.EventHandler(this.rdBtnSedan_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(249, 146);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown2.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(14, 146);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "N° Personas";
            // 
            // dtReservacion
            // 
            this.dtReservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReservacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReservacion.Location = new System.Drawing.Point(245, 62);
            this.dtReservacion.Name = "dtReservacion";
            this.dtReservacion.Size = new System.Drawing.Size(200, 26);
            this.dtReservacion.TabIndex = 11;
            this.dtReservacion.Value = new System.DateTime(2014, 4, 7, 8, 13, 52, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha de reservación";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(643, 64);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 40);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Continuar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(639, 135);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(103, 46);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Transporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 461);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtReservacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxTipoCarro);
            this.Controls.Add(this.pbxImagenCarro);
            this.Controls.Add(this.listBoxCarros);
            this.Name = "Transporte";
            this.Text = "Transporte";
            this.Load += new System.EventHandler(this.Transporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenCarro)).EndInit();
            this.gbxTipoCarro.ResumeLayout(false);
            this.gbxTipoCarro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.PictureBox pbxImagenCarro;
        private System.Windows.Forms.GroupBox gbxTipoCarro;
        private System.Windows.Forms.RadioButton rdBtnTrabajo;
        private System.Windows.Forms.RadioButton rdBtnCamioneta;
        private System.Windows.Forms.RadioButton rdBtnSedan;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtReservacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
    }
}