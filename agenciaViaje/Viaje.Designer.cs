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
            this.labelOrigen = new System.Windows.Forms.Label();
            this.labelDestino = new System.Windows.Forms.Label();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPartida = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelPartida = new System.Windows.Forms.Label();
            this.labelRegreso = new System.Windows.Forms.Label();
            this.numericUpDownAdultos = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMenores = new System.Windows.Forms.NumericUpDown();
            this.labelAdultos = new System.Windows.Forms.Label();
            this.labelMenores = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMenores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(12, 47);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 28);
            this.cmbOrigen.TabIndex = 0;
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigen.Location = new System.Drawing.Point(12, 24);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(56, 20);
            this.labelOrigen.TabIndex = 1;
            this.labelOrigen.Text = "Origen";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestino.Location = new System.Drawing.Point(244, 24);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(64, 20);
            this.labelDestino.TabIndex = 3;
            this.labelDestino.Text = "Destino";
            // 
            // cbDestino
            // 
            this.cbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(244, 47);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(121, 28);
            this.cbDestino.TabIndex = 2;
            // 
            // dateTimePickerPartida
            // 
            this.dateTimePickerPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPartida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPartida.Location = new System.Drawing.Point(16, 129);
            this.dateTimePickerPartida.Name = "dateTimePickerPartida";
            this.dateTimePickerPartida.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerPartida.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(248, 129);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // labelPartida
            // 
            this.labelPartida.AutoSize = true;
            this.labelPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartida.Location = new System.Drawing.Point(16, 106);
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
            this.labelRegreso.Location = new System.Drawing.Point(248, 106);
            this.labelRegreso.Name = "labelRegreso";
            this.labelRegreso.Size = new System.Drawing.Size(70, 20);
            this.labelRegreso.TabIndex = 7;
            this.labelRegreso.Text = "Regreso";
            this.labelRegreso.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // numericUpDownAdultos
            // 
            this.numericUpDownAdultos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAdultos.Location = new System.Drawing.Point(16, 294);
            this.numericUpDownAdultos.Name = "numericUpDownAdultos";
            this.numericUpDownAdultos.Size = new System.Drawing.Size(40, 26);
            this.numericUpDownAdultos.TabIndex = 8;
            this.numericUpDownAdultos.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDownMenores
            // 
            this.numericUpDownMenores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMenores.Location = new System.Drawing.Point(85, 294);
            this.numericUpDownMenores.Name = "numericUpDownMenores";
            this.numericUpDownMenores.Size = new System.Drawing.Size(39, 26);
            this.numericUpDownMenores.TabIndex = 9;
            this.numericUpDownMenores.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // labelAdultos
            // 
            this.labelAdultos.AutoSize = true;
            this.labelAdultos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdultos.Location = new System.Drawing.Point(12, 249);
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
            this.labelMenores.Location = new System.Drawing.Point(78, 249);
            this.labelMenores.Name = "labelMenores";
            this.labelMenores.Size = new System.Drawing.Size(71, 20);
            this.labelMenores.TabIndex = 11;
            this.labelMenores.Text = "Menores";
            this.labelMenores.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 149);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(463, 170);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 35);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Continuar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 26);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(248, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 26);
            this.textBox2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 177);
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
            this.label2.Location = new System.Drawing.Point(248, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora de regreso";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(463, 234);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(109, 35);
            this.Cancelar.TabIndex = 13;
            this.Cancelar.Text = "Continuar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMenores);
            this.Controls.Add(this.labelAdultos);
            this.Controls.Add(this.numericUpDownMenores);
            this.Controls.Add(this.numericUpDownAdultos);
            this.Controls.Add(this.labelRegreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPartida);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePickerPartida);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.labelOrigen);
            this.Controls.Add(this.cmbOrigen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Viaje";
            this.Text = "Viaje";
            this.Load += new System.EventHandler(this.Viaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMenores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label labelOrigen;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.DateTimePicker dateTimePickerPartida;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelPartida;
        private System.Windows.Forms.Label labelRegreso;
        private System.Windows.Forms.NumericUpDown numericUpDownAdultos;
        private System.Windows.Forms.NumericUpDown numericUpDownMenores;
        private System.Windows.Forms.Label labelAdultos;
        private System.Windows.Forms.Label labelMenores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancelar;
    }
}