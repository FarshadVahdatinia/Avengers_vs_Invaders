namespace Avengers_vs_Invaders
{
    partial class HeroesRoleDetailTblForm
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
            this.herosCombo = new System.Windows.Forms.ComboBox();
            this.herosGrd = new System.Windows.Forms.DataGridView();
            this.heroSelectionLbl = new System.Windows.Forms.Label();
            this.filterLbl = new System.Windows.Forms.Label();
            this.invaderComboBox = new System.Windows.Forms.ComboBox();
            this.invaderLbl = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.roleLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.herosGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // herosCombo
            // 
            this.herosCombo.FormattingEnabled = true;
            this.herosCombo.Location = new System.Drawing.Point(106, 26);
            this.herosCombo.Name = "herosCombo";
            this.herosCombo.Size = new System.Drawing.Size(121, 23);
            this.herosCombo.TabIndex = 0;
            this.herosCombo.SelectedIndexChanged += new System.EventHandler(this.herosCombo_SelectedIndexChanged_1);
            // 
            // herosGrd
            // 
            this.herosGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.herosGrd.Location = new System.Drawing.Point(12, 55);
            this.herosGrd.Name = "herosGrd";
            this.herosGrd.RowTemplate.Height = 25;
            this.herosGrd.Size = new System.Drawing.Size(776, 371);
            this.herosGrd.TabIndex = 1;
            // 
            // heroSelectionLbl
            // 
            this.heroSelectionLbl.AutoSize = true;
            this.heroSelectionLbl.Location = new System.Drawing.Point(12, 29);
            this.heroSelectionLbl.Name = "heroSelectionLbl";
            this.heroSelectionLbl.Size = new System.Drawing.Size(88, 15);
            this.heroSelectionLbl.TabIndex = 2;
            this.heroSelectionLbl.Text = "Select one hero";
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Location = new System.Drawing.Point(317, 29);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(55, 15);
            this.filterLbl.TabIndex = 3;
            this.filterLbl.Text = "Filter By: ";
            // 
            // invaderComboBox
            // 
            this.invaderComboBox.FormattingEnabled = true;
            this.invaderComboBox.Location = new System.Drawing.Point(378, 26);
            this.invaderComboBox.Name = "invaderComboBox";
            this.invaderComboBox.Size = new System.Drawing.Size(121, 23);
            this.invaderComboBox.TabIndex = 4;
            this.invaderComboBox.SelectedIndexChanged += new System.EventHandler(this.invaderComboBox_SelectedIndexChanged);
            // 
            // invaderLbl
            // 
            this.invaderLbl.AutoSize = true;
            this.invaderLbl.Location = new System.Drawing.Point(406, 8);
            this.invaderLbl.Name = "invaderLbl";
            this.invaderLbl.Size = new System.Drawing.Size(46, 15);
            this.invaderLbl.TabIndex = 5;
            this.invaderLbl.Text = "Invader";
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(522, 26);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(121, 23);
            this.roleComboBox.TabIndex = 6;
            this.roleComboBox.SelectedIndexChanged += new System.EventHandler(this.roleComboBox_SelectedIndexChanged);
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Location = new System.Drawing.Point(560, 8);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(30, 15);
            this.roleLbl.TabIndex = 7;
            this.roleLbl.Text = "Role";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(679, 25);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(88, 23);
            this.resetBtn.TabIndex = 11;
            this.resetBtn.Text = "ResetFilters";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // HeroesRoleDetailTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.invaderLbl);
            this.Controls.Add(this.invaderComboBox);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.heroSelectionLbl);
            this.Controls.Add(this.herosGrd);
            this.Controls.Add(this.herosCombo);
            this.Name = "HeroesRoleDetailTblForm";
            this.Text = "HerosDetailTblForm";
            ((System.ComponentModel.ISupportInitialize)(this.herosGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox herosCombo;
        private DataGridView herosGrd;
        private Label heroSelectionLbl;
        private Label filterLbl;
        private ComboBox invaderComboBox;
        private Label invaderLbl;
        private ComboBox roleComboBox;
        private Label roleLbl;
        private Button resetBtn;
    }
}