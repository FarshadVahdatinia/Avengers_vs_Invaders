using Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Avengers_vs_Invaders.Helper
{

    public static class DataTablesHelper
    {
        /// <summary>
        ///  lookup table with "country-invader species-role specific-email contacts of avengers" Columns
        /// </summary>
        /// <returns></returns>
        public static List<Task1> GetLookupTblData()
        {
            var lookup = FetchData.HeadQuarterHeroInvaders
                       .Join(FetchData.CountryHeadQuarterInvaders, x => x.HeadQuarterId, y => y.HeadQuarterId, (x, y) => new { headQuarter = x, countryInvader = y })
                       .Join(FetchData.Countries, h => h.countryInvader.CountryId, c => c.Id, (h, c) => new { h.headQuarter, h.countryInvader, country = c })
                       .Join(FetchData.Invaders, h => h.countryInvader.InvaderId, c => c.Id, (h, c) => new { h.headQuarter, h.countryInvader, h.country, invader = c })
                       .Join(FetchData.Roles, h => h.headQuarter.RoleId, c => c.Id, (h, c) => new { h.headQuarter, h.countryInvader, h.country, h.invader, role = c })
                       .Join(FetchData.Heroes, h => h.headQuarter.HeroId, c => c.Id, (h, c) => new { h.headQuarter, h.countryInvader, h.country, h.invader, h.role, hero = c })
                       .Where(x => !string.IsNullOrEmpty(x.hero.Email));
            return lookup.ToList().Select(x => new Task1()
            {
                Country = x.country.Code,
                InvaderSpecies = x.invader.GroupName,
                RoleSpecific = x.role.Name,
                AvengerEmail = x.hero.Email
            }).ToList();
        }

        /// <summary>
        ///  avenger role descriptions under HQ + invader-species
        /// </summary>
        /// <param name="lookup"></param>
        /// <param name="heroName"></param>
        /// <returns></returns>
        public static List<Task2> GetRoleTblData(List<HeadQuarterInvaderRoleDto> lookup, string? heroName)
        {
            var showTbl = lookup.Where(x => x.Hero.Name == heroName)
                .GroupBy(x => x.HeadQuarter.Name)
                .Select(x => new Task2()
                {
                    Group = x.Key,
                    aliens = x.Any(c => c.HeadQuarter.Name == x.Key && c.Invader.Id == 1) ? string.Join(" ", x.Select(c => c.Role.Name.ToUpper()[0]).Distinct()) : "",
                    mind_flayer = x.Any(c => c.HeadQuarter.Name == x.Key && c.Invader.Id == 6) ? string.Join(" ", x.Select(c => c.Role.Name.ToUpper()[0]).Distinct()) : "",
                    beholder = x.Any(c => c.HeadQuarter.Name == x.Key && c.Invader.Id == 3) ? string.Join(" ", x.Select(c => c.Role.Name.ToUpper()[0]).Distinct()) : "",
                    hill_giant = x.Any(c => c.HeadQuarter.Name == x.Key && c.Invader.Id == 9) ? string.Join(" ", x.Select(c => c.Role.Name.ToUpper()[0]).Distinct()) : "",
                    lich = x.Any(c => c.HeadQuarter.Name == x.Key && c.Invader.Id == 5) ? string.Join(" ", x.Select(c => c.Role.Name.ToUpper()[0]).Distinct()) : "",
                    predators = x.Any(c => c.HeadQuarter.Name == x.Key && c.Invader.Id == 2) ? string.Join(" ", x.Select(c => c.Role.Name.ToUpper()[0]).Distinct()) : "",
                    red_dragon = x.Any(c => c.HeadQuarter.Name == x.Key && c.Invader.Id == 8) ? string.Join(" ", x.Select(c => c.Role.Name.ToUpper()[0]).Distinct()) : "",
                    treant = x.Any(c => c.HeadQuarter.Name == x.Key && c.Invader.Id == 10) ? string.Join(" ", x.Select(c => c.Role.Name.ToUpper()[0]).Distinct()) : "",
                    vampire = x.Any(c => c.HeadQuarter.Name == x.Key && c.Invader.Id == 7) ? string.Join(" ", x.Select(c => c.Role.Name.ToUpper()[0]).Distinct()) : "",
                    werewolf = x.Any(c => c.HeadQuarter.Name == x.Key && c.Invader.Id == 11) ? string.Join(" ", x.Select(c => c.Role.Name.ToUpper()[0]).Distinct()) : "",
                    yuan_ti = x.Any(c => c.HeadQuarter.Name == x.Key && c.Invader.Id == 12) ? string.Join(" ", x.Select(c => c.Role.Name.ToUpper()[0]).Distinct()) : "", 
                    devil = x.Any(c => c.HeadQuarter.Name == x.Key && c.Invader.Id == 4) ? string.Join(" ", x.Select(c => c.Role.Name.ToUpper()[0]).Distinct()) : "",
                }).ToList();
            return showTbl;
        }

        /// <summary>
        /// Get Joined table of HQ-Invaders-Role-Hero
        /// </summary>
        /// <returns></returns>
        public static List<HeadQuarterInvaderRoleDto> GetHeroesDetail()
        {
            return FetchData.HeadQuarterHeroInvaders
                   .Join(FetchData.HeadQuarters, h => h.HeadQuarterId, c => c.Id, (h, c) => new { headQuarterHero = h, headQuarter = c })
                   .Join(FetchData.Invaders, h => h.headQuarterHero.InvaderId, c => c.Id, (h, c) => new { h.headQuarterHero, h.headQuarter, invader = c })
                   .Join(FetchData.Roles, h => h.headQuarterHero.RoleId, c => c.Id, (h, c) => new { h.headQuarterHero, h.headQuarter, h.invader, role = c })
                   .Join(FetchData.Heroes, h => h.headQuarterHero.HeroId, c => c.Id, (h, c) => new { h.headQuarterHero, h.headQuarter, h.invader, h.role, hero = c })
                  .Select(x => new HeadQuarterInvaderRoleDto
                  {
                      HeadQuarter = x.headQuarter,
                      Invader = x.invader,
                      Role = x.role,
                      Hero = x.hero
                  }).ToList();
        }
    }
}
