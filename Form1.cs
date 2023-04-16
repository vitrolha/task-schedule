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
using Mysqlx.Crud;

namespace AgendaSQL
{
    public partial class Form1 : Form
    {
        private MySqlConnection conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=agenda";

        public Form1()
        {
            InitializeComponent();

            listaTarefas.View = View.Details;
            listaTarefas.LabelEdit = true;
            listaTarefas.AllowColumnReorder = true;
            listaTarefas.FullRowSelect = true;
            listaTarefas.GridLines = true;

            listaTarefas.Columns.Add("ID",30,HorizontalAlignment.Left);
            listaTarefas.Columns.Add("Conteudo", 500, HorizontalAlignment.Left);

            exibirTarefas();
        }

        //Botão adicionar tarefa
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBox_AddTarefa.Text != "")
                {
                    adicionarTarefas();
                }
                else
                {
                    MessageBox.Show("Digite algo");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                exibirTarefas();
            }
        }

        //Botão excluir tarefa
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Deseja realmente atualizar tarefa?", "Atualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirmar == DialogResult.Yes)
            try
            {
                excluirTarefas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //MessageBox.Show("Tarefa Excluida");
                exibirTarefas();
            }
            
        }

        //Botão Atualizar Tarefa
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Deseja realmente atualizar tarefa?", "Atualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);

            if (confirmar == DialogResult.Yes && txtBox_AddTarefa.Text != "")
            {
                try
                {
                    atualizarTarefas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //MessageBox.Show("Tarefa Atualizada");
                    exibirTarefas();
                }
            }
            else if(txtBox_AddTarefa.Text == "")
            {
                MessageBox.Show("Não é possivel atualizar para texto em branco");
            }
        }

        public void adicionarTarefas()
        {
            conexao = new MySqlConnection(data_source);

            string sql = $"insert into tarefas (conteudo) values ('{txtBox_AddTarefa.Text}') ";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            conexao.Open();

            comando.ExecuteReader();

            MessageBox.Show("Tarefa Adicionada");

            conexao.Close();
        }

        public void exibirTarefas()
        {
            conexao = new MySqlConnection(data_source);

            string sql = "select * from tarefas";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            conexao.Open();

            MySqlDataReader reader = comando.ExecuteReader();

            listaTarefas.Items.Clear();

            while (reader.Read())
            {
                string[] row =
                {
                        reader.GetString(0),
                        reader.GetString(1)
                    };

                var linha_listview = new ListViewItem(row);

                listaTarefas.Items.Add(linha_listview);
            }

            conexao.Close();
        }

        public void excluirTarefas()
        {
            conexao = new MySqlConnection(data_source);

            if (listaTarefas.SelectedItems.Count > 0)
            {
                // Obtém a linha selecionada
                ListViewItem linhaSelecionada = listaTarefas.SelectedItems[0];

                // Obtém o valor da coluna "Id"
                int valorId = Convert.ToInt32(linhaSelecionada.SubItems[0].Text);

                // Usa o valor como necessário
                //MessageBox.Show($"O valor da coluna 'Id' é {valorId}");

                string sql = $"delete from tarefas where tarefa_id = {valorId};";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();

                comando.ExecuteReader();

                //MessageBox.Show("Tarefa Excluida");

                conexao.Close();

            }


            
        }

        public void atualizarTarefas()
        {
            conexao = new MySqlConnection(data_source);

            if (listaTarefas.SelectedItems.Count > 0)
            {
                // Obtém a linha selecionada
                ListViewItem linhaSelecionada = listaTarefas.SelectedItems[0];

                // Obtém o valor da coluna "Id"
                int valorId = Convert.ToInt32(linhaSelecionada.SubItems[0].Text);

                string sql = $"update tarefas set conteudo = '{txtBox_AddTarefa.Text}' where tarefa_id = {valorId}";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();

                comando.ExecuteReader();

                conexao.Close();
            }

        }

    }
}
