using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Data;
using System.Security.Cryptography.X509Certificates;


namespace sistema_escola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void btnListar_Click(object sender, EventArgs e)
        {



            string conexaoBanco = "Server=localHost; Database=escola; Uid=root; pwd=''";
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);

            conexao.Open();

            string sql = "SELECT * FROM alunos";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conexao);

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            dgvAlunos.DataSource = dataTable;

            dgvAlunos.AutoResizeColumns();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                string nome = txtNome.Text;
                string telefone = txtTelefone.Text;
                string curso = txtCurso.Text;
                string nasc = txtNascimento.Text;

                DateTime dataMySqlFormat = Convert.ToDateTime(nasc);
                string dataNascimentoFormatada = dataMySqlFormat.ToString("yyyy-MM-dd");

                string conexaoBanco = "Server=localHost; Database=escola; Uid=root; pwd=''";
                MySqlConnection conexao = new MySqlConnection(conexaoBanco);

                conexao.Open();

                string insert = "INSERT INTO alunos (nome, telefone, curso, nascimento) VALUES (@nome, @telefone, @curso, @nasc)";

                MySqlCommand insertAluno = new MySqlCommand(insert, conexao);

                insertAluno.Parameters.AddWithValue("@nome", nome);
                insertAluno.Parameters.AddWithValue("@telefone", telefone);
                insertAluno.Parameters.AddWithValue("@curso", curso);
                insertAluno.Parameters.AddWithValue("@nasc", dataNascimentoFormatada);


                int contLines = Convert.ToInt32(insertAluno.ExecuteNonQuery());

                if (contLines > 0)
                {

                    MessageBox.Show("Usuário cadastrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("Não foi possível cadastrar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtCurso.Text = "";
            txtTelefone.Text = "";
            txtNome.Text = "";
            txtNascimento.Text = "";


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string telefone = txtTelefone.Text;
                string curso = txtCurso.Text;
                string nasc = txtNascimento.Text;

                DateTime dataMySqlFormat = Convert.ToDateTime(nasc);
                string dataNascimentoFormatada = dataMySqlFormat.ToString("yyyy-MM-dd");

                string conexaoBanco = "Server=localHost; Database=escola; Uid=root; pwd=''";
                MySqlConnection conexao = new MySqlConnection(conexaoBanco);

                conexao.Open();


                string selectId = "SELECT id FROM alunos WHERE nome = @nome";
                MySqlCommand selectIdAluno = new MySqlCommand(selectId, conexao);
                selectIdAluno.Parameters.AddWithValue("@nome", nome);

                int result = Convert.ToInt32(selectIdAluno.ExecuteScalar());

                if (result > 0)
                {
                    int idAluno = Convert.ToInt32(result);
                    
                    string update = "UPDATE alunos SET nome = @nome, telefone = @telefone, curso = @curso, nascimento = @nasc WHERE id = @id";
                    MySqlCommand updateAluno = new MySqlCommand(update, conexao);

                    updateAluno.Parameters.AddWithValue("@nome", nome);
                    updateAluno.Parameters.AddWithValue("@telefone", telefone);
                    updateAluno.Parameters.AddWithValue("@curso", curso);
                    updateAluno.Parameters.AddWithValue("@nasc", dataNascimentoFormatada);
                    updateAluno.Parameters.AddWithValue("@id", idAluno);

                    int contLines = updateAluno.ExecuteNonQuery();

                    if (contLines > 0)
                    {
                        MessageBox.Show("Dados alterados!", "Atualização de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível editar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dgvAlunos.CurrentRow.Cells[1].Value.ToString();
            txtTelefone.Text = dgvAlunos.CurrentRow.Cells[2].Value.ToString();
            txtCurso.Text = dgvAlunos.CurrentRow.Cells[3].Value.ToString();

            string dataNascimento = dgvAlunos.CurrentRow.Cells[4].Value.ToString();



            txtNascimento.Text = dataNascimento;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try { 
                string conexaoBanco = "Server=localHost; Database=escola; Uid=root; pwd=''";
                MySqlConnection conexao = new MySqlConnection(conexaoBanco);

                conexao.Open();


                string delete = "DELETE FROM alunos WHERE nome = @nome";
                MySqlCommand selectIdAluno = new MySqlCommand(delete, conexao);
                selectIdAluno.Parameters.AddWithValue("@nome", dgvAlunos.CurrentRow.Cells[1].Value.ToString());

                int result = Convert.ToInt32(selectIdAluno.ExecuteNonQuery());

                if (result > 0)
                {

                    MessageBox.Show("Dados deletados!", "Atualização de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}
    }
}

