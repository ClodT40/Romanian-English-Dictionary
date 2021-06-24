using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PROIECT_PAW
{
    public partial class Form1 : Form
    {
        string traducerea, explicatia, id;
        int nr;
        Dictionar d;
        string pathCuvRo = @"D:\\proiectPAAW\bin\Debug\Cuvinte_romana.txt";
        string pathCuvEng = @"D:\\proiectPAAW\bin\Debug\Cuvinte_engleza.txt";
        string pathExplicatii = @"D:\\proiectPAAW\bin\Debug\Explicatii.txt";

        SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\proiectPAAW\Database1.mdf;Integrated Security=True");
        
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void button1_Click(object sender, EventArgs e) //adaugare in dictionar
        {
            
            if (string.IsNullOrEmpty(tb1.Text) || string.IsNullOrEmpty(tb2.Text) ||
             string.IsNullOrEmpty(tb3.Text))
            {
                MessageBox.Show("Completati va rugam toate casetele cu datele aferente");
            }
            else
            {
                c.Open();
                //verific sa nu existe deja cuvantul in baza
                string select = @"SELECT *  FROM Dictionar WHERE Cuv_Ro='" + tb1.Text + "'";
                SqlCommand cmd = new SqlCommand(select, c);

                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    traducerea = r["Cuv_Eng"].ToString();
                    explicatia = r["Explicatii"].ToString();
                    id = r["Id"].ToString();
                    nr = Convert.ToInt32(id);
                }
                c.Close();
                

                if (id != null)
                {
                    MessageBox.Show("Cuvantul pe care doriti sa-l inserati exista deja  in dictionar!");
                    id = null;
                }
                else
                {
                    int dimensiune = tb3.Text.Length;
                    if (dimensiune>700 )
                    {
                        MessageBox.Show("Explicatia depaseste numarul de caractere!");
                    }
                    else
                    {
                        //-----------------------------------------------------------------------------------------
                        //adaugarea in clasa dictionar a cuvintelor
                        if (d == null)
                        {
                            d = new Dictionar(tb1.Text, tb2.Text, tb3.Text);

                            if (!File.Exists(pathCuvRo) && !File.Exists(pathCuvEng) && !File.Exists(pathExplicatii))
                            {
                                using (StreamWriter sw = File.CreateText(pathCuvRo))
                                {
                                    sw.WriteLine(d.getCuvantDinCuvinteRomana());
                                }
                                using (StreamWriter sw = File.CreateText(pathCuvEng))
                                {
                                    sw.WriteLine(d.getCuvantDinCuvinteEngleza());
                                }
                                using (StreamWriter sw = File.CreateText(pathExplicatii))
                                {
                                    sw.WriteLine(d.getCuvantDinExplicatii());
                                }
                            }

                            using (StreamWriter sw = File.AppendText(pathCuvRo))
                            {
                                sw.WriteLine(d.getCuvantDinCuvinteRomana());
                            }
                            using (StreamWriter sw = File.AppendText(pathCuvEng))
                            {
                                sw.WriteLine(d.getCuvantDinCuvinteEngleza());
                            }
                            using (StreamWriter sw = File.AppendText(pathExplicatii))
                            {
                                sw.WriteLine(d.getCuvantDinExplicatii());
                            }
                        }
                        else
                        {
                            Dictionar aux;
                            aux = new Dictionar(tb1.Text, tb2.Text, tb3.Text);
                            d = d + aux;

                            //adaugare in fisier a cuvintelor
                            if (!File.Exists(pathCuvRo) && !File.Exists(pathCuvEng) && !File.Exists(pathExplicatii))
                            {
                                using (StreamWriter sw = File.CreateText(pathCuvRo))
                                {
                                    sw.WriteLine(aux.getCuvantDinCuvinteRomana());
                                }
                                using (StreamWriter sw = File.CreateText(pathCuvEng))
                                {
                                    sw.WriteLine(aux.getCuvantDinCuvinteEngleza());
                                }
                                using (StreamWriter sw = File.CreateText(pathExplicatii))
                                {
                                    sw.WriteLine(aux.getCuvantDinExplicatii());
                                }
                            }

                            using (StreamWriter sw = File.AppendText(pathCuvRo))
                            {
                                sw.WriteLine(aux.getCuvantDinCuvinteRomana());
                            }
                            using (StreamWriter sw = File.AppendText(pathCuvEng))
                            {
                                sw.WriteLine(aux.getCuvantDinCuvinteEngleza());
                            }
                            using (StreamWriter sw = File.AppendText(pathExplicatii))
                            {
                                sw.WriteLine(aux.getCuvantDinExplicatii());
                            }
                        }

                        //--------------------------------------------------------------------------------------------
                        ///baza de date: 


                        c.Open();
                        string insert = @"INSERT INTO Dictionar(Cuv_Ro,Cuv_Eng,Explicatii) VALUES (@Cuv_Ro,@Cuv_Eng,@Explicatii)";
                        cmd = new SqlCommand(insert, c);

                        cmd.Parameters.AddWithValue("Cuv_Ro", tb1.Text);
                        cmd.Parameters.AddWithValue("Cuv_Eng", tb2.Text);
                        cmd.Parameters.AddWithValue("Explicatii", tb3.Text);

                        r = cmd.ExecuteReader();

                        tb1.Clear();
                        tb2.Clear();
                        tb3.Clear();
                        MessageBox.Show("S-a inserat cuvantul!");
                    }                   
                } 
            }
            c.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
