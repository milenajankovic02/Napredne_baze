namespace Projekat
{
    partial class FrmHerbarijum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHerbarijum));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.dtpDatumOsnivanja = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(165, 105);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 41);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Dodaj herbarijum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Naziv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Opis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Datum osnivanja";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(195, 179);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(206, 22);
            this.txtNaziv.TabIndex = 7;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(195, 227);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(203, 22);
            this.txtOpis.TabIndex = 8;
            // 
            // dtpDatumOsnivanja
            // 
            this.dtpDatumOsnivanja.Location = new System.Drawing.Point(195, 268);
            this.dtpDatumOsnivanja.Name = "dtpDatumOsnivanja";
            this.dtpDatumOsnivanja.Size = new System.Drawing.Size(256, 22);
            this.dtpDatumOsnivanja.TabIndex = 11;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(195, 331);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(206, 56);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Sačuvaj podatke";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // FrmHerbarijum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekat.Properties.Resources.s21;
            this.ClientSize = new System.Drawing.Size(561, 518);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dtpDatumOsnivanja);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHerbarijum";
            this.Text = "Add/Change herbarium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.DateTimePicker dtpDatumOsnivanja;
        private System.Windows.Forms.Button saveBtn;
    }
}