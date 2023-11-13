namespace QuizPertemuan14
{
    partial class FormUtama
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
            this.panelBG = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtKS = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelKS = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.panelBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBG
            // 
            this.panelBG.BackColor = System.Drawing.Color.Silver;
            this.panelBG.Controls.Add(this.btnLogin);
            this.panelBG.Controls.Add(this.btnExit);
            this.panelBG.Controls.Add(this.txtKS);
            this.panelBG.Controls.Add(this.txtEmail);
            this.panelBG.Controls.Add(this.labelKS);
            this.panelBG.Controls.Add(this.labelEmail);
            this.panelBG.Controls.Add(this.PBLogo);
            this.panelBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBG.Location = new System.Drawing.Point(0, 0);
            this.panelBG.Name = "panelBG";
            this.panelBG.Size = new System.Drawing.Size(800, 450);
            this.panelBG.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumBlue;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(481, 285);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 38);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(372, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtKS
            // 
            this.txtKS.Location = new System.Drawing.Point(372, 224);
            this.txtKS.Multiline = true;
            this.txtKS.Name = "txtKS";
            this.txtKS.PasswordChar = '*';
            this.txtKS.Size = new System.Drawing.Size(203, 22);
            this.txtKS.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(372, 196);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // labelKS
            // 
            this.labelKS.AutoSize = true;
            this.labelKS.Location = new System.Drawing.Point(279, 227);
            this.labelKS.Name = "labelKS";
            this.labelKS.Size = new System.Drawing.Size(72, 16);
            this.labelKS.TabIndex = 2;
            this.labelKS.Text = "Kata Sandi";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(279, 196);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 16);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "E-Mail";
            // 
            // PBLogo
            // 
            this.PBLogo.BackgroundImage = global::QuizPertemuan14.Properties.Resources.Screenshot_2023_11_13_202117_removebg_preview;
            this.PBLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBLogo.Location = new System.Drawing.Point(323, 12);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(168, 146);
            this.PBLogo.TabIndex = 0;
            this.PBLogo.TabStop = false;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Login";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.panelBG.ResumeLayout(false);
            this.panelBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBG;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtKS;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelKS;
        private System.Windows.Forms.Label labelEmail;
    }
}

