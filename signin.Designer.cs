namespace projet_restau
{
    partial class signin
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            user_name = new TextBox();
            student_id = new TextBox();
            email = new TextBox();
            password = new TextBox();
            confirm_password = new TextBox();
            bouton_signin = new Button();
            retour = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 104);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 152);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Student_id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 199);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 256);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 312);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 4;
            label5.Text = "Confirm Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(106, 34);
            label6.Name = "label6";
            label6.Size = new Size(204, 20);
            label6.TabIndex = 5;
            label6.Text = "RESTAURANT UNIVERSITAIRE";
            // 
            // user_name
            // 
            user_name.Location = new Point(213, 97);
            user_name.Name = "user_name";
            user_name.Size = new Size(125, 27);
            user_name.TabIndex = 6;
            // 
            // student_id
            // 
            student_id.Location = new Point(213, 145);
            student_id.Name = "student_id";
            student_id.Size = new Size(125, 27);
            student_id.TabIndex = 7;
            // 
            // email
            // 
            email.Location = new Point(213, 192);
            email.Name = "email";
            email.Size = new Size(125, 27);
            email.TabIndex = 8;
            // 
            // password
            // 
            password.Location = new Point(213, 253);
            password.Name = "password";
            password.Size = new Size(125, 27);
            password.TabIndex = 9;
            // 
            // confirm_password
            // 
            confirm_password.Location = new Point(213, 305);
            confirm_password.Name = "confirm_password";
            confirm_password.Size = new Size(125, 27);
            confirm_password.TabIndex = 10;
            // 
            // bouton_signin
            // 
            bouton_signin.Location = new Point(164, 382);
            bouton_signin.Name = "bouton_signin";
            bouton_signin.Size = new Size(94, 29);
            bouton_signin.TabIndex = 11;
            bouton_signin.Text = "SIGN IN";
            bouton_signin.UseVisualStyleBackColor = true;
            // 
            // retour
            // 
            retour.Location = new Point(22, 25);
            retour.Name = "retour";
            retour.Size = new Size(56, 29);
            retour.TabIndex = 12;
            retour.Text = "<--";
            retour.UseVisualStyleBackColor = true;
            // 
            // signin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 472);
            Controls.Add(retour);
            Controls.Add(bouton_signin);
            Controls.Add(confirm_password);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(student_id);
            Controls.Add(user_name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signin";
            Text = "signin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox user_name;
        private TextBox student_id;
        private TextBox email;
        private TextBox password;
        private TextBox confirm_password;
        private Button bouton_signin;
        private Button retour;
    }
}