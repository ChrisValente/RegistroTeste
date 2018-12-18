using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult exit = MessageBox.Show("Desejar sair do programa?", 
                "Sair!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Validations.ExitAppValidation(exit);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                FrmInsert frmInsert = new FrmInsert();
                frmInsert.Show();
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsult frmConsult = new FrmConsult();
                frmConsult.Show();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
