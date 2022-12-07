namespace ElGamal
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
            this.SMsg = new System.Windows.Forms.TextBox();
            this.PtextBox = new System.Windows.Forms.TextBox();
            this.XtextBox = new System.Windows.Forms.TextBox();
            this.Msg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SMsg
            // 
            this.SMsg.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SMsg.Location = new System.Drawing.Point(12, 27);
            this.SMsg.Multiline = true;
            this.SMsg.Name = "SMsg";
            this.SMsg.Size = new System.Drawing.Size(461, 159);
            this.SMsg.TabIndex = 0;
            // 
            // PtextBox
            // 
            this.PtextBox.Location = new System.Drawing.Point(101, 51);
            this.PtextBox.Name = "PtextBox";
            this.PtextBox.Size = new System.Drawing.Size(100, 20);
            this.PtextBox.TabIndex = 1;
            // 
            // XtextBox
            // 
            this.XtextBox.Location = new System.Drawing.Point(101, 95);
            this.XtextBox.Name = "XtextBox";
            this.XtextBox.Size = new System.Drawing.Size(100, 20);
            this.XtextBox.TabIndex = 2;
            // 
            // Msg
            // 
            this.Msg.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Msg.Location = new System.Drawing.Point(12, 248);
            this.Msg.Multiline = true;
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(461, 166);
            this.Msg.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(563, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 80);
            this.button1.TabIndex = 6;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Значение P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Значение X";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.XtextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PtextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(545, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 158);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(622, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ключи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(88, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Зашифрованное сообщение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(88, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Расшифрованное сообщение";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.SMsg);
            this.Name = "Form2";
            this.Text = "Расшифрование";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SMsg;
        private System.Windows.Forms.TextBox PtextBox;
        private System.Windows.Forms.TextBox XtextBox;
        private System.Windows.Forms.TextBox Msg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}