using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace THA_W8_Cevin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form2 rf2 { get; set; }
        public Form3 rf3 { get; set; }

        bool cek1 = false;
        bool cek2 = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cek1 == true)
            {
                rf3.Hide();
                cek1 = false;
                Form2 f2 = new Form2();
                f2.MdiParent = this;
                f2.Show();
                this.rf2 = f2;
                rf2.rf1 = this;
            }
            else
            {
                cek2 = true;
                Form2 f2 = new Form2();
                f2.MdiParent = this;
                f2.Show();
                this.rf2 = f2;
                rf2.rf1 = this;
            }
        }

        private void showMatchDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cek2 == true)
            {
                rf2.Hide(); 
                cek1 = true;
                Form3 f3 = new Form3();
                f3.MdiParent = this;
                f3.Show();
                this.rf3 = f3;
                rf3.rf1 = this;
            }
            else
            {
                cek1 = true;
                Form3 f3 = new Form3();
                f3.MdiParent = this;
                f3.Show();
                this.rf3 = f3;
                rf3.rf1 = this;
            }
        }
    }
}
