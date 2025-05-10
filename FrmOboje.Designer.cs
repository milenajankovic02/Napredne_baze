namespace Projekat
{
    partial class FrmOboje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOboje));
            this.saveBtn = new System.Windows.Forms.Button();
            this.cbPlant = new System.Windows.Forms.ComboBox();
            this.cbHerbarium = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpDatumSmjestanja = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(220, 252);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 65);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Dodaj";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // cbPlant
            // 
            this.cbPlant.FormattingEnabled = true;
            this.cbPlant.Location = new System.Drawing.Point(258, 118);
            this.cbPlant.Name = "cbPlant";
            this.cbPlant.Size = new System.Drawing.Size(157, 24);
            this.cbPlant.TabIndex = 7;
            // 
            // cbHerbarium
            // 
            this.cbHerbarium.FormattingEnabled = true;
            this.cbHerbarium.Location = new System.Drawing.Point(258, 163);
            this.cbHerbarium.Name = "cbHerbarium";
            this.cbHerbarium.Size = new System.Drawing.Size(157, 24);
            this.cbHerbarium.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(135, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Biljka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(115, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Herbarijum";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(124, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(291, 32);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Dodaj biljku u herbarijum";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBox1.Location = new System.Drawing.Point(60, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 332);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dtpDatumSmjestanja
            // 
            this.dtpDatumSmjestanja.Location = new System.Drawing.Point(257, 210);
            this.dtpDatumSmjestanja.Name = "dtpDatumSmjestanja";
            this.dtpDatumSmjestanja.Size = new System.Drawing.Size(245, 22);
            this.dtpDatumSmjestanja.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(78, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Datum smještanja";
            // 
            // FrmOboje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekat.Properties.Resources.s5;
            this.ClientSize = new System.Drawing.Size(554, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumSmjestanja);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbHerbarium);
            this.Controls.Add(this.cbPlant);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOboje";
            this.Text = "Plants and Herbariums";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox cbPlant;
        private System.Windows.Forms.ComboBox cbHerbarium;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpDatumSmjestanja;
        private System.Windows.Forms.Label label1;
    }
}