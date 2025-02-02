using System;

namespace Valentines_Project
{
    public partial class MainForm : Form
    {
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Width = 600;
            this.Height = 550;

            btnNo.TabStop = false;
        }

        private void btnNo_MouseEnter(object sender, EventArgs e)
        {
            int maxX = this.ClientSize.Width - btnNo.Width;
            int maxY = this.ClientSize.Height - btnNo.Height;


            int newX = random.Next(0, maxX);
            int newY = random.Next(0, maxY);

            btnNo.Location = new Point(newX, newY);
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ohh you caught me! :D");
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();

            this.Hide();    
        }
    }
}
