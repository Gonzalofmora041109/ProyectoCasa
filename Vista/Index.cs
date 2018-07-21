using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btn_cerrar_BackColorChanged(object sender, EventArgs e)
        {

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 183)
            {
                MenuVertical.Width = 60;
            }
            else MenuVertical.Width = 183;
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }
        private void MostrarPanelContenedor(Form form) {
            if (Contenedor.Controls.Count > 0) {
                Contenedor.Controls.RemoveAt(0);
            }
            Form fm = form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            Contenedor.Controls.Add(fm);
            fm.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MostrarPanelContenedor(new IngresarGasto());
        }
    }
}
