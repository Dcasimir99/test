
namespace DanielCasimirGUIPractice
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.InfoGrabber = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBox3 = new System.Windows.Forms.CheckBox();
            this.cBox2 = new System.Windows.Forms.CheckBox();
            this.cBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rButton3 = new System.Windows.Forms.RadioButton();
            this.rButton2 = new System.Windows.Forms.RadioButton();
            this.rButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ABox = new System.Windows.Forms.TextBox();
            this.NBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.InfoGrabber.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InfoGrabber
            // 
            this.InfoGrabber.Controls.Add(this.pBox);
            this.InfoGrabber.Controls.Add(this.groupBox2);
            this.InfoGrabber.Controls.Add(this.groupBox1);
            this.InfoGrabber.Controls.Add(this.label4);
            this.InfoGrabber.Controls.Add(this.listBox1);
            this.InfoGrabber.Controls.Add(this.ABox);
            this.InfoGrabber.Controls.Add(this.NBox);
            this.InfoGrabber.Controls.Add(this.label3);
            this.InfoGrabber.Controls.Add(this.label2);
            this.InfoGrabber.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoGrabber.Location = new System.Drawing.Point(170, 82);
            this.InfoGrabber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InfoGrabber.Name = "InfoGrabber";
            this.InfoGrabber.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InfoGrabber.Size = new System.Drawing.Size(1186, 734);
            this.InfoGrabber.TabIndex = 1;
            this.InfoGrabber.TabStop = false;
            this.InfoGrabber.Text = "InfoGrabber";
            this.InfoGrabber.Enter += new System.EventHandler(this.InfoGrabber_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBox3);
            this.groupBox2.Controls.Add(this.cBox2);
            this.groupBox2.Controls.Add(this.cBox1);
            this.groupBox2.Location = new System.Drawing.Point(572, 298);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(300, 229);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Peferred Pet";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cBox3
            // 
            this.cBox3.AutoSize = true;
            this.cBox3.Location = new System.Drawing.Point(9, 168);
            this.cBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBox3.Name = "cBox3";
            this.cBox3.Size = new System.Drawing.Size(114, 43);
            this.cBox3.TabIndex = 2;
            this.cBox3.Text = "Frogs";
            this.cBox3.UseVisualStyleBackColor = true;
            this.cBox3.CheckedChanged += new System.EventHandler(this.cBox3_CheckedChanged);
            // 
            // cBox2
            // 
            this.cBox2.AutoSize = true;
            this.cBox2.Location = new System.Drawing.Point(10, 111);
            this.cBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBox2.Name = "cBox2";
            this.cBox2.Size = new System.Drawing.Size(100, 43);
            this.cBox2.TabIndex = 1;
            this.cBox2.Text = "Cats";
            this.cBox2.UseVisualStyleBackColor = true;
            this.cBox2.CheckedChanged += new System.EventHandler(this.cBox2_CheckedChanged);
            // 
            // cBox1
            // 
            this.cBox1.AutoSize = true;
            this.cBox1.Location = new System.Drawing.Point(10, 52);
            this.cBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBox1.Name = "cBox1";
            this.cBox1.Size = new System.Drawing.Size(108, 43);
            this.cBox1.TabIndex = 0;
            this.cBox1.Text = "Dogs";
            this.cBox1.UseVisualStyleBackColor = true;
            this.cBox1.CheckedChanged += new System.EventHandler(this.cBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rButton3);
            this.groupBox1.Controls.Add(this.rButton2);
            this.groupBox1.Controls.Add(this.rButton1);
            this.groupBox1.Location = new System.Drawing.Point(572, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(312, 238);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rButton3
            // 
            this.rButton3.AutoSize = true;
            this.rButton3.Location = new System.Drawing.Point(10, 169);
            this.rButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rButton3.Name = "rButton3";
            this.rButton3.Size = new System.Drawing.Size(119, 43);
            this.rButton3.TabIndex = 2;
            this.rButton3.TabStop = true;
            this.rButton3.Text = "Other";
            this.rButton3.UseVisualStyleBackColor = true;
            // 
            // rButton2
            // 
            this.rButton2.AutoSize = true;
            this.rButton2.Location = new System.Drawing.Point(10, 111);
            this.rButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rButton2.Name = "rButton2";
            this.rButton2.Size = new System.Drawing.Size(139, 43);
            this.rButton2.TabIndex = 1;
            this.rButton2.TabStop = true;
            this.rButton2.Text = "Female";
            this.rButton2.UseVisualStyleBackColor = true;
            this.rButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rButton1
            // 
            this.rButton1.AutoSize = true;
            this.rButton1.Location = new System.Drawing.Point(10, 52);
            this.rButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rButton1.Name = "rButton1";
            this.rButton1.Size = new System.Drawing.Size(110, 43);
            this.rButton1.TabIndex = 0;
            this.rButton1.TabStop = true;
            this.rButton1.Text = "Male";
            this.rButton1.UseVisualStyleBackColor = true;
            this.rButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "City";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Items.AddRange(new object[] {
            "Manhattan",
            "St. George",
            "Westmorellan",
            "Wamego",
            "Ogden",
            "Junction City",
            "Topeka"});
            this.listBox1.Location = new System.Drawing.Point(166, 282);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(346, 236);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ABox
            // 
            this.ABox.Location = new System.Drawing.Point(166, 183);
            this.ABox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ABox.Name = "ABox";
            this.ABox.Size = new System.Drawing.Size(346, 47);
            this.ABox.TabIndex = 3;
            // 
            // NBox
            // 
            this.NBox.Location = new System.Drawing.Point(166, 95);
            this.NBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NBox.Name = "NBox";
            this.NBox.Size = new System.Drawing.Size(346, 47);
            this.NBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(826, 907);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(141, 48);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1210, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(891, 63);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(258, 225);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox.TabIndex = 8;
            this.pBox.TabStop = false;
            this.pBox.Click += new System.EventHandler(this.pBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 1034);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.InfoGrabber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Main";
            this.InfoGrabber.ResumeLayout(false);
            this.InfoGrabber.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox InfoGrabber;
        private System.Windows.Forms.TextBox ABox;
        private System.Windows.Forms.TextBox NBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rButton1;
        private System.Windows.Forms.RadioButton rButton2;
        private System.Windows.Forms.RadioButton rButton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cBox3;
        private System.Windows.Forms.CheckBox cBox2;
        private System.Windows.Forms.CheckBox cBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.PictureBox pBox;
    }
}

