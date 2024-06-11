namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        Delay delay = new();
        public Form1() => InitializeComponent();

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resource1.cookie2;
            delay.Start(timer1, 10, ChangePicture);
        }

        private void ChangePicture() => pictureBox1.Image = Resource1.cookie1;


        private void timer1_Tick(object sender, EventArgs e) => delay.Tick();
    }
}
