namespace Lokaverkefni
{
    partial class Main
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
            this.txtMainUsername = new System.Windows.Forms.TextBox();
            this.txtMainPassword = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btMainRetrive = new System.Windows.Forms.Button();
            this.btMainLogin = new System.Windows.Forms.Button();
            this.btMainRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMainUsername
            // 
            this.txtMainUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainUsername.Location = new System.Drawing.Point(160, 85);
            this.txtMainUsername.Name = "txtMainUsername";
            this.txtMainUsername.Size = new System.Drawing.Size(100, 22);
            this.txtMainUsername.TabIndex = 23;
            // 
            // txtMainPassword
            // 
            this.txtMainPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainPassword.Location = new System.Drawing.Point(160, 147);
            this.txtMainPassword.Name = "txtMainPassword";
            this.txtMainPassword.Size = new System.Drawing.Size(100, 22);
            this.txtMainPassword.TabIndex = 22;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(62, 147);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(76, 16);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "Password";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(128, 35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 16);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Movie database";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(62, 85);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 16);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Username";
            // 
            // btMainRetrive
            // 
            this.btMainRetrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainRetrive.Location = new System.Drawing.Point(254, 219);
            this.btMainRetrive.Name = "btMainRetrive";
            this.btMainRetrive.Size = new System.Drawing.Size(125, 50);
            this.btMainRetrive.TabIndex = 18;
            this.btMainRetrive.Text = "Retrive information";
            this.btMainRetrive.UseVisualStyleBackColor = true;
            // 
            // btMainLogin
            // 
            this.btMainLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainLogin.Location = new System.Drawing.Point(16, 219);
            this.btMainLogin.Name = "btMainLogin";
            this.btMainLogin.Size = new System.Drawing.Size(113, 50);
            this.btMainLogin.TabIndex = 17;
            this.btMainLogin.Text = "Sign in with a user account";
            this.btMainLogin.UseVisualStyleBackColor = true;
            // 
            // btMainRegister
            // 
            this.btMainRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainRegister.Location = new System.Drawing.Point(135, 219);
            this.btMainRegister.Name = "btMainRegister";
            this.btMainRegister.Size = new System.Drawing.Size(113, 50);
            this.btMainRegister.TabIndex = 16;
            this.btMainRegister.Text = "Register a new account";
            this.btMainRegister.UseVisualStyleBackColor = true;
            this.btMainRegister.Click += new System.EventHandler(this.btMainRegister_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(393, 313);
            this.Controls.Add(this.txtMainUsername);
            this.Controls.Add(this.txtMainPassword);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btMainRetrive);
            this.Controls.Add(this.btMainLogin);
            this.Controls.Add(this.btMainRegister);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtMainUsername;
        internal System.Windows.Forms.TextBox txtMainPassword;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btMainRetrive;
        internal System.Windows.Forms.Button btMainLogin;
        internal System.Windows.Forms.Button btMainRegister;
    }
}

