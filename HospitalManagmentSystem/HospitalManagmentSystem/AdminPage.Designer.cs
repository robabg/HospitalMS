namespace HospitalManagmentSystem
{
    partial class AdminPage
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
            menuStrip1 = new MenuStrip();
            Mn_register = new ToolStripMenuItem();
            btn_logout = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ScrollBar;
            menuStrip1.Items.AddRange(new ToolStripItem[] { Mn_register });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(771, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Mn_register
            // 
            Mn_register.Name = "Mn_register";
            Mn_register.Size = new Size(61, 20);
            Mn_register.Text = "Register";
            Mn_register.Click += toolStripMenuItem1_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = SystemColors.AppWorkspace;
            btn_logout.Location = new Point(618, 39);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(141, 23);
            btn_logout.TabIndex = 1;
            btn_logout.Text = "Log out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += button1_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 450);
            Controls.Add(btn_logout);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminPage";
            Text = "AdminPage";
            Load += AdminPage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Mn_register;
        private Button btn_logout;
    }
}