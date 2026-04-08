namespace projet_restau
{
    partial class admin_management
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
            bouton_menu = new Button();
            bouton_employee = new Button();
            retour = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 147);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "MANAGEMENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 72);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 1;
            label2.Text = "ONLY DELICIOUS FOOD";
            // 
            // bouton_menu
            // 
            bouton_menu.Location = new Point(158, 257);
            bouton_menu.Name = "bouton_menu";
            bouton_menu.Size = new Size(94, 29);
            bouton_menu.TabIndex = 2;
            bouton_menu.Text = "MENU";
            bouton_menu.UseVisualStyleBackColor = true;
            bouton_menu.Click += button1_Click;
            // 
            // bouton_employee
            // 
            bouton_employee.Location = new Point(158, 344);
            bouton_employee.Name = "bouton_employee";
            bouton_employee.Size = new Size(94, 29);
            bouton_employee.TabIndex = 3;
            bouton_employee.Text = "EMPLOYEE";
            bouton_employee.UseVisualStyleBackColor = true;
            // 
            // retour
            // 
            retour.Location = new Point(24, 50);
            retour.Name = "retour";
            retour.Size = new Size(61, 29);
            retour.TabIndex = 4;
            retour.Text = "<--";
            retour.UseVisualStyleBackColor = true;
            // 
            // admin_management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 470);
            Controls.Add(retour);
            Controls.Add(bouton_employee);
            Controls.Add(bouton_menu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "admin_management";
            Text = "admin_management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button bouton_menu;
        private Button bouton_employee;
        private Button retour;
    }
}