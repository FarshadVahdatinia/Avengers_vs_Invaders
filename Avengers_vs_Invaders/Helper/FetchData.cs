using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using Core;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using Core.Enums;

namespace Avengers_vs_Invaders.Helper
{
    public static class FetchData
    {
        public static List<Hero> Heroes = new List<Hero>();
        public static List<Role> Roles = new List<Role>();
        public static List<Country> Countries = new List<Country>();
        public static List<HeadQuarter> HeadQuarters = new List<HeadQuarter>();
        public static List<Invader> Invaders = new List<Invader>();
        public static List<CountryHeadQuarterInvader> CountryHeadQuarterInvaders = new List<CountryHeadQuarterInvader>();
        public static List<HeadQuarterHeroInvader> HeadQuarterHeroInvaders = new List<HeadQuarterHeroInvader>();

        public static void Initial()
        {
            FixData();
            ReadExcel();
        }

        private static void FixData()
        {
            Roles.Add(new Role() { Id = (int)RollEnum.attack_role, Name = RollEnum.attack_role.ToString() });
            Roles.Add(new Role() { Id = (int)RollEnum.defense_role, Name = RollEnum.defense_role.ToString() });
            Roles.Add(new Role() { Id = (int)RollEnum.healing_role, Name = RollEnum.healing_role.ToString() });

            Invaders.Add(new Invader() { Id = 1, Name = "aliens" });
            Invaders.Add(new Invader() { Id = 2, Name = "predators" });
            Invaders.Add(new Invader() { Id = 3, GroupName = "D&D Monsters", Name = "d&d_beholder" });
            Invaders.Add(new Invader() { Id = 4, GroupName = "D&D Monsters", Name = "d&d_devil" });
            Invaders.Add(new Invader() { Id = 5, GroupName = "D&D Monsters", Name = "d&d_lich" });
            Invaders.Add(new Invader() { Id = 6, GroupName = "D&D Monsters", Name = "d&d_mind_flayer" });
            Invaders.Add(new Invader() { Id = 7, GroupName = "D&D Monsters", Name = "d&d_vampire" });
            Invaders.Add(new Invader() { Id = 8, GroupName = "D&D Monsters", Name = "d&d_red_dragon" });
            Invaders.Add(new Invader() { Id = 9, GroupName = "D&D Monsters", Name = "d&d_hill_giant" });
            Invaders.Add(new Invader() { Id = 10, GroupName = "D&D Monsters", Name = "d&d_treant" });
            Invaders.Add(new Invader() { Id = 11, GroupName = "D&D Monsters", Name = "d&d_werewolf" });
            Invaders.Add(new Invader() { Id = 12, GroupName = "D&D Monsters", Name = "d&d_yuan-ti" });

        }

