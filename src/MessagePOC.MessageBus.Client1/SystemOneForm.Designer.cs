namespace MessagePOC.MessageBus.Client1
{
    partial class SystemOneForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.UserNamePrompt = new System.Windows.Forms.Label();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.OriginalNamePrompt = new System.Windows.Forms.Label();
            this.OriginalNameInput = new System.Windows.Forms.TextBox();
            this.NewNamePrompt = new System.Windows.Forms.Label();
            this.NewNameInput = new System.Windows.Forms.TextBox();
            this.SendCommand = new System.Windows.Forms.Button();
            this.IncomePrompt = new System.Windows.Forms.Label();
            this.IncomeInput = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.UserNamePrompt);
            this.flowLayoutPanel1.Controls.Add(this.UserNameInput);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(606, 26);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // UserNamePrompt
            // 
            this.UserNamePrompt.Location = new System.Drawing.Point(3, 0);
            this.UserNamePrompt.Name = "UserNamePrompt";
            this.UserNamePrompt.Size = new System.Drawing.Size(100, 20);
            this.UserNamePrompt.TabIndex = 1;
            this.UserNamePrompt.Text = "User";
            this.UserNamePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(109, 3);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(244, 20);
            this.UserNameInput.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.OriginalNamePrompt);
            this.flowLayoutPanel2.Controls.Add(this.OriginalNameInput);
            this.flowLayoutPanel2.Controls.Add(this.NewNamePrompt);
            this.flowLayoutPanel2.Controls.Add(this.NewNameInput);
            this.flowLayoutPanel2.Controls.Add(this.IncomePrompt);
            this.flowLayoutPanel2.Controls.Add(this.IncomeInput);
            this.flowLayoutPanel2.Controls.Add(this.SendCommand);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 26);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(606, 107);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // OriginalNamePrompt
            // 
            this.OriginalNamePrompt.Location = new System.Drawing.Point(3, 0);
            this.OriginalNamePrompt.Name = "OriginalNamePrompt";
            this.OriginalNamePrompt.Size = new System.Drawing.Size(100, 20);
            this.OriginalNamePrompt.TabIndex = 0;
            this.OriginalNamePrompt.Text = "Original Name";
            this.OriginalNamePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OriginalNameInput
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.OriginalNameInput, true);
            this.OriginalNameInput.Location = new System.Drawing.Point(109, 3);
            this.OriginalNameInput.Name = "OriginalNameInput";
            this.OriginalNameInput.Size = new System.Drawing.Size(244, 20);
            this.OriginalNameInput.TabIndex = 1;
            // 
            // NewNamePrompt
            // 
            this.NewNamePrompt.Location = new System.Drawing.Point(3, 26);
            this.NewNamePrompt.Name = "NewNamePrompt";
            this.NewNamePrompt.Size = new System.Drawing.Size(100, 20);
            this.NewNamePrompt.TabIndex = 2;
            this.NewNamePrompt.Text = "New Name";
            this.NewNamePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NewNameInput
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.NewNameInput, true);
            this.NewNameInput.Location = new System.Drawing.Point(109, 29);
            this.NewNameInput.Name = "NewNameInput";
            this.NewNameInput.Size = new System.Drawing.Size(244, 20);
            this.NewNameInput.TabIndex = 3;
            // 
            // SendCommand
            // 
            this.SendCommand.Location = new System.Drawing.Point(3, 81);
            this.SendCommand.Name = "SendCommand";
            this.SendCommand.Size = new System.Drawing.Size(75, 23);
            this.SendCommand.TabIndex = 6;
            this.SendCommand.Text = "Send";
            this.SendCommand.UseVisualStyleBackColor = true;
            this.SendCommand.Click += new System.EventHandler(this.SendCommand_Click);
            // 
            // IncomePrompt
            // 
            this.IncomePrompt.Location = new System.Drawing.Point(3, 52);
            this.IncomePrompt.Name = "IncomePrompt";
            this.IncomePrompt.Size = new System.Drawing.Size(100, 20);
            this.IncomePrompt.TabIndex = 4;
            this.IncomePrompt.Text = "Income";
            this.IncomePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IncomeInput
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.IncomeInput, true);
            this.IncomeInput.Location = new System.Drawing.Point(109, 55);
            this.IncomeInput.Name = "IncomeInput";
            this.IncomeInput.Size = new System.Drawing.Size(244, 20);
            this.IncomeInput.TabIndex = 5;
            // 
            // SystemOneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 430);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SystemOneForm";
            this.Text = "System One";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.Label UserNamePrompt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label OriginalNamePrompt;
        private System.Windows.Forms.TextBox OriginalNameInput;
        private System.Windows.Forms.Button SendCommand;
        private System.Windows.Forms.Label NewNamePrompt;
        private System.Windows.Forms.TextBox NewNameInput;
        private System.Windows.Forms.Label IncomePrompt;
        private System.Windows.Forms.TextBox IncomeInput;
    }
}

