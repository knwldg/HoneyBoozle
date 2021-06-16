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

        private static ILookup<int, string> LoadWords(string wordPath) =>
            File.ReadAllLines(wordPath).ToLookup(x => x.Length, x => x);

        private IEnumerable<string> FilterByLength(int length) => _wordsByLength[length];

        private static IEnumerable<string> FilterByContainsAllChars(IEnumerable<string> words, char[] chars) =>
            words.Where(x => chars.All(x.Contains));

        private static IEnumerable<string> FilterByContainsSomeChars(IEnumerable<string> words, char[] chars) =>
            words.Where(x => chars.Any(x.Contains));

        private static IEnumerable<string> FilterByOnlyContainsLegal(IEnumerable<string> words, char[] chars) =>
            words.Where(x => x.All(chars.Contains));

        private static IEnumerable<string> FilterByContainsTooMany(IEnumerable<string> words, char[] chars) =>
            words.Where(x => !chars.Any(c => x.Count(p => p == c) > chars.Count(z => z == c)));

        private static IEnumerable<string> FilterByCharPosition(IEnumerable<string> words, int position, char c) =>
            words.Where(x => x.Length >= position && x[position - 1] == c);

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

        private void FilterButton_Click(object sender, EventArgs e)
        {
            wordGridView.Rows.Clear();

            var length = Convert.ToInt32(wordLengthBox.Text);
            var chars = charBox.Text.ToCharArray();

            _filteredResults = FilterByLength(length);
            _filteredResults = FilterByContainsTooMany(_filteredResults, chars);
            _filteredResults = FilterByOnlyContainsLegal(_filteredResults, chars);

            _filteredResults = length >= chars.Length
                ? FilterByContainsAllChars(_filteredResults, chars)
                : FilterByContainsSomeChars(_filteredResults, chars);

            if (!string.IsNullOrWhiteSpace(knownPositionBox.Text))
            {
                var pairs = knownPositionBox.Text.Split(',');
                foreach (var pair in pairs)
                {
                    var letter = pair[^1];
                    var position = int.Parse(pair.Replace(letter, ' '));
                    _filteredResults =
                        FilterByCharPosition(_filteredResults, position, letter);
                }
            }

            var finalFiltered = _filteredResults.ToArray();
            filteredWords.Text = $@"Possible results: {finalFiltered.Length}";
            foreach (var word in finalFiltered) wordGridView.Rows.Add(word);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            wordGridView.Rows.Clear();
            _filteredResults = null;
            filteredWords.Text = @"Filtered words: 0";
        }
    }
}