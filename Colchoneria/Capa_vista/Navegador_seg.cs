using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_vista
{
    public partial class Navegador_seg : Form
    {
        public Navegador_seg()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario b = new Usuario();
            b.Show();
            this.Hide();
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aplicacion b = new Aplicacion();
            b.Show();
            this.Hide();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfiles b = new Perfiles();
            b.Show();
            this.Hide();
        }

        private void módulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos b = new Modulos();
            b.Show();
            this.Hide();
        }

        private void asignacionesDeAplicacionesAUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignacionAplicacion b = new AsignacionAplicacion();
            b.Show();
            this.Hide();
        }

        private void asignaciónDePerfilesAUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignacionPerfiles b = new AsignacionPerfiles();
            b.Show();
            this.Hide();
        }

        private void asignaciónDeAplicacionesAPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignacionAplicacionesPerfiles b = new AsignacionAplicacionesPerfiles();
            b.Show();
            this.Hide();
        }
    }
}
