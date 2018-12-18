using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Registro
{
    public static class Validations
    {
        
        //Valida se realmente deseja encerrar a aplicação
        public static void ExitAppValidation(DialogResult messageBox)
        {
            DialogResult closeApp = new DialogResult();
            closeApp = messageBox;
            if (closeApp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        //==================================================================================//


        //Valida se os campos referentes aos dados pessoais estão preenchidos
        public static void NameAgeValidation(TextBox name, TextBox lastName, NumericUpDown field)
        {
            if (name.Text!=string.Empty)
            {
                if (lastName.Text!=string.Empty)
                {
                    if (field.Value == 0 || field.Value < 0)
                    {
                        MessageBox.Show("Campo \"Idade\" inválido!",
                            "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        field.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Campo \"Sobrenome\" inválido!",
                        "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lastName.Focus();                   
                }
            }
            else
            {
                MessageBox.Show("Campo \"Nome\" inválido!", 
                "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                name.Focus();
            }            
        }


        //==================================================================================//

        // Valida se o campo e-mail está preenchido corretamente
        public static void EmailValidation( TextBox email)
        {
            if (email.Text!=string.Empty)
            {
                ErrorProvider errorProvider = new ErrorProvider();
                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA]{2,9})$";
                if (Regex.IsMatch(email.Text, pattern))
                {
                    errorProvider.Clear();
                }
                else
                {
                    errorProvider.SetError(email, "Email inválido");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo \"E-mail\"");
                email.Focus();

            }


        }


        //==================================================================================//


        //valida se pelo menos um campo de contato foi preenchido
        public static void PhoneValidation(MaskedTextBox res, MaskedTextBox com, MaskedTextBox cel)
        {
            if (!res.MaskCompleted && !com.MaskCompleted && !cel.MaskCompleted)
            {
                MessageBox.Show("É necessário fornecer pelo menos um telefone para contato!", 
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FrmInsert frmInsert = new FrmInsert();
                frmInsert.Focus();
            }
        }

        //Valida se se deseja apagar dados
        
        public static void ClearValidation(TextBox tbxName, TextBox tbxLastName, TextBox tbxEmail, NumericUpDown nudAge, MaskedTextBox mtbCel, MaskedTextBox mtbCom, MaskedTextBox mtbRes)
        {
            try
            {
                DialogResult delete = new DialogResult();
                delete = MessageBox.Show("Deseja apagar todos os campos?",
                    "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete == DialogResult.Yes)
                {
                    tbxName.Clear();
                    tbxLastName.Clear();
                    tbxEmail.Clear();
                    nudAge.Value = 0;
                    mtbCel.Clear();
                    mtbCom.Clear();
                    mtbRes.Clear();

                    tbxName.Focus();
                }
                return;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }




            //Metodo para apagar dados e metodo para alterar dados
        }

    }
}
