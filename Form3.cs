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
    public partial class Form3 : Form
    {
        string pathCuvRo = @"D:\\proiectPAAW\bin\Debug\Cuvinte_romana.txt";
        string pathCuvEng = @"D:\\proiectPAAW\bin\Debug\Cuvinte_engleza.txt";
        string pathExplicatii = @"D:\\proiectPAAW\bin\Debug\Explicatii.txt";

        string traducereaNoua, explicatiaNoua,traducereaVeche,explicatiaVeche, id;
        int nr;

        SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\proiectPAAW\Database1.mdf;Integrated Security=True");

        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            

            
            if (RtoE.Checked == false && EtoR.Checked == false)
            {
                MessageBox.Show("Bifati va rugam tipul de traducere");
            }
            else
            {
                if (RtoE.Checked == true)
                {
                    //----------------------------------------------------------------------------------------------------
                    //romana engleza
                    c.Open();
                    string select = @"SELECT * FROM Dictionar WHERE Cuv_Ro='" + cuvCautat.Text + "'";
                    SqlCommand cmd = new SqlCommand(select, c);

                    SqlDataReader r = cmd.ExecuteReader();

                    //gasirea in baza de date a pozitiei in fisier a cuvantului cautat
                    while (r.Read())
                    {
                        traducereaVeche = r["Cuv_Ro"].ToString(); //fac rost de traducerea veche
                        explicatiaVeche = r["Explicatii"].ToString(); //fac rost de explicatia veche
                        id = r["Id"].ToString();
                        nr = Convert.ToInt32(id);
                    }
                    c.Close();
                    c.Open();
                    //modific in baza cuvantul
                        string update = @"UPDATE DICTIONAR SET Cuv_Eng='" + TBtraducere.Text +
                        "' , Explicatii='" + TBexplicatii.Text + "' WHERE Cuv_Ro='" + cuvCautat.Text + "'";
                     cmd = new SqlCommand(update, c);

                     r = cmd.ExecuteReader();

                    while (r.Read())
                    {     
                        traducereaNoua = r["Cuv_Eng"].ToString();
                        explicatiaNoua = r["Explicatii"].ToString();     
                    }
                    //------------------------------------------------------------------------------------------------------
                    if (id == null )
                    {
                        MessageBox.Show("Cuvantul pe care doriti sa-l modificati este  incorect, nu exista in dictionar sau nu ati setat corect tipul de traducere");
                    }
                    else
                    {
                        string[] lines = File.ReadAllLines("Cuvinte_engleza.txt");

                        // Write the new file over the old file.
                        using (StreamWriter writer = File.AppendText(pathCuvEng))
                        {
                            for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                            {
                                if (currentLine == nr)
                                {
                                    writer.WriteLine(TBtraducere.Text);
                                }
                                //else
                                //{
                                //    writer.WriteLine(lines[currentLine - 1]);
                                //}
                            }
                        }
                        lines = File.ReadAllLines("Explicatii.txt");

                        // Write the new file over the old file.
                        using (StreamWriter writer = File.AppendText(pathExplicatii))
                        {
                            for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                            {
                                if (currentLine == nr)
                                {
                                    writer.WriteLine(TBexplicatii.Text);
                                }
                                //else
                                //{
                                //    writer.WriteLine(lines[currentLine - 1]);
                                //}
                            }
                        }
                        //    string text = File.ReadAllText("Cuvinte_engleza.txt");
                        //    text = text.Replace(traducereaVeche, TBtraducere.Text);
                        //    File.WriteAllText("Cuvinte_engleza.txt", text);

                        //text = File.ReadAllText("Explicatii.txt");
                        //text = text.Replace(explicatiaVeche, TBexplicatii.Text);
                        //File.WriteAllText("Explicatii.txt", text);

                        id = null;
                    }
                    c.Close();
                }
                else
                {
                    //engleza romana
                    if (EtoR.Checked == true)
                    {
                        //---------------------------------------------------------------------------------------------------
                        //engleza romana
                        c.Open();
                        string select = @"SELECT * FROM Dictionar WHERE Cuv_Eng='" + cuvCautat.Text + "'";
                        SqlCommand cmd = new SqlCommand(select, c);

                        SqlDataReader r = cmd.ExecuteReader();

                        //gasirea in baza de date a pozitiei cuvantului cautat
                        while (r.Read())
                        {
                            traducereaVeche = r["Cuv_Ro"].ToString(); //fac rost de traducerea veche
                            explicatiaVeche = r["Explicatii"].ToString(); //fac rost de explicatia veche
                            id = r["Id"].ToString();
                            nr = Convert.ToInt32(id);
                        }

                        c.Close();
                        c.Open();

                        //modific in baza datele
                        string update = @"UPDATE DICTIONAR SET Cuv_Ro='" + TBtraducere.Text +
                        "' , Explicatii='" + TBexplicatii.Text + "' WHERE Cuv_Eng='" + cuvCautat.Text + "'";
                        cmd = new SqlCommand(update, c);

                        r = cmd.ExecuteReader();

                        while (r.Read())
                        {
                            traducereaNoua = r["Cuv_Eng"].ToString();
                            explicatiaNoua = r["Explicatii"].ToString();
                        }

                        //---------------------------------------------------------------------------------------------------
                        if (id == null )
                        {
                            MessageBox.Show("Cuvantul pe care doriti sa-l modificati este incorect, nu exista in dictionar sau nu ati setat corect tipul de traducere");
                        }
                        else
                        {

                            string[] lines = File.ReadAllLines("Cuvinte_romana.txt");

                            // Write the new file over the old file.
                            using (StreamWriter writer = File.AppendText(pathCuvRo))
                            {
                                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                                {
                                    if (currentLine == nr)
                                    {
                                        writer.WriteLine(TBtraducere.Text);
                                    }
                                    //else
                                    //{
                                    //    writer.WriteLine(lines[currentLine - 1]);
                                    //}
                                }
                            }
                            lines = File.ReadAllLines("Explicatii.txt");

                            // Write the new file over the old file.
                            using (StreamWriter writer = File.AppendText(pathExplicatii))
                            {
                                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                                {
                                    if (currentLine == nr)
                                    {
                                        writer.WriteLine(TBexplicatii.Text);
                                    }
                                    //else
                                    //{
                                    //    writer.WriteLine(lines[currentLine - 1]);
                                    //}
                                }
                            }

                            //modificarile propriu zise in fisier
                            //string text = File.ReadAllText("Cuvinte_romana.txt");
                            //text = text.Replace(traducereaVeche, TBtraducere.Text);
                            //File.WriteAllText("Cuvinte_romana.txt", text);

                            //text = File.ReadAllText("Explicatii.txt");
                            //text = text.Replace(explicatiaVeche, TBexplicatii.Text);
                            //File.WriteAllText("Explicatii.txt", text);

                            id = null; //o iau de la capat in cazu in care vrea sa modifice un nou cuvant. 
                        }
                        c.Close();
                    }
                }
            }
            c.Close();


            cuvCautat.Clear();
            TBexplicatii.Clear();
            TBtraducere.Clear();
            RtoE.Checked = false;
            EtoR.Checked = false;
        }

       


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
