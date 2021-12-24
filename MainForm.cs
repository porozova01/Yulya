using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yulya
{
    public partial class MainForm : Form
    {
        void get_Info(ListView List)
        {
            string query = "select tovar.id, tovar.name, tovar.price, category.name_cat from tovar join category on tovar.category = category.id;";
            MySqlConnection conn = DB.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3)};
                        var listViewItem = new ListViewItem(row);
                        Info.Items.Add(listViewItem);
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public MainForm()
        {
            InitializeComponent();
            get_Info(Info);
            this.FormClosing += Items_FormClosing;
        }

        private void Items_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addtovar add = new Addtovar("add", 0);
            add.Show();
        }

        private void Delbutton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult Result = MessageBox.Show("Вы уверены, что хотите удалить товар ?", "Внимание!", buttons);
            if (Result == DialogResult.Yes)
            {
                string query = "delete from tovar where id = " + Info.Items[Info.SelectedIndices[0]].Text + ";";
                MySqlConnection conn = DB.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    this.Info.Items.Clear();
                    get_Info(Info);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addtovar add = new Addtovar("change", Convert.ToInt32(Convert.ToString(Info.Items[Info.SelectedIndices[0]].Text)));
            add.Show();
        }

        private void search_Box_TextChanged(object sender, EventArgs e)
        {
            Info.Items.Clear();
            string query = "select * from tovar where concat(id, name, price ) like '%" + search_Box.Text + "%'"; //условие like позволяет искать по всем столбцам.
            MySqlConnection conn = DB.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2) };
                        var listItem = new ListViewItem(row);
                        Info.Items.Add(listItem);
                    }
                }
                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
