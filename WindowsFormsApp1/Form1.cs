using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
           // MessageBox.Show("Pedro Pedro Pe!");
        }

        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            string contra1 = textBoxusr.Text.ToLower();
            string contra2 = textBoxpass.Text.ToLower();

            if (contra1.Equals("admin") && contra2.Equals("admin"))
            {
                LabelTitulo.Text = "Bienvenido";
                Frmingreso forma = new Frmingreso();
                forma.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña equivocado");
                textBoxpass.Text = "";
                textBoxusr.Text = "";

                int fallos = 0;
                fallos += 1;
                if (fallos>=3)
                {
                    buttonIngreso.Enabled = false;
                }
            }



        }

        //private void Inicio_Click(object sender, EventArgs e)
        //{
        //    LabelTitulo.Text = "Bienvenido";
        //    Frmingreso forma = new Frmingreso();
        //    forma.Show();
        //}
    }
}
