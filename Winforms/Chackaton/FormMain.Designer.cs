namespace Chackaton
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelSideMenu = new Panel();
            panelManualMenu = new Panel();
            buttonManual = new Button();
            panelBacklight2 = new Panel();
            panelLogo = new Panel();
            pictureBoxLogo = new PictureBox();
            labelLogo = new Label();
            labelGreeting = new Label();
            panelMain = new Panel();
            panelSideMenu.SuspendLayout();
            panelManualMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(231, 238, 255);
            panelSideMenu.Controls.Add(panelManualMenu);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(225, 641);
            panelSideMenu.TabIndex = 1;
            // 
            // panelManualMenu
            // 
            panelManualMenu.BackColor = Color.FromArgb(208, 218, 255);
            panelManualMenu.Controls.Add(buttonManual);
            panelManualMenu.Controls.Add(panelBacklight2);
            panelManualMenu.Dock = DockStyle.Top;
            panelManualMenu.Location = new Point(0, 125);
            panelManualMenu.Name = "panelManualMenu";
            panelManualMenu.Size = new Size(225, 80);
            panelManualMenu.TabIndex = 4;
            // 
            // buttonManual
            // 
            buttonManual.BackColor = Color.FromArgb(208, 218, 255);
            buttonManual.Cursor = Cursors.Hand;
            buttonManual.Dock = DockStyle.Fill;
            buttonManual.FlatAppearance.BorderSize = 0;
            buttonManual.FlatStyle = FlatStyle.Flat;
            buttonManual.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            buttonManual.ForeColor = Color.Black;
            buttonManual.Image = (Image)resources.GetObject("buttonManual.Image");
            buttonManual.ImageAlign = ContentAlignment.MiddleLeft;
            buttonManual.Location = new Point(8, 0);
            buttonManual.Name = "buttonManual";
            buttonManual.Size = new Size(217, 80);
            buttonManual.TabIndex = 2;
            buttonManual.Text = "Управление";
            buttonManual.TextAlign = ContentAlignment.MiddleRight;
            buttonManual.UseVisualStyleBackColor = false;
            buttonManual.Click += buttonManual_Click;
            // 
            // panelBacklight2
            // 
            panelBacklight2.BackColor = Color.FromArgb(2, 100, 254);
            panelBacklight2.Dock = DockStyle.Left;
            panelBacklight2.Location = new Point(0, 0);
            panelBacklight2.Name = "panelBacklight2";
            panelBacklight2.Size = new Size(8, 80);
            panelBacklight2.TabIndex = 0;
            panelBacklight2.Visible = false;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Controls.Add(labelLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(225, 125);
            panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.InitialImage = (Image)resources.GetObject("pictureBoxLogo.InitialImage");
            pictureBoxLogo.Location = new Point(10, 22);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(80, 80);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            labelLogo.ForeColor = Color.Black;
            labelLogo.Location = new Point(95, 22);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(98, 37);
            labelLogo.TabIndex = 0;
            labelLogo.Text = "Хаббл";
            // 
            // labelGreeting
            // 
            labelGreeting.BackColor = Color.White;
            labelGreeting.Dock = DockStyle.Fill;
            labelGreeting.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelGreeting.Location = new Point(0, 0);
            labelGreeting.Name = "labelGreeting";
            labelGreeting.Size = new Size(1419, 641);
            labelGreeting.TabIndex = 2;
            labelGreeting.Text = "Добро пожаловать!\r\nПроект команды Хаббл";
            labelGreeting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(labelGreeting);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(225, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1419, 641);
            panelMain.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1644, 641);
            Controls.Add(panelMain);
            Controls.Add(panelSideMenu);
            Name = "FormMain";
            ShowIcon = false;
            Text = "Управление биореактором";
            panelSideMenu.ResumeLayout(false);
            panelManualMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelManualMenu;
        private Button buttonManual;
        private Panel panelBacklight2;
        private Panel panelLogo;
        private PictureBox pictureBoxLogo;
        private Label labelLogo;
        private Label labelGreeting;
        private Panel panelMain;
    }
}
