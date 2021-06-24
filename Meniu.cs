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


namespace PROIECT_PAW
{
    public partial class Meniu : Form
    {
        
        public Meniu()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e) //inchidere aplicatie
        {
            button3.BackColor = Color.LightSteelBlue;
            Application.Exit();
        }

        //private void button4_Click(object sender, EventArgs e) //modificare cuv
        //{
           
        //    Form3 form3 = new Form3();
        //    form3.ShowDialog();
        //}
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.LightSteelBlue;
            
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            
            button2.BackColor = Color.LightSteelBlue;
        }

        //private void button4_MouseMove(object sender, MouseEventArgs e)
        //{
        //    button4.BackColor = Color.LightSteelBlue;
        //}

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.LightSteelBlue;
        }
    }

    
}


