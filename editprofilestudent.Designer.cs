namespace projet_restau
{
    partial class editprofilestudent
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
            editprofile = new Button();
            editpassword = new Button();
            logout = new Button();
            backhome = new Button();
            profile = new Button();
            calender = new Button();
            label1 = new Label();
            retour = new Button();
            SuspendLayout();
            // 
            // editprofile
            // 
            editprofile.Location = new Point(128, 135);
            editprofile.Name = "editprofile";
            editprofile.Size = new Size(145, 29);
            editprofile.TabIndex = 0;
            editprofile.Text = "Edit Profile";
            editprofile.UseVisualStyleBackColor = true;
            // 
            // editpassword
            // 
            editpassword.Location = new Point(128, 217);
            editpassword.Name = "editpassword";
            editpassword.Size = new Size(145, 29);
            editpassword.TabIndex = 1;
            editpassword.Text = "Change Password ";
            editpassword.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            logout.Location = new Point(128, 305);
            logout.Name = "logout";
            logout.Size = new Size(145, 29);
            logout.TabIndex = 2;
            logout.Text = "Log Out";
            logout.UseVisualStyleBackColor = true;
            // 
            // backhome
            // 
            backhome.Location = new Point(26, 403);
            backhome.Name = "backhome";
            backhome.Size = new Size(94, 29);
            backhome.TabIndex = 3;
            backhome.Text = "Home";
            backhome.UseVisualStyleBackColor = true;
            // 
            // profile
            // 
            profile.Location = new Point(161, 403);
            profile.Name = "profile";
            profile.Size = new Size(94, 29);
            profile.TabIndex = 4;
            profile.Text = "Profile";
            profile.UseVisualStyleBackColor = true;
            // 
            // calender
            // 
            calender.Location = new Point(298, 403);
            calender.Name = "calender";
            calender.Size = new Size(94, 29);
            calender.TabIndex = 5;
            calender.Text = "Calender";
            calender.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 48);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 6;
            label1.Text = "EDIT PROFILE";
            // 
            // retour
            // 
            retour.Location = new Point(26, 44);
            retour.Name = "retour";
            retour.Size = new Size(72, 29);
            retour.TabIndex = 7;
            retour.Text = "<--";
            retour.UseVisualStyleBackColor = true;
            // 
            // editprofilestudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 492);
            Controls.Add(retour);
            Controls.Add(label1);
            Controls.Add(calender);
            Controls.Add(profile);
            Controls.Add(backhome);
            Controls.Add(logout);
            Controls.Add(editpassword);
            Controls.Add(editprofile);
            Name = "editprofilestudent";
            Text = "editprofilestudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button editprofile;
        private Button editpassword;
        private Button logout;
        private Button backhome;
        private Button profile;
        private Button calender;
        private Label label1;
        private Button retour;
    }
}