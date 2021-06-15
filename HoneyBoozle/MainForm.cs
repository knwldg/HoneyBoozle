using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HoneyBoozle
{
    public partial class MainForm : Form
    {
        private readonly ILookup<int, string> _wordsByLength;
        private IEnumerable<string> _filteredResults;

        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Minimized;
            using (var dialog = new OpenFileDialog {Filter = @"Text files (*.txt)|*.txt"})
            {
                dialog.ShowDialog();
                try
                {
                    _wordsByLength = LoadWords(dialog.FileName);
                    Show();
                    WindowState = FormWindowState.Normal;
                }
                catch (Exception e)
                {
                    MessageBox.Show($@"Error loading words! {e.Message}", @":(", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

            totalWordsLoaded.Text = $@"Words loaded: {_wordsByLength.Sum(x => x.Count()).ToString()}";
        }

        private ILookup<int, string> LoadWords(string wordPath) =>
            File.ReadAllLines(wordPath).ToLookup(x => x.Length, x => x);

        private IEnumerable<string> FilterByLength(int length) => _wordsByLength[length];

        private IEnumerable<string> FilterByContainsAllChars(IEnumerable<string> words, char[] chars) =>
            words.Where(x => chars.All(x.Contains));

        private IEnumerable<string> FilterByContainsSome(IEnumerable<string> words, char[] chars) =>
            words.Where(x => chars.Any(x.Contains));

        private IEnumerable<string> FilterByContainsIllegal(IEnumerable<string> words, char[] chars) =>
            words.Where(x => x.All(chars.Contains));

        private IEnumerable<string> FilterByContainsTooMany(IEnumerable<string> words, char[] chars) =>
            words.Where(x => !chars.Any(c => chars.Count(z => z == c) < x.Count(p => p == c)));

        private IEnumerable<string> FilterByCharPosition(IEnumerable<string> words, int position, char c) =>
            words.Where(x => x.Length >= position && x[position - 1] == c);

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var length = Convert.ToInt32(textBox1.Text);
            var chars = textBox2.Text.ToCharArray();

            _filteredResults = FilterByLength(length);

            if (length >= chars.Length)
                _filteredResults = FilterByContainsAllChars(_filteredResults, chars);
            else
            {
                _filteredResults = FilterByContainsIllegal(_filteredResults, chars);
                _filteredResults = FilterByContainsTooMany(_filteredResults, chars);
                _filteredResults = FilterByContainsSome(_filteredResults, chars);
            }

            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                var pairs = textBox3.Text.Split(',');
                foreach (var pair in pairs)
                    _filteredResults =
                        FilterByCharPosition(_filteredResults, (int) char.GetNumericValue(pair[0]), pair[1]);
            }

            var finalFiltered = _filteredResults.ToArray();
            filteredWords.Text = $@"Possible results: {finalFiltered.Length}";
            foreach (var word in finalFiltered) dataGridView1.Rows.Add(word);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            _filteredResults = null;
            filteredWords.Text = @"Filtered words: 0";
        }
    }
}