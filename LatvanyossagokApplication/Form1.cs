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

namespace LatvanyossagokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            try
            {
                MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
                sb.Server = "localhost";
                sb.UserID = "root";
                sb.Password = "";
                sb.Port = 3307;
                sb.Database = "latvanyosagokdb";
                //conn = new MySqlConnection("Server=localhost;" +
                //                            " Port=3307;" +
                //                            " database=latvanyosagokdb;" +
                //                            " Uid=root; " +
                //                            "Pwd=;");
                conn = new MySqlConnection(sb.ToString());
                conn.Open();
                varosTablaLetrehoz();
                latvanyossagTablaLetrehoz();
               // idegenkulcsok();
                varoslistazas();
            }
            catch(Exception e)
            {
                MessageBox.Show("Nem sikerült kapcsolódni az Adatbázishoz!!! "+e);
            }

        }
        private void varosTablaLetrehoz()
        {
            var command = conn.CreateCommand();
            command.CommandText = @"CREATE TABLE IF NOT EXISTS varosok(
                                        id INTEGER PRIMARY KEY AUTO_INCREMENT,
                                        nev VARCHAR(1000) NOT NULL,
                                        lakossag INTEGER NOT NULL)";
            command.ExecuteNonQuery();
        }
        private void latvanyossagTablaLetrehoz()
        {
            var command = conn.CreateCommand();
            command.CommandText = @"CREATE TABLE IF NOT EXISTS latvanyossagok(
                                        id INTEGER PRIMARY KEY AUTO_INCREMENT,
                                        nev VARCHAR(1000) NOT NULL,
                                        leiras VARCHAR(1000) NOT NULL,
                                        ar INTEGER NOT NULL DEFAULT '0',
                                        varos_id INTEGER NOT NULL, 
                                        FOREIGN KEY(varos_id) 
                                        REFERENCES varosok (id))";
            command.ExecuteNonQuery();
        }
        //private void idegenkulcsok()
        //{
        //    var command = conn.CreateCommand();
        //    command.CommandText = @"ALTER TABLE latvanyossagok
        //                            ADD CONSTRAINT latvanyossagok_idegenkulcs 
        //                            FOREIGN KEY(varos_id) 
        //                            REFERENCES varosok (id);";
        //    command.ExecuteNonQuery();
        //}
        private void varoslistazas()
        {
            listBox_varosok.Items.Clear();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, nev, lakossag FROM varosok ORDER BY nev";
            using (var reader = cmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var lakossag = reader.GetInt32("lakossag");
                    var varos = new Varos(id, nev, lakossag);
                    listBox_varosok.Items.Add(varos);
                }
            }
        }

        private void button_hozzaAd_Click(object sender, EventArgs e)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO varosok (nev, lakossag)
                                VALUES (@nev, @lakossag)";
            cmd.Parameters.AddWithValue("@nev", textBox_varosHozzaAd.Text);
            cmd.Parameters.AddWithValue("@lakossag", numericUpDown_lakossagHozzaAd.Value);
            cmd.ExecuteNonQuery();
            varoslistazas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            varoslistazas();
        }
    }
}
