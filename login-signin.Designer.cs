namespace projet_restau
{
    partial class login_signin
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
            bouton_login = new Button();
            bouton_signin = new Button();
            retour = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 93);
            label1.Name = "label1";
            label1.Size = new Size(274, 20);
            label1.TabIndex = 0;
            label1.Text = "BRING JOY THROUGH DELICIOUS FOOD";
            // 
            // bouton_login
            // 
            bouton_login.Location = new Point(159, 202);
            bouton_login.Name = "bouton_login";
            bouton_login.Size = new Size(94, 29);
            bouton_login.TabIndex = 1;
            bouton_login.Text = "LOG IN";
            bouton_login.UseVisualStyleBackColor = true;
            // 
            // bouton_signin
            // 
            bouton_signin.Location = new Point(159, 297);
            bouton_signin.Name = "bouton_signin";
            bouton_signin.Size = new Size(94, 29);
            bouton_signin.TabIndex = 2;
            bouton_signin.Text = "SIGN IN";
            bouton_signin.UseVisualStyleBackColor = true;
            // 
            // retour
            // 
            retour.Location = new Point(23, 33);
            retour.Name = "retour";
            retour.Size = new Size(63, 29);
            retour.TabIndex = 3;
            retour.Text = "<--";
            retour.UseVisualStyleBackColor = true;
            // 
            // login_signin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 450);
            Controls.Add(retour);
            Controls.Add(bouton_signin);
            Controls.Add(bouton_login);
            Controls.Add(label1);
            Name = "login_signin";
            Text = "login_signin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bouton_login;
        private Button bouton_signin;
        private Button retour;
    }
}