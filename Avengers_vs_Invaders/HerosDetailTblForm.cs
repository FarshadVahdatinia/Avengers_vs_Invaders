using Avengers_vs_Invaders.Helper;
using Core.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avengers_vs_Invaders
{
    public partial class HerosDetailTblForm : Form
    {
        public HerosDetailTblForm()
        {
            InitializeComponent();
            FillHerosCombo();
        }

        private void FillHerosCombo()
        {
            var heroes = FetchData.Heroes;
            string[] the_array = new string[heroes.Count];
            for (var i = 0; i < heroes.Count; ++i)
                the_array[i] = heroes[i].Name.ToString();
            herosCombo.Items.AddRange(the_array);
        }

        private void herosCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var heroName = herosCombo.SelectedItem.ToString();
            var lookup = FetchData.HeadQuarterHeroInvaders
                   .Join(FetchData.HeadQuarters, h => h.HeadQuarterId, c => c.Id, (h, c) => new { headQuarterHero = h, headQuarter = c })
                   .Join(FetchData.Invaders, h => h.headQuarterHero.InvaderId, c => c.Id, (h, c) => new { h.headQuarterHero, h.headQuarter, invader = c })
                   .Join(FetchData.Roles, h => h.headQuarterHero.RoleId, c => c.Id, (h, c) => new { h.headQuarterHero, h.headQuarter, h.invader, role = c })
                   .Join(FetchData.Heroes, h => h.headQuarterHero.HeroId, c => c.Id, (h, c) => new { h.headQuarterHero, h.headQuarter, h.invader, h.role, hero = c })
                   .Where(x => x.hero.Name == heroName);

            var showTbl = lookup.ToList()
                .GroupBy(x => x.headQuarter.Name)
                .Select(x => new Task2()
                {
                    Group = x.Key,
                    aliens = x.Any(c => c.headQuarter.Name == x.Key && c.invader.Id == 1) ? string.Join(" ", x.Select(c => c.role.Name.ToUpper()[0]).Distinct()) : "",
                    mind_flayer = x.Any(c => c.headQuarter.Name == x.Key && c.invader.Id == 6) ? string.Join(" ", x.Select(c => c.role.Name.ToUpper()[0]).Distinct()) : "",
                    beholder = x.Any(c => c.headQuarter.Name == x.Key && c.invader.Id == 3) ? string.Join(" ", x.Select(c => c.role.Name.ToUpper()[0]).Distinct()) : "",
                    hill_giant = x.Any(c => c.headQuarter.Name == x.Key && c.invader.Id == 9) ? string.Join(" ", x.Select(c => c.role.Name.ToUpper()[0]).Distinct()) : "",
                    lichrEmail = x.Any(c => c.headQuarter.Name == x.Key && c.invader.Id == 5) ? string.Join(" ", x.Select(c => c.role.Name.ToUpper()[0]).Distinct()) : "",
                    predators = x.Any(c => c.headQuarter.Name == x.Key && c.invader.Id == 2) ? string.Join(" ", x.Select(c => c.role.Name.ToUpper()[0]).Distinct()) : "",
                    red_dragon = x.Any(c => c.headQuarter.Name == x.Key && c.invader.Id == 8) ? string.Join(" ", x.Select(c => c.role.Name.ToUpper()[0]).Distinct()) : "",
                    treant = x.Any(c => c.headQuarter.Name == x.Key && c.invader.Id == 10) ? string.Join(" ", x.Select(c => c.role.Name.ToUpper()[0]).Distinct()) : "",
                    vampire = x.Any(c => c.headQuarter.Name == x.Key && c.invader.Id == 7) ? string.Join(" ", x.Select(c => c.role.Name.ToUpper()[0]).Distinct()) : "",
                    werewolf = x.Any(c => c.headQuarter.Name == x.Key && c.invader.Id == 11) ? string.Join(" ", x.Select(c => c.role.Name.ToUpper()[0]).Distinct()) : "",
                    yuan_ti = x.Any(c => c.headQuarter.Name == x.Key && c.invader.Id == 12) ? string.Join(" ", x.Select(c => c.role.Name.ToUpper()[0]).Distinct()) : "",
                }).ToList();
            herosGrd.DataSource = showTbl;
        }
    }
}
