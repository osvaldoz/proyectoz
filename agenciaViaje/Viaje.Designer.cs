namespace agenciaViaje
{
    partial class Viaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viaje));
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.dtSalida = new System.Windows.Forms.DateTimePicker();
            this.dtRegreso = new System.Windows.Forms.DateTimePicker();
            this.labelPartida = new System.Windows.Forms.Label();
            this.labelRegreso = new System.Windows.Forms.Label();
            this.nAdultos = new System.Windows.Forms.NumericUpDown();
            this.nMenores = new System.Windows.Forms.NumericUpDown();
            this.labelAdultos = new System.Windows.Forms.Label();
            this.labelMenores = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.dtTimeS = new System.Windows.Forms.DateTimePicker();
            this.dtTimeR = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEstadoOrigen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbEstadoDestino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMenores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(14, 103);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 28);
            this.cmbOrigen.TabIndex = 0;
            // 
            // cmbDestino
            // 
            this.cmbDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(25, 110);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 28);
            this.cmbDestino.TabIndex = 2;
            // 
            // dtSalida
            // 
            this.dtSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSalida.Location = new System.Drawing.Point(16, 191);
            this.dtSalida.Name = "dtSalida";
            this.dtSalida.Size = new System.Drawing.Size(117, 26);
            this.dtSalida.TabIndex = 4;
            // 
            // dtRegreso
            // 
            this.dtRegreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRegreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRegreso.Location = new System.Drawing.Point(12, 263);
            this.dtRegreso.Name = "dtRegreso";
            this.dtRegreso.Size = new System.Drawing.Size(121, 26);
            this.dtRegreso.TabIndex = 5;
            // 
            // labelPartida
            // 
            this.labelPartida.AutoSize = true;
            this.labelPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartida.Location = new System.Drawing.Point(16, 168);
            this.labelPartida.Name = "labelPartida";
            this.labelPartida.Size = new System.Drawing.Size(59, 20);
            this.labelPartida.TabIndex = 6;
            this.labelPartida.Text = "Partida";
            this.labelPartida.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelRegreso
            // 
            this.labelRegreso.AutoSize = true;
            this.labelRegreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegreso.Location = new System.Drawing.Point(12, 240);
            this.labelRegreso.Name = "labelRegreso";
            this.labelRegreso.Size = new System.Drawing.Size(70, 20);
            this.labelRegreso.TabIndex = 7;
            this.labelRegreso.Text = "Regreso";
            this.labelRegreso.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // nAdultos
            // 
            this.nAdultos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nAdultos.Location = new System.Drawing.Point(16, 356);
            this.nAdultos.Name = "nAdultos";
            this.nAdultos.Size = new System.Drawing.Size(40, 26);
            this.nAdultos.TabIndex = 8;
            this.nAdultos.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nMenores
            // 
            this.nMenores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMenores.Location = new System.Drawing.Point(85, 356);
            this.nMenores.Name = "nMenores";
            this.nMenores.Size = new System.Drawing.Size(39, 26);
            this.nMenores.TabIndex = 9;
            this.nMenores.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // labelAdultos
            // 
            this.labelAdultos.AutoSize = true;
            this.labelAdultos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdultos.Location = new System.Drawing.Point(12, 311);
            this.labelAdultos.Name = "labelAdultos";
            this.labelAdultos.Size = new System.Drawing.Size(63, 20);
            this.labelAdultos.TabIndex = 10;
            this.labelAdultos.Text = "Adultos";
            this.labelAdultos.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labelMenores
            // 
            this.labelMenores.AutoSize = true;
            this.labelMenores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenores.Location = new System.Drawing.Point(78, 311);
            this.labelMenores.Name = "labelMenores";
            this.labelMenores.Size = new System.Drawing.Size(71, 20);
            this.labelMenores.TabIndex = 11;
            this.labelMenores.Text = "Menores";
            this.labelMenores.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 149);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(624, 189);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 35);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Continuar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hora de Salida";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora de regreso";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(624, 254);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(109, 35);
            this.Cancelar.TabIndex = 13;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtTimeS
            // 
            this.dtTimeS.CustomFormat = "HH:mm";
            this.dtTimeS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTimeS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeS.Location = new System.Drawing.Point(216, 191);
            this.dtTimeS.Name = "dtTimeS";
            this.dtTimeS.ShowUpDown = true;
            this.dtTimeS.Size = new System.Drawing.Size(117, 26);
            this.dtTimeS.TabIndex = 4;
            // 
            // dtTimeR
            // 
            this.dtTimeR.CustomFormat = "HH:mm";
            this.dtTimeR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTimeR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeR.Location = new System.Drawing.Point(216, 263);
            this.dtTimeR.Name = "dtTimeR";
            this.dtTimeR.ShowUpDown = true;
            this.dtTimeR.Size = new System.Drawing.Size(117, 26);
            this.dtTimeR.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEstadoOrigen);
            this.groupBox1.Controls.Add(this.cmbOrigen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 161);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origen";
            // 
            // cmbEstadoOrigen
            // 
            this.cmbEstadoOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEstadoOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEstadoOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoOrigen.FormattingEnabled = true;
            this.cmbEstadoOrigen.Location = new System.Drawing.Point(14, 45);
            this.cmbEstadoOrigen.Name = "cmbEstadoOrigen";
            this.cmbEstadoOrigen.Size = new System.Drawing.Size(121, 28);
            this.cmbEstadoOrigen.TabIndex = 0;
            this.cmbEstadoOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoOrigen_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ciudad";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDestino);
            this.groupBox2.Controls.Add(this.cmbEstadoDestino);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(358, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 161);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destino";
            // 
            // cmbEstadoDestino
            // 
            this.cmbEstadoDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEstadoDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEstadoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoDestino.FormattingEnabled = true;
            this.cmbEstadoDestino.Location = new System.Drawing.Point(25, 45);
            this.cmbEstadoDestino.Name = "cmbEstadoDestino";
            this.cmbEstadoDestino.Size = new System.Drawing.Size(121, 28);
            this.cmbEstadoDestino.TabIndex = 0;
            this.cmbEstadoDestino.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoDestino_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ciudad";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Estado";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // Viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMenores);
            this.Controls.Add(this.labelAdultos);
            this.Controls.Add(this.nMenores);
            this.Controls.Add(this.nAdultos);
            this.Controls.Add(this.labelRegreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPartida);
            this.Controls.Add(this.dtRegreso);
            this.Controls.Add(this.dtTimeR);
            this.Controls.Add(this.dtTimeS);
            this.Controls.Add(this.dtSalida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Viaje";
            this.Text = "Viaje";
            this.Load += new System.EventHandler(this.Viaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMenores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.DateTimePicker dtSalida;
        private System.Windows.Forms.DateTimePicker dtRegreso;
        private System.Windows.Forms.Label labelPartida;
        private System.Windows.Forms.Label labelRegreso;
        private System.Windows.Forms.NumericUpDown nAdultos;
        private System.Windows.Forms.NumericUpDown nMenores;
        private System.Windows.Forms.Label labelAdultos;
        private System.Windows.Forms.Label labelMenores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.DateTimePicker dtTimeS;
        private System.Windows.Forms.DateTimePicker dtTimeR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEstadoOrigen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbEstadoDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}