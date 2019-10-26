using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReedMullerCode.Helpers;

namespace ReedMullerCode
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static int _mText;
        private static int _mVector;
        private static int _mPicture;
        private static Bitmap _pictureBitmap;
        private static Channel _channel = new Channel();
        private static Vector _encodedVector;
        private static Vector _vectorFromChannel;
        private static VectorHelpers _vectorHelpers = new VectorHelpers(_channel);
        private static TextHelpers _textHelpers = new TextHelpers(_channel);
        private static PictureHelpers _pictureHelpers = new PictureHelpers(_channel);

        private void vectorEncodeButton_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(mVectorTextBox.Text, "^[0-9]{1,}$"))
            {
                mLengthVectorLabel.Text = $"m should be a numeric value";
                return;
            }

            _mVector = int.Parse(mVectorTextBox.Text);

            mLengthVectorLabel.Text = $"Expected vector length is {Vector.GetExpectedVectorLength(_mVector)}";

            this.Refresh();

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

            _encodedVector = _vectorHelpers.EncodeVector(vectorTextBox.Text, _mVector);

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
            if (!Regex.IsMatch(mVectorTextBox.Text, "^[0-9]{1,}$"))
            {
                mLengthVectorLabel.Text = $"m should be a numeric value";
                return;
            }

            _mVector = int.Parse(mVectorTextBox.Text);

            mLengthVectorLabel.Text = $"Expected vector length is {Vector.GetExpectedVectorLength(_mVector)}";

            this.Refresh();

            if (!Regex.IsMatch(vectorErrorRate.Text.Replace(',', '.'), "^(0)$|^([0].[0-9]{1,})|^(1)$|^(1.(0){1,})$"))
            {
                vectorErrorValueLabel.Text = "Error rate should be a value between 0.0 and 1.0";
                return;
            }

            vectorErrorValueLabel.Text = "";

            List<int> errors;
            (_vectorFromChannel, errors) = _vectorHelpers.SendThroughChannel(_encodedVector, double.Parse(vectorErrorRate.Text.Replace(',', '.')));

            vectorErrorCountLabel.Text = $"{errors.Count} error(s) occured at positions: {string.Join(", ", errors)}";

            vectorFromChannelLabel.Visible = true;
            vectorFromChannelText.Visible = true;
            vectorFromChannelText.Text = _vectorFromChannel.ToString();
            vectorDecodeButton.Visible = true;
        }

        private void vectorDecodeButton_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(mVectorTextBox.Text, "^[0-9]{1,}$"))
            {
                mLengthVectorLabel.Text = $"m should be a numeric value";
                return;
            }

            _mVector = int.Parse(mVectorTextBox.Text);

            mLengthVectorLabel.Text = $"Expected vector length is {Vector.GetExpectedVectorLength(_mVector)}";

            this.Refresh();

            if (_encodedVector.Bits.Length != vectorFromChannelText.Text.Length)
            {
                vectorFromChannelError.Text = $"Length of vector to decode should be {_encodedVector.Bits.Length}." +
                                              $" Actual length is {vectorFromChannelText.Text.Length}";
                return;
            }

            if (!Regex.IsMatch(vectorFromChannelText.Text, "^[0-1]{1,}$"))
            {
                vectorFromChannelError.Text = $"Vector from channel should contain 0s and 1s";
                return;
            }

            vectorFromChannelError.Text = "";

            _vectorFromChannel = new Vector(vectorFromChannelText.Text.Select(c => int.Parse(c.ToString())).ToArray(), _mVector);
            var decodedVector = _vectorHelpers.DecodeVector(_vectorFromChannel);

            decodedVectorLabel.Visible = true;
            decodedVectorText.Visible = true;
            decodedVectorText.Text = decodedVector.ToString();
        }

        private void textSendButton_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(mText.Text, "^[0-9]{1,}$"))
            {
                mLengthTextLabel.Text = $"m should be a numeric value";
                return;
            }

            _mText = int.Parse(mText.Text);

            mLengthTextLabel.Text = $"Text will be split into vectors of length {Vector.GetExpectedVectorLength(_mText)}";

            this.Refresh();

            if (!Regex.IsMatch(textErrorRateInput.Text.Replace(',', '.'), "^(0)$|^([0].[0-9]{1,})|^(1)$|^(1.(0){1,})$"))
            {
                textErrorLabel.Text = "Error rate should be a value between 0.0 and 1.0";
                return;
            }

            textErrorLabel.Text = "";

            var mistakeProbability = double.Parse(textErrorRateInput.Text.Replace(',', '.'));
            var binaryString = Helpers.Helpers.ConvertStringToBinary(textInput.Text);

            var stringWithCoding = _textHelpers.HandleTextWithCoding(binaryString, _mText, mistakeProbability);
            var stringWithoutCoding = _textHelpers.HandleTextWithoutCoding(binaryString, mistakeProbability);

            textWithCodingLabel.Visible = true;
            textWithCodingOutput.Visible = true;
            textWithCodingOutput.Text = stringWithCoding;
            textWithoutCodingLabel.Visible = true;
            textWithoutCodingOutput.Visible = true;
            textWithoutCodingOutput.Text = stringWithoutCoding;
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog { Filter = "BMP|*.bmp" };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _pictureBitmap = new Bitmap(ofd.FileName);
            }

            pictureErrorRateLabel.Visible = true;
            pictureErrorRateText.Visible = true;
            pictureSend.Visible = true;
            inputPictureLabel.Visible = true;
            inputPictureBox.Visible = true;
            inputPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            inputPictureBox.Image = _pictureBitmap;
        }

        private void pictureSend_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(mPictureText.Text, "^[0-9]{1,}$"))
            {
                mPictureLengthLabel.Text = $"m should be a numeric value";
                return;
            }

            _mPicture = int.Parse(mPictureText.Text);

            mPictureLengthLabel.Text = $"Text will be split into vectors of length {Vector.GetExpectedVectorLength(_mPicture)}";
            
            this.Refresh();

            if (!Regex.IsMatch(pictureErrorRateText.Text.Replace(',', '.'), "^(0)$|^([0].[0-9]{1,})|^(1)$|^(1.(0){1,})$"))
            {
                pictureErrorLabel.Text = "Error rate should be a value between 0.0 and 1.0";
                return;
            }

            var mistakeProbability = double.Parse(pictureErrorRateText.Text.Replace(',', '.'));

            var sw = new Stopwatch();
            sw.Start();

            Cursor.Current = Cursors.WaitCursor;

            var inputPictureBits = _pictureHelpers.ConvertImageToBinaryString(_pictureBitmap);

            var binaryStringWithoutHeader = _pictureHelpers.RemoveBmpHeaderFromBitArray(inputPictureBits, out var header);

            var binaryPictureWithCoding = _pictureHelpers.HandlePictureWithCoding(binaryStringWithoutHeader, _mPicture, mistakeProbability);
            var binaryPictureWithoutCoding = _pictureHelpers.HandlePictureWithoutCoding(binaryStringWithoutHeader, mistakeProbability);

            var pictureWithCoding = _pictureHelpers.ConvertBinaryStringToImage(header + binaryPictureWithCoding);
            var pictureWithoutCoding = _pictureHelpers.ConvertBinaryStringToImage(header + binaryPictureWithoutCoding);

            sw.Stop();
            Cursor.Current = Cursors.Default;
            pictureErrorLabel.Text = $"Elapsed time: {sw.Elapsed}";
            pictureWithCodingLabel.Visible = true;
            pictureBoxWithCoding.Visible = true;
            pictureBoxWithCoding.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWithCoding.Image = pictureWithCoding;

            pictureWithoutCodingLabel.Visible = true;
            pictureBoxWithoutCoding.Visible = true;
            pictureBoxWithoutCoding.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWithoutCoding.Image = pictureWithoutCoding;
        }
    }
}
