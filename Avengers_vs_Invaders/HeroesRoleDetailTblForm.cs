using Avengers_vs_Invaders.Helper;
using Core.DTO;
using Core.Enums;
using MarkdownLog;
using System.Data;
using System.Linq.Expressions;

namespace Avengers_vs_Invaders
{
    public partial class HeroesRoleDetailTblForm : Form
    {
        public HeroesRoleDetailTblForm()
        {
            InitializeComponent();
            FillHeroesCombo();
            GetInvaders();
            GetRoles();
        }

        private void FillHeroesCombo()
        {
            var heroes = FetchData.Heroes;
            string[] the_array = new string[heroes.Count + 1];
            for (var i = 1; i < heroes.Count + 1; ++i)
                the_array[i] = heroes[i - 1].Name.ToString();
            the_array[0] = "";
            herosCombo.Items.AddRange(the_array);
        }

        private void GetInvaders()
        {
            var invaders = FetchData.Invaders;
            string[] the_array = new string[invaders.Count + 1];
            for (var i = 1; i < invaders.Count + 1; ++i)
                the_array[i] = invaders[i - 1].Name.ToString();
            the_array[0] = "";
            invaderComboBox.Items.AddRange(the_array);
        }
        private void GetRoles()
        {
            var roles = FetchData.Roles;
            string[] the_array = new string[roles.Count + 1];
            for (var i = 1; i < roles.Count + 1; ++i)
                the_array[i] = roles[i - 1].Name.ToString();
            the_array[0] = "";
            roleComboBox.Items.AddRange(the_array);
        }
        private void FillData()
        {
            var heroName = herosCombo.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(heroName))
            {
                herosGrd.DataSource = null;
                return;
            }

            var lookup = DataTablesHelper.GetHeroesDetail();
            var showTbl = DataTablesHelper.GetRoleTblData(lookup, heroName);
        
            if (!string.IsNullOrEmpty(invaderComboBox.Text?.ToString()))
                switch (invaderComboBox.Text)
                {
                    case "aliens":
                        showTbl= showTbl.Where(x => !string.IsNullOrEmpty(x.aliens)).ToList();
                        break;
                    case "d&d_mind_flayer":
                        showTbl = showTbl.Where(x => !string.IsNullOrEmpty(x.mind_flayer)).ToList();
                        break;
                    case "d&d_beholder":
                        showTbl = showTbl.Where(x => !string.IsNullOrEmpty(x.beholder)).ToList();
                        break;
                    case "d&d_hill_giant":
                        showTbl = showTbl.Where(x => !string.IsNullOrEmpty(x.hill_giant)).ToList();
                        break;
                    case "d&d_lich":
                        showTbl = showTbl.Where(x => !string.IsNullOrEmpty(x.lich)).ToList();
                        break;
                    case "predators":
                        showTbl = showTbl.Where(x => !string.IsNullOrEmpty(x.predators)).ToList();
                        break;
                    case "d&d_red_dragon":
                        showTbl = showTbl.Where(x => !string.IsNullOrEmpty(x.red_dragon)).ToList();
                        break;
                    case "d&d_treant":
                        showTbl = showTbl.Where(x => !string.IsNullOrEmpty(x.treant)).ToList();
                        break;
                    case "d&d_vampire":
                        showTbl = showTbl.Where(x => !string.IsNullOrEmpty(x.vampire)).ToList();
                        break;
                    case "d&d_werewolf":
                        showTbl = showTbl.Where(x => !string.IsNullOrEmpty(x.werewolf)).ToList();
                        break;
                    case "d&d_yuan_ti":
                        showTbl = showTbl.Where(x => !string.IsNullOrEmpty(x.yuan_ti)).ToList();
                        break;
                    case "d&d_devil":
                        showTbl = showTbl.Where(x => !string.IsNullOrEmpty(x.devil)).ToList();
                        break;
                    default:
                        break;
                }

            if (!string.IsNullOrEmpty(roleComboBox.Text?.ToString()))
            {
                string role = roleComboBox.Text.ToString() == "defense_role" ? "D" : roleComboBox.Text.ToString() == "attack_role" ? "A" : "H";
                showTbl = showTbl.Where(x => x.werewolf.Contains(role) || x.yuan_ti.Contains(role) || x.lich.Contains(role) || x.mind_flayer.Contains(role) || x.hill_giant.Contains(role) || x.predators.Contains(role) || x.red_dragon.Contains(role) || x.treant.Contains(role) || x.vampire.Contains(role) || x.aliens.Contains(role) || x.beholder.Contains(role) || x.devil.Contains(role) ).ToList();
            }
            herosGrd.DataSource = showTbl;
        }


        private void invaderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void herosCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FillData();
        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            roleComboBox.SelectedIndex = 0;
            invaderComboBox.SelectedIndex = 0;
            FillData();
        }
    }
}
