using lenguaje.Recursos_Localizables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lenguaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            aplicarIdioma();
        }

        private void aplicarIdioma()
        {
            archivoToolStripMenuItem.Text = StringResources.menuArchivo;
            abrirArchivoToolStripMenuItem.Text = StringResources.archivoAbrir;
            guardarToolStripMenuItem.Text = StringResources.archivoGuardar;
            salirToolStripMenuItem.Text = StringResources.archivoSalir;

            edicionToolStripMenuItem.Text = StringResources.menuEdicion;
            copiarToolStripMenuItem.Text = StringResources.edicionCopiar;
            copiarToolStripMenuItem.Text = StringResources.edicionCortar;
            pegarToolStripMenuItem.Text = StringResources.edicionPegar;

            lenguajeToolStripMenuItem.Text = StringResources.menuLenguaje;
            españolToolStripMenuItem.Text = StringResources.lenguajeEspañol;
            inglesToolStripMenuItem.Text = StringResources.lenguajeIngles;
            francesToolStripMenuItem.Text = StringResources.lenguajeFrances;
            tzotzilToolStripMenuItem.Text = StringResources.lenguajeTzotzil;
          


        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture =
                new CultureInfo("ES-ES");

            aplicarIdioma();
        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture =
                new CultureInfo("EN-US");

            aplicarIdioma();
        }

        private void francesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture =
                new CultureInfo("FR-FR");

            aplicarIdioma();
        }

        private void tzotzilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture =
                            new CultureInfo("ES-MX");

            aplicarIdioma();
        }
    }
}
