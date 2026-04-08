namespace projet_restau
{
    partial class login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            user_id_in_login = new TextBox();
            password_in_login = new TextBox();
            label4 = new Label();
            bouton_signin_filogin = new Button();
            retour = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 41);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 0;
            label1.Text = "RESTAUARNT UNIVERSITAIRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 117);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "USER ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 168);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "PASSWORD";
            // 
            // user_id_in_login
            // 
            user_id_in_login.Location = new Point(160, 110);
            user_id_in_login.Name = "user_id_in_login";
            user_id_in_login.Size = new Size(202, 27);
            user_id_in_login.TabIndex = 3;
            // 
            // password_in_login
            // 
            password_in_login.Location = new Point(160, 168);
            password_in_login.Name = "password_in_login";
            password_in_login.Size = new Size(202, 27);
            password_in_login.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 250);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 5;
            label4.Text = "don't have an account?";
            // 
            // bouton_signin_filogin
            // 
            bouton_signin_filogin.Location = new Point(268, 250);
            bouton_signin_filogin.Name = "bouton_signin_filogin";
            bouton_signin_filogin.Size = new Size(94, 29);
            bouton_signin_filogin.TabIndex = 6;
            bouton_signin_filogin.Text = "sign in";
            bouton_signin_filogin.UseVisualStyleBackColor = true;
            // 
            // retour
            // 
            retour.Location = new Point(21, 37);
            retour.Name = "retour";
            retour.Size = new Size(70, 29);
            retour.TabIndex = 7;
            retour.Text = "<--";
            retour.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 450);
            Controls.Add(retour);
            Controls.Add(bouton_signin_filogin);
            Controls.Add(label4);
            Controls.Add(password_in_login);
            Controls.Add(user_id_in_login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox user_id_in_login;
        private TextBox password_in_login;
        private Label label4;
        private Button bouton_signin_filogin;
        private Button retour;
    }
}