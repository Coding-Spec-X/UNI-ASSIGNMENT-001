using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Quallifier
{
    public partial class loanQualifier : Form
    {
        public loanQualifier()
        {
            InitializeComponent();
        }
        //NESTED CONDITONAL STATEMENTS
        private void checkButton_Click(object sender, EventArgs e)
        { 
            try
            {
                const decimal MINIMUM_SALARY = 40000m;
                const decimal MINIMUM_YEARS_ON_JOB = 2;

                //LOCAL VAROABLES
                decimal salary;
                int yearsOnJob;

                //GET THE SALARY AND YEARS ON JOB
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);  

                //DETERMINE WHETHER OR NOT THE USER QUALIFIES
                if(salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                    {
                        //THE USER QUALIFIES
                        decisionLabel.Text="Congratulations! You qualify for the loan";
                    }
                    else
                    {
                        //THE USER DOES NOT QUALIFY
                        decisionLabel.Text = "Sorry! "+"you do not qualify for the loan";
                    }
                }
                else
                {
                //THE USER DOES NOT QUALIFY
                decisionLabel.Text = "Minimum salary requirement " + "not met";
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //CLEAR TEXT BOXES
            salaryTextBox.Clear();
            yearsTextBox.Clear();
            decisionLabel.Text = "";

            //RESET THE FOCUS
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
