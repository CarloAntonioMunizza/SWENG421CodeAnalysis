namespace PCBuilder
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
            WishListButton = new Button();
            ImportButton = new Button();
            Titlelabel = new Label();
            Choosebutton = new Button();
            SuspendLayout();
            // 
            // WishListButton
            // 
            WishListButton.Location = new Point(387, 250);
            WishListButton.Name = "WishListButton";
            WishListButton.Size = new Size(94, 29);
            WishListButton.TabIndex = 0;
            WishListButton.Text = "WishList";
            WishListButton.UseVisualStyleBackColor = true;
            WishListButton.Click += WishListButton_Click;
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(287, 250);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(94, 29);
            ImportButton.TabIndex = 1;
            ImportButton.Text = "Import";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // Titlelabel
            // 
            Titlelabel.AutoSize = true;
            Titlelabel.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Titlelabel.ForeColor = SystemColors.HotTrack;
            Titlelabel.Location = new Point(53, 126);
            Titlelabel.Name = "Titlelabel";
            Titlelabel.Size = new Size(640, 33);
            Titlelabel.TabIndex = 2;
            Titlelabel.Text = "Welcome to Computer Component Chooser!";
            // 
            // Choosebutton
            // 
            Choosebutton.Location = new Point(287, 285);
            Choosebutton.Name = "Choosebutton";
            Choosebutton.Size = new Size(194, 29);
            Choosebutton.TabIndex = 3;
            Choosebutton.Text = "Choose Computer";
            Choosebutton.UseVisualStyleBackColor = true;
            Choosebutton.Click += Choosebutton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Choosebutton);
            Controls.Add(Titlelabel);
            Controls.Add(ImportButton);
            Controls.Add(WishListButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button WishListButton;
        private Button ImportButton;
        private Label Titlelabel;
        private Button Choosebutton;
    }
}