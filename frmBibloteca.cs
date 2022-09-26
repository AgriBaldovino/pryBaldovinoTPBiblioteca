using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryBaldovinoTPBiblioteca
{
    public partial class frmBiblioteca : Form
    {
        string[] Libro = new string[21];
        public string[,] baseLibro = new string[20, 5];
        int indiceRecorrido = 0;
        char separador = Convert.ToChar(",");

        public frmBiblioteca()
        {
            InitializeComponent();
        }

        private void frmBiblioteca_Load(object sender, EventArgs e)
        {
            int i = 0;

            StreamReader lectorLibro = new StreamReader("./LIBRO.txt");

            while (!lectorLibro.EndOfStream)
            {
                string[] VecLibro = lectorLibro.ReadLine().Split(separador);

                if (i < 20)
                {
                    //codigo libro
                    baseLibro[i, 0] = VecLibro[0];
                    //nombre libro
                    baseLibro[i, 1] = VecLibro[1];
                    //codigo editorial
                    //buscar e l nombre de editorial en el archivo EDITORIAL

                    BuscarNombreEditorial(VecLibro[2]);
                    baseLibro[i, 2] = VecLibro[2];

                    //codigo autor
                    baseLibro[i, 3] = VecLibro[3];
                    //codigo distri
                    BuscarNombreDistribuidor(VecLibro[4]);
                    baseLibro[i, 4] = VecLibro[4];
                    i++;

                }
            }

            lectorLibro.Close();
        }

        private void BuscarNombreEditorial(string numeroEditorialBuscado)
        {
            StreamReader lectorEditorial = new StreamReader("./EDITORIAL.txt");

            while (!lectorEditorial.EndOfStream)
            {
                //necesito comparar el còdigo del LIBRO con el de EDITORIAL
                //devolver el nombre de EDITORIAL

                string[] vecEditorial = lectorEditorial.ReadLine().Split(separador);

                if (vecEditorial[0] == numeroEditorialBuscado)
                {
                    //MessageBox.Show(vecEditorial[1]);
                    lblCodigoEditorial.Text = vecEditorial[1];
                }
            }

            lectorEditorial.Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //para que lea adentro del vec
        int iRecorrido = 0;
        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            indiceRecorrido++;

            lblCodigo.Text = baseLibro[indiceRecorrido, 0];
            lblNombreLibro.Text = baseLibro[indiceRecorrido, 1];

            BuscarNombreEditorial(baseLibro[indiceRecorrido, 2]);
            //txtCodigoEdito.Text = baseLibro[indiceRecorrido, 2];

            lblCodigoAutor.Text = baseLibro[indiceRecorrido, 3];

            BuscarNombreDistribuidor(baseLibro[indiceRecorrido, 4]);
            //txtCodigoDistri.Text = baseLibro[indiceRecorrido, 4];
            cmdAnterior.Enabled = true;

            if (indiceRecorrido == baseLibro.GetLength(0) - 1)
            {
                cmdSiguiente.Enabled = false;
            }
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            indiceRecorrido--;
            if (indiceRecorrido >= 0)
            {
                lblCodigo.Text = baseLibro[indiceRecorrido, 0];
                lblNombreLibro.Text = baseLibro[indiceRecorrido, 1];
                lblCodigoEditorial.Text = baseLibro[indiceRecorrido, 2];
                lblCodigoAutor.Text = baseLibro[indiceRecorrido, 3];
                lblCodigoDistribuidor.Text = baseLibro[indiceRecorrido, 4];

                if (indiceRecorrido == 0)
                {
                    cmdAnterior.Enabled = false;
                }

            }
            else
            {
                cmdAnterior.Enabled = false;
            }
        }
        private void BuscarNombreDistribuidor(string numeroDistribuidorBuscado)
        {

            StreamReader lectorDistribuidor = new StreamReader("./EDITORIAL.txt");

            while (!lectorDistribuidor.EndOfStream)
            {
                //necesito comparar el còdigo del LIBRO con el de EDITORIAL
                //devolver el nombre de EDITORIAL

                string[] vecDistribuidor = lectorDistribuidor.ReadLine().Split(separador);

                if (vecDistribuidor[0] == numeroDistribuidorBuscado)
                {
                    //MessageBox.Show(vecDistribuidor[1]);
                    lblCodigoDistribuidor.Text = vecDistribuidor[1];
                }
            }

            lectorDistribuidor.Close();
        }
    }
}
