using Avengers_vs_Invaders.Helper;
using Core.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
            FillData();
            GetCountries();
            GetRoles();
            GetInvaders();
        }

        private void FillData()
        {
            var showTbl = DataTablesHelper.GetLookupTblData();
            if (!string.IsNullOrEmpty(countriesComboBox.SelectedItem?.ToString()))
                showTbl = showTbl.Where(x => x.Country == countriesComboBox.SelectedItem?.ToString()).ToList();
            if (!string.IsNullOrEmpty(roleComboBox.SelectedItem?.ToString()))
                showTbl = showTbl.Where(x => x.RoleSpecific == roleComboBox.SelectedItem?.ToString()).ToList();
            if (!string.IsNullOrEmpty(invaderComboBox.SelectedItem?.ToString()))
                showTbl = showTbl.Where(x => x.InvaderSpecies == invaderComboBox.SelectedItem?.ToString()).ToList();
            if (!string.IsNullOrEmpty(emailTextBox.Text?.ToString()))
                showTbl = showTbl.Where(x => x.AvengerEmail.ToLower().Contains(emailTextBox.Text.ToString().ToLower())).ToList();
            dataGridView1.DataSource = showTbl;
        }

        private void GetCountries()
        {
            var counrties = FetchData.Countries;
            string[] the_array = new string[counrties.Count + 1];
            for (var i = 1; i < counrties.Count + 1; ++i)
                the_array[i] = counrties[i - 1].Code.ToString();
            the_array[0] = "";
            countriesComboBox.Items.AddRange(the_array);
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
        private void GetInvaders()
        {
            var invaders = FetchData.Invaders.DistinctBy(x=>x.GroupName).ToList();
            string[] the_array = new string[invaders.Count + 1];
            for (var i = 1; i < invaders.Count + 1; ++i)
                the_array[i] = invaders[i - 1].GroupName.ToString();
            the_array[0] = "";
            invaderComboBox.Items.AddRange(the_array);
        }
        private void countriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void invaderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void emaiTextBox1_TextChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            countriesComboBox.SelectedIndex = 0;
            roleComboBox.SelectedIndex = 0;
            invaderComboBox.SelectedIndex = 0;
            emailTextBox.Text = "";
            FillData();
        }
    }
}
