namespace PCBuilder
{
    partial class PSUForm
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
            PSULabel = new Label();
            PSUDropDown = new ComboBox();
            NextButton = new Button();
            SocketDisp = new Label();
            CPUDisp = new Label();
            ThermalDisp = new Label();
            CoolerDisp = new Label();
            MOBODisp = new Label();
            GPUDisp = new Label();
            RAMDisp = new Label();
            StorageDisp = new Label();
            CaseDisp = new Label();
            SuspendLayout();
            // 
            // PSULabel
            // 
            PSULabel.AutoSize = true;
            PSULabel.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            PSULabel.ForeColor = SystemColors.HotTrack;
            PSULabel.Location = new Point(357, 54);
            PSULabel.Name = "PSULabel";
            PSULabel.Size = new Size(78, 35);
            PSULabel.TabIndex = 0;
            PSULabel.Text = "PSU:";
            // 
            // PSUDropDown
            // 
            PSUDropDown.FormattingEnabled = true;
            PSUDropDown.Location = new Point(317, 106);
            PSUDropDown.Name = "PSUDropDown";
            PSUDropDown.Size = new Size(151, 28);
            PSUDropDown.TabIndex = 1;
            PSUDropDown.SelectedIndexChanged += PSUDropDown_SelectedIndexChanged;
            // 
            // NextButton
            // 
            NextButton.Location = new Point(694, 409);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(94, 29);
            NextButton.TabIndex = 2;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // SocketDisp
            // 
            SocketDisp.AutoSize = true;
            SocketDisp.Location = new Point(16, 278);
            SocketDisp.Name = "SocketDisp";
            SocketDisp.Size = new Size(56, 20);
            SocketDisp.TabIndex = 3;
            SocketDisp.Text = "Socket:";
            // 
            // CPUDisp
            // 
            CPUDisp.AutoSize = true;
            CPUDisp.Location = new Point(12, 329);
            CPUDisp.Name = "CPUDisp";
            CPUDisp.Size = new Size(43, 20);
            CPUDisp.TabIndex = 4;
            CPUDisp.Text = "CPU: ";
            // 
            // ThermalDisp
            // 
            ThermalDisp.AutoSize = true;
            ThermalDisp.Location = new Point(12, 349);
            ThermalDisp.Name = "ThermalDisp";
            ThermalDisp.Size = new Size(108, 20);
            ThermalDisp.TabIndex = 5;
            ThermalDisp.Text = "Thermal Paste: ";
            // 
            // CoolerDisp
            // 
            CoolerDisp.AutoSize = true;
            CoolerDisp.Location = new Point(12, 369);
            CoolerDisp.Name = "CoolerDisp";
            CoolerDisp.Size = new Size(60, 20);
            CoolerDisp.TabIndex = 6;
            CoolerDisp.Text = "Cooler: ";
            // 
            // MOBODisp
            // 
            MOBODisp.AutoSize = true;
            MOBODisp.Location = new Point(12, 389);
            MOBODisp.Name = "MOBODisp";
            MOBODisp.Size = new Size(104, 20);
            MOBODisp.TabIndex = 7;
            MOBODisp.Text = "Motherboard: ";
            // 
            // GPUDisp
            // 
            GPUDisp.AutoSize = true;
            GPUDisp.Location = new Point(316, 331);
            GPUDisp.Name = "GPUDisp";
            GPUDisp.Size = new Size(44, 20);
            GPUDisp.TabIndex = 8;
            GPUDisp.Text = "GPU: ";
            // 
            // RAMDisp
            // 
            RAMDisp.AutoSize = true;
            RAMDisp.Location = new Point(316, 351);
            RAMDisp.Name = "RAMDisp";
            RAMDisp.Size = new Size(48, 20);
            RAMDisp.TabIndex = 9;
            RAMDisp.Text = "RAM: ";
            // 
            // StorageDisp
            // 
            StorageDisp.AutoSize = true;
            StorageDisp.Location = new Point(316, 369);
            StorageDisp.Name = "StorageDisp";
            StorageDisp.Size = new Size(68, 20);
            StorageDisp.TabIndex = 10;
            StorageDisp.Text = "Storage: ";
            // 
            // CaseDisp
            // 
            CaseDisp.AutoSize = true;
            CaseDisp.Location = new Point(317, 389);
            CaseDisp.Name = "CaseDisp";
            CaseDisp.Size = new Size(47, 20);
            CaseDisp.TabIndex = 11;
            CaseDisp.Text = "Case: ";
            // 
            // PSUForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CaseDisp);
            Controls.Add(StorageDisp);
            Controls.Add(RAMDisp);
            Controls.Add(GPUDisp);
            Controls.Add(MOBODisp);
            Controls.Add(CoolerDisp);
            Controls.Add(ThermalDisp);
            Controls.Add(CPUDisp);
            Controls.Add(SocketDisp);
            Controls.Add(NextButton);
            Controls.Add(PSUDropDown);
            Controls.Add(PSULabel);
            Name = "PSUForm";
            Text = "PSUForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PSULabel;
        private ComboBox PSUDropDown;
        private Button NextButton;
        private Label SocketDisp;
        private Label CPUDisp;
        private Label ThermalDisp;
        private Label CoolerDisp;
        private Label MOBODisp;
        private Label GPUDisp;
        private Label RAMDisp;
        private Label StorageDisp;
        private Label CaseDisp;
    }
}