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
    public partial class Form2 : Form
    {
        DataTable dt = new DataTable();
        bool duplicate = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            duplicate = false ;
            for (int i=0;i<dt.Rows.Count;i++)
            {

                if(chkedit.Checked==true)
                {
                    if (txtemail.Text == dt.Rows[i]["Email"].ToString())
                    {

                        if (txtemail.Text != dt.Rows[i]["Name"].ToString() && txtemail.Text != dt.Rows[i]["Email"].ToString())
                        {
                            duplicate = true;
                            MessageBox.Show("Email already exist");
                            return;
                        }
                    }
                }
                else
                {
                    if (txtemail.Text == dt.Rows[i]["Email"].ToString())
                    {
                        duplicate = true;
                        MessageBox.Show("Email already exist");
                        return;
                    }
                }

               
            }
            if (duplicate !=true)
            {

                if (chkedit.Checked != true)
                {
                    dt.Rows.Add(txtname.Text, txtemail.Text);
                    gvCandidate.DataSource = dt;
                    MessageBox.Show("Saved Successfully");
                }
                else
                {
                    MessageBox.Show("Updated Successfully");
                }

                
            }


     

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            dt.Columns.Add("Name");
            dt.Columns.Add("Email");
            dt.Rows.Add("JD","JD@gmail.com");

            gvCandidate.DataSource = dt;
            
        }
    }
}
