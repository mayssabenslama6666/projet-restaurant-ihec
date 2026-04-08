namespace projet_restau
{
    partial class edit2
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            num = new MaskedTextBox();
            mail = new TextBox();
            nom = new TextBox();
            confirm = new Button();
            cancel = new Button();
            m = new Label();
            retour = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(136, 244);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 86);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 140);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 194);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 3;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 251);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 4;
            label4.Text = "Date Of Birth";
            // 
            // num
            // 
            num.Location = new Point(136, 187);
            num.Mask = "(+216)99999999";
            num.Name = "num";
            num.Size = new Size(250, 27);
            num.TabIndex = 5;
            // 
            // mail
            // 
            mail.Location = new Point(136, 137);
            mail.Name = "mail";
            mail.Size = new Size(250, 27);
            mail.TabIndex = 6;
            // 
            // nom
            // 
            nom.Location = new Point(136, 83);
            nom.Name = "nom";
            nom.Size = new Size(250, 27);
            nom.TabIndex = 7;
            // 
            // confirm
            // 
            confirm.Location = new Point(87, 348);
            confirm.Name = "confirm";
            confirm.Size = new Size(94, 29);
            confirm.TabIndex = 8;
            confirm.Text = "Confirm";
            confirm.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            cancel.Location = new Point(251, 348);
            cancel.Name = "cancel";
            cancel.Size = new Size(94, 29);
            cancel.TabIndex = 9;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            // 
            // m
            // 
            m.AutoSize = true;
            m.Location = new Point(181, 35);
            m.Name = "m";
            m.Size = new Size(63, 20);
            m.TabIndex = 10;
            m.Text = "PROFILE";
            // 
            // retour
            // 
            retour.Location = new Point(21, 26);
            retour.Name = "retour";
            retour.Size = new Size(63, 29);
            retour.TabIndex = 11;
            retour.Text = "<--";
            retour.UseVisualStyleBackColor = true;
            // 
            // edit2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 487);
            Controls.Add(retour);
            Controls.Add(m);
            Controls.Add(cancel);
            Controls.Add(confirm);
            Controls.Add(nom);
            Controls.Add(mail);
            Controls.Add(num);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "edit2";
            Text = "edit2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox num;
        private TextBox mail;
        private TextBox nom;
        private Button confirm;
        private Button cancel;
        private Label m;
        private Button retour;
    }
}