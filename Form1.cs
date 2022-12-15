using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Funcion_Parametros__sin_y_con_Ref_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double mediaFuncion(double nota1, double nota2, double nota3)
        {
            double res;     //Funcion con argumentos normales sale un resultado double
            res = (nota1 + nota2 + nota3) / 3;
            return res;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;
            n1 = double.Parse(tNota1.Text);
            n2 = double.Parse(tNota2.Text);
            n3 = double.Parse(tNota3.Text);
            media = mediaFuncion(n1, n2, n3);  //variable media recoge el valor de la funcion normalita
            MessageBox.Show("La media es: " + media);
        }

        void mediaReferencia(double nota1, double nota2, double nota3, out double res)
        {
            res = (nota1 + nota2 + nota3) / 3; //Funcion con ARGUMENTO OUT, CON VOID ADELANTE, SIN RETURNyyyd                                                                                                     
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;
            n1 = double.Parse(tNota1.Text);
            n2 = double.Parse(tNota2.Text);
            n3 = double.Parse(tNota3.Text);
            mediaReferencia(n1, n2, n3, out media);    //La funcion llamada directamente arroja el valor media
            MessageBox.Show("La media es: " + media);
        }
    }
}
