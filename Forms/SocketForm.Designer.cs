namespace PCBuilder
{
    partial class SocketForm
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
            SocketLabel = new Label();
            AMDButton = new RadioButton();
            IntelButton = new RadioButton();
            NextButton = new Button();
            SuspendLayout();
            // 
            // SocketLabel
            // 
            SocketLabel.AutoSize = true;
            SocketLabel.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SocketLabel.ForeColor = SystemColors.HotTrack;
            SocketLabel.Location = new Point(327, 169);
            SocketLabel.Name = "SocketLabel";
            SocketLabel.Size = new Size(129, 35);
            SocketLabel.TabIndex = 0;
            SocketLabel.Text = "Socket:";
            // 
            // AMDButton
            // 
            AMDButton.AutoSize = true;
            AMDButton.Location = new Point(353, 216);
            AMDButton.Name = "AMDButton";
            AMDButton.Size = new Size(64, 24);
            AMDButton.TabIndex = 1;
            AMDButton.TabStop = true;
            AMDButton.Text = "AMD";
            AMDButton.UseVisualStyleBackColor = true;
            AMDButton.CheckedChanged += radioButtonChanged;
            // 
            // IntelButton
            // 
            IntelButton.AutoSize = true;
            IntelButton.Location = new Point(353, 246);
            IntelButton.Name = "IntelButton";
            IntelButton.Size = new Size(59, 24);
            IntelButton.TabIndex = 2;
            IntelButton.TabStop = true;
            IntelButton.Text = "Intel";
            IntelButton.UseVisualStyleBackColor = true;
            IntelButton.CheckedChanged += radioButtonChanged;

            // 
            // NextButton
            // 
            NextButton.Location = new Point(694, 409);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(94, 29);
            NextButton.TabIndex = 3;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // SocketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NextButton);
            Controls.Add(IntelButton);
            Controls.Add(AMDButton);
            Controls.Add(SocketLabel);
            Name = "SocketForm";
            Text = "SocketForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SocketLabel;
        private RadioButton AMDButton;
        private RadioButton IntelButton;
        private Button NextButton;
    }
}