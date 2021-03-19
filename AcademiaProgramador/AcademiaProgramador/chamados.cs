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
    public partial class chamados : Form
    {
        public chamados()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chamadoslist add = new chamadoslist();
            add.ShowDialog();
        }
    }
}
