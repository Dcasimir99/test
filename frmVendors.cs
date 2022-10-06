using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormApp2Redo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Create Excel Objects
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;

        //CREATE A FEW VARIABLE NAMES

        string sname = "c:\\Users\\Daniel Casimir\\Desktop\\MIS 555 Programs\\SquitchVendors.xlsx";
        int iRow, iCol = 1;


        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSubmitVendors_Click(object sender, EventArgs e)
        {
            // Ensure something is in each field
            if (txtBusinessName.Text == "")
            {
                txtBusinessName.Text = "n/a";
            }
            if (txtContact.Text == "")
            {
                txtContact.Text = "n/a";
            }
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "n/a";
            }
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "n/a";
            }
            if (txtSpecialty.Text == "")
            {
                txtSpecialty.Text = "n/a";
            }
            if (txtComments.Text == "")
            {
                txtComments.Text = "n/a";
            }

            // OPEN THE EXCEL FILE FOR COMMENTS AND CHECK FOR ERRORS.         
            xlApp = new Excel.Application();
            // ERROR TRAP FOR PROBLEMS WITH FILE
            try
            {
                // OPEN THE EXCEL FILE AND GO TO SHEET1
                xlWorkBook = xlApp.Workbooks.Open(sname);
                xlWorkSheet = xlWorkBook.Worksheets["Sheet1"];        // NAME OF THE SHEET.
                // FIND THE FIRST EMPTY ROW
                for (iRow = 2; iRow <= xlWorkSheet.Rows.Count; iRow++)
                // START FROM THE SECOND ROW AND LOOK FOR A BLANK LINE.
                {


                    if (xlWorkSheet.Cells[iRow, 1].value == null)
                    {
                        // IF THE ROW IS BLANK THEN INSERT THE FORM DETAILS 
                        {
                            xlWorkSheet.Cells[iRow, iCol].value = txtBusinessName.Text;         // INSERT FIRST NAME IN CELL 1.
                            xlWorkSheet.Cells[iRow, iCol + 1].value = txtContact.Text;    //  INSERT LAST NAME IN CELL 2.
                            xlWorkSheet.Cells[iRow, iCol + 2].value = txtPhone.Text;  //  INSERT NICKNAME IN CELL 3.
                            xlWorkSheet.Cells[iRow, iCol + 3].value = txtEmail.Text;  //  INSERT TAG 1 IN CELL 4.
                            xlWorkSheet.Cells[iRow, iCol + 4].value = txtSpecialty.Text;  //  INSERT TAG 2 IN CELL 5.
                            xlWorkSheet.Cells[iRow, iCol + 5].value = txtComments.Text;  //  INSERT TAG 3 IN CELL 5.
                            break;          // BREAK, DONE AND LEAVE THE LOOP.
                        }
                    }
                }
                // DONE SO RELEASE THE RESOURCE
                xlWorkBook.Close();
                xlApp.Quit();

                // CLEAN UP.
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
                // MESSAGE THAT ITEM WAS SAVED
                MessageBox.Show("Complete. Thank You");
                txtBusinessName.Text = "";
                txtContact.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                txtSpecialty.Text = "";
                txtComments.Text = "";
            }
            // MESSAGE FOR ANY ERRORS THAT WERE CAUGHT
            catch (Exception ex)
            {
                MessageBox.Show("Excel file Not Found or another problem exists. Please let Squitcher know something is wrong on her computer. " + ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowsFormApp2Redo.FrmDisplay form = new WindowsFormApp2Redo.FrmDisplay();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox2.Load("c:\\Users\\Daniel Casimir\\Desktop\\MIS 555 Programs\\Vendors.png");
            this.pictureBox1.Load("c:\\Users\\Daniel Casimir\\Desktop\\MIS 555 Programs\\Headshot.png");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
