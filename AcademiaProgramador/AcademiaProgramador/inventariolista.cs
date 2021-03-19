using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaProgramador
{
    public partial class inventariolista : Form
    {
        public inventariolista()
        {
            InitializeComponent();
        }

        private void inventariolista_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            inventario add = new inventario();
            add.ShowDialog();
        }
    }
}
