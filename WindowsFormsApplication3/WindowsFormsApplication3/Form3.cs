using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
        private void Form3_Load(object sender, EventArgs e)
        {

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Check";
            dgcheck.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            checkBoxColumn.Name = "checkBoxColumn";
            dgcheck.Columns.Insert(0, checkBoxColumn);
            dgcheck.Rows.Add(false);
            dgcheck.AllowUserToAddRows = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            if (cbcheck.Checked)
           {
               dgcheck.Rows[0].Cells[0].Value = true;
           }
            else
            {
                dgcheck.Rows[0].Cells[0].Value = false;
            }
        }


        private void dgcheck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


    }
}

