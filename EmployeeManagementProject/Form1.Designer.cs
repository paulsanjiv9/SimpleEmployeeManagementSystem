namespace EmployeeManagementProject
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.combo_department = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doj = new System.Windows.Forms.DateTimePicker();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_addmanagers = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_mname = new System.Windows.Forms.TextBox();
            this.txt_mid = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.combo_department2 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.combo_dept = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 593);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1014, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.combo_department);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.doj);
            this.panel1.Controls.Add(this.dob);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_address);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_salary);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.txt_number);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 550);
            this.panel1.TabIndex = 0;
            // 
            // combo_department
            // 
            this.combo_department.FormattingEnabled = true;
            this.combo_department.Items.AddRange(new object[] {
            "Computer",
            "Mechanical",
            "Administration",
            "Please Select"});
            this.combo_department.Location = new System.Drawing.Point(239, 183);
            this.combo_department.Name = "combo_department";
            this.combo_department.Size = new System.Drawing.Size(200, 21);
            this.combo_department.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 209);
            this.dataGridView1.TabIndex = 51;
            // 
            // doj
            // 
            this.doj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.doj.Location = new System.Drawing.Point(239, 124);
            this.doj.Name = "doj";
            this.doj.Size = new System.Drawing.Size(200, 20);
            this.doj.TabIndex = 50;
            // 
            // dob
            // 
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.Location = new System.Drawing.Point(239, 150);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 20);
            this.dob.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Date of Birth";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(239, 220);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(200, 20);
            this.txt_address.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Date of Join";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Employee Number";
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(239, 91);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(200, 20);
            this.txt_salary.TabIndex = 40;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(239, 65);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(200, 20);
            this.txt_name.TabIndex = 39;
            // 
            // txt_number
            // 
            this.txt_number.Enabled = false;
            this.txt_number.Location = new System.Drawing.Point(239, 39);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(200, 20);
            this.txt_number.TabIndex = 38;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(239, 273);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 28);
            this.btn_submit.TabIndex = 37;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1014, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Employees/Managers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.combo_dept);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(12, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 451);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Department ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1014, 567);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Managers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.combo_department2);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btn_addmanagers);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_mname);
            this.panel3.Controls.Add(this.txt_mid);
            this.panel3.Location = new System.Drawing.Point(13, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 457);
            this.panel3.TabIndex = 0;
            // 
            // btn_addmanagers
            // 
            this.btn_addmanagers.Location = new System.Drawing.Point(75, 148);
            this.btn_addmanagers.Name = "btn_addmanagers";
            this.btn_addmanagers.Size = new System.Drawing.Size(108, 30);
            this.btn_addmanagers.TabIndex = 4;
            this.btn_addmanagers.Text = "Submit";
            this.btn_addmanagers.UseVisualStyleBackColor = true;
            this.btn_addmanagers.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Manager Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Manager ID";
            // 
            // txt_mname
            // 
            this.txt_mname.Location = new System.Drawing.Point(150, 78);
            this.txt_mname.Name = "txt_mname";
            this.txt_mname.Size = new System.Drawing.Size(221, 20);
            this.txt_mname.TabIndex = 1;
            // 
            // txt_mid
            // 
            this.txt_mid.Enabled = false;
            this.txt_mid.Location = new System.Drawing.Point(150, 33);
            this.txt_mid.Name = "txt_mid";
            this.txt_mid.Size = new System.Drawing.Size(221, 20);
            this.txt_mid.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Department";
            // 
            // combo_department2
            // 
            this.combo_department2.FormattingEnabled = true;
            this.combo_department2.Items.AddRange(new object[] {
            "Computer",
            "Mechanical",
            "Administration",
            "Please Select"});
            this.combo_department2.Location = new System.Drawing.Point(150, 117);
            this.combo_department2.Name = "combo_department2";
            this.combo_department2.Size = new System.Drawing.Size(200, 21);
            this.combo_department2.TabIndex = 53;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(33, 111);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(746, 231);
            this.dataGridView2.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "View Employees Under Manager By Department";
            // 
            // combo_dept
            // 
            this.combo_dept.FormattingEnabled = true;
            this.combo_dept.Items.AddRange(new object[] {
            "Computer",
            "Mechanical",
            "Administration",
            "Please Select"});
            this.combo_dept.Location = new System.Drawing.Point(155, 39);
            this.combo_dept.Name = "combo_dept";
            this.combo_dept.Size = new System.Drawing.Size(200, 21);
            this.combo_dept.TabIndex = 54;
            this.combo_dept.SelectedIndexChanged += new System.EventHandler(this.combo_dept_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 593);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combo_department;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker doj;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_addmanagers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_mname;
        private System.Windows.Forms.TextBox txt_mid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox combo_department2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox combo_dept;
    }
}

