using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazaDanych.Properties;


namespace BazaDanych
{

    public partial class Form1 : Form
    {
        Dictionary<string, string> tables = new Dictionary<string, string>();
        public string GetConnectionString()
        {
            string connectionString;
            connectionString = String.Format("DATA SOURCE={0}:{1}/{2};PASSWORD={3};PERSIST SECURITY INFO=True;USER ID={4}",
                tbDBAdress.Text, numPort.Value, tbSID.Text, tbPassword.Text, tbUsername.Text);
            return connectionString;
        }
        public Form1()
        {
            InitializeComponent();
            var resourceName = "tables.txt";
            String tablesFilePath = Path.Combine(Directory.GetCurrentDirectory(), resourceName);
            string[] lines = File.ReadAllLines(tablesFilePath);
            foreach (String line in lines)
                {
                String name = line.Split(';')[0];
                String tableName = line.Split(';')[1];
                tables.Add(name, tableName);
                listBox1.Items.Add(name);
            }
            tables = lines.Select(l => l.Split(';')).ToDictionary(a => a[0], a => a[1]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Enabled = false;
            dodajUczestnikaBtn.Enabled = false;
        }

        private bool PolaczZBaza()
        {
            try
            {
                string ConString = GetConnectionString();
                using (OracleConnection con = new OracleConnection(ConString))
                    con.Open();
                MessageBox.Show("Udalo się połączyć z bazą");
                tbDBAdress.Enabled = false;
                tbPassword.Enabled = false;
                tbSID.Enabled = false;
                tbUsername.Enabled = false;
                numPort.Enabled = false;
                dodajUczestnikaBtn.Enabled = true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Polączenie nieudane" + ex.ToString(), "BŁĄD!");
                return false;
            }
        }

        private void LoadData(string tableName)
        {
            try
            {
                string ConString = GetConnectionString(); // "DATA SOURCE=localhost:1521/xe;PASSWORD=marta;PERSIST SECURITY INFO=True;USER ID=MARTA";
                using (OracleConnection con = new OracleConnection(ConString))
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM "+tableName, con);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(tables[listBox1.GetItemText(listBox1.SelectedItem)]);
        }

        private void dodajUczestnikaBtn_Click(object sender, EventArgs e)
        {
            dodajForm dodajuczestnika = new dodajForm(GetConnectionString());
            dodajuczestnika.Show();
        }
         
        private void btnPolacz_Click(object sender, EventArgs e)
        {
            if (PolaczZBaza() == true)
            {
                listBox1.Enabled = true;
                btnPolacz.Enabled = false;
            }
        }
    }
}