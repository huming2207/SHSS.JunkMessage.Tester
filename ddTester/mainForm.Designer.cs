namespace ddTester
{
    partial class mainForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.commentTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.threadTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.runCrTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(48, 791);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(948, 166);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Here we go";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.Location = new System.Drawing.Point(168, 49);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(828, 44);
            this.nameTextbox.TabIndex = 2;
            this.nameTextbox.Text = "John.Smith";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.Location = new System.Drawing.Point(168, 129);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(828, 44);
            this.emailTextbox.TabIndex = 4;
            this.emailTextbox.Text = "js@szkegao.net";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Comment:";
            // 
            // commentTextbox
            // 
            this.commentTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentTextbox.Location = new System.Drawing.Point(171, 363);
            this.commentTextbox.Multiline = true;
            this.commentTextbox.Name = "commentTextbox";
            this.commentTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextbox.Size = new System.Drawing.Size(828, 245);
            this.commentTextbox.TabIndex = 6;
            this.commentTextbox.Text = "苟利国家生死以，岂因祸福趋避之。就做了一点微小的工作，谢谢大家。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 667);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thread(s):";
            // 
            // threadTextbox
            // 
            this.threadTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threadTextbox.Location = new System.Drawing.Point(158, 655);
            this.threadTextbox.Name = "threadTextbox";
            this.threadTextbox.Size = new System.Drawing.Size(113, 44);
            this.threadTextbox.TabIndex = 9;
            this.threadTextbox.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Article title:";
            // 
            // titleTextbox
            // 
            this.titleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextbox.Location = new System.Drawing.Point(168, 213);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(828, 44);
            this.titleTextbox.TabIndex = 11;
            this.titleTextbox.Text = "Nothing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 667);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Run Circle(s):";
            // 
            // runCrTextbox
            // 
            this.runCrTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runCrTextbox.Location = new System.Drawing.Point(598, 655);
            this.runCrTextbox.Name = "runCrTextbox";
            this.runCrTextbox.Size = new System.Drawing.Size(113, 44);
            this.runCrTextbox.TabIndex = 13;
            this.runCrTextbox.Text = "500";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Phone:";
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextbox.Location = new System.Drawing.Point(168, 286);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(828, 44);
            this.phoneTextbox.TabIndex = 15;
            this.phoneTextbox.Text = "13800138000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 736);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Progress: ";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(153, 736);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(91, 25);
            this.resultLabel.TabIndex = 18;
            this.resultLabel.Text = "Standby";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 969);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.runCrTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.threadTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commentTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.startButton);
            this.Name = "mainForm";
            this.Text = "SHSS Junk message DDoS bug tester - For testing only";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox commentTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox threadTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox runCrTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label resultLabel;
    }
}

