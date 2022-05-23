namespace MMK_CS_1_ColorGenerator
{
    public partial class ColorGenerator : Form
    {
        public ColorGenerator()
        {
            InitializeComponent();
        }

        private void trackBar_Color_Red_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar_Color_Red_ValueChanged(object sender, EventArgs e)
        {
            label_Color_Red_Value.Text = ((TrackBar)sender).Value.ToString();
        }

        private void trackBar_Color_Green_ValueChanged(object sender, EventArgs e)
        {
            label_Color_Green_Value.Text = ((TrackBar)sender).Value.ToString();
        }

        private void trackBar_Color_Blue_ValueChanged(object sender, EventArgs e)
        {
            label_Color_Blue_Value.Text = ((TrackBar)sender).Value.ToString();
        }
    }
}