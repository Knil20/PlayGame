using System.Media;


namespace PlayGame
{
    public partial class formLabel1 : Form
    {
        public formLabel1()
        {
            InitializeComponent();
        }

        private void buttonLabel_Click(object sender, EventArgs e)
        {
            //Change color of button and title
            startButton.BackColor = Color.DarkMagenta;
            startButton.ForeColor = Color.DarkMagenta;

            titleLabel.ForeColor = Color.DarkMagenta;

            //Countdown
            numberLabel1.Text = "3";
            
            Refresh();
            Thread.Sleep(1000);

            numberLabel2.Text = "2";
            numberLabel1.ForeColor = Color.DarkMagenta;

            Refresh();
            Thread.Sleep(1000);

            numberLabel3.Text = "1";
            numberLabel2.ForeColor = Color.DarkMagenta;

            Refresh();
            Thread.Sleep(1000);

            numberLabel3.ForeColor = Color.DarkMagenta;

            numberLabel2.Text = "Go!";
            numberLabel2.ForeColor = Color.Black;

            
        }

        private void numberLabel3_Click(object sender, EventArgs e)
        {

        }

        private void formLabel_Load(object sender, EventArgs e)
        {

        }
    }
}