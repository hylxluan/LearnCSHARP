using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestaoClientes
{
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }


        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            string conexaoString = "server=localhost;port=3306;user=root;password=;database=gt_clientes;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();
                    using (MySqlCommand comando = conexao.CreateCommand())
                    {

                        comando.CommandText = "INSERT INTO clientes (nome, documento) VALUES (@nome, @documento)";
                        comando.Parameters.AddWithValue("@nome", txtCliente.Text);
                        comando.Parameters.AddWithValue("@documento", txtRG.Text);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cliente inserido com sucesso!");
                    }
                    MessageBox.Show("Conexão bem-sucedida!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }
    }
}
