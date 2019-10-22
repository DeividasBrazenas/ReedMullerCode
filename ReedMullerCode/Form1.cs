using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReedMullerCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int _m = 0;
        private static Vector _vector;
        private static Vector _encodedVector;
        private static Vector _vectorFromChannel;
        private static Channel _channel = new Channel();

        private void mVectorSubmit_Click(object sender, EventArgs e)
        {
            VectorHideEverything();

            if (!Regex.IsMatch(mVectorTextBox.Text, "^[0-9]{1,}$"))
            {
                mLengthVectorLabel.Text = $"m should be a numeric value";
                return;
            }

            _m = int.Parse(mVectorTextBox.Text);

            mLengthVectorLabel.Text = $"Expected vector length is {Vector.GetExpectedVectorLength(_m)}";

            vectorLabel.Visible = true;
            vectorTextBox.Visible = true;
            vectorTextBox.Text = "";
            vectorEncodeButton.Visible = true;
        }

        private void vectorEncodeButton_Click(object sender, EventArgs e)
        {
            if (vectorTextBox.Text.Length != Vector.GetExpectedVectorLength(_m))
            {
                vectorLengthErrorLabel.Text = $"Length of vector to encode should be {Vector.GetExpectedVectorLength(_m)}." +
                                              $" Actual length is {vectorTextBox.Text.Length}";
                return;
            }

            if (!Regex.IsMatch(vectorTextBox.Text, "^[0-1]{1,}$"))
            {
                vectorLengthErrorLabel.Text = $"Vector should contain 0s and 1s";
                return;
            }

            vectorLengthErrorLabel.Text = "";

            _vector = new Vector(vectorTextBox.Text.Select(c => int.Parse(c.ToString())).ToList(), _m);
            _encodedVector = _vector.Encode();

            encodedVectorLabel.Visible = true;
            encodedVectorText.Visible = true;
            encodedVectorText.Text = string.Join("", _encodedVector.Bits);
            vectorErrorRateLabel.Visible = true;
            vectorErrorRate.Visible = true;
            vectorErrorRate.Text = "0.0";
            vectorSendButton.Visible = true;
        }

        private void vectorSendButton_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(vectorErrorRate.Text, "^(0)$|^([0].[0-9]{1,})|^(1)$|^(1.0)$"))
            {
                vectorErrorValueLabel.Text = "Error rate should be a value between 0.0 and 1.0";
                return;
            }

            vectorErrorValueLabel.Text = "";

            _vectorFromChannel = _channel.SendThroughNoisyChannel(_encodedVector, double.Parse(vectorErrorRate.Text));
            var errors = _channel.GetErrorPositions(_encodedVector, _vectorFromChannel);

            vectorErrorCountLabel.Text = $"{errors.Count} error(s) occured at positions: {string.Join(", ", errors)}";

            vectorFromChannelLabel.Visible = true;
            vectorFromChannelText.Visible = true;
            vectorFromChannelText.Text = string.Join("", _vectorFromChannel.Bits);
            vectorDecodeButton.Visible = true;
        }

        private void vectorDecodeButton_Click(object sender, EventArgs e)
        {
            if (_encodedVector.Bits.Count != vectorFromChannelText.Text.Length)
            {
                vectorFromChannelError.Text = $"Length of vector to decode should be {_encodedVector.Bits.Count}." +
                                              $" Actual length is {vectorFromChannelText.Text.Length}";
                return;
            }

            if (!Regex.IsMatch(vectorFromChannelText.Text, "^[0-1]{1,}$"))
            {
                vectorFromChannelError.Text = $"Vector from channel should contain 0s and 1s";
                return;
            }

            vectorFromChannelError.Text = "";

            _vectorFromChannel = new Vector(vectorFromChannelText.Text.Select(c => int.Parse(c.ToString())).ToList(), _m);
            var decodedVector = _vectorFromChannel.Decode();

            decodedVectorLabel.Visible = true;
            decodedVectorText.Visible = true;
            decodedVectorText.Text = string.Join("", decodedVector.Bits);
            vectorStartAgainButton.Visible = true;
        }

        private void vectorStartAgainButton_Click(object sender, EventArgs e)
        {
            VectorHideEverything();
        }

        private void VectorHideEverything()
        {
            vectorLabel.Visible = false;
            vectorTextBox.Visible = false;
            vectorEncodeButton.Visible = false;
            encodedVectorLabel.Visible = false;
            encodedVectorText.Visible = false;
            vectorErrorRateLabel.Visible = false;
            vectorErrorRate.Visible = false;
            vectorSendButton.Visible = false;
            vectorFromChannelLabel.Visible = false;
            vectorFromChannelText.Visible = false;
            vectorDecodeButton.Visible = false;
            vectorErrorCountLabel.Text = "";
            mLengthVectorLabel.Text = "";
            decodedVectorLabel.Visible = false;
            decodedVectorText.Visible = false;
            vectorStartAgainButton.Visible = false;
        }

    }
}
