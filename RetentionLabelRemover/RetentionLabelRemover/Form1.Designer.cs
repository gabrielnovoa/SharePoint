namespace RetentionLabelRemover
{
    partial class MainForm
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlSPOData = new System.Windows.Forms.Panel();
            this.grbSPOData = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gpbListData = new System.Windows.Forms.GroupBox();
            this.cbbLists = new System.Windows.Forms.ComboBox();
            this.pnlListData = new System.Windows.Forms.Panel();
            this.pnlSPOData.SuspendLayout();
            this.grbSPOData.SuspendLayout();
            this.gpbListData.SuspendLayout();
            this.pnlListData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(195, 189);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(328, 31);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect and Retrieve Lists";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(119, 38);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(554, 30);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "https://tenant.sharepoint.com/sites/sitecol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Site URL:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(119, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(554, 30);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(119, 88);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(554, 30);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "username@tenant.onmicrosoft.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select a List to clear Retention Labels:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(499, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(174, 81);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Retention Labels";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(21, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // pnlSPOData
            // 
            this.pnlSPOData.Controls.Add(this.grbSPOData);
            this.pnlSPOData.Location = new System.Drawing.Point(12, 61);
            this.pnlSPOData.Name = "pnlSPOData";
            this.pnlSPOData.Size = new System.Drawing.Size(753, 279);
            this.pnlSPOData.TabIndex = 13;
            // 
            // grbSPOData
            // 
            this.grbSPOData.Controls.Add(this.btnConnect);
            this.grbSPOData.Controls.Add(this.txtPassword);
            this.grbSPOData.Controls.Add(this.txtUsername);
            this.grbSPOData.Controls.Add(this.txtURL);
            this.grbSPOData.Controls.Add(this.label1);
            this.grbSPOData.Controls.Add(this.label2);
            this.grbSPOData.Controls.Add(this.label3);
            this.grbSPOData.Location = new System.Drawing.Point(15, 12);
            this.grbSPOData.Name = "grbSPOData";
            this.grbSPOData.Size = new System.Drawing.Size(699, 237);
            this.grbSPOData.TabIndex = 14;
            this.grbSPOData.TabStop = false;
            this.grbSPOData.Text = "Login Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(714, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "SharePoint Online Bulk Retention Label Remover";
            // 
            // gpbListData
            // 
            this.gpbListData.Controls.Add(this.label4);
            this.gpbListData.Controls.Add(this.cbbLists);
            this.gpbListData.Controls.Add(this.btnClear);
            this.gpbListData.Location = new System.Drawing.Point(15, 12);
            this.gpbListData.Name = "gpbListData";
            this.gpbListData.Size = new System.Drawing.Size(689, 135);
            this.gpbListData.TabIndex = 16;
            this.gpbListData.TabStop = false;
            this.gpbListData.Text = "List Information";
            // 
            // cbbLists
            // 
            this.cbbLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLists.FormattingEnabled = true;
            this.cbbLists.Location = new System.Drawing.Point(11, 74);
            this.cbbLists.Name = "cbbLists";
            this.cbbLists.Size = new System.Drawing.Size(463, 28);
            this.cbbLists.TabIndex = 7;
            // 
            // pnlListData
            // 
            this.pnlListData.Controls.Add(this.gpbListData);
            this.pnlListData.Location = new System.Drawing.Point(12, 399);
            this.pnlListData.Name = "pnlListData";
            this.pnlListData.Size = new System.Drawing.Size(753, 164);
            this.pnlListData.TabIndex = 17;
            this.pnlListData.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 590);
            this.Controls.Add(this.pnlListData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnlSPOData);
            this.Controls.Add(this.label5);
            this.Name = "MainForm";
            this.Text = "Retention Label Remover - by gabn@microsoft.com";
            this.pnlSPOData.ResumeLayout(false);
            this.grbSPOData.ResumeLayout(false);
            this.grbSPOData.PerformLayout();
            this.gpbListData.ResumeLayout(false);
            this.gpbListData.PerformLayout();
            this.pnlListData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlSPOData;
        private System.Windows.Forms.GroupBox grbSPOData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gpbListData;
        private System.Windows.Forms.Panel pnlListData;
        private System.Windows.Forms.ComboBox cbbLists;
    }
}

