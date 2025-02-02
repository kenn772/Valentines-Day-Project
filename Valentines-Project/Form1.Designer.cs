namespace Valentines_Project
{
    partial class MainForm
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
            title = new Label();
            btnNo = new Button();
            btnYes = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            title.ForeColor = Color.PaleVioletRed;
            title.Location = new Point(109, 128);
            title.Name = "title";
            title.Size = new Size(382, 41);
            title.TabIndex = 0;
            title.Text = "Will you be my Valentine?";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.White;
            btnNo.Cursor = Cursors.Hand;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNo.ForeColor = Color.DarkRed;
            btnNo.Location = new Point(175, 259);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(100, 41);
            btnNo.TabIndex = 0;
            btnNo.TabStop = false;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            btnNo.MouseEnter += btnNo_MouseEnter;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.White;
            btnYes.Cursor = Cursors.Hand;
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnYes.ForeColor = Color.DarkGreen;
            btnYes.Location = new Point(311, 259);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(100, 41);
            btnYes.TabIndex = 2;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(582, 503);
            Controls.Add(btnYes);
            Controls.Add(btnNo);
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "<3";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button btnNo;
        private Button btnYes;
    }
}
