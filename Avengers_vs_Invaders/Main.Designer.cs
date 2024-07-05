namespace Avengers_vs_Invaders
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LookupTable = new System.Windows.Forms.Button();
            this.HeroesRoleInfoTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MarkDownFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LookupTable
            // 
            this.LookupTable.Location = new System.Drawing.Point(36, 403);
            this.LookupTable.Name = "LookupTable";
            this.LookupTable.Size = new System.Drawing.Size(202, 34);
            this.LookupTable.TabIndex = 0;
            this.LookupTable.Text = "1-LookupTable";
            this.LookupTable.UseVisualStyleBackColor = true;
            this.LookupTable.Click += new System.EventHandler(this.lookupTableBtn_Click_1);
            // 
            // HeroesRoleInfoTable
            // 
            this.HeroesRoleInfoTable.Location = new System.Drawing.Point(309, 403);
            this.HeroesRoleInfoTable.Name = "HeroesRoleInfoTable";
            this.HeroesRoleInfoTable.Size = new System.Drawing.Size(196, 34);
            this.HeroesRoleInfoTable.TabIndex = 1;
            this.HeroesRoleInfoTable.Text = "2-HeroesRoleInfoTable";
            this.HeroesRoleInfoTable.UseVisualStyleBackColor = true;
            this.HeroesRoleInfoTable.Click += new System.EventHandler(this.heroesRoleInfoTableBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Farshadvdt@yahoo.com";
            // 
            // MarkDownFile
            // 
            this.MarkDownFile.Location = new System.Drawing.Point(571, 402);
            this.MarkDownFile.Name = "MarkDownFile";
            this.MarkDownFile.Size = new System.Drawing.Size(202, 35);
            this.MarkDownFile.TabIndex = 3;
            this.MarkDownFile.Text = "3-MarkDownFile";
            this.MarkDownFile.UseVisualStyleBackColor = true;
            this.MarkDownFile.Click += new System.EventHandler(this.markDownFileBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Avengers_vs_Invaders.Properties.Resources.qJNJkqMErNYoYoeDTVWVaV;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MarkDownFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeroesRoleInfoTable);
            this.Controls.Add(this.LookupTable);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LookupTable;
        private Button HeroesRoleInfoTable;
        private Label label1;
        private Button MarkDownFile;
    }
}
