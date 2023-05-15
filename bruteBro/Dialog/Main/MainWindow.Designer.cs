namespace bruteBro
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.logTBOX = new System.Windows.Forms.RichTextBox();
            this.ipTBOX = new System.Windows.Forms.TextBox();
            this.startBTN = new System.Windows.Forms.Button();
            this.logonTryCHBOX = new System.Windows.Forms.CheckBox();
            this.ipLAB = new System.Windows.Forms.Label();
            this.portLAB = new System.Windows.Forms.Label();
            this.portCBOX = new System.Windows.Forms.ComboBox();
            this.nicCBOX = new System.Windows.Forms.ComboBox();
            this.nicLAB = new System.Windows.Forms.Label();
            this.passwordLenghtTBAR = new System.Windows.Forms.TrackBar();
            this.pwlengthTBARLAB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLenghtTBAR)).BeginInit();
            this.SuspendLayout();
            // 
            // logTBOX
            // 
            this.logTBOX.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logTBOX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTBOX.ForeColor = System.Drawing.Color.Chartreuse;
            this.logTBOX.Location = new System.Drawing.Point(12, 12);
            this.logTBOX.Name = "logTBOX";
            this.logTBOX.ReadOnly = true;
            this.logTBOX.Size = new System.Drawing.Size(635, 382);
            this.logTBOX.TabIndex = 0;
            this.logTBOX.Text = "";
            // 
            // ipTBOX
            // 
            this.ipTBOX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTBOX.Location = new System.Drawing.Point(714, 12);
            this.ipTBOX.Name = "ipTBOX";
            this.ipTBOX.Size = new System.Drawing.Size(100, 20);
            this.ipTBOX.TabIndex = 1;
            // 
            // startBTN
            // 
            this.startBTN.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBTN.Location = new System.Drawing.Point(653, 122);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(75, 23);
            this.startBTN.TabIndex = 2;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // logonTryCHBOX
            // 
            this.logonTryCHBOX.AutoSize = true;
            this.logonTryCHBOX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logonTryCHBOX.Location = new System.Drawing.Point(656, 68);
            this.logonTryCHBOX.Name = "logonTryCHBOX";
            this.logonTryCHBOX.Size = new System.Drawing.Size(146, 17);
            this.logonTryCHBOX.TabIndex = 3;
            this.logonTryCHBOX.Text = "CheckMaximumLogonTry";
            this.logonTryCHBOX.UseVisualStyleBackColor = true;
            this.logonTryCHBOX.CheckedChanged += new System.EventHandler(this.LogonTryCHBOX_CheckedChanged);
            // 
            // ipLAB
            // 
            this.ipLAB.AutoSize = true;
            this.ipLAB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipLAB.Location = new System.Drawing.Point(653, 15);
            this.ipLAB.Name = "ipLAB";
            this.ipLAB.Size = new System.Drawing.Size(37, 13);
            this.ipLAB.TabIndex = 4;
            this.ipLAB.Text = "IPv4:";
            // 
            // portLAB
            // 
            this.portLAB.AutoSize = true;
            this.portLAB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLAB.Location = new System.Drawing.Point(653, 41);
            this.portLAB.Name = "portLAB";
            this.portLAB.Size = new System.Drawing.Size(37, 13);
            this.portLAB.TabIndex = 5;
            this.portLAB.Text = "Port:";
            // 
            // portCBOX
            // 
            this.portCBOX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portCBOX.FormattingEnabled = true;
            this.portCBOX.Location = new System.Drawing.Point(714, 41);
            this.portCBOX.Name = "portCBOX";
            this.portCBOX.Size = new System.Drawing.Size(100, 21);
            this.portCBOX.TabIndex = 6;
            this.portCBOX.SelectedIndexChanged += new System.EventHandler(this.PortCBOX_SelectedIndexChanged);
            // 
            // nicCBOX
            // 
            this.nicCBOX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicCBOX.FormattingEnabled = true;
            this.nicCBOX.Location = new System.Drawing.Point(715, 95);
            this.nicCBOX.Name = "nicCBOX";
            this.nicCBOX.Size = new System.Drawing.Size(369, 21);
            this.nicCBOX.TabIndex = 7;
            this.nicCBOX.SelectedIndexChanged += new System.EventHandler(this.NicCBOX_SelectedIndexChanged);
            // 
            // nicLAB
            // 
            this.nicLAB.AutoSize = true;
            this.nicLAB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicLAB.Location = new System.Drawing.Point(656, 98);
            this.nicLAB.Name = "nicLAB";
            this.nicLAB.Size = new System.Drawing.Size(55, 13);
            this.nicLAB.TabIndex = 8;
            this.nicLAB.Text = "Use NIC:";
            // 
            // passwordLenghtTBAR
            // 
            this.passwordLenghtTBAR.Location = new System.Drawing.Point(831, 17);
            this.passwordLenghtTBAR.Maximum = 32;
            this.passwordLenghtTBAR.Minimum = 1;
            this.passwordLenghtTBAR.Name = "passwordLenghtTBAR";
            this.passwordLenghtTBAR.Size = new System.Drawing.Size(253, 45);
            this.passwordLenghtTBAR.TabIndex = 9;
            this.passwordLenghtTBAR.Value = 1;
            this.passwordLenghtTBAR.Scroll += new System.EventHandler(this.PasswordLenghtTBAR_Scroll);
            this.passwordLenghtTBAR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PasswordLenghtTBAR_MouseUp);
            // 
            // pwlengthTBARLAB
            // 
            this.pwlengthTBARLAB.AutoSize = true;
            this.pwlengthTBARLAB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwlengthTBARLAB.Location = new System.Drawing.Point(837, 49);
            this.pwlengthTBARLAB.Name = "pwlengthTBARLAB";
            this.pwlengthTBARLAB.Size = new System.Drawing.Size(115, 13);
            this.pwlengthTBARLAB.TabIndex = 10;
            this.pwlengthTBARLAB.Text = "PasswordLength - 1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 412);
            this.Controls.Add(this.pwlengthTBARLAB);
            this.Controls.Add(this.passwordLenghtTBAR);
            this.Controls.Add(this.nicLAB);
            this.Controls.Add(this.nicCBOX);
            this.Controls.Add(this.portCBOX);
            this.Controls.Add(this.portLAB);
            this.Controls.Add(this.ipLAB);
            this.Controls.Add(this.logonTryCHBOX);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.ipTBOX);
            this.Controls.Add(this.logTBOX);
            this.Name = "MainWindow";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordLenghtTBAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox logTBOX;
        private System.Windows.Forms.TextBox ipTBOX;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.CheckBox logonTryCHBOX;
        private System.Windows.Forms.Label ipLAB;
        private System.Windows.Forms.Label portLAB;
        private System.Windows.Forms.ComboBox portCBOX;
        private System.Windows.Forms.ComboBox nicCBOX;
        private System.Windows.Forms.Label nicLAB;
        private System.Windows.Forms.TrackBar passwordLenghtTBAR;
        private System.Windows.Forms.Label pwlengthTBARLAB;
    }
}

