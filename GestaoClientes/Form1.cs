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
                        comando.CommandText = @"INSERT INTO clientes (nome, documento, cpfcnpj, estadocivil, genero, 
                                        data_nascimento, cep, numero_endereco, endereco, bairro, 
                                        cidade, estado, email, celular, observacoes, situacao_cadastral) 
                                        VALUES (@nome, @documento, @cpfcnpj, @estadocivil, @genero, 
                                        @data_nascimento, @cep, @numero_endereco, @endereco, @bairro, 
                                        @cidade, @estado, @email, @celular, @observacoes, @situacao_cadastral)";
                        
                        comando.Parameters.AddWithValue("@nome", txtCliente.Text);
                        comando.Parameters.AddWithValue("@documento", txtRG.Text);
                        comando.Parameters.AddWithValue("@cpfcnpj", maskedCPFCNPJ.Text);
                        comando.Parameters.AddWithValue("@estadocivil", comboEstadoCivil.SelectedItem?.ToString() ?? "");
                        comando.Parameters.AddWithValue("@genero", radioMasculino.Checked ? "M" : (radioFeminino.Checked ? "F" : ""));
                        comando.Parameters.AddWithValue("@data_nascimento", maskedDataNascimento.Text);
                        comando.Parameters.AddWithValue("@cep", maskedCEP.Text);
                        comando.Parameters.AddWithValue("@numero_endereco", txtNumero.Text);
                        comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                        comando.Parameters.AddWithValue("@estado", comboEstado.SelectedItem?.ToString() ?? "");
                        comando.Parameters.AddWithValue("@email", txtEmail.Text);
                        comando.Parameters.AddWithValue("@celular", maskedCelular.Text);
                        comando.Parameters.AddWithValue("@observacoes", txtMultiObservacoes.Text);
                        comando.Parameters.AddWithValue("@situacao_cadastral", checkBoxAtiva.Checked ? "Ativa" : "Inativa");
                        
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cliente inserido com sucesso!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }
    }
}
