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
using MySql.Data.Types;

namespace Agenda
{
    public partial class Agenda : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=db_contatos";

        private int ?id_contato_selecionado = null;

        public Agenda()
        {
            InitializeComponent();


            lstContatos.View = View.Details;
            lstContatos.LabelEdit = true;
            lstContatos.AllowColumnReorder = true;
            lstContatos.FullRowSelect = true;
            lstContatos.GridLines = true;
                    
            lstContatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Email", 150, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

            carregarContatos();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;


                if (id_contato_selecionado == null)
                {
                    //Cadastrando no banco
                    cmd.CommandText = "INSERT INTO contatos (nome, email, telefone) " +
                                  "VALUES " +
                                  "(@nome, @email, @telefone) ";
                    

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", mskTelefone.Text);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato Inserido com Sucesso!",
                                    "Sucesso!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    id_contato_selecionado = null;
                    //Zerar Campos
                    txtNome.Text = string.Empty;
                    txtEmail.Text = "";
                    mskTelefone.Text = "";


                    carregarContatos();
                }
                else
                {
                    // Atualização de Contato

                    cmd.CommandText = "UPDATE contatos SET " +
                                      "nome=@nome, email=@email, telefone=@telefone " +
                                      "WHERE id=@id ";
                   

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", mskTelefone.Text);
                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato Atualizado com Sucesso!",
                                    "Sucesso!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }
        private void Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                //criar conexão com MySQL
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                cmd.Prepare();
                cmd.CommandText = "SELECT * FROM contatos WHERE nome LIKE @q OR email LIKE @q";

                

                cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");
                

                //Executar Lista

                MySqlDataReader reader = cmd.ExecuteReader();

                lstContatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };
                    lstContatos.Items.Add(new ListViewItem(row));
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void carregarContatos()
        {
            try
            {
                //criar conexão com MySQL
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                cmd.Parameters.AddWithValue("@id", id_contato_selecionado);
                cmd.Prepare();
                cmd.CommandText = "SELECT * FROM contatos ORDER BY id DESC";


                //Executar Lista

                MySqlDataReader reader = cmd.ExecuteReader();

                lstContatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };
                    lstContatos.Items.Add(new ListViewItem(row));
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void lstContatos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //listar banco de dados

            ListView.SelectedListViewItemCollection itens_Selecionados = lstContatos.SelectedItems;

            foreach(ListViewItem item in itens_Selecionados){
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
                txtEmail.Text = item.SubItems[2].Text;
                mskTelefone.Text = item.SubItems[3].Text;
                tsbExcluir.Visible = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            zerarFormulario();
       
        }
        //limpar formulario de cadastro
        private void zerarFormulario()
        {
            id_contato_selecionado = null;

            //Zerar Campos
            txtNome.Text = string.Empty;
            txtEmail.Text = "";
            mskTelefone.Text = "";

            txtNome.Focus();
            tsbExcluir.Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            zerarFormulario();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            excluirContato();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            excluirContato();
        }
        //Deletar Contato
        private void excluirContato()
        {

            try
            {
                DialogResult conf = MessageBox.Show("Tem Certeza que deseja excluir o Registro",
                                                   "tem certeza?",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);
                if (conf == DialogResult.Yes)
                {
                    //criar conexão com MySQL
                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conexao;

                    cmd.CommandText = "DELETE FROM contatos WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Contato Exclido com Sucesso!!!",
                                    "Sucesso!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    carregarContatos();
                    zerarFormulario();

                }




            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                               "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }

        }
    }
}
