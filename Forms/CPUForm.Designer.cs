namespace PCBuilder
{
    partial class CPUForm
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
            CPUDropDown = new ComboBox();
            MOBODropDown = new ComboBox();
            CoolerDropDown = new ComboBox();
            ThermDropDown = new ComboBox();
            Socketlabel = new Label();
            MOBOlabel = new Label();
            Coolerlabel = new Label();
            Thermlabel = new Label();
            CPUlabel = new Label();
            Nextbutton = new Button();
            SuspendLayout();
            // 
            // CPUDropDown
            // 
            CPUDropDown.FormattingEnabled = true;
            CPUDropDown.Location = new Point(12, 121);
            CPUDropDown.Name = "CPUDropDown";
            CPUDropDown.Size = new Size(151, 28);
            CPUDropDown.TabIndex = 0;
            CPUDropDown.SelectedIndexChanged += CPUDropDown_SelectedIndexChanged;
            // 
            // MOBODropDown
            // 
            MOBODropDown.FormattingEnabled = true;
            MOBODropDown.Location = new Point(643, 121);
            MOBODropDown.Name = "MOBODropDown";
            MOBODropDown.Size = new Size(151, 28);
            MOBODropDown.TabIndex = 1;
            MOBODropDown.SelectedIndexChanged += MOBODropDown_SelectedIndexChanged;
            // 
            // CoolerDropDown
            // 
            CoolerDropDown.FormattingEnabled = true;
            CoolerDropDown.Location = new Point(430, 121);
            CoolerDropDown.Name = "CoolerDropDown";
            CoolerDropDown.Size = new Size(151, 28);
            CoolerDropDown.TabIndex = 2;
            CoolerDropDown.SelectedIndexChanged += CoolerDropDown_SelectedIndexChanged;
            // 
            // ThermDropDown
            // 
            ThermDropDown.FormattingEnabled = true;
            ThermDropDown.Location = new Point(215, 121);
            ThermDropDown.Name = "ThermDropDown";
            ThermDropDown.Size = new Size(151, 28);
            ThermDropDown.TabIndex = 3;
            ThermDropDown.SelectedIndexChanged += PastesDropDown_SelectedIndexChanged;
            
            // 
            // Socketlabel
            // 
            Socketlabel.AutoSize = true;
            Socketlabel.Location = new Point(22, 308);
            Socketlabel.Name = "Socketlabel";
            Socketlabel.Size = new Size(60, 20);
            Socketlabel.TabIndex = 4;
            Socketlabel.Text = "Socket: ";
            // 
            // MOBOlabel
            // 
            MOBOlabel.AutoSize = true;
            MOBOlabel.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            MOBOlabel.ForeColor = SystemColors.HotTrack;
            MOBOlabel.Location = new Point(613, 75);
            MOBOlabel.Name = "MOBOlabel";
            MOBOlabel.Size = new Size(228, 33);
            MOBOlabel.TabIndex = 5;
            MOBOlabel.Text = "Motherboard:";
            // 
            // Coolerlabel
            // 
            Coolerlabel.AutoSize = true;
            Coolerlabel.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Coolerlabel.ForeColor = SystemColors.HotTrack;
            Coolerlabel.Location = new Point(447, 75);
            Coolerlabel.Name = "Coolerlabel";
            Coolerlabel.Size = new Size(125, 33);
            Coolerlabel.TabIndex = 6;
            Coolerlabel.Text = "Cooler:";
            // 
            // Thermlabel
            // 
            Thermlabel.AutoSize = true;
            Thermlabel.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Thermlabel.ForeColor = SystemColors.HotTrack;
            Thermlabel.Location = new Point(181, 75);
            Thermlabel.Name = "Thermlabel";
            Thermlabel.Size = new Size(233, 33);
            Thermlabel.TabIndex = 7;
            Thermlabel.Text = "Thermal Paste:";
            // 
            // CPUlabel
            // 
            CPUlabel.AutoSize = true;
            CPUlabel.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            CPUlabel.ForeColor = SystemColors.HotTrack;
            CPUlabel.Location = new Point(56, 75);
            CPUlabel.Name = "CPUlabel";
            CPUlabel.Size = new Size(77, 33);
            CPUlabel.TabIndex = 8;
            CPUlabel.Text = "CPU:";
            // 
            // Nextbutton
            // 
            Nextbutton.Location = new Point(762, 409);
            Nextbutton.Name = "Nextbutton";
            Nextbutton.Size = new Size(94, 29);
            Nextbutton.TabIndex = 9;
            Nextbutton.Text = "Next";
            Nextbutton.UseVisualStyleBackColor = true;
            Nextbutton.Click += GotoBuilder;
            // 
            // CPUForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 450);
            Controls.Add(Nextbutton);
            Controls.Add(CPUlabel);
            Controls.Add(Thermlabel);
            Controls.Add(Coolerlabel);
            Controls.Add(MOBOlabel);
            Controls.Add(Socketlabel);
            Controls.Add(ThermDropDown);
            Controls.Add(CoolerDropDown);
            Controls.Add(MOBODropDown);
            Controls.Add(CPUDropDown);
            Name = "CPUForm";
            Text = "Form1";
           
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private ComboBox CPUDropDown;
        private ComboBox MOBODropDown;
        private ComboBox CoolerDropDown;
        private ComboBox ThermDropDown;
        private Label Socketlabel;
        private Label MOBOlabel;
        private Label Coolerlabel;
        private Label Thermlabel;
        private Label CPUlabel;
        private Button Nextbutton;
    }
}