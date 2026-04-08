namespace projet_restau
{
    partial class Confirmation_reservation
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
            richTextBox1 = new RichTextBox();
            retour = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(98, 162);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(246, 155);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // retour
            // 
            retour.Location = new Point(41, 41);
            retour.Name = "retour";
            retour.Size = new Size(94, 29);
            retour.TabIndex = 1;
            retour.Text = "<--";
            retour.UseVisualStyleBackColor = true;
            // 
            // Confirmation_reservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 488);
            Controls.Add(retour);
            Controls.Add(richTextBox1);
            Name = "Confirmation_reservation";
            Text = "Confirmation_reservation";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button retour;
    }
}