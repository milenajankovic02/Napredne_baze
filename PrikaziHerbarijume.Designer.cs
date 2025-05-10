namespace Projekat
{
    partial class PrikaziHerbarijume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrikaziHerbarijume));
            this.dgHerbariums = new System.Windows.Forms.DataGridView();
            this.txtDescriptionSearch = new System.Windows.Forms.TextBox();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteHerbariumBtn = new System.Windows.Forms.Button();
            this.changeHerbariumBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlantMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHerbariumMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlantInHerbariumMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allPlantsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.allHerbariumsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHerbariums)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgHerbariums
            // 
            this.dgHerbariums.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHerbariums.BackgroundColor = System.Drawing.Color.Beige;
            this.dgHerbariums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHerbariums.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgHerbariums.Location = new System.Drawing.Point(38, 216);
            this.dgHerbariums.Name = "dgHerbariums";
            this.dgHerbariums.RowHeadersWidth = 51;
            this.dgHerbariums.RowTemplate.Height = 24;
            this.dgHerbariums.Size = new System.Drawing.Size(761, 299);
            this.dgHerbariums.TabIndex = 0;
            // 
            // txtDescriptionSearch
            // 
            this.txtDescriptionSearch.Location = new System.Drawing.Point(125, 176);
            this.txtDescriptionSearch.Name = "txtDescriptionSearch";
            this.txtDescriptionSearch.Size = new System.Drawing.Size(187, 22);
            this.txtDescriptionSearch.TabIndex = 2;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(125, 136);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(187, 22);
            this.txtNameSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(31, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pretraži herbarijume po:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(34, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opisu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(34, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nazivu";
            // 
            // deleteHerbariumBtn
            // 
            this.deleteHerbariumBtn.BackColor = System.Drawing.Color.Yellow;
            this.deleteHerbariumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteHerbariumBtn.Location = new System.Drawing.Point(676, 48);
            this.deleteHerbariumBtn.Name = "deleteHerbariumBtn";
            this.deleteHerbariumBtn.Size = new System.Drawing.Size(153, 82);
            this.deleteHerbariumBtn.TabIndex = 8;
            this.deleteHerbariumBtn.Text = "Obriši herbarijum";
            this.deleteHerbariumBtn.UseVisualStyleBackColor = false;
            // 
            // changeHerbariumBtn
            // 
            this.changeHerbariumBtn.BackColor = System.Drawing.Color.Yellow;
            this.changeHerbariumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeHerbariumBtn.Location = new System.Drawing.Point(518, 48);
            this.changeHerbariumBtn.Name = "changeHerbariumBtn";
            this.changeHerbariumBtn.Size = new System.Drawing.Size(152, 82);
            this.changeHerbariumBtn.TabIndex = 9;
            this.changeHerbariumBtn.Text = "Izmijeni herbarijum";
            this.changeHerbariumBtn.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cornsilk;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem,
            this.izvještajiToolStripMenuItem,
            this.exitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 30);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.BackColor = System.Drawing.Color.Moccasin;
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlantMenuItem,
            this.addHerbariumMenuItem,
            this.addPlantInHerbariumMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // addPlantMenuItem
            // 
            this.addPlantMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.addPlantMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addPlantMenuItem.Name = "addPlantMenuItem";
            this.addPlantMenuItem.Size = new System.Drawing.Size(261, 26);
            this.addPlantMenuItem.Text = "Dodaj biljku";
            // 
            // addHerbariumMenuItem
            // 
            this.addHerbariumMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.addHerbariumMenuItem.Name = "addHerbariumMenuItem";
            this.addHerbariumMenuItem.Size = new System.Drawing.Size(261, 26);
            this.addHerbariumMenuItem.Text = "Dodaj herbarijum";
            // 
            // addPlantInHerbariumMenuItem
            // 
            this.addPlantInHerbariumMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.addPlantInHerbariumMenuItem.Name = "addPlantInHerbariumMenuItem";
            this.addPlantInHerbariumMenuItem.Size = new System.Drawing.Size(261, 26);
            this.addPlantInHerbariumMenuItem.Text = "Dodaj biljku u herbarijum";
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.BackColor = System.Drawing.Color.Moccasin;
            this.izvještajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allPlantsReport,
            this.allHerbariumsReport});
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // allPlantsReport
            // 
            this.allPlantsReport.BackColor = System.Drawing.Color.Bisque;
            this.allPlantsReport.Name = "allPlantsReport";
            this.allPlantsReport.Size = new System.Drawing.Size(191, 26);
            this.allPlantsReport.Text = "Sve biljke";
            // 
            // allHerbariumsReport
            // 
            this.allHerbariumsReport.BackColor = System.Drawing.Color.Bisque;
            this.allHerbariumsReport.Name = "allHerbariumsReport";
            this.allHerbariumsReport.Size = new System.Drawing.Size(191, 26);
            this.allHerbariumsReport.Text = "Svi herbarijumi";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.BackColor = System.Drawing.Color.Moccasin;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(74, 26);
            this.exitMenuItem.Text = "Napusti";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Yellow;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(355, 156);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 42);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // PrikaziHerbarijume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekat.Properties.Resources.k2;
            this.ClientSize = new System.Drawing.Size(841, 545);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.changeHerbariumBtn);
            this.Controls.Add(this.deleteHerbariumBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.txtDescriptionSearch);
            this.Controls.Add(this.dgHerbariums);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrikaziHerbarijume";
            this.Text = "Herbariums";
            ((System.ComponentModel.ISupportInitialize)(this.dgHerbariums)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHerbariums;
        private System.Windows.Forms.TextBox txtDescriptionSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteHerbariumBtn;
        private System.Windows.Forms.Button changeHerbariumBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlantMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHerbariumMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlantInHerbariumMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem allPlantsReport;
        private System.Windows.Forms.ToolStripMenuItem allHerbariumsReport;
    }
}