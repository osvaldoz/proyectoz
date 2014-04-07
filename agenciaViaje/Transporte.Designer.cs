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
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenCarro)).BeginInit();
            this.gbxTipoCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(12, 152);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(133, 147);
            this.listBoxCarros.TabIndex = 2;
            this.listBoxCarros.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pbxImagenCarro
            // 
            this.pbxImagenCarro.Location = new System.Drawing.Point(179, 152);
            this.pbxImagenCarro.Name = "pbxImagenCarro";
            this.pbxImagenCarro.Size = new System.Drawing.Size(255, 147);
            this.pbxImagenCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
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
            // Transporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.gbxTipoCarro);
            this.Controls.Add(this.pbxImagenCarro);
            this.Controls.Add(this.listBoxCarros);
            this.Name = "Transporte";
            this.Text = "Transporte";
            this.Load += new System.EventHandler(this.Transporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenCarro)).EndInit();
            this.gbxTipoCarro.ResumeLayout(false);
            this.gbxTipoCarro.PerformLayout();
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
    }
}