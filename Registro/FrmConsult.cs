using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Registro
{
    public partial class FrmConsult : Form
    {
        public FrmConsult()
        {
            InitializeComponent();

            try
            {
                ConnectionDB connection = new ConnectionDB();
                connection.getData(dgvScreen);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Sai da janela de exibição dos dados
        private void btnExit3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult exitWindow = new DialogResult();
                exitWindow = MessageBox.Show("Deseja sair?", 
                "Sair!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (exitWindow==DialogResult.Yes)
                {
                    this.Dispose();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        //Deleta os dados do Grid
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionDB conDelete = new ConnectionDB();
                conDelete.deleteData(dgvScreen);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            //Implementar código para alterar dados
            try
            {
                ConnectionDB connDB = new ConnectionDB();
                connDB.updateData(dgvScreen);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
