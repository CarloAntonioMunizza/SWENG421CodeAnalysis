namespace PCBuilder
{
    partial class DisplayForm
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
            WattDisp = new Label();
            PriceDisp = new Label();
            MOBODisp = new Label();
            CoolerDisp = new Label();
            ThermalDisp = new Label();
            CPUDisp = new Label();
            SocketDisp = new Label();
            PSUDisp = new Label();
            Confirmbutton = new Button();
            GPUlabel = new Label();
            Caselabel = new Label();
            Storelabel = new Label();
            RAMlabel = new Label();
            SAMlabel = new Label();
            SLIlabel = new Label();
            SuspendLayout();
            // 
            // WattDisp
            // 
            WattDisp.AutoSize = true;
            WattDisp.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            WattDisp.ForeColor = SystemColors.HotTrack;
            WattDisp.Location = new Point(380, 297);
            WattDisp.Name = "WattDisp";
            WattDisp.Size = new Size(164, 35);
            WattDisp.TabIndex = 0;
            WattDisp.Text = "Wattage: ";

            // 
            // PriceDisp
            // 
            PriceDisp.AutoSize = true;
            PriceDisp.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            PriceDisp.ForeColor = SystemColors.HotTrack;
            PriceDisp.Location = new Point(82, 297);
            PriceDisp.Name = "PriceDisp";
            PriceDisp.Size = new Size(113, 35);
            PriceDisp.TabIndex = 1;
            PriceDisp.Text = "Price: ";
            // 
            // MOBODisp
            // 
            MOBODisp.AutoSize = true;
            MOBODisp.Location = new Point(152, 193);
            MOBODisp.Name = "MOBODisp";
            MOBODisp.Size = new Size(104, 20);
            MOBODisp.TabIndex = 12;
            MOBODisp.Text = "Motherboard: ";
            // 
            // CoolerDisp
            // 
            CoolerDisp.AutoSize = true;
            CoolerDisp.Location = new Point(152, 173);
            CoolerDisp.Name = "CoolerDisp";
            CoolerDisp.Size = new Size(60, 20);
            CoolerDisp.TabIndex = 11;
            CoolerDisp.Text = "Cooler: ";
            // 
            // ThermalDisp
            // 
            ThermalDisp.AutoSize = true;
            ThermalDisp.Location = new Point(152, 153);
            ThermalDisp.Name = "ThermalDisp";
            ThermalDisp.Size = new Size(108, 20);
            ThermalDisp.TabIndex = 10;
            ThermalDisp.Text = "Thermal Paste: ";
            // 
            // CPUDisp
            // 
            CPUDisp.AutoSize = true;
            CPUDisp.Location = new Point(152, 133);
            CPUDisp.Name = "CPUDisp";
            CPUDisp.Size = new Size(43, 20);
            CPUDisp.TabIndex = 9;
            CPUDisp.Text = "CPU: ";
            // 
            // SocketDisp
            // 
            SocketDisp.AutoSize = true;
            SocketDisp.Location = new Point(152, 83);
            SocketDisp.Name = "SocketDisp";
            SocketDisp.Size = new Size(56, 20);
            SocketDisp.TabIndex = 8;
            SocketDisp.Text = "Socket:";
            // 
            // PSUDisp
            // 
            PSUDisp.AutoSize = true;
            PSUDisp.Location = new Point(452, 83);
            PSUDisp.Name = "PSUDisp";
            PSUDisp.Size = new Size(42, 20);
            PSUDisp.TabIndex = 13;
            PSUDisp.Text = "PSU: ";
            // 
            // Confirmbutton
            // 
            Confirmbutton.Location = new Point(694, 409);
            Confirmbutton.Name = "Confirmbutton";
            Confirmbutton.Size = new Size(94, 29);
            Confirmbutton.TabIndex = 14;
            Confirmbutton.Text = "Confirm";
            Confirmbutton.UseVisualStyleBackColor = true;
            Confirmbutton.Click += Confirmbutton_Click;
            // 
            // GPUlabel
            // 
            GPUlabel.AutoSize = true;
            GPUlabel.Location = new Point(452, 133);
            GPUlabel.Name = "GPUlabel";
            GPUlabel.Size = new Size(44, 20);
            GPUlabel.TabIndex = 15;
            GPUlabel.Text = "GPU: ";
            // 
            // Caselabel
            // 
            Caselabel.AutoSize = true;
            Caselabel.Location = new Point(452, 193);
            Caselabel.Name = "Caselabel";
            Caselabel.Size = new Size(47, 20);
            Caselabel.TabIndex = 16;
            Caselabel.Text = "Case: ";
            // 
            // Storelabel
            // 
            Storelabel.AutoSize = true;
            Storelabel.Location = new Point(452, 173);
            Storelabel.Name = "Storelabel";
            Storelabel.Size = new Size(68, 20);
            Storelabel.TabIndex = 17;
            Storelabel.Text = "Storage: ";
            // 
            // RAMlabel
            // 
            RAMlabel.AutoSize = true;
            RAMlabel.Location = new Point(452, 153);
            RAMlabel.Name = "RAMlabel";
            RAMlabel.Size = new Size(48, 20);
            RAMlabel.TabIndex = 18;
            RAMlabel.Text = "RAM: ";
            // 
            // SAMlabel
            // 
            SAMlabel.AutoSize = true;
            SAMlabel.Location = new Point(452, 239);
            SAMlabel.Name = "SAMlabel";
            SAMlabel.Size = new Size(133, 20);
            SAMlabel.TabIndex = 19;
            SAMlabel.Text = "Can Support SAM: ";
            // 
            // SLIlabel
            // 
            SLIlabel.AutoSize = true;
            SLIlabel.Location = new Point(152, 239);
            SLIlabel.Name = "SLIlabel";
            SLIlabel.Size = new Size(121, 20);
            SLIlabel.TabIndex = 20;
            SLIlabel.Text = "Can Support SLI: ";
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SLIlabel);
            Controls.Add(SAMlabel);
            Controls.Add(RAMlabel);
            Controls.Add(Storelabel);
            Controls.Add(Caselabel);
            Controls.Add(GPUlabel);
            Controls.Add(Confirmbutton);
            Controls.Add(PSUDisp);
            Controls.Add(MOBODisp);
            Controls.Add(CoolerDisp);
            Controls.Add(ThermalDisp);
            Controls.Add(CPUDisp);
            Controls.Add(SocketDisp);
            Controls.Add(PriceDisp);
            Controls.Add(WattDisp);
            Name = "DisplayForm";
            Text = "Display";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WattDisp;
        private Label PriceDisp;
        private Label MOBODisp;
        private Label CoolerDisp;
        private Label ThermalDisp;
        private Label CPUDisp;
        private Label SocketDisp;
        private Label PSUDisp;
        private Button Confirmbutton;
        private Label GPUlabel;
        private Label Caselabel;
        private Label Storelabel;
        private Label RAMlabel;
        private Label SAMlabel;
        private Label SLIlabel;
    }
}