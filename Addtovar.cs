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
    public partial class Addtovar : Form
    {
       
        public string modeS = "";
        int item;
        void setMode(string mode)
        {
            if (mode == "add")
            {
                addbut.Text = "Добавить";
            }
            else if (mode == "change")
            {
               
                addbut.Text = "Редактировать";
                string Info = "select name, price, category from tovar where id =" + item.ToString() + ";";
                MySqlConnection conn = DB.GetDBConnection();
                MySqlCommand cmInfo = new MySqlCommand(Info, conn);
                MySqlDataReader inRead;
                cmInfo.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    inRead = cmInfo.ExecuteReader();
                    if (inRead.HasRows)
                    {
                        while (inRead.Read())
                        {
                            NametextBox.Text = inRead.GetString(0);
                            PricetextBox.Text = inRead.GetString(1);
                            CattextBox.Text = inRead.GetString(2);
                            

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
        public Addtovar(string mode, int id)
        {
            InitializeComponent();


            modeS = mode;
            item = id;
            setMode(mode);

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void addbut_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text == "")
            {
                MessageBox.Show("Введите название товара");
                return;
            }

            if (PricetextBox.Text == "")
            {
                MessageBox.Show("Введите цену");
                return;
            }

            if (CattextBox.Text == "")
            {
                MessageBox.Show("Введите название категории товара");
                return;
            }

           

            if (modeS == "add")
            {
                string query = "insert into tovar(name, price, category) values('" + NametextBox.Text + "', '" + PricetextBox.Text + "', '" + CattextBox.Text + "');";
                MySqlConnection conn = DB.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Товар был добавлен.");
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Товар не добавлен.");
                    MessageBox.Show(ex.Message);
                }
            }
            if (modeS == "change")
            {
                
                string query = "update tovar set name ='" + NametextBox.Text + "', price='" + PricetextBox.Text + "', category='" + CattextBox.Text + "' where id = " + item.ToString() + ";";
                MySqlConnection conn = DB.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Товар был изменен.");
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();


                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Товар не изменен.");
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    }
    