        private static void ReadExcel()
        {
            var currentPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            string filePath = System.IO.Path.Combine(currentPath, "Avengers_vs_Invaders_Challenge.xlsx");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(new System.IO.FileInfo(filePath)))
            {
                ExcelWorksheet sheet1 = package.Workbook.Worksheets[0]; // Assuming sheet index starts from 1
                ExcelWorksheet sheet2 = package.Workbook.Worksheets[1];

                ReadDataFromSheet1(sheet1);
                ReadDataFromSheet2(sheet2);
            }
        }
        private static void ReadDataFromSheet1(ExcelWorksheet sheet)
        {
            for (int row = sheet.Dimension.Start.Row+1; row <= sheet.Dimension.End.Row; row++)
            {
                var countryName = (string)sheet.Cells[row, 1].Value;
                var countryCode = (string)sheet.Cells[row, 2].Value;
                var alien = (string)sheet.Cells[row, 3].Value;
                var predator = (string)sheet.Cells[row, 4].Value;
                var monster = (string)sheet.Cells[row, 5].Value;

                if(!Countries.Any(x=>x.Name == countryName))
                    Countries.Add(new Country() { Id = SetId<Country>(Countries),Name= countryName,Code=countryCode });

                if (!HeadQuarters.Any(x => x.Name == alien))
                    HeadQuarters.Add(new HeadQuarter() { Id = SetId<HeadQuarter>(HeadQuarters), Name = alien});

                if (!HeadQuarters.Any(x => x.Name == predator))
                    HeadQuarters.Add(new HeadQuarter() { Id = SetId<HeadQuarter>(HeadQuarters), Name = predator });

                if (!HeadQuarters.Any(x => x.Name == monster))
                    HeadQuarters.Add(new HeadQuarter() { Id = SetId<HeadQuarter>(HeadQuarters), Name = monster });


                CountryHeadQuarterInvaders.Add(new CountryHeadQuarterInvader()
                {
                    CountryId = Countries.First(x=>x.Name == countryName).Id,
                    HeadQuarterId = HeadQuarters.First(x=>x.Name == alien).Id,
                    InvaderId = 1
                });

                CountryHeadQuarterInvaders.Add(new CountryHeadQuarterInvader()
                {
                    CountryId = Countries.First(x => x.Name == countryName).Id,
                    HeadQuarterId = HeadQuarters.First(x => x.Name == predator).Id,
                    InvaderId = 2
                });

                CountryHeadQuarterInvaders.Add(new CountryHeadQuarterInvader()
                {
                    CountryId = Countries.First(x => x.Name == countryName).Id,
                    HeadQuarterId = HeadQuarters.First(x => x.Name == monster).Id,
                    InvaderId = 3
                });
            }
        }

        private static void ReadDataFromSheet2(ExcelWorksheet sheet)
        {
            string column=string.Empty;
            int headQuarterId = 0;
            for (int row = sheet.Dimension.Start.Row; row <= sheet.Dimension.End.Row; row++)
            {
                column = (string)sheet.Cells[row, 1].Value;
                if (string.IsNullOrEmpty(column))
                    continue;

                if (!Invaders.Any(x => x.Name == column))
                {
                    headQuarterId = HeadQuarters.First(x => x.Name == column).Id;
                    continue;
                }

                var attack = (string)sheet.Cells[row, 2].Value;
                var defense = (string)sheet.Cells[row, 3].Value;
                var healing = (string)sheet.Cells[row, 4].Value;

                if (!string.IsNullOrEmpty(attack) && !Heroes.Any(x => x.Name == attack))
                    Heroes.Add(new Hero() { Id = SetId<Hero>(Heroes), Name = attack });

                if (!string.IsNullOrEmpty(defense) && !Heroes.Any(x => x.Name == defense))
                    Heroes.Add(new Hero() { Id = SetId<Hero>(Heroes), Name = defense });

                if (!string.IsNullOrEmpty(healing) && !Heroes.Any(x => x.Name == healing))
                    Heroes.Add(new Hero() { Id = SetId<Hero>(Heroes), Name = healing });

                if (!string.IsNullOrEmpty(attack))
                    HeadQuarterHeroInvaders.Add(new HeadQuarterHeroInvader()
                {
                    InvaderId = Invaders.First(x => x.Name == column).Id,
                    HeadQuarterId = headQuarterId,
                    HeroId = Heroes.First(x => x.Name == attack).Id,
                    RoleId = 1
                });

                if (!string.IsNullOrEmpty(defense))
                    HeadQuarterHeroInvaders.Add(new HeadQuarterHeroInvader()
                {
                    InvaderId = Invaders.First(x => x.Name == column).Id,
                    HeadQuarterId = headQuarterId,
                    HeroId = Heroes.First(x => x.Name == defense).Id,
                    RoleId = 2
                });

                if (!string.IsNullOrEmpty(healing))
                HeadQuarterHeroInvaders.Add(new HeadQuarterHeroInvader()
                {
                    InvaderId = Invaders.First(x => x.Name == column).Id,
                    HeadQuarterId = headQuarterId,
                    HeroId = Heroes.First(x => x.Name == healing).Id,
                    RoleId = 3
                });


            }
        }

        private static int SetId<T>(List<T> list) where T : BaseEntity
        {
            var max = list.Any() ? list.Max(x => x.Id) : 0;

            return max+1;
        }
    }
}
