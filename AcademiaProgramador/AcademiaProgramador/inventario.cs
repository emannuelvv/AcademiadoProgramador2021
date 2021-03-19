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
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();
        }

        SqlConnection sqlcom = null;
        private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bd;Data Source=DESKTOP-NSJ96GG";
        private SqlConnection sqlCon;
        private string strSql = string.Empty;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /* botão salvar*/
            strCon = "insert into inventario (Nome,Preco,Serie,Fabricacao,Fabricante) values (@Nome,@Preco,@Serie,@Fabricacao,@Fabricante) ";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = SqlCommand(strCon, strSql);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).value = nome.Text;
            comando.Parameters.Add("@Preco", SqlDbType.VarChar).value = preco.Text;
            comando.Parameters.Add("@Serie", SqlDbType.VarChar).value = serialnumber.Text;
            comando.Parameters.Add("@Fabricacao", SqlDbType.VarChar).value = data.Text;
            comando.Parameters.Add("@Fabricante", SqlDbType.VarChar).value = fabricante.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteQuery();

                MessageBox.Show("Cadastro Feito");
            }
            catch(Execption ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            
            {
                sqlCon.Close();

            }

        }

        private SqlCommand SqlCommand(string strCon, string strSql)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
