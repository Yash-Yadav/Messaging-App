namespace MessageApp_Local
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PortUser1 = new System.Windows.Forms.NumericUpDown();
            this.IPTxtBoxUser1 = new System.Windows.Forms.TextBox();
            this.IPUser1Label = new System.Windows.Forms.Label();
            this.PortUser1Label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PortUser2 = new System.Windows.Forms.NumericUpDown();
            this.IPTxtBoxUser2 = new System.Windows.Forms.TextBox();
            this.PortUser2Label = new System.Windows.Forms.Label();
            this.IPUser2Label = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ListMessage = new System.Windows.Forms.ListBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortUser1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortUser2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PortUser1);
            this.groupBox1.Controls.Add(this.IPTxtBoxUser1);
            this.groupBox1.Controls.Add(this.IPUser1Label);
            this.groupBox1.Controls.Add(this.PortUser1Label);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User 1";
            // 
            // PortUser1
            // 
            this.PortUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortUser1.Location = new System.Drawing.Point(68, 69);
            this.PortUser1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortUser1.Name = "PortUser1";
            this.PortUser1.Size = new System.Drawing.Size(120, 24);
            this.PortUser1.TabIndex = 6;
            this.PortUser1.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // IPTxtBoxUser1
            // 
            this.IPTxtBoxUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPTxtBoxUser1.Location = new System.Drawing.Point(68, 27);
            this.IPTxtBoxUser1.MaxLength = 15;
            this.IPTxtBoxUser1.Name = "IPTxtBoxUser1";
            this.IPTxtBoxUser1.Size = new System.Drawing.Size(194, 24);
            this.IPTxtBoxUser1.TabIndex = 5;
            // 
            // IPUser1Label
            // 
            this.IPUser1Label.AutoSize = true;
            this.IPUser1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPUser1Label.Location = new System.Drawing.Point(6, 30);
            this.IPUser1Label.Name = "IPUser1Label";
            this.IPUser1Label.Size = new System.Drawing.Size(21, 18);
            this.IPUser1Label.TabIndex = 3;
            this.IPUser1Label.Text = "IP";
            // 
            // PortUser1Label
            // 
            this.PortUser1Label.AutoSize = true;
            this.PortUser1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortUser1Label.Location = new System.Drawing.Point(6, 71);
            this.PortUser1Label.Name = "PortUser1Label";
            this.PortUser1Label.Size = new System.Drawing.Size(36, 18);
            this.PortUser1Label.TabIndex = 4;
            this.PortUser1Label.Text = "Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PortUser2);
            this.groupBox2.Controls.Add(this.IPTxtBoxUser2);
            this.groupBox2.Controls.Add(this.PortUser2Label);
            this.groupBox2.Controls.Add(this.IPUser2Label);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(306, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User 2";
            // 
            // PortUser2
            // 
            this.PortUser2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortUser2.Location = new System.Drawing.Point(69, 71);
            this.PortUser2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortUser2.Name = "PortUser2";
            this.PortUser2.Size = new System.Drawing.Size(120, 24);
            this.PortUser2.TabIndex = 6;
            this.PortUser2.Value = new decimal(new int[] {
            81,
            0,
            0,
            0});
            // 
            // IPTxtBoxUser2
            // 
            this.IPTxtBoxUser2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPTxtBoxUser2.Location = new System.Drawing.Point(69, 30);
            this.IPTxtBoxUser2.MaxLength = 15;
            this.IPTxtBoxUser2.Name = "IPTxtBoxUser2";
            this.IPTxtBoxUser2.Size = new System.Drawing.Size(194, 24);
            this.IPTxtBoxUser2.TabIndex = 5;
            // 
            // PortUser2Label
            // 
            this.PortUser2Label.AutoSize = true;
            this.PortUser2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortUser2Label.Location = new System.Drawing.Point(6, 71);
            this.PortUser2Label.Name = "PortUser2Label";
            this.PortUser2Label.Size = new System.Drawing.Size(36, 18);
            this.PortUser2Label.TabIndex = 6;
            this.PortUser2Label.Text = "Port";
            // 
            // IPUser2Label
            // 
            this.IPUser2Label.AutoSize = true;
            this.IPUser2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPUser2Label.Location = new System.Drawing.Point(6, 30);
            this.IPUser2Label.Name = "IPUser2Label";
            this.IPUser2Label.Size = new System.Drawing.Size(21, 18);
            this.IPUser2Label.TabIndex = 5;
            this.IPUser2Label.Text = "IP";
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ConnectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConnectButton.Location = new System.Drawing.Point(604, 69);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(129, 43);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "CONNECT";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ListMessage
            // 
            this.ListMessage.BackColor = System.Drawing.SystemColors.Info;
            this.ListMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListMessage.FormattingEnabled = true;
            this.ListMessage.ItemHeight = 18;
            this.ListMessage.Location = new System.Drawing.Point(9, 176);
            this.ListMessage.Name = "ListMessage";
            this.ListMessage.Size = new System.Drawing.Size(590, 238);
            this.ListMessage.TabIndex = 3;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SendButton.Location = new System.Drawing.Point(610, 335);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(116, 43);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.SystemColors.Info;
            this.textMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessage.Location = new System.Drawing.Point(9, 448);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(717, 54);
            this.textMessage.TabIndex = 6;
            this.textMessage.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Conversations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type the Message Here:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(738, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ListMessage);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textMessage);
            this.MaximumSize = new System.Drawing.Size(754, 550);
            this.MinimumSize = new System.Drawing.Size(754, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortUser1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortUser2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IPTxtBoxUser1;
        private System.Windows.Forms.Label IPUser1Label;
        private System.Windows.Forms.Label PortUser1Label;
        private System.Windows.Forms.Label PortUser2Label;
        private System.Windows.Forms.Label IPUser2Label;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox IPTxtBoxUser2;
        private System.Windows.Forms.NumericUpDown PortUser1;
        private System.Windows.Forms.ListBox ListMessage;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.NumericUpDown PortUser2;
        private System.Windows.Forms.RichTextBox textMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

