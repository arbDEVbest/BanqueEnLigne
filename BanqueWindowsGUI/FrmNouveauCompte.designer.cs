namespace BanqueWindowsGUI
{
    partial class FrmNouveauCompte
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codeBanqueLabel;
            System.Windows.Forms.Label codeGuichetLabel;
            System.Windows.Forms.Label numeroCompteLabel;
            System.Windows.Forms.Label cléRIBLabel;
            System.Windows.Forms.Label libellécompteLabel;
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAbandonner = new System.Windows.Forms.Button();
            this.gbCompteExterne = new System.Windows.Forms.GroupBox();
            this.codeBanqueTextBox = new System.Windows.Forms.TextBox();
            this.codeGuichetTextBox = new System.Windows.Forms.TextBox();
            this.numeroCompteTextBox = new System.Windows.Forms.TextBox();
            this.cleRIBTextBox = new System.Windows.Forms.TextBox();
            this.libellécompteTextBox = new System.Windows.Forms.TextBox();
            this.ErpSaisi = new System.Windows.Forms.ErrorProvider(this.components);
            codeBanqueLabel = new System.Windows.Forms.Label();
            codeGuichetLabel = new System.Windows.Forms.Label();
            numeroCompteLabel = new System.Windows.Forms.Label();
            cléRIBLabel = new System.Windows.Forms.Label();
            libellécompteLabel = new System.Windows.Forms.Label();
            this.gbCompteExterne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErpSaisi)).BeginInit();
            this.SuspendLayout();
            // 
            // codeBanqueLabel
            // 
            codeBanqueLabel.AutoSize = true;
            codeBanqueLabel.Location = new System.Drawing.Point(20, 30);
            codeBanqueLabel.Name = "codeBanqueLabel";
            codeBanqueLabel.Size = new System.Drawing.Size(75, 13);
            codeBanqueLabel.TabIndex = 0;
            codeBanqueLabel.Text = "Code Banque:";
            // 
            // codeGuichetLabel
            // 
            codeGuichetLabel.AutoSize = true;
            codeGuichetLabel.Location = new System.Drawing.Point(20, 56);
            codeGuichetLabel.Name = "codeGuichetLabel";
            codeGuichetLabel.Size = new System.Drawing.Size(75, 13);
            codeGuichetLabel.TabIndex = 2;
            codeGuichetLabel.Text = "Code Guichet:";
            // 
            // numeroCompteLabel
            // 
            numeroCompteLabel.AutoSize = true;
            numeroCompteLabel.Location = new System.Drawing.Point(20, 82);
            numeroCompteLabel.Name = "numeroCompteLabel";
            numeroCompteLabel.Size = new System.Drawing.Size(86, 13);
            numeroCompteLabel.TabIndex = 4;
            numeroCompteLabel.Text = "Numero Compte:";
            // 
            // cléRIBLabel
            // 
            cléRIBLabel.AutoSize = true;
            cléRIBLabel.Location = new System.Drawing.Point(20, 108);
            cléRIBLabel.Name = "cléRIBLabel";
            cléRIBLabel.Size = new System.Drawing.Size(46, 13);
            cléRIBLabel.TabIndex = 6;
            cléRIBLabel.Text = "Clé RIB:";
            // 
            // libellécompteLabel
            // 
            libellécompteLabel.AutoSize = true;
            libellécompteLabel.Location = new System.Drawing.Point(20, 134);
            libellécompteLabel.Name = "libellécompteLabel";
            libellécompteLabel.Size = new System.Drawing.Size(40, 13);
            libellécompteLabel.TabIndex = 8;
            libellécompteLabel.Text = "Libellé:";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(12, 179);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(94, 23);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // btnAbandonner
            // 
            this.btnAbandonner.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbandonner.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbandonner.Location = new System.Drawing.Point(131, 179);
            this.btnAbandonner.Name = "btnAbandonner";
            this.btnAbandonner.Size = new System.Drawing.Size(91, 23);
            this.btnAbandonner.TabIndex = 11;
            this.btnAbandonner.Text = "Abandonner";
            this.btnAbandonner.UseVisualStyleBackColor = true;
            this.btnAbandonner.Click += new System.EventHandler(this.BtnAbandonner_Click);
            // 
            // gbCompteExterne
            // 
            this.gbCompteExterne.Controls.Add(codeBanqueLabel);
            this.gbCompteExterne.Controls.Add(this.codeBanqueTextBox);
            this.gbCompteExterne.Controls.Add(codeGuichetLabel);
            this.gbCompteExterne.Controls.Add(this.codeGuichetTextBox);
            this.gbCompteExterne.Controls.Add(numeroCompteLabel);
            this.gbCompteExterne.Controls.Add(this.numeroCompteTextBox);
            this.gbCompteExterne.Controls.Add(cléRIBLabel);
            this.gbCompteExterne.Controls.Add(this.cleRIBTextBox);
            this.gbCompteExterne.Controls.Add(libellécompteLabel);
            this.gbCompteExterne.Controls.Add(this.libellécompteTextBox);
            this.gbCompteExterne.Controls.Add(this.btnAbandonner);
            this.gbCompteExterne.Controls.Add(this.btnValider);
            this.gbCompteExterne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbCompteExterne.Location = new System.Drawing.Point(27, 26);
            this.gbCompteExterne.Name = "gbCompteExterne";
            this.gbCompteExterne.Size = new System.Drawing.Size(393, 228);
            this.gbCompteExterne.TabIndex = 0;
            this.gbCompteExterne.TabStop = false;
            this.gbCompteExterne.Text = "Références du compte Externe à ajouter";
            // 
            // codeBanqueTextBox
            // 
            this.codeBanqueTextBox.Location = new System.Drawing.Point(112, 27);
            this.codeBanqueTextBox.Name = "codeBanqueTextBox";
            this.codeBanqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeBanqueTextBox.TabIndex = 1;
            // 
            // codeGuichetTextBox
            // 
            this.codeGuichetTextBox.Location = new System.Drawing.Point(112, 53);
            this.codeGuichetTextBox.Name = "codeGuichetTextBox";
            this.codeGuichetTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeGuichetTextBox.TabIndex = 3;
            // 
            // numeroCompteTextBox
            // 
            this.numeroCompteTextBox.Location = new System.Drawing.Point(112, 79);
            this.numeroCompteTextBox.Name = "numeroCompteTextBox";
            this.numeroCompteTextBox.Size = new System.Drawing.Size(222, 20);
            this.numeroCompteTextBox.TabIndex = 5;
            this.numeroCompteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.numeroCompteTextBox_Validating);
            // 
            // cleRIBTextBox
            // 
            this.cleRIBTextBox.Location = new System.Drawing.Point(112, 105);
            this.cleRIBTextBox.Name = "cleRIBTextBox";
            this.cleRIBTextBox.Size = new System.Drawing.Size(47, 20);
            this.cleRIBTextBox.TabIndex = 7;
            // 
            // libellécompteTextBox
            // 
            this.libellécompteTextBox.Location = new System.Drawing.Point(112, 131);
            this.libellécompteTextBox.Name = "libellécompteTextBox";
            this.libellécompteTextBox.Size = new System.Drawing.Size(263, 20);
            this.libellécompteTextBox.TabIndex = 9;
            // 
            // ErpSaisi
            // 
            this.ErpSaisi.ContainerControl = this;
            // 
            // FrmNouveauCompte
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAbandonner;
            this.ClientSize = new System.Drawing.Size(455, 290);
            this.ControlBox = false;
            this.Controls.Add(this.gbCompteExterne);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmNouveauCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un nouveau compte de bénéficiaire ";
            this.Load += new System.EventHandler(this.FrmNouveauCompte_Load);
            this.gbCompteExterne.ResumeLayout(false);
            this.gbCompteExterne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErpSaisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

    
        private System.Windows.Forms.GroupBox gbCompteExterne;
        private System.Windows.Forms.Button btnAbandonner;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox codeBanqueTextBox;
        private System.Windows.Forms.TextBox codeGuichetTextBox;
        private System.Windows.Forms.TextBox numeroCompteTextBox;
        private System.Windows.Forms.TextBox cleRIBTextBox;
        private System.Windows.Forms.TextBox libellécompteTextBox;
        private System.Windows.Forms.ErrorProvider ErpSaisi;
    }
}