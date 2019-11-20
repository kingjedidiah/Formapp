using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication3
{
    public partial class frnemployee : Form
    {
        int indexRow;
        bool executerow = true;
        bool num = false;
        bool check = true;
        bool one = true;
        string mode = "NEW";

        public frnemployee()
        {
            InitializeComponent();
        }

        private void txtage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            int currentAge = DateTime.Today.Year - DateTimePicker.Value.Year;
            txtage.Text = currentAge.ToString();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 6)
            {
               
                DialogResult result = MessageBox.Show("Do you want to delete from this row??", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    table.Rows.Add(dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString(),
                        dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString(), dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString());
                    if (Convert.ToBoolean(dataGridView2.Rows[e.RowIndex].Cells[0].Value) == true)
                    {
                        //cbcheck.Checked = true;
                        dataGridView1.Rows[e.RowIndex].Cells[0].Value = true;
                    }
                    else
                    {
                        // cbcheck.Checked = false;
                        dataGridView1.Rows[e.RowIndex].Cells[0].Value = false;
                    }
                    dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                }
                else if (result == DialogResult.No)
                {

                }
            }
       
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                mode = "EDIT";
                txtname.ReadOnly = true;
                lblmode.Text = "EDIT";
                indexRow = e.RowIndex;
                executerow = false;
                //MessageBox.Show(executerow.ToString());
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtage.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbogender.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                //string status = "";
                //status = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
              /*  if (status == "0")
                {
                    cbcheck.Checked = false;
                }
                else
                {
                    cbcheck.Checked = true;
                } */
                if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[0].Value) == true)
                {
                    cbcheck.Checked = true;
                    //dataGridView1.Rows[e.RowIndex].Cells[0].Value = true;
                }
                else
                {
                    cbcheck.Checked = false;
                   // dataGridView1.Rows[e.RowIndex].Cells[0].Value = false;
                }

            }
            else if (e.ColumnIndex == 7)
            {
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Do you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
                else if (result == DialogResult.No)
                {

                }
            }

            else if (e.ColumnIndex == 8)
            {
                 DialogResult result = MessageBox.Show("Do you want to move the data to new table?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                  if (result == DialogResult.Yes)
                 {
                     
                     table2.Rows.Add(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), 
                         dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                         dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                     if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[0].Value) == true)
                     {
                         //cbcheck.Checked = true;
                         dataGridView2.Rows[e.RowIndex].Cells[0].Value = true;
                     }
                     else
                     {
                         // cbcheck.Checked = false;
                         dataGridView2.Rows[e.RowIndex].Cells[0].Value = false;
                     }
                         dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                         
                 }
                 else if (result == DialogResult.No)
                 {

                 }
              
            }
            else if (e.ColumnIndex == 9)
            {
                //DialogResult result = MessageBox.Show("Do you want to move the data to new table?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                MessageBox.Show("Content will be edited");
                    table3.Rows.Add(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                        dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                    if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[0].Value) == true)
                    {
                        //cbcheck.Checked = true;
                        dataGridView3.Rows[e.RowIndex].Cells[0].Value = true;
                    }
                    else
                    {
                        // cbcheck.Checked = false;
                        dataGridView3.Rows[e.RowIndex].Cells[0].Value = false;
                    }

                    //dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

       
        int LastSelectedRowIndex = 0;
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                {
                    string searchValue = textBox1.Text;
                    string searchValue2 = textBox2.Text;
                    string Name = txtname.Text;
                    // dataGridView1.SelectionMode = DataGridViewSelectionMode.currentRowSelect;

                    foreach (DataGridViewRow i in dataGridView3.Rows)
                    {
                        string a = i.Cells[4].Value.ToString();
                        if (i.Cells[4].Value.ToString().Equals(searchValue))
                        {

                            if (i.Cells[4].Value.ToString().Equals(searchValue) && i.Cells[1].Value.ToString().Equals(Name))
                            {

                            }
                            else
                            {
                                MessageBox.Show("Email id already exist");
                                dataGridView3.Rows[e.RowIndex].Cells[4].Value = "";

                                return;
                            }

                            if (i.Cells[5].Value.ToString().Equals(searchValue))
                            {

                                if (i.Cells[5].Value.ToString().Equals(searchValue) && i.Cells[1].Value.ToString().Equals(Name))
                                {

                                }
                                else
                                {

                                    MessageBox.Show("Mobile number already exist");
                                    dataGridView3.Rows[e.RowIndex].Cells[5].Value = "";

                                    return;
                                }
                            }                                               
                        }
                    }
                    if (Convert.ToBoolean(dataGridView3.Rows[e.RowIndex].Cells[0].Value) == true)
                    {
                        //cbcheck.Checked = true;
                        dataGridView1.Rows[e.RowIndex].Cells[0].Value = true;
                    }
                    else
                    {
                        // cbcheck.Checked = false;
                        dataGridView1.Rows[e.RowIndex].Cells[0].Value = false;
                    }
                    dataGridView1.Rows[LastSelectedRowIndex].Cells[1].Value = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
                    dataGridView1.Rows[LastSelectedRowIndex].Cells[2].Value = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
                    dataGridView1.Rows[LastSelectedRowIndex].Cells[3].Value = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
                    dataGridView1.Rows[LastSelectedRowIndex].Cells[4].Value = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
                    dataGridView1.Rows[LastSelectedRowIndex].Cells[5].Value = dataGridView3.Rows[e.RowIndex].Cells[5].Value.ToString();
                    dataGridView3.Rows.RemoveAt(dataGridView3.CurrentRow.Index);
                }
            }
        }
        
        void clear()
        {
            txtname.Clear();
            txtage.Clear();
            cbogender.Text = "";
            cbcheck.Checked = false;
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = "";
            label4.Text = "";
            mode = "NEW";
            lblmode.Text = "NEW";
            txtname.ReadOnly = false;
        }
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        DataTable table3 = new DataTable();
        
        private void Form1_Load(object sender, EventArgs e)
        {

            table.Columns.Add("Name", typeof(String));
            table.Columns.Add("Age", typeof(Int32));
            table.Columns.Add("Gender", typeof(String));
            //table.Columns.Add("status", typeof(String));

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Status";
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            checkBoxColumn.Width = 60;
            checkBoxColumn.Name = "checkBoxColumn";
            dataGridView1.Columns.Insert(0, checkBoxColumn);
            dataGridView1.Rows.Add(false);
            dataGridView1.AllowUserToAddRows = false;

            table.Columns.Add("Email", typeof(String));
            table.Columns.Add("Ph.No.", typeof(String));

            table2.Columns.Add("Name", typeof(String));
            table2.Columns.Add("Age", typeof(Int32));
            table2.Columns.Add("Gender", typeof(String));
            //table2.Columns.Add("status", typeof(String));
            DataGridViewCheckBoxColumn checkBoxColumn1 = new DataGridViewCheckBoxColumn();
            checkBoxColumn1.HeaderText = "Status";
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            checkBoxColumn1.Width = 60;
            checkBoxColumn1.Name = "Status";
            dataGridView2.Columns.Insert(0, checkBoxColumn1);
            dataGridView2.Rows.Add(false);
            dataGridView2.AllowUserToAddRows = false;
            table2.Columns.Add("Email", typeof(String));
            table2.Columns.Add("Ph.No.", typeof(String));

            table3.Columns.Add("Name", typeof(String));
            table3.Columns.Add("Age", typeof(Int32));
            table3.Columns.Add("Gender", typeof(String));
            //table3.Columns.Add("status", typeof(String));
            DataGridViewCheckBoxColumn checkBoxColumn2 = new DataGridViewCheckBoxColumn();
            checkBoxColumn2.HeaderText = "Status"; 
            checkBoxColumn2.Width = 60;
            checkBoxColumn2.Name = "Status";
            dataGridView3.Columns.Insert(0, checkBoxColumn2);
            dataGridView3.Rows.Add(false);
            dataGridView3.AllowUserToAddRows = false;
            table3.Columns.Add("Email", typeof(String));
            table3.Columns.Add("Ph.No.", typeof(String));

            dataGridView1.DataSource = table;
            dataGridView2.DataSource = table2;
            dataGridView3.DataSource = table3;

            DataGridViewButtonColumn editbutton = new DataGridViewButtonColumn();

            editbutton.FlatStyle = FlatStyle.Popup;

            editbutton.HeaderText = "Edit";
            editbutton.Name = "Edit";
            editbutton.UseColumnTextForButtonValue = true;
            editbutton.Text = "Edit";

            editbutton.Width = 60;
            if (dataGridView1.Columns.Contains(editbutton.Name = "Edit"))
            {

            }
            else
            {
                dataGridView1.Columns.Add(editbutton);
            }

            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();

            deletebutton.FlatStyle = FlatStyle.Popup;

            deletebutton.HeaderText = "Delete";
            deletebutton.Name = "Delete";
            deletebutton.UseColumnTextForButtonValue = true;
            deletebutton.Text = "Delete";

            deletebutton.Width = 60;
            if (dataGridView1.Columns.Contains(deletebutton.Name = "Delete"))
            {

            }
            else
            {
                dataGridView1.Columns.Add(deletebutton);
            }
            DataGridViewButtonColumn movebutton = new DataGridViewButtonColumn();

            movebutton.FlatStyle = FlatStyle.Popup;

            movebutton.HeaderText = "Move";
            movebutton.Name = "Move";
            movebutton.UseColumnTextForButtonValue = true;
            movebutton.Text = "Move";

            deletebutton.Width = 60;
           
            if (dataGridView1.Columns.Contains(movebutton.Name = "Move"))
            {

            }
            else
            {
                dataGridView1.Columns.Add(movebutton);
            }
            
            DataGridViewButtonColumn delete_button = new DataGridViewButtonColumn();

            delete_button.FlatStyle = FlatStyle.Popup;

            delete_button.HeaderText = "Delete";
            delete_button.Name = "Delete";
            delete_button.UseColumnTextForButtonValue = true;
            delete_button.Text = "Delete";

            delete_button.Width = 60;
            if (dataGridView2.Columns.Contains(delete_button.Name = "Delete"))
            {

            }
            else
            {
                dataGridView2.Columns.Add(delete_button);
            }
            DataGridViewButtonColumn updatebutton = new DataGridViewButtonColumn();

            updatebutton.FlatStyle = FlatStyle.Popup;

            updatebutton.HeaderText = "Update";
            updatebutton.Name = "Update";
            updatebutton.UseColumnTextForButtonValue = true;
            updatebutton.Text = "Update";

            updatebutton.Width = 60;
            if (dataGridView1.Columns.Contains(updatebutton.Name = "Update"))
            {

            }
            else
            {
                dataGridView1.Columns.Add(updatebutton);
            }
            DataGridViewButtonColumn update_button = new DataGridViewButtonColumn();

            update_button.FlatStyle = FlatStyle.Popup;

            update_button.HeaderText = "Update";
            update_button.Name = "Update";
            update_button.UseColumnTextForButtonValue = true;
            update_button.Text = "Update";

            update_button.Width = 60;
            if (dataGridView3.Columns.Contains(update_button.Name = "Update"))
            {

            }
            else
            {
                dataGridView3.Columns.Add(update_button);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (mode=="NEW")
            {

                IsDuplicate();

                if (num == false)
                {
                    Regex reg = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" +
                  "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
                    Regex re = new Regex("^[0-9]{10}");
                    if (!reg.IsMatch(textBox1.Text) && re.IsMatch(textBox2.Text.Trim()) == false || textBox2.Text.Length < 10)
                    {
                        MessageBox.Show("Mobile number or Email already exist");
                        textBox1.Clear();
                        textBox2.Clear();
                        label3.Text = "";
                        label4.Text = "";
                    }
                    
                    else
                    {
                        
                        int row = table.Rows.Count;
                        table.Rows.Add(txtname.Text, txtage.Text, this.cbogender.SelectedItem, textBox1.Text, textBox2.Text);
                        if (cbcheck.Checked == true)
                        {
                            dataGridView1.Rows[row].Cells[0].Value = true;
                        }
                        else
                        {
                            dataGridView1.Rows[row].Cells[0].Value = false;
                        }
                        clear();
                        num = true;
                    }
                }
                
            }
            else
            {
               
                    string searchValue = textBox1.Text;
                    string searchValue2 = textBox2.Text;
                    string Name = txtname.Text;
                    // dataGridView1.SelectionMode = DataGridViewSelectionMode.currentRowSelect;

                    foreach (DataGridViewRow i in dataGridView1.Rows)
                    {
                        string a = i.Cells[4].Value.ToString();
                        if (i.Cells[4].Value.ToString().Equals(searchValue))
                        {

                            if (i.Cells[4].Value.ToString().Equals(searchValue) && i.Cells[1].Value.ToString().Equals(Name))
                            {

                            }
                            else
                            {

                                MessageBox.Show("Email id already exist");
                                textBox1.Clear();
                                label3.Text = "";
                                check = true;
                                //break;
                                return;
                            }

                        }
                        if (i.Cells[5].Value.ToString().Equals(searchValue2))
                        {
                            if (i.Cells[5].Value.ToString().Equals(searchValue2) && i.Cells[1].Value.ToString().Equals(Name))
                            {

                            }
                            else
                            {

                                MessageBox.Show("Mobile number already exist");
                                textBox2.Clear();
                                label4.Text = "";
                                check = true;
                                //break;
                                return;
                            }
                        }
                        else
                        {
                            one = false;
                        }
                    }

                    DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
                    //int row = table.Rows.Count;
                    if (cbcheck.Checked == true)
                    {
                        newDataRow.Cells[0].Value = true;
                    }
                    else
                    {
                        newDataRow.Cells[0].Value = false;
                    }
                    newDataRow.Cells[1].Value = txtname.Text;
                    newDataRow.Cells[2].Value = txtage.Text;
                    newDataRow.Cells[3].Value = cbogender.Text;
                    newDataRow.Cells[4].Value = textBox1.Text;
                    newDataRow.Cells[5].Value = textBox2.Text;
                    
                    clear();

                    check = true;
                    return;
        
              } 
            } 

        private void button2_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
              
                Regex reg = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"+"@"+ @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
                if (!reg.IsMatch(textBox1.Text))
                {
                    label3.ForeColor = Color.FromArgb(200, Color.Red);
                    label3.Text = "Please enter valid email";
                }
                else
                {
                   
                    label3.Text = "";
                }
            }
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
           
            Regex re = new Regex("^[0-9]{10}");

            if (re.IsMatch(textBox2.Text.Trim()) == false || textBox2.Text.Length > 10)
            {
                label4.ForeColor = Color.FromArgb(200, Color.Red);
                label4.Text = "Please enter valid Phone Number";
            }
            else
            {
              
               label4.Text = "";

            } 
        }
   
        private void IsDuplicate()
        {
            string searchValue = textBox1.Text;
            string searchValue2 = textBox2.Text;
          
           
            if (dataGridView1.Rows.Count == 0)
            {
                Regex reg = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" +
                   "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
                Regex re = new Regex("^[0-9]{10}");
                if (!reg.IsMatch(textBox1.Text) && re.IsMatch(textBox2.Text.Trim()) == false || textBox2.Text.Length < 10)
                {
                    MessageBox.Show("Mobile number or Email already exist");
                    textBox1.Clear();
                    textBox2.Clear();
                    label3.Text = "";
                    label4.Text = "";
                    num = true;
                }

                else
                //{
                //    string status = "";
                //    if (cbcheck.Checked)
                //        status = "1";
                //    else
                //        status = "0";
                {
                    int row = table.Rows.Count;
                    table.Rows.Add(txtname.Text, txtage.Text, this.cbogender.SelectedItem, textBox1.Text, textBox2.Text);
                    if (cbcheck.Checked == true)
                    {
                        dataGridView1.Rows[row].Cells[0].Value = true;
                    }
                    else
                    {
                        dataGridView1.Rows[row].Cells[0].Value = false;
                    }
                      
                    clear();
                    num = true;
                   
                }
            }
            else
            {
                foreach (DataGridViewRow i in dataGridView1.Rows)
                {

                    string a = i.Cells[4].Value.ToString();
                    if (i.Cells[4].Value.ToString().Equals(searchValue))
                    {
                        i.Selected = true;
                        MessageBox.Show("E  mail id already exist");
                        textBox1.Clear();
                        label3.Text = "";
                        num = true;
                        break;
                        
                    }
                    if (i.Cells[5].Value.ToString().Equals(searchValue2))
                    {
                        // rowIndex = row.Index;
                        i.Selected = true;
                        MessageBox.Show("Mobile number already exist");
                        textBox2.Clear();
                        label4.Text = "";
                        num = true;
                        
                    }
                    else
                    {
                        num = false;
                    }
                }
                
            }
            
        }
          
      





      
      
    }
   }

