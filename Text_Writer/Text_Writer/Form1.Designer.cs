using System.Drawing;
using System.Windows.Forms;

namespace Text_Writer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Text = "My Text Editor";
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Load += ChangeTextStyleRegular;
            this.Load += ChangePositionLeft;
            this.Load += DayTheme;
            this.FormClosed += ExitForApp;
            this.SizeChanged += (s, e) =>
            {
                LeftBarTextOption.Width = this.Width / 4;
                LeftBarTextOption.Height = this.Height - UpBarMenu.Height - 38;
                LeftBarTextOption.Location = new Point(0, UpBarMenu.Height);


                FontFamilyLabel.Width = LeftBarTextOption.Width / 4;
                FontFamilyLabel.Font = new Font(FontFamilyLabel.Font.FontFamily, FontFamilyLabel.Width / 8);
                FontFamilyLabel.Height = int.Parse(FontFamilyLabel.Font.Size.ToString()) * 2;
                FontFamilyLabel.Location = new Point(40, 20);


                TextFontFamily.Width = LeftBarTextOption.Width - 80;
                TextFontFamily.Font = new Font(TextFontFamily.Font.FontFamily, TextFontFamily.Width / 25);
                TextFontFamily.Location = new Point((LeftBarTextOption.Width / 2) - (TextFontFamily.Width / 2), FontFamilyLabel.Location.Y + FontFamilyLabel.Height);

                
                FontSizeLabel.Font = new Font(FontSizeLabel.Font.FontFamily, FontFamilyLabel.Font.Size);
                FontSizeLabel.Width = int.Parse(FontSizeLabel.Font.Size.ToString()) * 7;
                FontSizeLabel.Height = int.Parse(FontSizeLabel.Font.Size.ToString()) * 2;
                FontSizeLabel.Location = new Point(40, TextFontFamily.Location.Y + TextFontFamily.Height + (TextFontFamily.Height / 2));


                TextFontSize.Width = LeftBarTextOption.Width - 80;
                TextFontSize.Font = new Font(TextFontSize.Font.FontFamily, FontSizeLabel.Font.Size);
                TextFontSize.Location = new Point((LeftBarTextOption.Width / 2) - (TextFontFamily.Width / 2), FontSizeLabel.Location.Y + FontSizeLabel.Height);


                FontStyleLabel.Width = LeftBarTextOption.Width / 4;
                FontStyleLabel.Font = new Font(FontStyleLabel.Font.FontFamily, FontFamilyLabel.Font.Size);
                FontStyleLabel.Height = int.Parse(FontStyleLabel.Font.Size.ToString()) * 2;
                FontStyleLabel.Location = new Point(40, TextFontSize.Location.Y + TextFontSize.Height + (TextFontSize.Height / 2));


                PanelFontStyle.Width = LeftBarTextOption.Width - 80;
                PanelFontStyle.Height = LeftBarTextOption.Height / 14;
                PanelFontStyle.Location = new Point((LeftBarTextOption.Width / 2) - (PanelFontStyle.Width / 2), FontStyleLabel.Location.Y + FontStyleLabel.Height);


                BoldText.Height = PanelFontStyle.Height - 10;
                BoldText.Width = PanelFontStyle.Width / 5 - 10;
                BoldText.Font = new Font(BoldText.Font.FontFamily, BoldText.Width / 5, FontStyle.Bold);
                BoldText.Location = new Point(5, 5);


                ItalicText.Height = PanelFontStyle.Height - 10;
                ItalicText.Width = PanelFontStyle.Width / 5 - 10;
                ItalicText.Font = new Font(ItalicText.Font.FontFamily, ItalicText.Width / 5, FontStyle.Italic);
                ItalicText.Location = new Point(BoldText.Location.X + BoldText.Width + 10, 5);


                RegularText.Height = PanelFontStyle.Height - 10;
                RegularText.Width = PanelFontStyle.Width / 5 - 10;
                RegularText.Font = new Font(RegularText.Font.FontFamily, RegularText.Width / 5, FontStyle.Regular);
                RegularText.Location = new Point(ItalicText.Location.X + ItalicText.Width + 10, 5);


                StrikeoutText.Height = PanelFontStyle.Height - 10;
                StrikeoutText.Width = PanelFontStyle.Width / 5 - 10;
                StrikeoutText.Font = new Font(StrikeoutText.Font.FontFamily, StrikeoutText.Width / 5, FontStyle.Strikeout);
                StrikeoutText.Location = new Point(RegularText.Location.X + RegularText.Width + 10, 5);


                UnderlineText.Height = PanelFontStyle.Height - 10;
                UnderlineText.Width = PanelFontStyle.Width / 5 - 10;
                UnderlineText.Font = new Font(UnderlineText.Font.FontFamily, UnderlineText.Width / 5, FontStyle.Underline);
                UnderlineText.Location = new Point(StrikeoutText.Location.X + StrikeoutText.Width + 10, 5);


                FontPositionLabel.Width = LeftBarTextOption.Width / 3;
                FontPositionLabel.Font = new Font(FontPositionLabel.Font.FontFamily, FontFamilyLabel.Font.Size);
                FontPositionLabel.Height = int.Parse(FontPositionLabel.Font.Size.ToString()) * 2;
                FontPositionLabel.Location = new Point(40, PanelFontStyle.Location.Y + PanelFontStyle.Height + (FontStyleLabel.Height / 2));


                PanelFontPosition.Width = LeftBarTextOption.Width - 80;
                PanelFontPosition.Height = LeftBarTextOption.Height / 14;
                PanelFontPosition.Location = new Point((LeftBarTextOption.Width / 2) - (PanelFontStyle.Width / 2), FontPositionLabel.Location.Y + FontPositionLabel.Height);


                LeftPositionText.Width = PanelFontPosition.Width / 3 - 10;
                LeftPositionText.Height = PanelFontPosition.Height - 10;
                LeftPositionText.Font = new Font(LeftPositionText.Font.FontFamily, LeftPositionText.Width / 8);
                LeftPositionText.Location = new Point(5, 5);


                CenterPositionText.Width = PanelFontPosition.Width / 3 - 10;
                CenterPositionText.Height = PanelFontPosition.Height - 10;
                CenterPositionText.Font = new Font(CenterPositionText.Font.FontFamily, CenterPositionText.Width / 8);
                CenterPositionText.Location = new Point(LeftPositionText.Location.X + LeftPositionText.Width + 10, 5);


                RightPositionText.Width = PanelFontPosition.Width / 3 - 10;
                RightPositionText.Height = PanelFontPosition.Height - 10;
                RightPositionText.Font = new Font(RightPositionText.Font.FontFamily, RightPositionText.Width / 8);
                RightPositionText.Location = new Point(CenterPositionText.Location.X + CenterPositionText.Width + 10, 5);


                ChangeColorText.Width = LeftBarTextOption.Width / 3;
                ChangeColorText.Height = LeftBarTextOption.Height / 11;
                ChangeColorText.Font = new Font(ChangeColorText.Font.FontFamily, ChangeColorText.Width / 11);
                ChangeColorText.Location = new Point(40, PanelFontPosition.Location.Y + FontPositionLabel.Height * 3);


                ColorText.Width = LeftBarTextOption.Width - 80 - ChangeColorText.Width - 20;
                ColorText.Height = ChangeColorText.Height - 20;
                ColorText.Location = new Point(ChangeColorText.Location.X + ChangeColorText.Width + 10, PanelFontPosition.Location.Y + (FontPositionLabel.Height * 3) + 10);


                PanelCountWords.Width = LeftBarTextOption.Width - 50;
                PanelCountWords.Location = new Point((LeftBarTextOption.Width / 2) - (PanelCountWords.Width / 2), LeftBarTextOption.Height - 140);


                WordCounter.Location = new Point((PanelCountWords.Width / 2) - (WordCounter.Width / 2), 10);


                AmountWords.Location = new Point((PanelCountWords.Width / 2) - AmountWords.Width, 45);


                LimitWords.Location = new Point(PanelCountWords.Width / 2, 45);


                OK.Height = LimitWords.Height;
                OK.Width = OK.Height + 20;
                OK.Location = new Point(LimitWords.Location.X + LimitWords.Width + 10, LimitWords.Location.Y);


                ProgressBarWords.Width = PanelCountWords.Width - 20;
                ProgressBarWords.Location = new Point((PanelCountWords.Width / 2) - (ProgressBarWords.Width / 2), 75);


                MainEnterText.Width = this.Width - LeftBarTextOption.Width - 15;
                MainEnterText.Height = this.Height - UpBarMenu.Height - 38;
                MainEnterText.Location = new Point(LeftBarTextOption.Width, UpBarMenu.Height);
            };

            #region Up Menu
            //
            //  MenuStrip 'UpBarMenu':
            //
            UpBarMenu = new MenuStrip();           
            this.Controls.Add(UpBarMenu);



            //
            //  ToolStripMenuItem 'NewFileItem': Створити файл
            //
            NewFileItem = new ToolStripMenuItem();           
            NewFileItem.Text = "New file";
            NewFileItem.Click += CreateFile;
            UpBarMenu.Items.Add(NewFileItem);



            //
            //  ToolStripMenuItem 'OpenFileItem': Відкрити файл
            //
            OpenFileItem = new ToolStripMenuItem();           
            OpenFileItem.Text = "Open file";
            OpenFileItem.Click += OpenFileForCorrect;
            UpBarMenu.Items.Add(OpenFileItem);



            //
            //  ToolStripMenuItem 'SaveFileItem': Зберегти файл
            //
            SaveFileItem = new ToolStripMenuItem();
            SaveFileItem.Text = "Save";
            SaveFileItem.Click += SaveCorrectFile;
            SaveFileItem.Enabled = false;
            UpBarMenu.Items.Add(SaveFileItem);



            //
            //  ToolStripMenuItem 'ThemeItem': Змінити тему додатку
            //
            ThemeItem = new ToolStripMenuItem();
            ThemeItem.Text = "Theme";
            ThemeItem.DropDownItems.Add(new ToolStripMenuItem("Night", null, NightTheme));
            ThemeItem.DropDownItems.Add(new ToolStripMenuItem("Day", null, DayTheme));
            ThemeItem.ForeColor = Color.FromArgb(255, 255, 255);
            UpBarMenu.Items.Add(ThemeItem);



            //
            //
            //
            PathFileItem = new ToolStripMenuItem();
            PathFileItem.Text = $"Path file: ";
            PathFileItem.Enabled = false;            
            UpBarMenu.Items.Add(PathFileItem);
            #endregion

            #region Text change bar
            //
            //  Panel 'LeftBarTextOption': панель з функціоналом для зміни текста
            //
            LeftBarTextOption = new Panel();
            LeftBarTextOption.Width = this.Width / 4;
            LeftBarTextOption.Height = this.Height - UpBarMenu.Height - 38;
            LeftBarTextOption.Location = new Point(0, UpBarMenu.Height);
            
            this.Controls.Add(LeftBarTextOption);



            //
            //  Label 'FontFamilyLabel'
            //
            FontFamilyLabel = new Label();
            FontFamilyLabel.Width = LeftBarTextOption.Width / 4;
            FontFamilyLabel.Font = new Font(FontFamilyLabel.Font.FontFamily, FontFamilyLabel.Width / 8);
            FontFamilyLabel.Height = int.Parse(FontFamilyLabel.Font.Size.ToString()) * 2;
            FontFamilyLabel.ForeColor = Color.FromArgb(255, 255, 255);
            FontFamilyLabel.Text = "Text family:";
            FontFamilyLabel.Location = new Point(40, 20);
            LeftBarTextOption.Controls.Add(FontFamilyLabel);



            //
            //  ComboBox 'TextFontFamily': зміна шрифта;
            //
            TextFontFamily = new ComboBox();
            TextFontFamily.Font = new Font(TextFontFamily.Font.FontFamily, FontFamilyLabel.Font.Size);
            TextFontFamily.Width = LeftBarTextOption.Width - 80;
            TextFontFamily.Items.Add("Arial");
            TextFontFamily.Items.Add("Times New Roman");
            TextFontFamily.Items.Add("Verdana");
            TextFontFamily.Items.Add("Comic Sans MS");
            TextFontFamily.Items.Add("Snell Roundhand");
            TextFontFamily.Items.Add("Impact");
            TextFontFamily.Items.Add("Courier");
            TextFontFamily.KeyPress += (s, e) => e.Handled = true;
            TextFontFamily.SelectedIndex = 4;
            TextFontFamily.SelectedIndexChanged += ChangeTextFamily;
            TextFontFamily.Location = new Point((LeftBarTextOption.Width / 2) - (TextFontFamily.Width / 2), FontFamilyLabel.Location.Y + FontFamilyLabel.Height);
            LeftBarTextOption.Controls.Add(TextFontFamily);




            //
            //  Label 'FontSizeLabel'
            //
            FontSizeLabel = new Label();           
            FontSizeLabel.Font = new Font(FontSizeLabel.Font.FontFamily, FontFamilyLabel.Font.Size);
            FontSizeLabel.Width = int.Parse(FontSizeLabel.Font.Size.ToString()) * 7;
            FontSizeLabel.Height = int.Parse(FontSizeLabel.Font.Size.ToString()) * 2;
            FontSizeLabel.ForeColor = Color.FromArgb(255, 255, 255);
            FontSizeLabel.Text = "Text size:";
            FontSizeLabel.Location = new Point(40, TextFontFamily.Location.Y + TextFontFamily.Height + (TextFontFamily.Height / 2));
            LeftBarTextOption.Controls.Add(FontSizeLabel);



            //
            //  ComboBox 'TextFontSize': зміна шрифта;
            //
            TextFontSize = new ComboBox();
            TextFontSize.Width = LeftBarTextOption.Width - 80;
            TextFontSize.Font = new Font(TextFontSize.Font.FontFamily, FontSizeLabel.Font.Size);
            TextFontSize.Items.Add("8");
            TextFontSize.Items.Add("9");
            TextFontSize.Items.Add("10");
            TextFontSize.Items.Add("11");
            TextFontSize.Items.Add("12");
            TextFontSize.Items.Add("14");
            TextFontSize.Items.Add("18");
            TextFontSize.Items.Add("24");
            TextFontSize.Items.Add("30");
            TextFontSize.Items.Add("36");
            TextFontSize.Items.Add("48");
            TextFontSize.Items.Add("60");
            TextFontSize.Items.Add("72");
            TextFontSize.Items.Add("96");
            TextFontSize.KeyPress += (s, e) => e.Handled = true;
            TextFontSize.SelectedIndex = 0;
            TextFontSize.SelectedIndexChanged += ChangeTextSize;
            TextFontSize.Location = new Point((LeftBarTextOption.Width / 2) - (TextFontFamily.Width / 2), FontSizeLabel.Location.Y + FontSizeLabel.Height);
            LeftBarTextOption.Controls.Add(TextFontSize);



            //
            //  Label 'FontStyleLabel'
            //
            FontStyleLabel = new Label();
            FontStyleLabel.Width = LeftBarTextOption.Width / 4;
            FontStyleLabel.Font = new Font(FontStyleLabel.Font.FontFamily, FontFamilyLabel.Font.Size);
            FontStyleLabel.Height = int.Parse(FontStyleLabel.Font.Size.ToString()) * 2;
            FontStyleLabel.ForeColor = Color.FromArgb(255, 255, 255);
            FontStyleLabel.Text = "Text style:";
            FontStyleLabel.Location = new Point(40, TextFontSize.Location.Y + TextFontSize.Height + (TextFontSize.Height / 2));
            LeftBarTextOption.Controls.Add(FontStyleLabel);



            //
            //  Pabel 'PanelFontStyle': зміна стиля текста;
            //
            PanelFontStyle = new Panel();
            PanelFontStyle.Width = LeftBarTextOption.Width - 80;
            PanelFontStyle.Height = LeftBarTextOption.Height / 14;
            PanelFontStyle.Location = new Point((LeftBarTextOption.Width / 2) - (PanelFontStyle.Width / 2), FontStyleLabel.Location.Y + FontStyleLabel.Height);
            LeftBarTextOption.Controls.Add(PanelFontStyle);



            //
            //  Button 'BoldText': кнопка, яка робить текст жирним
            //
            BoldText = new Button();
            BoldText.Text = "abc";
            BoldText.BackColor = Color.FromArgb(255, 255, 255);
            BoldText.Height = PanelFontStyle.Height - 10;
            BoldText.Width = PanelFontStyle.Width / 5 - 10;
            BoldText.Font = new Font(BoldText.Font.FontFamily, BoldText.Width / 5, FontStyle.Bold);
            BoldText.Click += ChangeTextStyleBold;
            BoldText.Location = new Point(5, 5);
            PanelFontStyle.Controls.Add(BoldText);



            //
            //  Button 'ItalicText': кнопка, яка робить текст курсивним
            //
            ItalicText = new Button();
            ItalicText.Text = "abc";
            ItalicText.BackColor = Color.FromArgb(255, 255, 255);
            ItalicText.Height = PanelFontStyle.Height - 10;
            ItalicText.Width = PanelFontStyle.Width / 5 - 10;
            ItalicText.Font = new Font(ItalicText.Font.FontFamily, ItalicText.Width / 5, FontStyle.Italic);
            ItalicText.Click += ChangeTextStyleItalic;
            ItalicText.Location = new Point(BoldText.Location.X + BoldText.Width + 10, 5);
            PanelFontStyle.Controls.Add(ItalicText);



            //
            //  Button 'RegularText': кнопка, яка робить текст звичайним
            //
            RegularText = new Button();
            RegularText.Text = "abc";
            RegularText.BackColor = Color.FromArgb(255, 255, 255);
            RegularText.Height = PanelFontStyle.Height - 10;
            RegularText.Width = PanelFontStyle.Width / 5 - 10;
            RegularText.Font = new Font(RegularText.Font.FontFamily, RegularText.Width / 5, FontStyle.Regular);
            RegularText.Click += ChangeTextStyleRegular;
            RegularText.Location = new Point(ItalicText.Location.X + ItalicText.Width + 10, 5);
            PanelFontStyle.Controls.Add(RegularText);



            //
            //  Button 'StrikeoutText': кнопка, яка робить текст перекресленим
            //
            StrikeoutText = new Button();
            StrikeoutText.Text = "abc";
            StrikeoutText.BackColor = Color.FromArgb(255, 255, 255);
            StrikeoutText.Height = PanelFontStyle.Height - 10;
            StrikeoutText.Width = PanelFontStyle.Width / 5 - 10;
            StrikeoutText.Font = new Font(StrikeoutText.Font.FontFamily, StrikeoutText.Width / 5, FontStyle.Strikeout);
            StrikeoutText.Click += ChangeTextStyleStrikeout;
            StrikeoutText.Location = new Point(RegularText.Location.X + RegularText.Width + 10, 5);
            PanelFontStyle.Controls.Add(StrikeoutText);



            //
            //  Button 'UnderlineText': кнопка, яка робить текст підчеркнутим
            //
            UnderlineText = new Button();
            UnderlineText.Text = "abc";
            UnderlineText.BackColor = Color.FromArgb(255, 255, 255);
            UnderlineText.Height = PanelFontStyle.Height - 10;
            UnderlineText.Width = PanelFontStyle.Width / 5 - 10;
            UnderlineText.Font = new Font(UnderlineText.Font.FontFamily, UnderlineText.Width / 5, FontStyle.Underline);
            UnderlineText.Click += ChangeTextStyleUnderline;
            UnderlineText.Location = new Point(StrikeoutText.Location.X + StrikeoutText.Width + 10, 5);
            PanelFontStyle.Controls.Add(UnderlineText);



            //
            //  Label 'FontPositionStyle'
            //
            FontPositionLabel = new Label();
            FontPositionLabel.Text = "Text position:";
            FontPositionLabel.Width = LeftBarTextOption.Width / 3;
            FontPositionLabel.Font = new Font(FontPositionLabel.Font.FontFamily, FontFamilyLabel.Font.Size);
            FontPositionLabel.Height = int.Parse(FontPositionLabel.Font.Size.ToString()) * 2;
            FontPositionLabel.ForeColor = Color.FromArgb(255, 255, 255);
            FontPositionLabel.Location = new Point(40, PanelFontStyle.Location.Y + PanelFontStyle.Height + (FontStyleLabel.Height / 2));
            LeftBarTextOption.Controls.Add(FontPositionLabel);



            //
            //  Panel 'PanelFontPosition'
            //
            PanelFontPosition = new Panel();
            PanelFontPosition.Width = LeftBarTextOption.Width - 80;
            PanelFontPosition.Height = LeftBarTextOption.Height / 14;
            PanelFontPosition.Location = new Point((LeftBarTextOption.Width / 2) - (PanelFontStyle.Width / 2), FontPositionLabel.Location.Y + FontPositionLabel.Height);
            LeftBarTextOption.Controls.Add(PanelFontPosition);



            //
            //  Button 'LeftPositionText': зміна позиції текста: ліво
            //
            LeftPositionText = new Button();
            LeftPositionText.Text = "Left";
            LeftPositionText.BackColor = Color.FromArgb(255, 255, 255);
            LeftPositionText.TextAlign = ContentAlignment.MiddleLeft;
            LeftPositionText.Width = PanelFontPosition.Width / 3 - 10;
            LeftPositionText.Height = PanelFontPosition.Height - 10;
            LeftPositionText.Font = new Font(LeftPositionText.Font.FontFamily, LeftPositionText.Width / 8);
            LeftPositionText.Click += ChangePositionLeft;
            LeftPositionText.Location = new Point(5, 5);
            PanelFontPosition.Controls.Add(LeftPositionText);



            //
            //  Button 'CenterPositionText': зміна позиції текста: центр
            //
            CenterPositionText = new Button();
            CenterPositionText.Text = "Center";
            CenterPositionText.BackColor = Color.FromArgb(255, 255, 255);
            CenterPositionText.TextAlign = ContentAlignment.MiddleCenter;
            CenterPositionText.Width = PanelFontPosition.Width / 3 - 10;
            CenterPositionText.Height = PanelFontPosition.Height - 10;
            CenterPositionText.Font = new Font(CenterPositionText.Font.FontFamily, CenterPositionText.Width / 8);
            CenterPositionText.Click += ChangePositionCenter;
            CenterPositionText.Location = new Point(LeftPositionText.Location.X + LeftPositionText.Width + 10, 5);
            PanelFontPosition.Controls.Add(CenterPositionText);



            //
            //  Button 'RightPositionText': зміна позиції текста: право
            //
            RightPositionText = new Button();
            RightPositionText.Text = "Right";
            RightPositionText.BackColor = Color.FromArgb(255, 255, 255);
            RightPositionText.TextAlign = ContentAlignment.MiddleRight;
            RightPositionText.Width = PanelFontPosition.Width / 3 - 10;
            RightPositionText.Height = PanelFontPosition.Height - 10;
            RightPositionText.Font = new Font(RightPositionText.Font.FontFamily, RightPositionText.Width / 8);
            RightPositionText.Click += ChangePositionRight;
            RightPositionText.Location = new Point(CenterPositionText.Location.X + CenterPositionText.Width + 10, 5);
            PanelFontPosition.Controls.Add(RightPositionText);



            //
            //  Panel 'PanelCountWords': панель з функціоналом для лічення кількості слів
            //
            PanelCountWords = new Panel();
            PanelCountWords.Width = LeftBarTextOption.Width - 50;
            PanelCountWords.Height = 115;
            PanelCountWords.Location = new Point((LeftBarTextOption.Width / 2) - (PanelCountWords.Width / 2), LeftBarTextOption.Height - 140);
            LeftBarTextOption.Controls.Add(PanelCountWords);



            //
            //  Label 'WordCounter'
            //
            WordCounter = new Label();
            WordCounter.Font = new Font(WordCounter.Font.FontFamily, 13);
            WordCounter.Width = 122;
            WordCounter.Text = "Word Counter";
            WordCounter.ForeColor = Color.FromArgb(255, 255, 255);
            WordCounter.Location = new Point((PanelCountWords.Width / 2) - (WordCounter.Width / 2), 10);
            PanelCountWords.Controls.Add(WordCounter);



            //
            //  Label 'AmountWords': кількість слів в тексті 
            //
            AmountWords = new Label();
            AmountWords.Font = new Font(AmountWords.Font.FontFamily, 13);
            AmountWords.Width = 80;
            AmountWords.TextAlign = ContentAlignment.MiddleRight;
            AmountWords.Text = "0 /";
            AmountWords.ForeColor = Color.FromArgb(255, 255, 255);
            AmountWords.Location = new Point((PanelCountWords.Width / 2) - AmountWords.Width, 45);
            PanelCountWords.Controls.Add(AmountWords);



            //
            //  TextBox 'LimitWords': для встановлення числа потрібної кількості слів в тексті
            //
            LimitWords = new TextBox();
            LimitWords.Font = new Font(LimitWords.Font.FontFamily, 10);
            LimitWords.KeyPress += (s, e) =>
            {
                if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    e.Handled = true;
            };
            LimitWords.Width = 70;
           
            LimitWords.Location = new Point(PanelCountWords.Width / 2, 45);
            PanelCountWords.Controls.Add(LimitWords);



            //
            //  Button 'OK': фіксація LimitWords
            //
            OK = new Button();
            OK.Text = "OK";
            OK.BackColor = Color.FromArgb(255, 255, 255);
            OK.Height = LimitWords.Height;
            OK.Width = OK.Height + 20;
            OK.Click += FixationLimitWord;
            OK.Location = new Point(LimitWords.Location.X + LimitWords.Width + 10, LimitWords.Location.Y);
            PanelCountWords.Controls.Add(OK); 



            //
            //  ProgressBar 'ProgressBarWords': показує прогрес
            //
            ProgressBarWords = new ProgressBar();
            ProgressBarWords.Width = PanelCountWords.Width - 20;
            ProgressBarWords.Minimum = 0;
            ProgressBarWords.Location = new Point((PanelCountWords.Width / 2) - (ProgressBarWords.Width / 2), 75);
            PanelCountWords.Controls.Add(ProgressBarWords);
            #endregion


            //
            //  TextBox 'MainEnterText': TextBox для введення і зміни текста txt-файла 
            //
            MainEnterText = new TextBox();
            MainEnterText.Width = this.Width - LeftBarTextOption.Width - 15;
            MainEnterText.Height = this.Height - UpBarMenu.Height - 38;
            MainEnterText.Multiline = true;
            MainEnterText.WordWrap = true;
            MainEnterText.AcceptsTab = true;
            MainEnterText.ScrollBars = ScrollBars.Both;
            MainEnterText.KeyUp += CheckCountWords;
            MainEnterText.Location = new Point(LeftBarTextOption.Width, UpBarMenu.Height);
            this.Controls.Add(MainEnterText);



            //
            //  Button 'ChangeColorText': кнопка з ColorDialog для зміни кольору текта
            //
            ChangeColorText = new Button();
            ChangeColorText.Text = "Text color";
            ChangeColorText.BackColor = Color.FromArgb(255, 255, 255);
            ChangeColorText.Width = LeftBarTextOption.Width / 3;
            ChangeColorText.Height = LeftBarTextOption.Height / 11;
            ChangeColorText.Font = new Font(ChangeColorText.Font.FontFamily, ChangeColorText.Width / 11);
            ChangeColorText.Click += ColorDialogText;
            ChangeColorText.Location = new Point(40, PanelFontPosition.Location.Y + FontPositionLabel.Height * 3);
            LeftBarTextOption.Controls.Add(ChangeColorText);



            //
            //  Panel 'ColorText': відображає теперешній кольор тексту
            //
            ColorText = new Panel();
            ColorText.Width = LeftBarTextOption.Width - 80 - ChangeColorText.Width - 20;
            ColorText.Height = ChangeColorText.Height - 20;
            ColorText.Location = new Point(ChangeColorText.Location.X + ChangeColorText.Width + 10, PanelFontPosition.Location.Y + (FontPositionLabel.Height * 3) + 10);
            ColorText.BackColor = MainEnterText.ForeColor;
            LeftBarTextOption.Controls.Add(ColorText);
        }

        #region Elements app
        //
        MenuStrip UpBarMenu;
        ToolStripMenuItem NewFileItem;
        ToolStripMenuItem OpenFileItem;
        ToolStripMenuItem SaveFileItem;
        ToolStripMenuItem ThemeItem;
        ToolStripMenuItem PathFileItem;
        //
        Panel LeftBarTextOption;
        ComboBox TextFontFamily;
        ComboBox TextFontSize;
        Panel PanelFontStyle;
        Panel PanelFontPosition;
        Button BoldText;
        Button ItalicText;
        Button RegularText;
        Button StrikeoutText;
        Button UnderlineText;
        Button LeftPositionText;
        Button CenterPositionText;
        Button RightPositionText;
        Label FontFamilyLabel;
        Label FontSizeLabel;
        Label FontStyleLabel;
        Label FontPositionLabel;
        Button ChangeColorText;
        Panel ColorText;
        //
        Panel PanelCountWords;
        Label WordCounter;
        Label AmountWords;
        TextBox LimitWords;
        Button OK;
        ProgressBar ProgressBarWords;
        //
        TextBox MainEnterText;
        #endregion

        #endregion
    }
}

