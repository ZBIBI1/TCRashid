
using Attendance_Log;
using MySql.Data.MySqlClient;
using Staff_Clearance_levels;
using System;
using System.Drawing;
using System.Windows.Forms;



namespace Members41

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
                        f1.Location = new Point(Screen.PrimaryScreen.Bounds.X,
                    Screen.PrimaryScreen.Bounds.Y);
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


        }

        private void button20_Click(object sender, EventArgs e)
        {

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
    }
}
