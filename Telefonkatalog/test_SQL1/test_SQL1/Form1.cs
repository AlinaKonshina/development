using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace test_SQL1
{
    public partial class Form1 : Form
    {
        WorkDB WDB=new WorkDB();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                //textBox1.Text.Co
                DataTable dt = WDB.Execute(textBox1.Text);
                dataGridView1.DataSource = dt;

                toolStripStatusLabel1.Text = string.Format("Количество строк: {0}",dt.Rows.Count);
            }
            finally { Cursor = Cursors.Default; }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
