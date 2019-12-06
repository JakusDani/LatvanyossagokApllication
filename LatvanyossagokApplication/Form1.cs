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
            
                MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
                sb.Server = "localhost";
                sb.UserID = "root";
                sb.Password = "";
                sb.Port = 3307;
                sb.Database = "latvanyossagokdb";
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
            if (textBox_varosHozzaAd.Text == "")
            {
                MessageBox.Show("Nem adta meg a város nevét");
            }
            else if (numericUpDown_lakossagHozzaAd.Value == 0)
            {
                MessageBox.Show("Nem adta meg a lakosság lélek számát");
            }
            else
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO varosok (nev, lakossag)
                                VALUES (@nev, @lakossag)";
                cmd.Parameters.AddWithValue("@nev", textBox_varosHozzaAd.Text);
                cmd.Parameters.AddWithValue("@lakossag", numericUpDown_lakossagHozzaAd.Value);
                cmd.ExecuteNonQuery();
                varoslistazas();
                MessageBox.Show("A várost sikeresen hozáadta!!");
                textBox_varosHozzaAd.Clear();
                numericUpDown_lakossagHozzaAd.Value = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            varoslistazas();
        }

        private void label_latvanyossag_leiras_Click(object sender, EventArgs e)
        {

        }

        private void button_latvanyossag_hozaad_Click(object sender, EventArgs e)
        {
            //hiba keresés
            if (listBox_varosok.SelectedIndex == -1)
            {
                MessageBox.Show("nem választott ki várost");
                return;
            }
            else if (textBox_latvanyossagNev.Text == "")
            {
                MessageBox.Show("Nem adott meg nevet");
            }
            else if (textBox_latvanyossag_leiras.Text == "")
            {
                MessageBox.Show("Nem adott meg leírást");
            }
            else if (numericUpDown_latvanyossag_ar.Value == 0)
            {
                MessageBox.Show("Nem adott meg árat");
            }
            else
            {
                Varos v = (Varos)listBox_varosok.SelectedItem;
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO latvanyossagok (nev, leiras, ar, varos_id)
                                VALUES (@nev, @leiras, @ar, @varos_id)";
                cmd.Parameters.AddWithValue("@nev", textBox_latvanyossagNev.Text);
                cmd.Parameters.AddWithValue("@leiras", textBox_latvanyossag_leiras.Text);
                cmd.Parameters.AddWithValue("@ar", numericUpDown_latvanyossag_ar.Value);
                cmd.Parameters.AddWithValue("@varos_id", v.Id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sikeresen hozzáadta a látványosságot");
                textBox_latvanyossagNev.Clear();
                textBox_latvanyossag_leiras.Clear();
                numericUpDown_latvanyossag_ar.Value = 0;
                listBox_varosok.ClearSelected();
            }
        }

        private void button_torles_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM `varosok`WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", ((Varos)listBox_varosok.SelectedItem).Id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sikeres Törlés!!");
                varoslistazas();
            }
            catch
            {
                MessageBox.Show("Ezt a várost nem tudod törölni mert meg van adva látványosság");
            }
        }
    }
}
