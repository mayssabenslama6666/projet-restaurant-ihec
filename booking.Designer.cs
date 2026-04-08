namespace projet_restau
{
    partial class booking
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
            monthCalendar1 = new MonthCalendar();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            time = new MaskedTextBox();
            label3 = new Label();
            confirmation = new Button();
            cancel = new Button();
            retour = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(99, 64);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "0 seat", "1 seat", "2 seats", "3 seats ", "4 seats ", "5 seats", "6 seats" });
            listBox1.Location = new Point(247, 314);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 24);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 318);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 2;
            label1.Text = "Seat Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 368);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Time :";
            // 
            // time
            // 
            time.Location = new Point(247, 365);
            time.Mask = "12h:30min";
            time.Name = "time";
            time.Size = new Size(150, 27);
            time.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 24);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Booking";
            // 
            // confirmation
            // 
            confirmation.Location = new Point(42, 430);
            confirmation.Name = "confirmation";
            confirmation.Size = new Size(170, 29);
            confirmation.TabIndex = 6;
            confirmation.Text = "Confirm Reservation";
            confirmation.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            cancel.Location = new Point(234, 430);
            cancel.Name = "cancel";
            cancel.Size = new Size(187, 29);
            cancel.TabIndex = 7;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            // 
            // retour
            // 
            retour.Location = new Point(12, 20);
            retour.Name = "retour";
            retour.Size = new Size(94, 29);
            retour.TabIndex = 8;
            retour.Text = "<--";
            retour.UseVisualStyleBackColor = true;
            // 
            // booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 497);
            Controls.Add(retour);
            Controls.Add(cancel);
            Controls.Add(confirmation);
            Controls.Add(label3);
            Controls.Add(time);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(monthCalendar1);
            Name = "booking";
            Text = "booking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private MaskedTextBox time;
        private Label label3;
        private Button confirmation;
        private Button cancel;
        private Button retour;
    }
}