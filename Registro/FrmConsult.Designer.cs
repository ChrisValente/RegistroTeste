namespace Registro
{
    partial class FrmConsult
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
            this.btnExit3 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.dgvScreen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit3
            // 
            this.btnExit3.Location = new System.Drawing.Point(713, 415);
            this.btnExit3.Name = "btnExit3";
            this.btnExit3.Size = new System.Drawing.Size(75, 23);
            this.btnExit3.TabIndex = 0;
            this.btnExit3.Text = "SAIR";
            this.btnExit3.UseVisualStyleBackColor = true;
            this.btnExit3.Click += new System.EventHandler(this.btnExit3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(621, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETAR";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(531, 415);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 2;
            this.btnAlter.Text = "ALTERAR";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // dgvScreen
            // 
            this.dgvScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScreen.Location = new System.Drawing.Point(12, 24);
            this.dgvScreen.Name = "dgvScreen";
            this.dgvScreen.Size = new System.Drawing.Size(776, 376);
            this.dgvScreen.TabIndex = 3;
            // 
            // FrmConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvScreen);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit3);
            this.Name = "FrmConsult";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.DataGridView dgvScreen;
    }
}