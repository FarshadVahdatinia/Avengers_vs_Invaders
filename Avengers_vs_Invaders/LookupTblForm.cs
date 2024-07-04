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
    public partial class LookupTblForm : Form
    {
        public LookupTblForm()
        {
            InitializeComponent();
            FillDate();
        }

        private void FillDate()
        {
            var lookup = FetchData.HeadQuarterHeroInvaders
                   .Join(FetchData.CountryHeadQuarterInvaders, x => x.HeadQuarterId, y => y.HeadQuarterId, (x, y) => new { headQuarter = x, countryInvader = y })
                   .Join(FetchData.Countries, h => h.countryInvader.CountryId, c => c.Id, (h, c) => new { h.headQuarter, h.countryInvader, country = c })
                   .Join(FetchData.Invaders, h => h.countryInvader.InvaderId, c => c.Id, (h, c) => new { h.headQuarter, h.countryInvader, h.country, invader = c })
                   .Join(FetchData.Roles, h => h.headQuarter.RoleId, c => c.Id, (h, c) => new { h.headQuarter, h.countryInvader, h.country, h.invader, role = c })
                   .Join(FetchData.Heroes, h => h.headQuarter.HeroId, c => c.Id, (h, c) => new { h.headQuarter, h.countryInvader, h.country, h.invader, h.role, hero = c })
                   .Where(x=>!string.IsNullOrEmpty(x.hero.Email));
            var showTbl = lookup.ToList().Select(x => new Task1()
            {
                Country = x.country.Code,
                InvaderSpecies = x.invader.Name,
                RoleSpecific = x.role.Name,
                AvengerEmail = x.hero.Email
            }).ToList();
            dataGridView1.DataSource = showTbl;
        }
    }
}
