using Oracle.DataAccess.Client;
using System;
using System.Windows.Forms;

namespace BazaDanych
{
    public partial class dodajForm : Form
    {
        private string ConString;
        public dodajForm(string connectionString)
        {
            ConString = connectionString;
            InitializeComponent();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConString))
                {
                    string zapytanie = "INSERT INTO Uczestnicy(DATA_DOLACZENIA, IMIE, NAZWISKO, E_MAIL, TELEFON, ROLA, IMIE_PARTNERA, NAZWISKO_PARTNERA) VALUES(:data, :imie, :nazwisko, :email, :tel, :rola, :imie_part, :nazwisko_part)";

                    using (OracleCommand cmd = new OracleCommand())
                    {

                        cmd.Connection = con;
                        con.Open();
                        cmd.CommandText = zapytanie;
                        OracleParameter dateParameter = new OracleParameter();
                        dateParameter.ParameterName = ":data";
                        dateParameter.OracleDbType = OracleDbType.Date;
                        dateParameter.Value = data_dolaczeniaDTP.Value.Date;

                        cmd.Parameters.Add(dateParameter);
                        cmd.Parameters.Add(new OracleParameter(":imie", imieTB.Text));
                        cmd.Parameters.Add(new OracleParameter(":nazwisko", nazwiskoTB.Text));
                        cmd.Parameters.Add(new OracleParameter(":email", e_mailTB.Text));
                        cmd.Parameters.Add(new OracleParameter(":telefon", telefonTB.Text));
                        cmd.Parameters.Add(new OracleParameter(":rola", rolaCB.Text));
                        cmd.Parameters.Add(new OracleParameter(":imie_part", imie_partneraTB.Text));
                        cmd.Parameters.Add(new OracleParameter(":nazwisko_part", nazwisko_partneraTB.Text));

                        int rowsUpdated = cmd.ExecuteNonQuery();
                        if (rowsUpdated == 0)
                            MessageBox.Show("Record not inserted");
                        else
                            MessageBox.Show("Uczestnik dodany", "SUKCES!");
                        con.Dispose();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
