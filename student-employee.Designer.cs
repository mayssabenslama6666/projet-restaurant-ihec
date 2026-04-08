namespace projet_restau
{
    partial class Form2
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
            bouton_student = new Button();
            bouton_employee = new Button();
            bouton_admin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 69);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 0;
            label1.Text = "ONLY DELICIOUS FOOD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 129);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "LOG IN AS";
            // 
            // bouton_student
            // 
            bouton_student.Location = new Point(165, 207);
            bouton_student.Name = "bouton_student";
            bouton_student.Size = new Size(94, 29);
            bouton_student.TabIndex = 2;
            bouton_student.Text = "STUDENT";
            bouton_student.UseVisualStyleBackColor = true;
            // 
            // bouton_employee
            // 
            bouton_employee.Location = new Point(165, 282);
            bouton_employee.Name = "bouton_employee";
            bouton_employee.Size = new Size(94, 29);
            bouton_employee.TabIndex = 3;
            bouton_employee.Text = "EMPLOYEE";
            bouton_employee.UseVisualStyleBackColor = true;
            // 
            // bouton_admin
            // 
            bouton_admin.Location = new Point(165, 358);
            bouton_admin.Name = "bouton_admin";
            bouton_admin.Size = new Size(94, 29);
            bouton_admin.TabIndex = 4;
            bouton_admin.Text = "ADMIN";
            bouton_admin.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 450);
            Controls.Add(bouton_admin);
            Controls.Add(bouton_employee);
            Controls.Add(bouton_student);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button bouton_student;
        private Button bouton_employee;
        private Button bouton_admin;
    }
}