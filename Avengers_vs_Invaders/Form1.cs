using Avengers_vs_Invaders.Helper;

namespace Avengers_vs_Invaders
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            LookupTblForm frm = new LookupTblForm();
            frm.ShowDialog();
        }

        private void HerosDetail_Click_1(object sender, EventArgs e)
        {
            HerosDetailTblForm frm = new HerosDetailTblForm();
            frm.ShowDialog();
        }
    }
}
