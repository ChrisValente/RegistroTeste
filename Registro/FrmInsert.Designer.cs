namespace Registro
{
    partial class FrmInsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbxContact = new System.Windows.Forms.GroupBox();
            this.mtbCel = new System.Windows.Forms.MaskedTextBox();
            this.mtbCom = new System.Windows.Forms.MaskedTextBox();
            this.mtbRes = new System.Windows.Forms.MaskedTextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.gbxContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Nome:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 68);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Sobrenome:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(20, 101);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 13);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Idade:";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(6, 32);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(65, 13);
            this.lblRes.TabIndex = 4;
            this.lblRes.Text = "Residencial:";
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(6, 82);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(56, 13);
            this.lblCom.TabIndex = 5;
            this.lblCom.Text = "Comercial:";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(240, 32);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(42, 13);
            this.lblCel.TabIndex = 6;
            this.lblCel.Text = "Celular:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(240, 82);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail:";
            // 
            // gbxContact
            // 
            this.gbxContact.Controls.Add(this.tbxEmail);
            this.gbxContact.Controls.Add(this.mtbCel);
            this.gbxContact.Controls.Add(this.mtbCom);
            this.gbxContact.Controls.Add(this.mtbRes);
            this.gbxContact.Controls.Add(this.lblRes);
            this.gbxContact.Controls.Add(this.lblEmail);
            this.gbxContact.Controls.Add(this.lblCom);
            this.gbxContact.Controls.Add(this.lblCel);
            this.gbxContact.Location = new System.Drawing.Point(23, 145);
            this.gbxContact.Name = "gbxContact";
            this.gbxContact.Size = new System.Drawing.Size(457, 121);
            this.gbxContact.TabIndex = 3;
            this.gbxContact.TabStop = false;
            this.gbxContact.Text = "Contatos:";
            // 
            // mtbCel
            // 
            this.mtbCel.Location = new System.Drawing.Point(285, 29);
            this.mtbCel.Mask = "(999) 00000-0000";
            this.mtbCel.Name = "mtbCel";
            this.mtbCel.Size = new System.Drawing.Size(100, 20);
            this.mtbCel.TabIndex = 2;
            // 
            // mtbCom
            // 
            this.mtbCom.Location = new System.Drawing.Point(77, 79);
            this.mtbCom.Mask = "(999) 0000-0000";
            this.mtbCom.Name = "mtbCom";
            this.mtbCom.Size = new System.Drawing.Size(119, 20);
            this.mtbCom.TabIndex = 1;
            // 
            // mtbRes
            // 
            this.mtbRes.Location = new System.Drawing.Point(77, 29);
            this.mtbRes.Mask = "(999) 0000-0000";
            this.mtbRes.Name = "mtbRes";
            this.mtbRes.Size = new System.Drawing.Size(119, 20);
            this.mtbRes.TabIndex = 0;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(90, 32);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(211, 20);
            this.tbxName.TabIndex = 0;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(90, 65);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(211, 20);
            this.tbxLastName.TabIndex = 1;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(90, 99);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(46, 20);
            this.nudAge.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(324, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SALVAR";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(243, 283);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(75, 23);
            this.btnErase.TabIndex = 5;
            this.btnErase.Text = "APAGAR";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(405, 283);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(75, 23);
            this.btnExit2.TabIndex = 6;
            this.btnExit2.Text = "SAIR";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(285, 79);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(137, 20);
            this.tbxEmail.TabIndex = 3;
            // 
            // FrmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 318);
            this.Controls.Add(this.btnExit2);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.gbxContact);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Name = "FrmInsert";
            this.Text = "Área de Cadastro";
            this.gbxContact.ResumeLayout(false);
            this.gbxContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gbxContact;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.MaskedTextBox mtbCel;
        private System.Windows.Forms.MaskedTextBox mtbCom;
        private System.Windows.Forms.MaskedTextBox mtbRes;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.TextBox tbxEmail;
    }
}