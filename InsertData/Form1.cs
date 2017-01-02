using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InsertData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strs=textBox1.Text.Split('\n');
            string sql = "INSERT INTO `dontstarve`.`categoryinfo`(`Name`) VALUES";
            foreach (string s in strs)
            {
                sql += "('" + s + "'),";
            }
            textBox2.Text = sql.Remove(sql.Length - 1, 1);
        }
    }
}
