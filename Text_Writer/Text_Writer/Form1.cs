using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Text_Writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string pathFile;
        string[] words;
        private void OpenFileForCorrect(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "text|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PathFileItem.Text = $"Path file: {dialog.FileName}";
                pathFile = dialog.FileName ;
                MainEnterText.Text = File.ReadAllText(dialog.FileName);
                SaveFileItem.Enabled = true;
                CheckCountWords(sender, e);
            }
        }
        private void CreateFile(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "text|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PathFileItem.Text = $"Path file: {dialog.FileName}";
                pathFile = dialog.FileName;
                File.WriteAllText(dialog.FileName, MainEnterText.Text);
                SaveFileItem.Enabled = true;
            }
        }
        private void SaveCorrectFile(object sender, EventArgs e)
        {
            File.WriteAllText(pathFile, MainEnterText.Text);
        }
        private void NightTheme(object sender, EventArgs e)
        {
            UpBarMenu.BackColor = Color.FromArgb(62, 63, 64);
            NewFileItem.BackColor = Color.FromArgb(62, 63, 64);
            NewFileItem.ForeColor = Color.FromArgb(255, 255, 255);
            OpenFileItem.BackColor = Color.FromArgb(62, 63, 64);
            OpenFileItem.ForeColor = Color.FromArgb(255, 255, 255);
            SaveFileItem.BackColor = Color.FromArgb(62, 63, 64);
            SaveFileItem.ForeColor = Color.FromArgb(255, 255, 255);
            PathFileItem.BackColor = Color.FromArgb(25, 25, 25);
            PathFileItem.ForeColor = Color.FromArgb(255, 255, 255);
            LeftBarTextOption.BackColor = Color.FromArgb(62, 63, 64);
            MainEnterText.BackColor = Color.FromArgb(37, 38, 39);
            LimitWords.BackColor = Color.FromArgb(37, 38, 39);
            LimitWords.ForeColor = Color.FromArgb(255, 255, 255);
            PanelCountWords.BackColor = Color.FromArgb(37, 38, 39);
        }
        private void DayTheme(object sender, EventArgs e)
        {
            UpBarMenu.BackColor = Color.FromArgb(171, 134, 255);
            NewFileItem.BackColor = Color.FromArgb(171, 134, 255);
            NewFileItem.ForeColor = Color.FromArgb(255, 255, 255);
            OpenFileItem.BackColor = Color.FromArgb(171, 134, 255);
            OpenFileItem.ForeColor = Color.FromArgb(255, 255, 255);
            SaveFileItem.BackColor = Color.FromArgb(171, 134, 255);
            SaveFileItem.ForeColor = Color.FromArgb(255, 255, 255);
            PathFileItem.BackColor = Color.FromArgb(218, 209, 238);
            PathFileItem.ForeColor = Color.FromArgb(255, 255, 255);
            LeftBarTextOption.BackColor = Color.FromArgb(171, 134, 255);
            MainEnterText.BackColor = Color.FromArgb(255, 255, 255);
            LimitWords.BackColor = Color.FromArgb(255, 255, 255);
            LimitWords.ForeColor = Color.FromArgb(0, 0, 0);
            PanelCountWords.BackColor = Color.FromArgb(100, 35, 238);
        }
        private void ExitForApp(object sender, EventArgs e)
        {
            if (pathFile != null)
            {
                if (MainEnterText.Text != File.ReadAllText(pathFile))
                {
                    DialogResult result = MessageBox.Show("You want to save changes to the file?\n" + pathFile, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SaveCorrectFile(sender, e);
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("You want to save text?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CreateFile(sender, e);
                }
            }
        }
        private void ChangeTextFamily(object sender, EventArgs e) => MainEnterText.Font = new Font(TextFontFamily.SelectedItem.ToString(), MainEnterText.Font.Size, MainEnterText.Font.Style);
        private void ChangeTextSize(object sender, EventArgs e) => MainEnterText.Font = new Font(MainEnterText.Font.FontFamily, float.Parse(TextFontSize.SelectedItem.ToString()), MainEnterText.Font.Style);
        private void ChangeTextStyleBold(object sender, EventArgs e)
        {
            CheckButtonClickStyleText();
            ClickColorButton(BoldText);
            MainEnterText.Font = new Font(MainEnterText.Font.FontFamily, MainEnterText.Font.Size, FontStyle.Bold);
        }
        private void ChangeTextStyleItalic(object sender, EventArgs e)
        {
            CheckButtonClickStyleText();
            ClickColorButton(ItalicText);
            MainEnterText.Font = new Font(MainEnterText.Font.FontFamily, MainEnterText.Font.Size, FontStyle.Italic);
        }
        private void ChangeTextStyleRegular(object sender, EventArgs e)
        {
            CheckButtonClickStyleText();
            ClickColorButton(RegularText);
            MainEnterText.Font = new Font(MainEnterText.Font.FontFamily, MainEnterText.Font.Size, FontStyle.Regular);
        }
        private void ChangeTextStyleStrikeout(object sender, EventArgs e)
        {
            CheckButtonClickStyleText();
            ClickColorButton(StrikeoutText);
            MainEnterText.Font = new Font(MainEnterText.Font.FontFamily, MainEnterText.Font.Size, FontStyle.Strikeout);
        }
        private void ChangeTextStyleUnderline(object sender, EventArgs e)
        {
            CheckButtonClickStyleText();
            ClickColorButton(UnderlineText);
            MainEnterText.Font = new Font(MainEnterText.Font.FontFamily, MainEnterText.Font.Size, FontStyle.Underline);
        }
        private void ChangePositionLeft(object sender, EventArgs e)
        {
            CheckButtonClickTextPosition();
            ClickColorButton(LeftPositionText);
            MainEnterText.TextAlign = HorizontalAlignment.Left;
        }
        private void ChangePositionCenter(object sender, EventArgs e)
        {
            CheckButtonClickTextPosition();
            ClickColorButton(CenterPositionText);
            MainEnterText.TextAlign = HorizontalAlignment.Center;
        }
        private void ChangePositionRight(object sender, EventArgs e)
        {
            CheckButtonClickTextPosition();
            ClickColorButton(RightPositionText);
            MainEnterText.TextAlign = HorizontalAlignment.Right;
        }
        private void ColorDialogText(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if(color.ShowDialog() == DialogResult.OK)
            {
                MainEnterText.ForeColor = color.Color;
                ColorText.BackColor= color.Color;
            }
        }
        private void FixationLimitWord(object sender, EventArgs e)
        {
            ProgressBarWords.Maximum = int.Parse(LimitWords.Text);
        }
        
        private void CheckCountWords(object sender, EventArgs e)
        {
            words = MainEnterText.Text.Split(new char[] { ' ', '.', ',', ';', ':', '-', '!', '?', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            //freq = MainEnterText.Text.Where(f => MainEnterText.Text[MainEnterText.Text.Length - 1] == ' ' && f != ' ').Count();
            AmountWords.Text = words.Length + " /";
            if(words.Length <= ProgressBarWords.Maximum)
                ProgressBarWords.Value = words.Length;
        }
        private void CheckButtonClickStyleText()
        {
            if(BoldText.BackColor == Color.FromArgb(0, 125, 230))
            {
                BoldText.BackColor = Color.FromArgb(255, 255, 255);
                BoldText.ForeColor = Color.FromArgb(0, 0, 0);
            }
            if(ItalicText.BackColor == Color.FromArgb(0, 125, 230))
            {
                ItalicText.BackColor = Color.FromArgb(255, 255, 255);
                ItalicText.ForeColor = Color.FromArgb(0, 0, 0);
            }
            if(RegularText.BackColor == Color.FromArgb(0, 125, 230))
            {
                RegularText.BackColor = Color.FromArgb(255, 255, 255);
                RegularText.ForeColor = Color.FromArgb(0, 0, 0);
            }
            if(StrikeoutText.BackColor == Color.FromArgb(0, 125, 230))
            {
                StrikeoutText.BackColor = Color.FromArgb(255, 255, 255);
                StrikeoutText.ForeColor = Color.FromArgb(0, 0, 0);
            }
            if(UnderlineText.BackColor == Color.FromArgb(0, 125, 230))
            {
                UnderlineText.BackColor = Color.FromArgb(255, 255, 255);
                UnderlineText.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }
        private void CheckButtonClickTextPosition()
        {
            if (LeftPositionText.BackColor == Color.FromArgb(0, 125, 230))
            {
                LeftPositionText.BackColor = Color.FromArgb(255, 255, 255);
                LeftPositionText.ForeColor = Color.FromArgb(0, 0, 0);
            }
            if (CenterPositionText.BackColor == Color.FromArgb(0, 125, 230))
            {
                CenterPositionText.BackColor = Color.FromArgb(255, 255, 255);
                CenterPositionText.ForeColor = Color.FromArgb(0, 0, 0);
            }
            if (RightPositionText.BackColor == Color.FromArgb(0, 125, 230))
            {
                RightPositionText.BackColor = Color.FromArgb(255, 255, 255);
                RightPositionText.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }
        private void ClickColorButton(Button button)
        {
            button.BackColor = Color.FromArgb(0, 125, 230);
            button.ForeColor = Color.FromArgb(255, 255, 255);
        }
    }
    
}
