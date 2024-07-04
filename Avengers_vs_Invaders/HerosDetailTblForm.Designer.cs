namespace Avengers_vs_Invaders
{
    partial class HerosDetailTblForm
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
            herosCombo = new ComboBox();
            herosGrd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)herosGrd).BeginInit();
            SuspendLayout();
            // 
            // herosCombo
            // 
            herosCombo.FormattingEnabled = true;
            herosCombo.Location = new Point(342, 12);
            herosCombo.Name = "herosCombo";
            herosCombo.Size = new Size(121, 23);
            herosCombo.TabIndex = 0;
            herosCombo.SelectedIndexChanged += herosCombo_SelectedIndexChanged;
            // 
            // herosGrd
            // 
            herosGrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            herosGrd.Location = new Point(44, 59);
            herosGrd.Name = "herosGrd";
            herosGrd.RowTemplate.Height = 25;
            herosGrd.Size = new Size(698, 272);
            herosGrd.TabIndex = 1;
            // 
            // HerosDetailTblForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(herosGrd);
            Controls.Add(herosCombo);
            Name = "HerosDetailTblForm";
            Text = "HerosDetailTblForm";
            ((System.ComponentModel.ISupportInitialize)herosGrd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox herosCombo;
        private DataGridView herosGrd;
    }
}