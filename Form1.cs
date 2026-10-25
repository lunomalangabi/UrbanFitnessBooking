using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPracVANDAG
{
    public partial class UrbFitnessBooking : Form
    {
        public UrbFitnessBooking()
        {
            InitializeComponent();
        }
        public static string InputBox(string prompt, string title, string defaultValue)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = prompt;
            ib.FormCaption = title;
            ib.DefaultValue = defaultValue;
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }

        

        //declare constants

        const double PADPrice = 150;
        const double ZUMPrice = 100;
        const double GYMPrice = 120;
        const double DiscRate = 0.02;

        //declare global variables

        double dblAccAmntDue;
        int intNoInvCust;
        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //declare local variables 
            bool blnValidFormInput = true;
            string strSessType;
            int intHrsBooked;
            double dblAmntDue= 0;
            double dblDiscAmnt;
            double dblSessAmnt;
            int intTotalHrs = 0;
            int intInvSess= 0;
            double dblTotalAmntDue;

            blnValidFormInput = ValidateFormInput(blnValidFormInput);   //call the validate form input method

            if (blnValidFormInput)

            {
                strSessType = InputBox("Please enter a session type(ZZZ to finish)", "Session type", "").ToUpper(); //Get the session type- intialisation

                while (strSessType != "ZZZ")  //termination
                {
                    bool blnValidSessType = true;

                    blnValidSessType = ValidateSessionType(blnValidSessType, strSessType);  //Call the validate session type method

                    if (blnValidSessType)
                    {
                        intHrsBooked = Convert.ToInt32(InputBox("Please eneter the hours booked", "Hours booked", "")); //Get the hours booked- intialisation

                        dblSessAmnt = CalcSessAmnt(intHrsBooked, strSessType);


                        dblAmntDue += dblSessAmnt;

                        intTotalHrs += intHrsBooked;

                    }
                    else
                        intInvSess += 1;    //add 1 to the number of invalid sessions 

                    strSessType = InputBox("Please enter a session type(ZZZ to finish)", "Session type", "").ToUpper(); //alteration
                }

                dblDiscAmnt = CalcDiscAmnt(intTotalHrs, dblAmntDue); //call discount calculation method

                dblTotalAmntDue = dblAmntDue - dblDiscAmnt;

                dblAccAmntDue += dblTotalAmntDue;   //accumulate the amnount due for all the customers 

                DisplayOutputs(dblTotalAmntDue, intInvSess);

            }
            else
            {
                intNoInvCust += 1;      //add 1 to the number of invalid clients 
                lblNoInvClients.Text=intNoInvCust.ToString();
            }
                
            

        }

        private bool ValidateFormInput(bool blnValidFormInput)
        {
            if (txtClientPhoneNo.Text=="")
            {
                blnValidFormInput = false;
                MessageBox.Show("Invalid phone number", "ERROR!");
            }

            return blnValidFormInput;
        }

        private bool ValidateSessionType(bool blnValidSessType, string strSessType)
        {
            if (strSessType != "PAD" && strSessType != "ZUM" && strSessType != "GYM")
            {
                blnValidSessType= false;
                MessageBox.Show("Invalid session type", "ERROR!");
            }
            return blnValidSessType;
        }

        private double CalcSessAmnt (int intHrsBooked, string strSessType)
        {
            double dblSessType;
            if (strSessType == "PAD")
            {
                dblSessType = intHrsBooked * PADPrice;
            }
            else
                if (strSessType == "ZUM")
                {
                    dblSessType = intHrsBooked * ZUMPrice;
                }
                else
                    dblSessType = intHrsBooked * GYMPrice;

            return dblSessType;
        }

        private double CalcDiscAmnt (int intTotalHrsBooked, double dblAmntDue)
        {
            double dblDiscAmnt = 0;
            if (intTotalHrsBooked>5)
            {
                dblDiscAmnt = dblAmntDue * DiscRate;
            }

            return dblDiscAmnt;
        }

        private void DisplayOutputs(double dblTotalAmntDue, int intInvSess)
        {
            lblAccAmntDue.Text = dblAccAmntDue.ToString("C2");
            lblAmntDue.Text = dblTotalAmntDue.ToString("C2");
            lblNoInvSess.Text = intInvSess.ToString("N0");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtClientPhoneNo.Text = "";

            lblAccAmntDue.Text = "0.00";
            lblAmntDue.Text = "0.00";
            lblNoInvClients.Text = "0";
            lblNoInvSess.Text= "0";
            txtClientPhoneNo.Focus();
        }
    }
}
