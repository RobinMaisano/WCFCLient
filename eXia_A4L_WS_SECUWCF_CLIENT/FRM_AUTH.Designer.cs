namespace eXia_A4L_WS_SECUWCF_CLIENT
{
    partial class frm_auth
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_information = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_service = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fileContent = new System.Windows.Forms.TextBox();
            this.btn_addFile = new System.Windows.Forms.Button();
            this.checkBox_resestFile = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_information
            // 
            this.txt_information.Location = new System.Drawing.Point(171, 235);
            this.txt_information.Multiline = true;
            this.txt_information.Name = "txt_information";
            this.txt_information.ReadOnly = true;
            this.txt_information.Size = new System.Drawing.Size(133, 62);
            this.txt_information.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Information";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(171, 161);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(100, 20);
            this.txt_login.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(171, 188);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 4;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Service";
            // 
            // txt_service
            // 
            this.txt_service.Location = new System.Drawing.Point(341, 161);
            this.txt_service.Name = "txt_service";
            this.txt_service.Size = new System.Drawing.Size(100, 20);
            this.txt_service.TabIndex = 7;
            this.txt_service.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "File Name";
            // 
            // txt_fileName
            // 
            this.txt_fileName.Location = new System.Drawing.Point(540, 161);
            this.txt_fileName.Name = "txt_fileName";
            this.txt_fileName.Size = new System.Drawing.Size(100, 20);
            this.txt_fileName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "File Content";
            // 
            // txt_fileContent
            // 
            this.txt_fileContent.Location = new System.Drawing.Point(540, 188);
            this.txt_fileContent.Multiline = true;
            this.txt_fileContent.Name = "txt_fileContent";
            this.txt_fileContent.Size = new System.Drawing.Size(100, 70);
            this.txt_fileContent.TabIndex = 11;
            // 
            // btn_addFile
            // 
            this.btn_addFile.Location = new System.Drawing.Point(646, 235);
            this.btn_addFile.Name = "btn_addFile";
            this.btn_addFile.Size = new System.Drawing.Size(75, 23);
            this.btn_addFile.TabIndex = 13;
            this.btn_addFile.Text = "Add File";
            this.btn_addFile.UseVisualStyleBackColor = true;
            this.btn_addFile.Click += new System.EventHandler(this.btn_addFileClick);
            // 
            // checkBox_resestFile
            // 
            this.checkBox_resestFile.AutoSize = true;
            this.checkBox_resestFile.Location = new System.Drawing.Point(646, 212);
            this.checkBox_resestFile.Name = "checkBox_resestFile";
            this.checkBox_resestFile.Size = new System.Drawing.Size(92, 17);
            this.checkBox_resestFile.TabIndex = 14;
            this.checkBox_resestFile.Text = "Reset File List";
            this.checkBox_resestFile.UseVisualStyleBackColor = true;
            // 
            // frm_auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_resestFile);
            this.Controls.Add(this.btn_addFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_fileContent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_fileName);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_service);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_information);
            this.Name = "frm_auth";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_information;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_service;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fileContent;
        private System.Windows.Forms.Button btn_addFile;
        private System.Windows.Forms.CheckBox checkBox_resestFile;
    }
}

