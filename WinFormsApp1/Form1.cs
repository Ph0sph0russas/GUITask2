namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstWord = this.firstWordLabel.Text;
            var secondWord = this.secondWordLabel.Text;

            var messageAnswer=Logic.checkSameElements(firstWord, secondWord);

            MessageBox.Show(messageAnswer);
        }
    }
    public class Logic
    {
        public static string clearSameSymbolsFromWord(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (char.ToLower(word[i]) == char.ToLower(word[j]))
                    {
                        word = word.Remove(j, 1);
                        j--;
                    }
                }
            }
            return word;
        }

        public static string checkSameElements(string firstWord, string secondWord)
        {
            string clearedFirstWord = clearSameSymbolsFromWord(firstWord);
            string result = "";
            bool detected = false;
            for (int i = 0; i < clearedFirstWord.Length; i++)
            {
                for (int j = 0; j < secondWord.Length; j++)
                {
                    if (char.ToLower(clearedFirstWord[i]) == char.ToLower(secondWord[j]))
                    {
                        detected = true;
                        break;
                    }
                }
                if (detected)
                {
                    result = result + "да ";
                    detected = false;
                }
                else
                {
                    result = result + "нет ";
                }
            }
            result = result.Remove(result.Length - 1);
            return result;
        }
    }
}
