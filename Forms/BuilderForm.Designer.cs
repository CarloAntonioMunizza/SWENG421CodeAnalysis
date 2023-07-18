namespace PCBuilder
{
    partial class BuilderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GPUlabel = new Label();
            RAMlabel = new Label();
            Caselabel = new Label();
            Storagelabel = new Label();
            GPUDropDown = new ComboBox();
            RAMDropDown = new ComboBox();
            StoreDropDown = new ComboBox();
            CaseDropDown = new ComboBox();
            NextButton = new Button();
            MOBODisp = new Label();
            CoolerDisp = new Label();
            ThermalDisp = new Label();
            CPUDisp = new Label();
            SocketDisp = new Label();
            SuspendLayout();
            // 
            // GPUlabel
            // 
            GPUlabel.AutoSize = true;
            GPUlabel.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            GPUlabel.ForeColor = SystemColors.HotTrack;
            GPUlabel.Location = new Point(169, 121);
            GPUlabel.Name = "GPUlabel";
            GPUlabel.Size = new Size(89, 35);
            GPUlabel.TabIndex = 1;
            GPUlabel.Text = "GPU: ";
            // 
            // RAMlabel
            // 
            RAMlabel.AutoSize = true;
            RAMlabel.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            RAMlabel.ForeColor = SystemColors.HotTrack;
            RAMlabel.Location = new Point(320, 121);
            RAMlabel.Name = "RAMlabel";
            RAMlabel.Size = new Size(90, 35);
            RAMlabel.TabIndex = 3;
            RAMlabel.Text = "RAM: ";
            // 
            // Caselabel
            // 
            Caselabel.AutoSize = true;
            Caselabel.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Caselabel.ForeColor = SystemColors.HotTrack;
            Caselabel.Location = new Point(663, 121);
            Caselabel.Name = "Caselabel";
            Caselabel.Size = new Size(95, 35);
            Caselabel.TabIndex = 4;
            Caselabel.Text = "Case: ";
            // 
            // Storagelabel
            // 
            Storagelabel.AutoSize = true;
            Storagelabel.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Storagelabel.ForeColor = SystemColors.HotTrack;
            Storagelabel.Location = new Point(461, 121);
            Storagelabel.Name = "Storagelabel";
            Storagelabel.Size = new Size(153, 35);
            Storagelabel.TabIndex = 6;
            Storagelabel.Text = "Storage: ";
            // 
            // GPUDropDown
            // 
            GPUDropDown.FormattingEnabled = true;
            GPUDropDown.Location = new Point(137, 169);
            GPUDropDown.Name = "GPUDropDown";
            GPUDropDown.Size = new Size(151, 28);
            GPUDropDown.TabIndex = 9;
            GPUDropDown.SelectedIndexChanged += GPUDropDown_SelectedIndexChanged;
            // 
            // RAMDropDown
            // 
            RAMDropDown.FormattingEnabled = true;
            RAMDropDown.Location = new Point(305, 169);
            RAMDropDown.Name = "RAMDropDown";
            RAMDropDown.Size = new Size(114, 28);
            RAMDropDown.TabIndex = 11;
            RAMDropDown.SelectedIndexChanged += RAMDropDown_SelectedIndexChanged;
            // 
            // StoreDropDown
            // 
            StoreDropDown.FormattingEnabled = true;
            StoreDropDown.Location = new Point(435, 169);
            StoreDropDown.Name = "StoreDropDown";
            StoreDropDown.Size = new Size(182, 28);
            StoreDropDown.TabIndex = 12;
            StoreDropDown.SelectedIndexChanged += StorageDropDown_SelectedIndexChanged;
            // 
            // CaseDropDown
            // 
            CaseDropDown.FormattingEnabled = true;
            CaseDropDown.Location = new Point(634, 169);
            CaseDropDown.Name = "CaseDropDown";
            CaseDropDown.Size = new Size(151, 28);
            CaseDropDown.TabIndex = 13;
            CaseDropDown.SelectedIndexChanged += CaseDropDown_SelectedIndexChanged;
            // 
            // NextButton
            // 
            NextButton.Location = new Point(788, 453);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(94, 29);
            NextButton.TabIndex = 15;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // MOBODisp
            // 
            MOBODisp.AutoSize = true;
            MOBODisp.Location = new Point(12, 450);
            MOBODisp.Name = "MOBODisp";
            MOBODisp.Size = new Size(104, 20);
            MOBODisp.TabIndex = 21;
            MOBODisp.Text = "Motherboard: ";
            // 
            // CoolerDisp
            // 
            CoolerDisp.AutoSize = true;
            CoolerDisp.Location = new Point(12, 430);
            CoolerDisp.Name = "CoolerDisp";
            CoolerDisp.Size = new Size(60, 20);
            CoolerDisp.TabIndex = 20;
            CoolerDisp.Text = "Cooler: ";
            // 
            // ThermalDisp
            // 
            ThermalDisp.AutoSize = true;
            ThermalDisp.Location = new Point(12, 410);
            ThermalDisp.Name = "ThermalDisp";
            ThermalDisp.Size = new Size(108, 20);
            ThermalDisp.TabIndex = 19;
            ThermalDisp.Text = "Thermal Paste: ";
            // 
            // CPUDisp
            // 
            CPUDisp.AutoSize = true;
            CPUDisp.Location = new Point(12, 390);
            CPUDisp.Name = "CPUDisp";
            CPUDisp.Size = new Size(43, 20);
            CPUDisp.TabIndex = 18;
            CPUDisp.Text = "CPU: ";
            // 
            // SocketDisp
            // 
            SocketDisp.AutoSize = true;
            SocketDisp.Location = new Point(12, 337);
            SocketDisp.Name = "SocketDisp";
            SocketDisp.Size = new Size(56, 20);
            SocketDisp.TabIndex = 17;
            SocketDisp.Text = "Socket:";
            // 
            // BuilderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 494);
            Controls.Add(MOBODisp);
            Controls.Add(CoolerDisp);
            Controls.Add(ThermalDisp);
            Controls.Add(CPUDisp);
            Controls.Add(SocketDisp);
            Controls.Add(NextButton);
            Controls.Add(CaseDropDown);
            Controls.Add(StoreDropDown);
            Controls.Add(RAMDropDown);
            Controls.Add(GPUDropDown);
            Controls.Add(Storagelabel);
            Controls.Add(Caselabel);
            Controls.Add(RAMlabel);
            Controls.Add(GPUlabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BuilderForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label GPUlabel;
        private Label RAMlabel;
        private Label Caselabel;
        private Label Storagelabel;
        private ComboBox GPUDropDown;
        private ComboBox RAMDropDown;
        private ComboBox StoreDropDown;
        private ComboBox CaseDropDown;
        private Button NextButton;
        private Label MOBODisp;
        private Label CoolerDisp;
        private Label ThermalDisp;
        private Label CPUDisp;
        private Label SocketDisp;
    }
}