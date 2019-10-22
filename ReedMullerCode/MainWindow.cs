using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ReedMullerCode
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static int _mText = 0;
        private static int _mVector = 0;
        private static int _mPicture = 0;
        private static Bitmap _pictureBitmap;
        private static Channel _channel = new Channel();
        private static Vector _vector;
        private static Vector _encodedVector;
        private static Vector _vectorFromChannel;

        private void mVectorSubmit_Click(object sender, EventArgs e)
        {
            VectorHideEverything();

            if (!Regex.IsMatch(mVectorTextBox.Text, "^[0-9]{1,}$"))
            {
                mLengthVectorLabel.Text = $"m should be a numeric value";
                return;
            }

            _mVector = int.Parse(mVectorTextBox.Text);

            mLengthVectorLabel.Text = $"Expected vector length is {Vector.GetExpectedVectorLength(_mVector)}";

            vectorLabel.Visible = true;
            vectorTextBox.Visible = true;
            vectorTextBox.Text = "";
            vectorEncodeButton.Visible = true;
        }

        private void vectorEncodeButton_Click(object sender, EventArgs e)
        {
            if (vectorTextBox.Text.Length != Vector.GetExpectedVectorLength(_mVector))
            {
                vectorLengthErrorLabel.Text = $"Length of vector to encode should be {Vector.GetExpectedVectorLength(_mVector)}." +
                                              $" Actual length is {vectorTextBox.Text.Length}";
                return;
            }

            if (!Regex.IsMatch(vectorTextBox.Text, "^[0-1]{1,}$"))
            {
                vectorLengthErrorLabel.Text = $"Vector should contain 0s and 1s";
                return;
            }

            vectorLengthErrorLabel.Text = "";

            _vector = new Vector(vectorTextBox.Text.Select(c => int.Parse(c.ToString())).ToList(), _mVector);
            _encodedVector = _vector.Encode();

            encodedVectorLabel.Visible = true;
            encodedVectorText.Visible = true;
            encodedVectorText.Text = _encodedVector.ToString();
            vectorErrorRateLabel.Visible = true;
            vectorErrorRate.Visible = true;
            vectorErrorRate.Text = "0.0";
            vectorSendButton.Visible = true;
        }

        private void vectorSendButton_Click(object sender, EventArgs e)
        {
            TextHideEverything();

            if (!Regex.IsMatch(vectorErrorRate.Text, "^(0)$|^([0].[0-9]{1,})|^(1)$|^(1.(0){1,})$"))
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
            vectorFromChannelText.Text = _vectorFromChannel.ToString();
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

            _vectorFromChannel = new Vector(vectorFromChannelText.Text.Select(c => int.Parse(c.ToString())).ToList(), _mVector);
            var decodedVector = _vectorFromChannel.Decode();

            decodedVectorLabel.Visible = true;
            decodedVectorText.Visible = true;
            decodedVectorText.Text = decodedVector.ToString();
            vectorStartAgainButton.Visible = true;
        }

        private void vectorStartAgainButton_Click(object sender, EventArgs e)
        {
            VectorHideEverything();
        }

        private void VectorHideEverything()
        {
            vectorLengthErrorLabel.Text = "";
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

        private void mTextSubmit_Click(object sender, EventArgs e)
        {
            TextHideEverything();

            if (!Regex.IsMatch(mText.Text, "^[0-9]{1,}$"))
            {
                mLengthTextLabel.Text = $"m should be a numeric value";
                return;
            }

            _mText = int.Parse(mText.Text);

            mLengthTextLabel.Text = $"Text will be split into vectors of length {Vector.GetExpectedVectorLength(_mText)}";
            textLabel.Visible = true;
            textInput.Visible = true;
            textErrorRateLabel.Visible = true;
            textErrorRateInput.Visible = true;
            textErrorRateInput.Text = "0.0";
            textSendButton.Visible = true;
        }

        private void textSendButton_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textErrorRateInput.Text, "^(0)$|^([0].[0-9]{1,})|^(1)$|^(1.(0){1,})$"))
            {
                textErrorLabel.Text = "Error rate should be a value between 0.0 and 1.0";
                return;
            }

            textErrorLabel.Text = "";
            var mistakeProbability = double.Parse(textErrorRateInput.Text);
            var stringWithCoding = HandleTextWithCoding(textInput.Text, _mText, mistakeProbability);
            var stringWithoutCoding = HandleTextWithoutCoding(textInput.Text, mistakeProbability);

            textWithCodingLabel.Visible = true;
            textWithCodingOutput.Visible = true;
            textWithCodingOutput.Text = stringWithCoding;
            textWithoutCodingLabel.Visible = true;
            textWithoutCodingOutput.Visible = true;
            textWithoutCodingOutput.Text = stringWithoutCoding;
            textStartAgainButton.Visible = true;
        }

        private void textStartAgainButton_Click(object sender, EventArgs e)
        {
            TextHideEverything();
        }

        private string HandleTextWithCoding(string text, int m, double mistakeProbability)
        {
            var binaryString = ConvertStringToBinary(text);
            var vectors = ConvertStringToVectors(binaryString, m, out var appendedBits);

            var encodedVectors = vectors.Select(x => x.Encode()).ToList();

            var vectorsFromChannel = new List<Vector>();
            for (var i = 0; i < encodedVectors.Count - 1; i++)
            {
                vectorsFromChannel.Add(_channel.SendThroughNoisyChannel(encodedVectors[i], mistakeProbability));
            }

            vectorsFromChannel.Add(appendedBits == 0
                ? _channel.SendThroughNoisyChannel(encodedVectors[encodedVectors.Count - 1], mistakeProbability)
                : encodedVectors[encodedVectors.Count - 1]);

            var decodedVectors = vectorsFromChannel.Select(x => x.Decode()).ToList();

            var decodedBinaryString = ConvertVectorsToString(decodedVectors, appendedBits);

            return ConvertBinaryToString(decodedBinaryString);
        }

        private string HandleTextWithoutCoding(string text, double mistakeProbability)
        {
            var binaryString = ConvertStringToBinary(text);

            var stringFromChannel = _channel.SendThroughNoisyChannel(binaryString, mistakeProbability);

            return ConvertBinaryToString(stringFromChannel);
        }

        private List<Vector> ConvertStringToVectors(string text, int m, out int appendedBits)
        {
            var vectors = text.SplitInParts(Vector.GetExpectedVectorLength(m)).ToList();

            appendedBits = Vector.GetExpectedVectorLength(m) - vectors.Last().Length;
            vectors[vectors.Count - 1] = AppendBits(vectors[vectors.Count - 1], appendedBits);

            return vectors.Select(x => new Vector(x, m)).ToList();
        }
        private string ConvertVectorsToString(List<Vector> vectors, int appendedBits)
        {
            var str = string.Join("", vectors.Select(x => x.ToString()));
            return str.Substring(0, str.Length - appendedBits);
        }

        private string ConvertStringToBinary(string text)
        {
            return string.Join("", Encoding.ASCII.GetBytes(text).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
        }

        public static string ConvertBinaryToString(string data)
        {
            var byteList = new List<byte>();

            for (var i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }

            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        private string AppendBits(string text, int bitsToAppend)
        {
            for (var i = 0; i < bitsToAppend; i++)
            {
                text += "0";
            }

            return text;
        }

        private void TextHideEverything()
        {
            mLengthTextLabel.Text = "";
            textLabel.Visible = false;
            textInput.Visible = false;
            textErrorRateLabel.Visible = false;
            textErrorRateInput.Visible = false;
            textSendButton.Visible = false;
            textWithCodingLabel.Visible = false;
            textWithCodingOutput.Visible = false;
            textWithoutCodingLabel.Visible = false;
            textWithoutCodingOutput.Visible = false;
            textStartAgainButton.Visible = false;
        }

        private void mPictureSubmit_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(mPictureText.Text, "^[0-9]{1,}$"))
            {
                mPictureLengthLabel.Text = $"m should be a numeric value";
                return;
            }

            _mPicture = int.Parse(mPictureText.Text);

            mPictureLengthLabel.Text = $"Text will be split into vectors of length {Vector.GetExpectedVectorLength(_mPicture)}";
            openFileButton.Visible = true;
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            ofd.Filter = "BMP|*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _pictureBitmap = new Bitmap(ofd.FileName);
            }

            pictureErrorRateLabel.Visible = true;
            pictureErrorRateText.Visible = true;
            pictureSend.Visible = true;
            inputPictureLabel.Visible = true;
            inputPictureBox.Visible = true;
            inputPictureBox.Image = _pictureBitmap;
        }

        private string ConvertImageToBinaryString(Image img)
        {
            var converter = new ImageConverter();
            var bytes = (byte[])converter.ConvertTo(img, typeof(byte[]));

            return string.Join("", bytes.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
        }
    }
}
