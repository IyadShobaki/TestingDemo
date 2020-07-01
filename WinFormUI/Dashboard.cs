using DemoLibrary;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        List<PersonModel> people;
        public Dashboard()
        {
            InitializeComponent();

            RebindDropdown();
        }

        private void RebindDropdown()
        {
            people = DataAccess.GetAllPeople();
            userDropdown.DataSource = null;
            userDropdown.DataSource = people;
            userDropdown.DisplayMember = "FullName";
        }
        private void addPersonButton_Click(object sender, EventArgs e)
        {
            DataAccess.AddNewPerson(new PersonModel { FirstName = firstNameText.Text, LastName = lastNameText.Text });

            firstNameText.Text = "";
            lastNameText.Text = "";

            RebindDropdown();
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            resultText.Text = Calculator.Add((double)firstNumberValue.Value,
                (double)secondNumberValue.Value).ToString();
            firstNumberValue.Value = 0;
            secondNumberValue.Value = 0;
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            resultText.Text = Calculator.Subtract((double)firstNumberValue.Value,
               (double)secondNumberValue.Value).ToString();
            firstNumberValue.Value = 0;
            secondNumberValue.Value = 0;
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            resultText.Text = Calculator.Multiply((double)firstNumberValue.Value,
               (double)secondNumberValue.Value).ToString();
            firstNumberValue.Value = 0;
            secondNumberValue.Value = 0;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            resultText.Text = Calculator.Divide((double)firstNumberValue.Value,
               (double)secondNumberValue.Value).ToString();
            firstNumberValue.Value = 0;
            secondNumberValue.Value = 0;
        }
    }
}
