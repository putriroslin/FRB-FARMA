namespace FRB_Farma
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labellogin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.BackColor = System.Drawing.Color.Transparent;
            this.labellogin.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogin.ForeColor = System.Drawing.Color.Coral;
            this.labellogin.Location = new System.Drawing.Point(549, 119);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(148, 60);
            this.labellogin.TabIndex = 0;
            this.labellogin.Text = "Login";
            this.labellogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.labelPassword);
            this.groupBox1.Controls.Add(this.labelUsername);
            this.groupBox1.Controls.Add(this.TbUsername);
            this.groupBox1.Controls.Add(this.TbPassword);
            this.groupBox1.Location = new System.Drawing.Point(307, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(84, 251);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(79, 152);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(120, 29);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(79, 44);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(124, 29);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TbUsername
            // 
            this.TbUsername.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsername.Location = new System.Drawing.Point(84, 75);
            this.TbUsername.Multiline = true;
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(505, 41);
            this.TbUsername.TabIndex = 1;
            this.TbUsername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TbPassword
            // 
            this.TbPassword.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.Location = new System.Drawing.Point(84, 180);
            this.TbPassword.Multiline = true;
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(505, 43);
            this.TbPassword.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1242, 717);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labellogin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "FRB FARMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button btnLogin;
    }
}

