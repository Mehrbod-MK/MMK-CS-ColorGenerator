namespace MMK_CS_1_ColorGenerator
{
    public partial class ColorGenerator : Form
    {
        public ColorGenerator()
        {
            InitializeComponent();

            // Add event handlers for labels.

        }

        private void trackBar_Color_Red_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar_Color_Red_ValueChanged(object sender, EventArgs e)
        {
            label_Color_Red_Value.Text = ((TrackBar)sender).Value.ToString();

            updateColors();
        }

        private void trackBar_Color_Green_ValueChanged(object sender, EventArgs e)
        {
            label_Color_Green_Value.Text = ((TrackBar)sender).Value.ToString();

            updateColors();
        }

        private void trackBar_Color_Blue_ValueChanged(object sender, EventArgs e)
        {
            label_Color_Blue_Value.Text = ((TrackBar)sender).Value.ToString();

            updateColors();
        }

        public void updateColors()
        {
            label_ColorView.BackColor = Color.FromArgb(Convert.ToInt32(label_Color_Red_Value.Text),
                                                       Convert.ToInt32(label_Color_Green_Value.Text),
                                                       Convert.ToInt32(label_Color_Blue_Value.Text));
        }

        public void setLabelColors(Label lbl, Color col)
        {
            if(checkBox_Painter_BkgColor.Checked)
                lbl.BackColor = col;
            if(checkBox_Painter_FrgColor.Checked)
                lbl.ForeColor = col;
        }

        private void label_TextView_Click(object sender, EventArgs e)
        {
            setLabelColors((Label)sender, label_ColorView.BackColor);
        }
    }
}