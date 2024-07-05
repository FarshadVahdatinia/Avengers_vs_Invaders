namespace Avengers_vs_Invaders
{
    partial class LookupTblForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.countriesComboBox = new System.Windows.Forms.ComboBox();
            this.filterLbl = new System.Windows.Forms.Label();
            this.countriesLbl = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.roleLbl = new System.Windows.Forms.Label();
            this.invaderComboBox = new System.Windows.Forms.ComboBox();
            this.invaderSpeciesLbl = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // countriesComboBox
            // 
            this.countriesComboBox.FormattingEnabled = true;
            this.countriesComboBox.Location = new System.Drawing.Point(99, 28);
            this.countriesComboBox.Name = "countriesComboBox";
            this.countriesComboBox.Size = new System.Drawing.Size(121, 23);
            this.countriesComboBox.Sorted = true;
            this.countriesComboBox.TabIndex = 1;
            this.countriesComboBox.SelectedIndexChanged += new System.EventHandler(this.countriesComboBox_SelectedIndexChanged);
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Location = new System.Drawing.Point(12, 31);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(52, 15);
            this.filterLbl.TabIndex = 2;
            this.filterLbl.Text = "Filter by:";
            // 
            // countriesLbl
            // 
            this.countriesLbl.AutoSize = true;
            this.countriesLbl.Location = new System.Drawing.Point(126, 9);
            this.countriesLbl.Name = "countriesLbl";
            this.countriesLbl.Size = new System.Drawing.Size(58, 15);
            this.countriesLbl.TabIndex = 3;
            this.countriesLbl.Text = "Countries";
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(236, 28);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(121, 23);
            this.roleComboBox.TabIndex = 4;
            this.roleComboBox.SelectedIndexChanged += new System.EventHandler(this.roleComboBox_SelectedIndexChanged);
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Location = new System.Drawing.Point(284, 9);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(30, 15);
            this.roleLbl.TabIndex = 5;
            this.roleLbl.Text = "Role";
            // 
            // invaderComboBox
            // 
            this.invaderComboBox.FormattingEnabled = true;
            this.invaderComboBox.Location = new System.Drawing.Point(372, 28);
            this.invaderComboBox.Name = "invaderComboBox";
            this.invaderComboBox.Size = new System.Drawing.Size(121, 23);
            this.invaderComboBox.TabIndex = 6;
            this.invaderComboBox.SelectedIndexChanged += new System.EventHandler(this.invaderComboBox_SelectedIndexChanged);
            // 
            // invaderSpeciesLbl
            // 
            this.invaderSpeciesLbl.AutoSize = true;
            this.invaderSpeciesLbl.Location = new System.Drawing.Point(388, 9);
            this.invaderSpeciesLbl.Name = "invaderSpeciesLbl";
            this.invaderSpeciesLbl.Size = new System.Drawing.Size(88, 15);
            this.invaderSpeciesLbl.TabIndex = 7;
            this.invaderSpeciesLbl.Text = "Invader Species";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(511, 28);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 23);
            this.emailTextBox.TabIndex = 8;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emaiTextBox1_TextChanged);
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(526, 9);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(85, 15);
            this.emailLbl.TabIndex = 9;
            this.emailLbl.Text = "Name or Email";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(656, 27);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(88, 23);
            this.resetBtn.TabIndex = 10;
            this.resetBtn.Text = "ResetFilters";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // LookupTblForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.invaderSpeciesLbl);
            this.Controls.Add(this.invaderComboBox);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.countriesLbl);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.countriesComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LookupTblForm";
            this.Text = "LookupTblForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox countriesComboBox;
        private Label filterLbl;
        private Label countriesLbl;
        private ComboBox roleComboBox;
        private Label roleLbl;
        private ComboBox invaderComboBox;
        private Label invaderSpeciesLbl;
        private TextBox emailTextBox;
        private Label emailLbl;
        private Button resetBtn;
    }
}