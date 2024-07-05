using Avengers_vs_Invaders.Helper;
using Core.DTO;
using MarkdownLog;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Avengers_vs_Invaders
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void lookupTableBtn_Click_1(object sender, EventArgs e)
        {
            LookupTblForm frm = new LookupTblForm();
            frm.ShowDialog();
        }

        private void heroesRoleInfoTableBtn_Click_1(object sender, EventArgs e)
        {
            HeroesRoleDetailTblForm frm = new HeroesRoleDetailTblForm();
            frm.ShowDialog();
        }

        private void markDownFileBtn_Click(object sender, EventArgs e)
        {

            try
            {
                StringBuilder sb = new();
                
                #region Task1Tbl
                var showTbl1 = DataTablesHelper.GetLookupTblData();
                var countryInvaderMd = sb.AppendLine(showTbl1.ToMarkdownTable().ToMarkdown() + System.Environment.NewLine);
                #endregion

                #region Task2Tbl
                var heroes = FetchData.Heroes;
                var heroesDetail = DataTablesHelper.GetHeroesDetail();
                foreach (var hero in heroes)
                {
                    var showTbl2 = DataTablesHelper.GetRoleTblData(heroesDetail, hero?.Name);
                    sb.AppendLine(hero.Name.ToMarkdownHeader().ToString());
                    sb.AppendLine(showTbl2.ToMarkdownTable().ToMarkdown() + System.Environment.NewLine);
                } 
                #endregion

                var currentPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                string MdFilePath = System.IO.Path.Combine(currentPath, "MDFiles\\Table.md");
                File.WriteAllText(MdFilePath, sb.ToString());
                DialogResult dialogResult = MessageBox.Show("The File is ready.Do you want to open?", "Success", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var aa = new ProcessStartInfo()
                    {
                        UseShellExecute = true,
                        Arguments = System.IO.Path.Combine(currentPath, "MDFiles"),
                        FileName = "explorer.exe",
                    };
                    Process.Start(aa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
