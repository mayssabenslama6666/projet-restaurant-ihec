namespace projet_restau
{
    partial class admin_employee
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
            bouton_ajout = new Button();
            bouton_calendrier = new Button();
            bouton_tasks = new Button();
            button4 = new Button();
            label1 = new Label();
            retour = new Button();
            SuspendLayout();
            // 
            // bouton_ajout
            // 
            bouton_ajout.Location = new Point(126, 124);
            bouton_ajout.Name = "bouton_ajout";
            bouton_ajout.Size = new Size(190, 29);
            bouton_ajout.TabIndex = 0;
            bouton_ajout.Text = "ajout un employer";
            bouton_ajout.UseVisualStyleBackColor = true;
            // 
            // bouton_calendrier
            // 
            bouton_calendrier.Location = new Point(126, 184);
            bouton_calendrier.Name = "bouton_calendrier";
            bouton_calendrier.Size = new Size(190, 29);
            bouton_calendrier.TabIndex = 1;
            bouton_calendrier.Text = "calendrier hebdomadaire\r\n\r\n";
            bouton_calendrier.UseVisualStyleBackColor = true;
            // 
            // bouton_tasks
            // 
            bouton_tasks.Location = new Point(126, 239);
            bouton_tasks.Name = "bouton_tasks";
            bouton_tasks.Size = new Size(190, 29);
            bouton_tasks.TabIndex = 2;
            bouton_tasks.Text = "tasks";
            bouton_tasks.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(126, 293);
            button4.Name = "button4";
            button4.Size = new Size(190, 29);
            button4.TabIndex = 3;
            button4.Text = "log out";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 49);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 4;
            label1.Text = "EMPLOYEE";
            // 
            // retour
            // 
            retour.Location = new Point(31, 45);
            retour.Name = "retour";
            retour.Size = new Size(74, 29);
            retour.TabIndex = 5;
            retour.Text = "<--";
            retour.UseVisualStyleBackColor = true;
            // 
            // admin_employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 450);
            Controls.Add(retour);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(bouton_tasks);
            Controls.Add(bouton_calendrier);
            Controls.Add(bouton_ajout);
            Name = "admin_employee";
            Text = "admin_employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bouton_ajout;
        private Button bouton_calendrier;
        private Button bouton_tasks;
        private Button button4;
        private Label label1;
        private Button retour;
    }
}