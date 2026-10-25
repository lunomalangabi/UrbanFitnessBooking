namespace TestPracVANDAG
{
    partial class UrbFitnessBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientPhoneNo = new System.Windows.Forms.TextBox();
            this.lblAmntDue = new System.Windows.Forms.Label();
            this.lblAccAmntDue = new System.Windows.Forms.Label();
            this.lblNoInvSess = new System.Windows.Forms.Label();
            this.lblNoInvClients = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Client Phone Number";
            // 
            // txtClientPhoneNo
            // 
            this.txtClientPhoneNo.Location = new System.Drawing.Point(410, 143);
            this.txtClientPhoneNo.Name = "txtClientPhoneNo";
            this.txtClientPhoneNo.Size = new System.Drawing.Size(126, 22);
            this.txtClientPhoneNo.TabIndex = 0;
            // 
            // lblAmntDue
            // 
            this.lblAmntDue.AutoSize = true;
            this.lblAmntDue.Location = new System.Drawing.Point(212, 276);
            this.lblAmntDue.Name = "lblAmntDue";
            this.lblAmntDue.Size = new System.Drawing.Size(31, 16);
            this.lblAmntDue.TabIndex = 2;
            this.lblAmntDue.Text = "0.00";
            // 
            // lblAccAmntDue
            // 
            this.lblAccAmntDue.AutoSize = true;
            this.lblAccAmntDue.Location = new System.Drawing.Point(594, 276);
            this.lblAccAmntDue.Name = "lblAccAmntDue";
            this.lblAccAmntDue.Size = new System.Drawing.Size(31, 16);
            this.lblAccAmntDue.TabIndex = 4;
            this.lblAccAmntDue.Text = "0.00";
            // 
            // lblNoInvSess
            // 
            this.lblNoInvSess.AutoSize = true;
            this.lblNoInvSess.Location = new System.Drawing.Point(270, 311);
            this.lblNoInvSess.Name = "lblNoInvSess";
            this.lblNoInvSess.Size = new System.Drawing.Size(14, 16);
            this.lblNoInvSess.TabIndex = 3;
            this.lblNoInvSess.Text = "0";
            // 
            // lblNoInvClients
            // 
            this.lblNoInvClients.AutoSize = true;
            this.lblNoInvClients.Location = new System.Drawing.Point(611, 311);
            this.lblNoInvClients.Name = "lblNoInvClients";
            this.lblNoInvClients.Size = new System.Drawing.Size(14, 16);
            this.lblNoInvClients.TabIndex = 5;
            this.lblNoInvClients.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.processToolStripMenuItem.Text = "process";
            this.processToolStripMenuItem.Click += new System.EventHandler(this.processToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Urban Fitness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount Due:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Accumulated Amount Due: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of invalid sessions:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Number of invalid clients:";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // UrbFitnessBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNoInvClients);
            this.Controls.Add(this.lblNoInvSess);
            this.Controls.Add(this.lblAccAmntDue);
            this.Controls.Add(this.lblAmntDue);
            this.Controls.Add(this.txtClientPhoneNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UrbFitnessBooking";
            this.Text = "Urban Fitness Booking";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientPhoneNo;
        private System.Windows.Forms.Label lblAmntDue;
        private System.Windows.Forms.Label lblAccAmntDue;
        private System.Windows.Forms.Label lblNoInvSess;
        private System.Windows.Forms.Label lblNoInvClients;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

