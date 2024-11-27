
using System;
using System.Drawing;
using System.Windows.Forms;
using Attendance_Log;
using MySql.Data.MySqlClient;
using Staff_Clearance_levels;



namespace Home

{ 
    public partial class Form1 : Form
    {
       public Form1()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.X,
                          Screen.PrimaryScreen.Bounds.Y);
            this.TopMost = true;
            this.StartPosition = FormStartPosition.Manual;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            {
                bool ISopen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "members")
                    {
                        ISopen = true;
                        f.BringToFront();
                        break;
                    }
                }
                if (ISopen == false)
                {
                    members f1 = new members();
                    {
                        f1.Location = new Point(Right);
                        f1.TopMost = true;
                        f1.StartPosition = FormStartPosition.Manual;
                    }

                    f1.Show();
                }
                
            }
        }


        private void button14_Click(object sender, EventArgs e)
        {
            {
                bool F2 = false;
                foreach (Form f2 in Application.OpenForms)
                {
                    if (f2.Name == "attendanceLog")
                    {
                        F2 = true;
                        f2.BringToFront();
                        break;
                    }
                }
                if (F2 == false)
                {
                    attendanceLog f2 = new attendanceLog();
                    {
                        f2.Location = new Point(Right);
                        f2.TopMost = true;
                        f2.StartPosition = FormStartPosition.Manual;
                    }

                    f2.Show();
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            TopLevel = true;
            
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=tc;uid=root;pwd=\"\";";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "Form2")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                Form2 f2 = new Form2();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "MembersAddresses")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                MembersAddresses f2 = new MembersAddresses();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void label2_Click(object sender, EventArgs e)
        {
            TopLevel = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            TopLevel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TopLevel = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "Events")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                Events f2 = new Events();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "Bookings")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                Bookings f2 = new Bookings();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "Engagements")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                Engagements f2 = new Engagements();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "Inq")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                Inq f2 = new Inq();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "Tags")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                Tags f2 = new Tags();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "Log")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                Log f2 = new Log();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "Pay")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                Pay f2 = new Pay();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "user")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                User f2 = new User();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "attendanceLog")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                Inqty f2 = new Inqty();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "Wrk")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                Wrk f2 = new Wrk();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "Staff")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                Staff f2 = new Staff();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "STatt")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                STatt f2 = new STatt();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "STadd")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                STadd f2 = new STadd();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool F2 = false;
            foreach (Form f2 in Application.OpenForms)
            {
                if (f2.Name == "SCL")
                {
                    F2 = true;
                    f2.BringToFront();
                    break;
                }
            }
            if (F2 == false)
            {
                SCL f2 = new SCL();
                {
                    f2.Location = new Point(Right);
                    f2.TopMost = true;
                    f2.StartPosition = FormStartPosition.Manual;
                }

                f2.Show();
            }
        }
    }
}
