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
    
    public partial class Form2 : Form
    {
        string pathCuvRo = @"D:\\proiectPAAW\bin\Debug\Cuvinte_romana.txt";
        string pathCuvEng = @"D:\\proiectPAAW\bin\Debug\Cuvinte_engleza.txt";
        string pathExplicatii = @"D:\\proiectPAAW\bin\Debug\Explicatii.txt";
        string traducerea, explicatia, id;
        int nr;

        SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\proiectPAAW\Database1.mdf;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            cuvCautat.Clear();
            TBexplicatii.Clear();
            TBtraducere.Clear();
            button2.Enabled = true;
            button3.Enabled = false;
            RtoE.Checked = false;
            EtoR.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            c.Open();
            if (RtoE.Checked == false && EtoR.Checked == false)
            {
                MessageBox.Show("Bifati va rugam tipul de traducere");
            }
            else
            {
                if( string.IsNullOrEmpty(cuvCautat.Text) )
                 {
                        MessageBox.Show("Completati va rugam cuvantul pe care doriti sa-l cautati!");
                 }
                else
                {

                    if (RtoE.Checked == true)
                    {
                        //----------------------------------------------------------------------------------------------------
                        //romana engleza
                        string select = @"SELECT *  FROM Dictionar WHERE Cuv_Ro='" + cuvCautat.Text + "'";
                        SqlCommand cmd = new SqlCommand(select, c);

                        SqlDataReader r = cmd.ExecuteReader();

                        while (r.Read())
                        {
                            traducerea = r["Cuv_Eng"].ToString();
                            explicatia = r["Explicatii"].ToString();
                            id = r["Id"].ToString();
                            nr = Convert.ToInt32(id);
                        }
                        //------------------------------------------------------------------------------------------------------
                        if (id == null || traducerea == cuvCautat.Text)
                        {
                            MessageBox.Show("Cuvant cautat incorect, nu exista in dictionar sau nu ati setat corect tipul de traducere");
                        }
                        else
                        {
                            using (StreamReader sr = File.OpenText(pathCuvEng))
                            {
                                string s = "";
                                int cnt = 1;
                                while ((s = sr.ReadLine()) != null && cnt < nr)
                                {
                                    cnt++;
                                }
                                TBtraducere.Text = s;
                            }
                            using (StreamReader sr = File.OpenText(pathExplicatii))
                            {
                                string s = "";
                                int cnt = 1;
                                while ((s = sr.ReadLine()) != null && cnt < nr)
                                {
                                    cnt++;
                                }
                                TBexplicatii.Text = s;
                            }
                            id = null;
                        }
                    }
                    else
                    {
                        //engleza romana
                        if (EtoR.Checked == true)
                        {
                            //---------------------------------------------------------------------------------------------------
                            //engleza romana
                            string select = @"SELECT * FROM Dictionar WHERE Cuv_Eng='" + cuvCautat.Text + "'";
                            SqlCommand cmd = new SqlCommand(select, c);

                            SqlDataReader r = cmd.ExecuteReader();

                            //gasirea in baza de date a cuvantului cautat
                            while (r.Read())
                            {
                                traducerea = r["Cuv_Ro"].ToString();
                                explicatia = r["Explicatii"].ToString();
                                id = r["Id"].ToString();
                                nr = Convert.ToInt32(id);
                            }
                            //---------------------------------------------------------------------------------------------------
                            if (id == null || traducerea == cuvCautat.Text)
                            {
                                MessageBox.Show("Cuvant cautat incorect, nu exista in dictionar sau nu ati setat corect tipul de traducere");
                            }
                            else
                            {
                                using (StreamReader sr = File.OpenText(pathCuvRo))
                                {
                                    string s = "";
                                    int cnt = 1;
                                    while ((s = sr.ReadLine()) != null && cnt < nr)
                                    {
                                        cnt++;
                                    }

                                    TBtraducere.Text = s;
                                }
                                using (StreamReader sr = File.OpenText(pathExplicatii))
                                {
                                    string s = "";
                                    int cnt = 1;
                                    while ((s = sr.ReadLine()) != null && cnt < nr)
                                    {
                                        cnt++;
                                    }

                                    TBexplicatii.Text = s;
                                }
                                id = null;
                            }
                        }
                    }

                    if (TBexplicatii.Text != null)
                    {
                        button2.Enabled = false;
                        button3.Enabled = true;

                    }
                }
                

                
            }      
            c.Close();      
        }      
    }
}
