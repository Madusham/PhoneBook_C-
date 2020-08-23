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
using System.IO;


namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("PhoneBook.txt"))
            {
                listView.View = View.Details;
                List<string> Cdata = File.ReadAllLines("PhoneBook.txt").ToList();
                foreach (string d in Cdata)
                {
                    // string[] items = d.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    string[] items = d.Split('\t');
                    dataGridView1.Rows.Add(items);
                }
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
                //  dataGridView1.s = SortOrder.Ascending;
            }

            /* if (File.Exists("PhoneBook.txt"))
             {
                 listView.View = View.Details;
                 List<string> Cdata = File.ReadAllLines("PhoneBook.txt").ToList();
                 foreach (string d in Cdata)
                 {
                     // string[] items = d.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                     string[] items = d.Split('\t');
                     listView.Items.Add(new ListViewItem(items));
                 }
                 listView.Sorting = SortOrder.Ascending;
             }*/

        }

         

         private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string line;
            int i = 1;
            //MadushaJayarathne

            if ((String.IsNullOrEmpty(CNametxt.Text) != true))
            {
                if ((string.IsNullOrEmpty(CNum1txt.Text) == false) || (string.IsNullOrEmpty(CNum2txt.Text) == false) || (string.IsNullOrEmpty(CNum3txt.Text) == false))
                {
                    if (File.Exists("PhoneBook.txt"))
                    {
                        StreamReader pr = new StreamReader("PhoneBook.txt");
                        while ((line = pr.ReadLine()) != null)
                        {
                            string[] list = line.Split('\t');
                            if (list.Contains(CNametxt.Text))
                            {
                                i = 0;
                                break;
                            }

                        }
                        pr.Close();
                        
                    }

                    if (i != 0)
                    {
                        StreamWriter sw = new StreamWriter("Phonebook.txt", true);
                        sw.WriteLine(CNametxt.Text + "\t" + CNum1txt.Text + "\t" + CNum2txt.Text + "\t" + CNum3txt.Text);
                        sw.Close();
 

                        string[] row = { CNametxt.Text, CNum1txt.Text, CNum2txt.Text, CNum3txt.Text};
                        dataGridView1.Rows.Add(row);

                        //var listViewItem = new ListViewItem(row);
                        //listView.Items.Add(listViewItem);

                        CNum1txt.Text = String.Empty;
                        CNum2txt.Text = String.Empty;
                        CNum3txt.Text = String.Empty;
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Contact Name already Used..!!\nTry Againg", "OPPS");
                    }
                    CNametxt.Text = String.Empty;
                }
                else
                {
                   MessageBox.Show("Enter a contact number", "Warning");
                }

            }
            else
            {
               MessageBox.Show("Enter a contact name", "Warning");
            }


            
        }

        private void detailsbox_TextChanged(object sender, EventArgs e)
        {
            

        }
 
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
           /*foreach(int index in listView.SelectedIndices)
            {
                DName.Text = listView.SelectedItems[0].SubItems[0].Text;
                DNum1.Text = listView.SelectedItems[0].SubItems[1].Text;
                DNum2.Text = listView.SelectedItems[0].SubItems[2].Text;
                DNum3.Text = listView.SelectedItems[0].SubItems[3].Text;
            }*/

               
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            row.Selected = true;
            //  dataGridView1.CurrentRow.Selected = true;
            DName.Text = row.Cells[0].Value.ToString();
            DNum1.Text = row.Cells[1].Value.ToString();
            DNum2.Text = row.Cells[2].Value.ToString();
            DNum3.Text = row.Cells[3].Value.ToString();


        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string searchValue = Searchbox.Text;
            

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString()!=(searchValue)&& row.Cells[1].Value.ToString()!=(searchValue)&& row.Cells[2].Value.ToString()!=(searchValue)&& row.Cells[3].Value.ToString()!=(searchValue))
                    {
                        row.Visible = false;
                       // break;
                    }
                }

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            //int RowIndex = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.CurrentRow.Cells[0].Value = DName.Text;
            dataGridView1.CurrentRow.Cells[1].Value = DNum1.Text;
            dataGridView1.CurrentRow.Cells[2].Value = DNum2.Text;
            dataGridView1.CurrentRow.Cells[3].Value = DNum3.Text;


           StreamWriter writer = new StreamWriter("PhoneBook.txt",true);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() +
                    "\t");
                }
                writer.WriteLine("");
            }
            writer.Close();
        }

        private void Deletbtn_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(RowIndex);
            DName.Clear();
            DNum1.Clear();
            DNum2.Clear();
            DNum3.Clear();

           //File.WriteAllText("PhoneBook.txt", String.Empty);
 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
