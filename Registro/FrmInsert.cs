using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;


namespace Registro
{
    public partial class FrmInsert : Form
    {
        public FrmInsert()
        {
            InitializeComponent();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbxName.Text != string.Empty || tbxLastName.Text != string.Empty)
                {
                    var exit = MessageBox.Show("Deseja sair sem salvar?", 
                        "Sair!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (exit == DialogResult.Yes)
                    {
                        this.Dispose();
                        this.Close();
                    }
                }
                else { this.Close(); }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }


        //==================================================================================//


        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                //TODO CORRIGIR ERRO QUE PERMITE DADOS SEREM SALVOS SEM O NUMERO DO CELULAR

                Validations.NameAgeValidation(tbxName, tbxLastName, nudAge);
                if (nudAge.Value!=0)
                {
                    Validations.EmailValidation(tbxEmail);
                    if (tbxEmail.Text != string.Empty)
                    {
                        Validations.PhoneValidation(mtbRes, mtbCom, mtbCel);
                        
                        //Salva Nome e Sobrenome no banco com as primeiras letras maiúsculas
                        CultureInfo ci = Thread.CurrentThread.CurrentCulture;
                        TextInfo ti = ci.TextInfo;

                        string name = ti.ToTitleCase(tbxName.Text);
                        string lastName = ti.ToTitleCase(tbxLastName.Text);
                        string email = tbxEmail.Text;
                        string phone = mtbRes.Text;
                        string commercialPhone = mtbCom.Text;
                        string celphone = mtbCel.Text;
                        int age = Convert.ToInt32(nudAge.Value);

                        ConnectionDB insert = new ConnectionDB();
                        insert.insertData(name, lastName, age, phone, commercialPhone, celphone, email);
                    }
                }

                
               

                

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //==================================================================================//


        private void btnErase_Click(object sender, EventArgs e)
        {
            //Valida se deseja apagar dados 
            Validations.ClearValidation(tbxName, tbxLastName, tbxEmail, nudAge, mtbCel, mtbCom, mtbRes);
        }
    }
}
