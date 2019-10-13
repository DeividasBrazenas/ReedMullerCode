using System;
using System.Linq;
using System.Windows.Forms;

namespace ReedMullerCode
{
    public partial class Form1 : Form
    {
        private readonly Channel _channel;

        public Form1()
        {
            InitializeComponent();
            _channel = new Channel();
        }

        private static int _m;

        private void MSubmitButton_Click(object sender, EventArgs e)
        {
            _m = int.Parse(MTextBox.Text);

            if (_m <= 0)
            {
                ErrorLabel.Text = "The value of parameter m should be 1 or higher";
                return;
            }

            ErrorLabel.Text = "";
            VectorLengthLabel.Text = $"Vector length should be {Vector.GetExpectedVectorLength(_m)}";
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            var vector = new Vector(VectorTextBox.Text.ToCharArray().Select(c => int.Parse(c.ToString())).ToList(), _m);

            var encodedVector = vector.Encode();

            _channel.SendThroughNoisyChannel(encodedVector, 0.7);


        }
    }
}
