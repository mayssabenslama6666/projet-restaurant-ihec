namespace projet_restau
{
    partial class editprofileemployee
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
            edit_profile_emp = new Button();
            weekly_schedule = new Button();
            tasks = new Button();
            logout = new Button();
            label1 = new Label();
            back_home = new Button();
            profile = new Button();
            calender = new Button();
            SuspendLayout();
            // 
            // edit_profile_emp
            // 
            edit_profile_emp.Location = new Point(157, 132);
            edit_profile_emp.Name = "edit_profile_emp";
            edit_profile_emp.Size = new Size(127, 29);
            edit_profile_emp.TabIndex = 0;
            edit_profile_emp.Text = "Edit Profile";
            edit_profile_emp.UseVisualStyleBackColor = true;
            // 
            // weekly_schedule
            // 
            weekly_schedule.Location = new Point(157, 190);
            weekly_schedule.Name = "weekly_schedule";
            weekly_schedule.Size = new Size(127, 29);
            weekly_schedule.TabIndex = 1;
            weekly_schedule.Text = "weekly_schedule";
            weekly_schedule.UseVisualStyleBackColor = true;
            // 
            // tasks
            // 
            tasks.Location = new Point(157, 261);
            tasks.Name = "tasks";
            tasks.Size = new Size(127, 29);
            tasks.TabIndex = 2;
            tasks.Text = "Tasks";
            tasks.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            logout.Location = new Point(176, 329);
            logout.Name = "logout";
            logout.Size = new Size(94, 29);
            logout.TabIndex = 3;
            logout.Text = "Log Out";
            logout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 47);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 4;
            label1.Text = "NAME";
            label1.Click += label1_Click;
            // 
            // back_home
            // 
            back_home.Location = new Point(35, 457);
            back_home.Name = "back_home";
            back_home.Size = new Size(94, 29);
            back_home.TabIndex = 5;
            back_home.Text = "Home ";
            back_home.UseVisualStyleBackColor = true;
            // 
            // profile
            // 
            profile.Location = new Point(176, 457);
            profile.Name = "profile";
            profile.Size = new Size(94, 29);
            profile.TabIndex = 6;
            profile.Text = "Profile";
            profile.UseVisualStyleBackColor = true;
            // 
            // calender
            // 
            calender.Location = new Point(331, 457);
            calender.Name = "calender";
            calender.Size = new Size(94, 29);
            calender.TabIndex = 7;
            calender.Text = "Calender";
            calender.UseVisualStyleBackColor = true;
            // 
            // editprofileemployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 498);
            Controls.Add(calender);
            Controls.Add(profile);
            Controls.Add(back_home);
            Controls.Add(label1);
            Controls.Add(logout);
            Controls.Add(tasks);
            Controls.Add(weekly_schedule);
            Controls.Add(edit_profile_emp);
            Name = "editprofileemployee";
            Text = "editprofileemployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button edit_profile_emp;
        private Button weekly_schedule;
        private Button tasks;
        private Button logout;
        private Label label1;
        private Button back_home;
        private Button profile;
        private Button calender;
    }
}