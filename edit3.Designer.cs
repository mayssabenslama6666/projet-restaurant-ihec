namespace projet_restau
{
    partial class edit3
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
            st_id = new TextBox();
            c_pwd = new TextBox();
            n_pwd = new TextBox();
            cn_pwd = new TextBox();
            save = new Button();
            Cancel = new Button();
            retour = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 35);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 0;
            label1.Text = "PASSWORD CHANGES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 115);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Student ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 187);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 2;
            label3.Text = "Current Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 260);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 3;
            label4.Text = "New Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1, 325);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 4;
            label5.Text = "Confirm New Password";
            // 
            // st_id
            // 
            st_id.Location = new Point(168, 112);
            st_id.Name = "st_id";
            st_id.Size = new Size(201, 27);
            st_id.TabIndex = 5;
            // 
            // c_pwd
            // 
            c_pwd.Location = new Point(168, 187);
            c_pwd.Name = "c_pwd";
            c_pwd.Size = new Size(201, 27);
            c_pwd.TabIndex = 6;
            // 
            // n_pwd
            // 
            n_pwd.Location = new Point(168, 257);
            n_pwd.Name = "n_pwd";
            n_pwd.Size = new Size(201, 27);
            n_pwd.TabIndex = 7;
            // 
            // cn_pwd
            // 
            cn_pwd.Location = new Point(168, 318);
            cn_pwd.Name = "cn_pwd";
            cn_pwd.Size = new Size(201, 27);
            cn_pwd.TabIndex = 8;
            // 
            // save
            // 
            save.Location = new Point(79, 391);
            save.Name = "save";
            save.Size = new Size(94, 29);
            save.TabIndex = 9;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(238, 391);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(94, 29);
            Cancel.TabIndex = 10;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            // 
            // retour
            // 
            retour.Location = new Point(14, 26);
            retour.Name = "retour";
            retour.Size = new Size(65, 29);
            retour.TabIndex = 11;
            retour.Text = "<--";
            retour.UseVisualStyleBackColor = true;
            // 
            // edit3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 494);
            Controls.Add(retour);
            Controls.Add(Cancel);
            Controls.Add(save);
            Controls.Add(cn_pwd);
            Controls.Add(n_pwd);
            Controls.Add(c_pwd);
            Controls.Add(st_id);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "edit3";
            Text = "edit3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox st_id;
        private TextBox c_pwd;
        private TextBox n_pwd;
        private TextBox cn_pwd;
        private Button save;
        private Button Cancel;
        private Button retour;
    }
}