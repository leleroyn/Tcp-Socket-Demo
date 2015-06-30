namespace SocketClient
{
    partial class StartForm
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
            this.tbServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRespose = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(102, 7);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(197, 21);
            this.tbServer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(102, 52);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(68, 21);
            this.tbPort.TabIndex = 3;
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(102, 115);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMsg.Size = new System.Drawing.Size(509, 45);
            this.tbMsg.TabIndex = 4;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(15, 137);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(47, 12);
            this.lbMessage.TabIndex = 5;
            this.lbMessage.Text = "Message";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(13, 231);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Response";
            // 
            // tbRespose
            // 
            this.tbRespose.Location = new System.Drawing.Point(102, 177);
            this.tbRespose.Multiline = true;
            this.tbRespose.Name = "tbRespose";
            this.tbRespose.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRespose.Size = new System.Drawing.Size(509, 45);
            this.tbRespose.TabIndex = 8;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 262);
            this.Controls.Add(this.tbRespose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.tbMsg);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.Text = "SoketClient-Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRespose;
    }
}

