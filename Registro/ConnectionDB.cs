using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Registro
{
    public class ConnectionDB
    {
        public string name { get; set; }
        public string lastName { get; private set; }
        public int age { get; private set; }
        public string phone { get; private set; }
        public string commercialPhone { get; private set; }
        public string celphone { get; private set; }
        public string email { get; private set; }

        //Persiste os dados no DB     
        public void insertData(string name, string lastName, int age, string phone, string commercialPhone, string celphone, string email )
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=CERES-PC\SQLEXPRESS;
                                          Initial Catalog=POO_TESTE;Integrated Security=True";

            string insertCli = "INSERT INTO CLIENTE(NOME, SOBRENOME, IDADE) VALUES (@NOME, @SOBRENOME, @IDADE); SELECT SCOPE_IDENTITY();";
            string insertCon = "INSERT INTO CONTATOS(ID_CLIENTE, TEL_RES, TEL_COM, CELULAR, EMAIL) VALUES (@ID_CLIENTE, @TEL_RES, @TEL_COM, @CELULAR, @EMAIL);";

            connection.Open();

            SqlCommand cmd01 = new SqlCommand(insertCli, connection);
            SqlCommand cmd02 = new SqlCommand(insertCon, connection);

            cmd01.Parameters.AddWithValue("@NOME",name);
            cmd01.Parameters.AddWithValue("@SOBRENOME", lastName);
            cmd01.Parameters.AddWithValue("@IDADE",age);
            int fkCli = Convert.ToInt32(cmd01.ExecuteScalar());

            cmd02.Parameters.AddWithValue("@ID_CLIENTE", fkCli);
            cmd02.Parameters.AddWithValue("@TEL_RES",phone);
            cmd02.Parameters.AddWithValue("@TEL_COM", commercialPhone);
            cmd02.Parameters.AddWithValue("@CELULAR",celphone);
            cmd02.Parameters.AddWithValue("@EMAIL", email);
            

            SqlTransaction tx = null;

            try
            {
                tx = connection.BeginTransaction();

                cmd01.Transaction = tx;
                cmd02.Transaction = tx;

                cmd02.ExecuteNonQuery();

                tx.Commit();

                MessageBox.Show("Cadastro salvo com sucesso!");
            }
            catch (Exception ex)
            {
                if (tx != null)
                {
                    tx.Rollback();
                }

                MessageBox.Show("Erro ao salvar!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed) { connection.Close(); };
            }

        }

        //==================================================================================================//

        //Busca os dados no DB e Preenche o grid  
        public void getData(DataGridView grid)
        {
            string conString = @"Data Source=CERES-PC\SQLEXPRESS;
                                          Initial Catalog=POO_TESTE;Integrated Security=True";
            string selectData = "SELECT CLI.NOME, CLI.SOBRENOME, CLI.IDADE, CON.EMAIL, CON.CELULAR, CON.TEL_RES, CON.TEL_COM FROM CLIENTE CLI INNER JOIN CONTATOS CON ON CLI.IDCLIENTE = CON.ID_CLIENTE;";

            SqlConnection connection = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand(selectData, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            connection.Open();
            cmd.ExecuteNonQuery();

            adapter.SelectCommand = cmd;
            adapter.Fill(ds);
            grid.DataSource = ds;
            grid.DataMember = ds.Tables[0].TableName;

            connection.Close();
        }

        //==================================================================================================//

        //Atualiza os dados no DB
        public void updateData(DataGridView grid)
        {
            DialogResult dr = new DialogResult();

            dr = MessageBox.Show("Deseja salvar alterações?", "Alterar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string conString = @"Data Source=CERES-PC\SQLEXPRESS;
                                          Initial Catalog=POO_TESTE;Integrated Security=True";

                string getName = grid.CurrentRow.Cells["NOME"].Value.ToString();
                string getLastName = grid.CurrentRow.Cells["SOBRENOME"].Value.ToString();
                string getEmail = grid.CurrentRow.Cells["EMAIL"].Value.ToString();
                string getAge = grid.CurrentRow.Cells["IDADE"].Value.ToString();
                string getCelphone = grid.CurrentRow.Cells["CELULAR"].Value.ToString();
                string getPhone = grid.CurrentRow.Cells["TEL_RES"].Value.ToString();
                string getComPhone = grid.CurrentRow.Cells["TEL_COM"].Value.ToString();
                int Fk;
                int pk;

                string selectFk = $"SELECT ID_CLIENTE FROM CONTATOS INNER JOIN CLIENTE ON ID_CLIENTE = IDCLIENTE WHERE NOME = '{getName}' AND SOBRENOME = '{getLastName}' AND EMAIL = '{getEmail}';";
                string selectPk = $"SELECT CLI.IDCLIENTE FROM CLIENTE CLI INNER JOIN CONTATOS CON ON CLI.IDCLIENTE = CON.ID_CLIENTE WHERE NOME = '{getName}' AND SOBRENOME = '{getLastName}' AND EMAIL = '{getEmail}';";

                SqlConnection connection = new SqlConnection(conString);
                SqlCommand cmdSelectFk = new SqlCommand(selectFk, connection);
                SqlCommand cmdPkSelect = new SqlCommand(selectPk, connection);

                connection.Open();

                Fk = Convert.ToInt32(cmdSelectFk.ExecuteScalar());
                pk = Convert.ToInt32(cmdPkSelect.ExecuteNonQuery());
                //todo: Verificar query funcionando parcialmente e inserir transaction
                string updateCon = $"UPDATE CONTATOS SET EMAIL = '{getEmail}', CELULAR = '{getCelphone}', TEL_RES = '{getPhone}', TEL_COM = '{getComPhone}' WHERE ID_CLIENTE ={Fk}; ";
                string updateCli = $"UPDATE CLIENTE SET NOME = '{getName}', SOBRENOME = '{getLastName}', IDADE = '{getAge}' WHERE IDCLIENTE = {pk};";
                string selectData = "SELECT CLI.NOME, CLI.SOBRENOME, CLI.IDADE, CON.EMAIL, CON.CELULAR, CON.TEL_RES, CON.TEL_COM FROM CLIENTE CLI INNER JOIN CONTATOS CON ON CLI.IDCLIENTE = CON.ID_CLIENTE;";

                
                SqlCommand cmdUpdCon = new SqlCommand(updateCon, connection);
                SqlCommand cmdUpdCli = new SqlCommand(updateCli, connection);
                SqlCommand cmdSelect = new SqlCommand(selectData, connection);

                cmdUpdCon.ExecuteNonQuery();
                cmdUpdCli.ExecuteNonQuery();
                

                MessageBox.Show($"Dados alterados com sucesso!: {getName},{getLastName},{getAge},{getEmail}");

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                adapter.SelectCommand = cmdSelect;
                adapter.Fill(ds);

                grid.DataSource = ds;
                grid.DataMember = ds.Tables[0].TableName;

                if (connection.State != ConnectionState.Closed) { connection.Close(); }
            }
        }

        //==================================================================================================//

        //Deleta os dados do DB
        public void deleteData(DataGridView grid)
        {
            DialogResult dialog = MessageBox.Show("Deseja realmente deletar o contato selecionado?","Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                string conString = @"Data Source=CERES-PC\SQLEXPRESS;
                                          Initial Catalog=POO_TESTE;Integrated Security=True";
                
                string getNameCli = grid.CurrentRow.Cells["NOME"].Value.ToString();
                string getLastNameCli = grid.CurrentRow.Cells["SOBRENOME"].Value.ToString();
                string getEmail = grid.CurrentRow.Cells["EMAIL"].Value.ToString();
                int Fk;

                string selectFk = $"SELECT CON.ID_CLIENTE FROM CONTATOS CON INNER JOIN CLIENTE CLI ON CON.ID_CLIENTE = CLI.IDCLIENTE WHERE NOME = '{getNameCli}' AND SOBRENOME = '{getLastNameCli}' AND EMAIL = '{getEmail}'";

                SqlConnection connection = new SqlConnection(conString);
                SqlCommand cmdSelectFk = new SqlCommand(selectFk, connection);
                              
                connection.Open();
                Fk = Convert.ToInt32(cmdSelectFk.ExecuteScalar());

                //MessageBox.Show(Fk.ToString());

                string deleteAll = $"DELETE CONTATOS FROM CONTATOS INNER JOIN CLIENTE ON ID_CLIENTE = IDCLIENTE WHERE ID_CLIENTE = {Fk};";                
                string selectData = "SELECT CLI.NOME, CLI.SOBRENOME, CLI.IDADE, CON.EMAIL, CON.CELULAR, CON.TEL_RES, CON.TEL_COM FROM CLIENTE CLI INNER JOIN CONTATOS CON ON CLI.IDCLIENTE = CON.ID_CLIENTE;";

                SqlCommand cmdDelAll = new SqlCommand(deleteAll, connection);  
                SqlCommand cmdSelect = new SqlCommand(selectData, connection);

                cmdDelAll.ExecuteNonQuery();
                MessageBox.Show("Contato excluído com sucesso!");
               
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                
                adapter.SelectCommand = cmdSelect;
                adapter.Fill(ds);
                grid.DataSource = ds;
                grid.DataMember = ds.Tables[0].TableName;

                connection.Close();
            }
        }


    }
}
