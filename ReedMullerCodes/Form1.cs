using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReedMullerCodes
{
    public partial class Form1 : Form
    {
        private MatrixGenerator _matrixGenerator;
        private Encoder _encoder;
        private Channel _channel;
        private Decoder _decoder;
        private List<int> _encodedVector;
        private int _m;
        private int _r;
        private int zerosAdded;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Reed Muller Codes";
            Initialize();
        }

        public void Initialize()
        {
            vectorPanel.Visible = false;
            textPanel.Visible = false;
        }

        private void onVectorClick(object sender, EventArgs e)
        {
            if ((_m != 0) && (_r != 0))
            {
                var length = CountVectorLength(_m, _r);
                vectorLength.Text = length.ToString();
            }

            textPanel.Visible = false;
            vectorPanel.Visible = true;
            probabilityLabel.Visible = false;
            probabilityTextBox.Visible = false;
            encodedVectorLabel.Visible = false;
            encodedVectorTextBox.Visible = false;
            sendVectorButton.Visible = false;
            receivedVectorLabel.Visible = false;
            receivedVectorTextBox.Visible = false;
            decodeVectorButton.Visible = false;
            decodedVectorTextBox.Visible = false;
            decodedVectorLabel.Visible = false;
            mistakesFoundLabel.Visible = false;
            mistakesFoundTextBox.Visible = false;
            mistakesPositionsLabel.Visible = false;
            mistakesPositionsTextBox.Visible = false;
        }

        private void EnterVector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!("\b01".Contains(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
            bool isCorrectLength;
            if (e.KeyChar != '\b')
            {
                isCorrectLength = enterVectorTextBox.Text.Length < int.Parse(vectorLength.Text);
            } else
            {
                isCorrectLength = true;
            }

            e.Handled = !isCorrectLength;
        }

        private void VectorEnter_OnClick(object sender, EventArgs e)
        {
            var maxLength = int.Parse(vectorLength.Text);
            if (maxLength != enterVectorTextBox.Text.Length)
            {
                MessageBox.Show($"Vector's length must be {maxLength} digits.");
                return;
            }

            _m = int.Parse(parameterMTextBox.Text);
            _r = int.Parse(parameterRTextBox.Text);

            _matrixGenerator = new MatrixGenerator(_m, _r);
            _encoder = new Encoder(_m, _r);

            var matrix = _matrixGenerator.GenerateMatrix();

            var vectorString = enterVectorTextBox.Text;

            var vector = vectorString.ToCharArray().Select(x => int.Parse(x.ToString())).ToList();
            _encodedVector = _encoder.EncodeVector(vector, matrix);

            encodedVectorTextBox.Text = _encodedVector.ListToString();

            encodedVectorLabel.Visible = true;
            encodedVectorTextBox.Visible = true;
            sendVectorButton.Visible = true;
            probabilityLabel.Visible = true;
            probabilityTextBox.Visible = true;
        }

        private void Parameters_OnClick(object sender, EventArgs e)
        {
            int m = int.Parse(parameterMTextBox.Text);
            int r = int.Parse(parameterRTextBox.Text);
            if (r > m)
            {
                MessageBox.Show("Parameter R can't be higher than M");
                return;
            }

            _m = m;
            _r = r;

            if (vectorPanel.Visible)
            {
                enterVectorLabel.Visible = true;
                enterVectorTextBox.Visible = true;
                enterVectorSubmit.Visible = true;

                vectorLength.Visible = true;
                var length = CountVectorLength(m, r);
                vectorLength.Text = length.ToString();

                var maxLength = int.Parse(vectorLength.Text);
                var lengthOfEnteredVector = enterVectorTextBox.Text.Length;

                if (maxLength < lengthOfEnteredVector)
                {
                    enterVectorTextBox.Text = enterVectorTextBox.Text.Substring(0, maxLength);
                }
            }
        }

        private void ParameterR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ParameterMTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private int CountVectorLength(int m, int r)
        {
            return m.CountCombination(r);
        }

        private void sendVectorButton_Click(object sender, EventArgs e)
        {
            double probability;
            if (!double.TryParse(probabilityTextBox.Text, out probability))
            {
                MessageBox.Show("Probability must be a number.");
                return;
            }

            if (probability >= 1 || probability <= 0)
            {
                MessageBox.Show($"Probability must be between 0 and 1");
                return;
            }

            _channel = new Channel(probability);
            var receivedVector = _channel.SendVector(_encodedVector);
            var mistakesFound = _channel.MistakesPositions;

            receivedVectorTextBox.Text = receivedVector.ListToString();
            mistakesFoundTextBox.Text = mistakesFound.Count.ToString();
            mistakesPositionsTextBox.Text = mistakesFound.ListToCommaSeparatedString();

            receivedVectorLabel.Visible = true;
            receivedVectorTextBox.Visible = true;
            mistakesFoundLabel.Visible = true;
            mistakesFoundTextBox.Visible = true;
            mistakesPositionsLabel.Visible = true;
            mistakesPositionsTextBox.Visible = true;
            decodeVectorButton.Visible = true;
        }

        private void decodeVectorButton_Click(object sender, EventArgs e)
        {
            _decoder = new Decoder(_m, _r, _matrixGenerator.Matrix);

            var receivedVector = receivedVectorTextBox.Text.StringToIntList();
            var decodedVector = _decoder.Decode(receivedVector);

            decodedVectorTextBox.Text = decodedVector.ListToString();
            decodedVectorLabel.Visible = true;
            decodedVectorTextBox.Visible = true;
        }

        private void onTextClick(object sender, EventArgs e)
        {
            textPanel.Visible = true;
            vectorPanel.Visible = false;
        }

        private void encodeTextButton_Click(object sender, EventArgs e)
        {
            if((_m == 0) || (_r ==0))
            {
                MessageBox.Show("Parameters are not submited!");
                return;
            }
            double probability;
            if (!double.TryParse(textProbabilityTextBox.Text, out probability))
            {
                MessageBox.Show("Probability must be a number.");
                return;
            }

            if (probability >= 1 || probability <= 0)
            {
                MessageBox.Show($"Probability must be between 0 and 1");
                return;
            }

            var text = enterTextTextBox.Text;

            var vectors = SplitIntoVectors(Encoding.UTF8, text);

            _matrixGenerator = new MatrixGenerator(_m, _r);
            var matrix = _matrixGenerator.GenerateMatrix();

            _encoder = new Encoder(_m, _r);

            //encode vectors
            var encodedVectors = vectors.Select(vector => _encoder.EncodeVector(vector, matrix)).ToList();

            var encodedVectorsString = encodedVectors.Select(vector => vector.ListToString()).ToList();
            var plainTextVectorListString = vectors.Select(vector => vector.ListToString()).ToList();

            encodedTextTextBox.Text = encodedVectorsString.StringListToString();
            plainTextBytesTextBox.Text = plainTextVectorListString.StringListToString();

            //send through channel
            _channel = new Channel(probability);
            var receivedEncodedVectors = encodedVectors.Select(vector => _channel.SendVector(vector)).ToList();
            var receivedPlainTextVectors = vectors.Select(vector => _channel.SendVector(vector)).ToList();

            receivedPlainTextTextBox.Text = receivedPlainTextVectors.Select(x => x.ListToString()).ToList().StringListToString();
            receivedTextTextBox.Text = receivedEncodedVectors.Select(x => x.ListToString()).ToList().StringListToString();


            //decode
            _decoder = new Decoder(_m, _r, matrix);
            var decodedVectors = receivedEncodedVectors.Select(vector => _decoder.Decode(vector).ListToString()).ToList();


            BytesToPlainText(receivedPlainTextVectors);
            DecodeTextVector(decodedVectors);

            ShowTextControllsAfterEncoding();
        }

        private void BytesToPlainText(List<List<int>> plainTextVectors)
        {
            var decodedVectorList = new List<int>();
            var vector = new List<string>();
            foreach (List<int> list in plainTextVectors)
            {
                vector.Add(string.Join("", list));
            }
            vector = VectorListToBytes(vector);
            string result = "";
            foreach (string bytes in vector)
            {
                var bits = bytes.Substring(0, 8);
                var number = Convert.ToInt32(bits, 2);
                result += (char)number;
            }

            resultPlainTextBox.Text = result;
        }

        private void DecodeTextVector(List<string> decodedVectors)
        {
            var vectors = new List<string>();
            
            vectors = VectorListToBytes(decodedVectors);
            string result = "";
            foreach (string bytes in vectors)
            {
                var first8 = bytes.Substring(0, 8);
                var number = Convert.ToInt32(first8, 2);
                result += (char)number;

            }
            decodedTextTextBox.Text = result;
        }

        private List<string> VectorListToBytes(List<string> vectorList)
        {
            var byteWord = string.Join("", vectorList);
            var wordBytes = new List<string>();
            var length = byteWord.Length;
            List<int> bytesList;
            byteWord = byteWord.Remove(length - zerosAdded, zerosAdded);

            while (byteWord.Length > 0)
            {
                bytesList = new List<int>();
                for (int i = 0; i < 8; i++)
                {
                    int bit = Convert.ToInt32(char.GetNumericValue(byteWord.ElementAt(i)));
                    bytesList.Add(bit);
                }
                byteWord = byteWord.Remove(0, 8);
                wordBytes.Add(string.Join("", bytesList));
            }

            return wordBytes;
        }

        private void ShowTextControllsAfterEncoding()
        {
            encodedTextLabel.Visible = true;
            encodedTextTextBox.Visible = true;
            plainTextBytesLabel.Visible = true;
            plainTextBytesTextBox.Visible = true;
            receivedPlainTextLabel.Visible = true;
            receivedTextLabel.Visible = true;
            receivedTextTextBox.Visible = true;
            receivedPlainTextTextBox.Visible = true;
            decodedTextLabel.Visible = true;
            decodedTextTextBox.Visible = true;
            resultPlainTextBox.Visible = true;
        }

        private List<List<int>> SplitIntoVectors(Encoding encoding, string text)
        {
            zerosAdded = 0;
            var listOfVectors = new List<List<int>>();
            var bits = string.Join("",encoding.GetBytes(text).Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToList());
            var bitsList = bits.StringToIntList();
            int k = _m.CountCombination(_r);
            while (bitsList.Count > 0)
            {
                var vector = new List<int>();
                if (bitsList.Count < k)
                {
                    for (int i = 0; i < bitsList.Count; i++)
                    {
                        vector.Add(bitsList[i]);
                    }

                    for (int i = 0; i < k - bitsList.Count; i++)
                    {
                        vector.Add(0);
                        zerosAdded++;
                    }
                    bitsList.RemoveRange(0, bitsList.Count);
                    listOfVectors.Add(vector);
                }
                else
                {
                    for (int i = 0; i < k; i++)
                    {
                        vector.Add(bitsList[i]);
                    }
                    listOfVectors.Add(vector);
                    bitsList.RemoveRange(0, k);
                }
            }

            return listOfVectors;
        }
    }
}
