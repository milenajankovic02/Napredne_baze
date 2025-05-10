namespace Projekat
{
    partial class FrmBiljka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiljka));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDatumZalivanja = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(215, 107);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dodaj biljku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(143, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vrsta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum zalivanja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Opis";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(222, 171);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(176, 22);
            this.txtNaziv.TabIndex = 5;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(222, 214);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(176, 22);
            this.txtVrsta.TabIndex = 6;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(222, 287);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(176, 22);
            this.txtOpis.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(222, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 58);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Sačuvaj podatke ";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dtpDatumZalivanja
            // 
            this.dtpDatumZalivanja.Location = new System.Drawing.Point(222, 251);
            this.dtpDatumZalivanja.Name = "dtpDatumZalivanja";
            this.dtpDatumZalivanja.Size = new System.Drawing.Size(245, 22);
            this.dtpDatumZalivanja.TabIndex = 10;
            // 
            // FrmBiljka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekat.Properties.Resources.s2;
            this.ClientSize = new System.Drawing.Size(566, 519);
            this.Controls.Add(this.dtpDatumZalivanja);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBiljka";
            this.Text = "Add/Change plant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDatumZalivanja;
        private System.Windows.Forms.Label label2;
    }
}