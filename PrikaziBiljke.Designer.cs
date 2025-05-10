namespace Projekat
{
    partial class PrikaziBiljke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrikaziBiljke));
            this.dgPlants = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlantMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHerbariumMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlantInHerbariumMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allPlantsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.allHerbariumsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTypeSearch = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.changePlantBtn = new System.Windows.Forms.Button();
            this.deletePlantBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlants)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPlants
            // 
            this.dgPlants.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgPlants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlants.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.dgPlants.Location = new System.Drawing.Point(42, 202);
            this.dgPlants.Name = "dgPlants";
            this.dgPlants.RowHeadersWidth = 51;
            this.dgPlants.RowTemplate.Height = 24;
            this.dgPlants.Size = new System.Drawing.Size(719, 236);
            this.dgPlants.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Beige;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem,
            this.izvještajiToolStripMenuItem,
            this.exitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlantMenuItem,
            this.addHerbariumMenuItem,
            this.addPlantInHerbariumMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // addPlantMenuItem
            // 
            this.addPlantMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addPlantMenuItem.Name = "addPlantMenuItem";
            this.addPlantMenuItem.Size = new System.Drawing.Size(261, 26);
            this.addPlantMenuItem.Text = "Dodaj biljku";
            // 
            // addHerbariumMenuItem
            // 
            this.addHerbariumMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addHerbariumMenuItem.Name = "addHerbariumMenuItem";
            this.addHerbariumMenuItem.Size = new System.Drawing.Size(261, 26);
            this.addHerbariumMenuItem.Text = "Dodaj herbarijum";
            // 
            // addPlantInHerbariumMenuItem
            // 
            this.addPlantInHerbariumMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addPlantInHerbariumMenuItem.Name = "addPlantInHerbariumMenuItem";
            this.addPlantInHerbariumMenuItem.Size = new System.Drawing.Size(261, 26);
            this.addPlantInHerbariumMenuItem.Text = "Dodaj biljku u herbarijum";
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.izvještajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allPlantsReport,
            this.allHerbariumsReport});
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // allPlantsReport
            // 
            this.allPlantsReport.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.allPlantsReport.ForeColor = System.Drawing.Color.Black;
            this.allPlantsReport.Name = "allPlantsReport";
            this.allPlantsReport.Size = new System.Drawing.Size(191, 26);
            this.allPlantsReport.Text = "Sve biljke";
            // 
            // allHerbariumsReport
            // 
            this.allHerbariumsReport.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.allHerbariumsReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.allHerbariumsReport.Name = "allHerbariumsReport";
            this.allHerbariumsReport.Size = new System.Drawing.Size(191, 26);
            this.allHerbariumsReport.Text = "Svi herbarijumi";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(74, 24);
            this.exitMenuItem.Text = "Napusti";
            // 
            // txtTypeSearch
            // 
            this.txtTypeSearch.Location = new System.Drawing.Point(135, 161);
            this.txtTypeSearch.Name = "txtTypeSearch";
            this.txtTypeSearch.Size = new System.Drawing.Size(140, 22);
            this.txtTypeSearch.TabIndex = 4;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.BackColor = System.Drawing.Color.Beige;
            this.lblPretraga.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretraga.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPretraga.Location = new System.Drawing.Point(36, 80);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(218, 31);
            this.lblPretraga.TabIndex = 6;
            this.lblPretraga.Text = "Pretraži biljke po:";
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.BackColor = System.Drawing.Color.Beige;
            this.lblP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblP1.Location = new System.Drawing.Point(38, 133);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(66, 20);
            this.lblP1.TabIndex = 7;
            this.lblP1.Text = "Nazivu";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraga.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnPretraga.Location = new System.Drawing.Point(319, 141);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(92, 42);
            this.btnPretraga.TabIndex = 10;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            // 
            // changePlantBtn
            // 
            this.changePlantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePlantBtn.Location = new System.Drawing.Point(434, 45);
            this.changePlantBtn.Name = "changePlantBtn";
            this.changePlantBtn.Size = new System.Drawing.Size(160, 76);
            this.changePlantBtn.TabIndex = 11;
            this.changePlantBtn.Text = "Izmijeni biljku ";
            this.changePlantBtn.UseVisualStyleBackColor = true;
            // 
            // deletePlantBtn
            // 
            this.deletePlantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePlantBtn.Location = new System.Drawing.Point(600, 45);
            this.deletePlantBtn.Name = "deletePlantBtn";
            this.deletePlantBtn.Size = new System.Drawing.Size(161, 76);
            this.deletePlantBtn.TabIndex = 12;
            this.deletePlantBtn.Text = "Ukloni biljku ";
            this.deletePlantBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(38, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Vrsti";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(135, 133);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(140, 22);
            this.txtNameSearch.TabIndex = 14;
            // 
            // PrikaziBiljke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekat.Properties.Resources.ova;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletePlantBtn);
            this.Controls.Add(this.changePlantBtn);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.txtTypeSearch);
            this.Controls.Add(this.dgPlants);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrikaziBiljke";
            this.Text = "Plants";
            ((System.ComponentModel.ISupportInitialize)(this.dgPlants)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPlants;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlantMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHerbariumMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.TextBox txtTypeSearch;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.ToolStripMenuItem addPlantInHerbariumMenuItem;
        private System.Windows.Forms.Button changePlantBtn;
        private System.Windows.Forms.Button deletePlantBtn;
        private System.Windows.Forms.ToolStripMenuItem allPlantsReport;
        private System.Windows.Forms.ToolStripMenuItem allHerbariumsReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameSearch;
    }
}