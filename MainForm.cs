using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielCasimirGUIPractice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InfoGrabber_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //innitalize main variables
            String pPet = "";
            String text = "";
            String city = "";
            string bGender = "";

            //Logical statements for radio buttons on Gender
            if (rButton1.Checked)
            {
                bGender = bGender + " is a " + rButton1.Text + " ";
            }
            else if (rButton2.Checked)
            {
                bGender = bGender + " is a " + rButton2.Text + " ";
            }
            else
            {
                bGender = bGender + " is a person ";
            }


            //Logical statements for checkbox combinations
            if (!(cBox1.Checked) && !(cBox2.Checked) && !(cBox3.Checked))
            {
                pPet = pPet + "who does not love pets :(";
            }

            else if ((cBox1.Checked) && !(cBox2.Checked) && !(cBox3.Checked))
            {
                pPet = pPet + "who loves " + cBox1.Text;
            }
            else if (!(cBox1.Checked) && (cBox2.Checked) && !(cBox3.Checked))
            {
                pPet = pPet + "who loves " + cBox2.Text;
            }
            else if (!(cBox1.Checked) && !(cBox2.Checked) && (cBox3.Checked))
            {
                pPet = pPet + "who loves " + cBox3.Text;
            }
            else if ((cBox1.Checked) && (cBox2.Checked) && !(cBox3.Checked))
            {
                pPet = pPet + "who loves " + cBox1.Text + " and " + cBox2.Text;
            }
            else if ((cBox1.Checked) && !(cBox2.Checked) && (cBox3.Checked))
            {
                pPet = pPet + "who loves " + cBox1.Text + " and " + cBox3.Text;
            }
            else if (!(cBox1.Checked) && (cBox2.Checked) && (cBox3.Checked))
            {
                pPet = pPet + "who loves " + cBox2.Text + " and " + cBox3.Text;
            }
            else if ((cBox1.Checked) && (cBox2.Checked) && (cBox3.Checked))
            {
                pPet = pPet + "who loves " + cBox1.Text + " and " + cBox2.Text + " and " + cBox3.Text;
            }


            //Statement to get item from list box
            city = city + listBox1.GetItemText(listBox1.SelectedItem);

            if (NBox.Text == "" || ABox.Text == "")
            {
                MessageBox.Show("Please enter a name and address!");

            }
            else
            {


                //final text variable statment (puts everything together)
                text = NBox.Text + " of" + ABox.Text + ", " + city + "," + bGender + pPet;

                //Display function
                MessageBox.Show(text);
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void cBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox1.Checked)
            {
                this.pBox.Load("dog.jpg");
            }
            else
            {
                pBox.Image = null;
            }
        }

        private void cBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox2.Checked)
            {
                this.pBox.Load("cat.jpg");
            }
            else
            {
                pBox.Image = null;
            }
        }

        private void cBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox3.Checked)
            {
                this.pBox.Load("frog.jpg");
            }
            else
            {
                pBox.Image = null;
            }
        }

        private void pBox_Click(object sender, EventArgs e)
        {

        }
    }
}
