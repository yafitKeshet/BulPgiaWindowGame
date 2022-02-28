using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ex05.BoolPgia.Logic; 

namespace Ex05.BoolPgia.UI
{
    public partial class BoardForm : Form
    {
        private enum eColors
        {
            Purple = 'A',
            Red,
            Green,
            LightBlue,
            Blue,
            Yellow,
            DarkRed,
            White
        }

        private readonly Button[,] r_GuessingButtons;
        private readonly Label[] r_ComputerGuess;
        private readonly int r_NumOfGuessing;
        private readonly Button[,] r_FeedBackLabels;
        private readonly SetupForm r_SetupForm=new SetupForm();
        private readonly GameLogic r_Game;  
        private readonly Button[] r_CalculatingButtons;
        private int k_NumberOfGuessesPerTurn = 4;
        private int m_CurrentGuess = 0;
        private int m_CurrentColumn = 0;
        

        public BoardForm()
        {
            InitializeComponent();
            if (r_SetupForm.ShowDialog() == DialogResult.OK)
            {
                r_NumOfGuessing = r_SetupForm.CurrentNumOfChances;
                r_Game = new GameLogic(r_NumOfGuessing + 1);
                r_GuessingButtons = new Button[r_NumOfGuessing, k_NumberOfGuessesPerTurn];
                r_ComputerGuess = new Label[k_NumberOfGuessesPerTurn];
                r_CalculatingButtons = new Button[r_NumOfGuessing];
                r_FeedBackLabels=new Button[r_NumOfGuessing,k_NumberOfGuessesPerTurn];
                r_Game.WinningSequence = r_Game.RandWinningSequence();
                r_Game.InsertNewGuessAndFeedbackCalculation(r_Game.WinningSequence);
                createBoard();
            }
            else
            {
                this.Close();
            }
        }

        private void createComputerGuessingLabels(int i_XPadding,int i_YPadding)
        {
            for (int i = 0; i < k_NumberOfGuessesPerTurn; i++)
            {
                Label computerGuessLabel = new Label();
                computerGuessLabel.BackColor = Color.Black;
                computerGuessLabel.Width = 50;
                computerGuessLabel.Height = 50;
                computerGuessLabel.Location = new Point(i_XPadding, i_YPadding);
                computerGuessLabel.TabStop = false;
                i_XPadding += 60;
                r_ComputerGuess[i] = computerGuessLabel;
                Controls.Add(computerGuessLabel);
            }
        }

        private void createGuessingButtons(ref int io_XPadding, int i_YPadding, int i_RowIndex)
        {
            for (int j = 0; j < k_NumberOfGuessesPerTurn; j++)
            {
                Button guessingButton = new Button();

                if (i_RowIndex != 0)
                {
                    guessingButton.Enabled = false;
                }

                guessingButton.BackColor = Color.Transparent;
                guessingButton.Width = 50;
                guessingButton.Height = 50;
                guessingButton.Location = new Point(io_XPadding, i_YPadding);
                guessingButton.Click += button_Click;
                guessingButton.TabStop = false;
                io_XPadding += 60;
                r_GuessingButtons[i_RowIndex, j] = guessingButton;
                Controls.Add(guessingButton);
            }
        }

        private void createCalcButton(ref int io_XPadding, int i_YPadding, int i_RowIndex)
        {
            Button calcButton = new Button();
            calcButton.Text = @"-->>";
            calcButton.Enabled = false;
            calcButton.Width = 50;
            calcButton.Height = 25;
            calcButton.Location = new Point(io_XPadding, i_YPadding + 12);
            calcButton.Click += calcButton_Click;
            calcButton.TabStop = false;
            io_XPadding += 60;
            r_CalculatingButtons[i_RowIndex] = calcButton;
            Controls.Add(calcButton);
        }

        private void createFeedBackLabels(ref int io_XPadding,ref int io_YPadding, int i_RowIndex)
        {
            int PaddingMini = 28;

            for (int k = 0; k < k_NumberOfGuessesPerTurn; k++)
            {
                Button feedbackButton = new Button();

                if (k == k_NumberOfGuessesPerTurn / 2)
                {
                    io_YPadding = io_YPadding + PaddingMini;
                    io_XPadding = io_XPadding - PaddingMini * k;
                }

                feedbackButton.Width = 22;
                feedbackButton.Height = 22;
                feedbackButton.Location = new Point(io_XPadding, io_YPadding);
                feedbackButton.TabStop = false;
                feedbackButton.Enabled = false;
                r_FeedBackLabels[i_RowIndex, k] = feedbackButton;
                io_XPadding += PaddingMini;
                Controls.Add(feedbackButton);
            }
        }

        private void createBoard()
        {
            int xPadding = 20, yPadding = 20;

            createComputerGuessingLabels(xPadding, yPadding);
            xPadding = 20;
            yPadding += 80;

            //create Needed buttons for each Row of the board;
            for (int i = 0; i < r_NumOfGuessing; i++)
            {
                createGuessingButtons(ref xPadding, yPadding, i);
                createCalcButton(ref xPadding, yPadding, i);
                createFeedBackLabels(ref xPadding, ref yPadding, i);
                xPadding = 20;
                yPadding += 30;
            }

            this.Width = (k_NumberOfGuessesPerTurn + 2) * 60 + 40;
            this.Height = (r_NumOfGuessing+1) * 60 + 80 + 20;
        }

        private void calcButton_Click(object i_Sender, EventArgs i_E)
        {
            string sequence = createSequence();

            if(r_Game.IsSequenceLegal(sequence))
            {
                string feedBack = r_Game.InsertNewGuessAndFeedbackCalculation(sequence);

                updateFeedBack(feedBack);
                r_CalculatingButtons[m_CurrentGuess].Enabled = false;
                prepareForNextGuess();
                if (r_Game.IsWin() || r_Game.IsTheGameOver())
                {
                    endGame();
                }
            }
            else
            {
                new InvalidChooseOfColor ().ShowDialog();
            }
        }

        private void endGame()
        {
            string winningSequence = r_Game.WinningSequence;

            for(int i = 0; i < k_NumberOfGuessesPerTurn; i++)
            {
               switch(winningSequence[i])
                {
                    case 'A':
                        r_ComputerGuess[i].BackColor = Color.Fuchsia;
                        break;
                    case 'B':
                        r_ComputerGuess[i].BackColor = Color.Red;
                        break;
                    case 'C':
                        r_ComputerGuess[i].BackColor = Color.LawnGreen;
                        break;
                    case 'D':
                        r_ComputerGuess[i].BackColor = Color.Cyan;
                        break;
                    case 'E':
                        r_ComputerGuess[i].BackColor = Color.Blue;
                        break;
                    case 'F':
                        r_ComputerGuess[i].BackColor = Color.Yellow;
                        break;
                    case 'G':
                        r_ComputerGuess[i].BackColor = Color.Maroon;
                        break;
                    case 'H':
                        r_ComputerGuess[i].BackColor = Color.White;
                        break;
                }
            }
        }

        private void updateFeedBack(string i_FeedBack)
        {
            int index = 0;

            foreach(char c in i_FeedBack)
            {
                switch(c)
                {
                    case 'V':
                        r_FeedBackLabels[m_CurrentGuess, index].BackColor = Color.Black;
                        break;
                    case 'X':
                        r_FeedBackLabels[m_CurrentGuess, index].BackColor = Color.Yellow;
                        break;
                    case ' ':
                        break;
                }

                index++;
            }
        }

        private void prepareForNextGuess()
        {
            for (int i = 0; i < k_NumberOfGuessesPerTurn; i++)
            {
                r_GuessingButtons[m_CurrentGuess, i].Enabled = false;

                if (m_CurrentGuess + 1 < r_NumOfGuessing)
                {
                    r_GuessingButtons[m_CurrentGuess + 1, i].Enabled = true;
                }
            }

            m_CurrentGuess++;
            m_CurrentColumn = 0;
        }

        private string createSequence()
        {
            StringBuilder sequence = new StringBuilder();

            for(int i = 0; i < k_NumberOfGuessesPerTurn; i++)
            {
                switch (r_GuessingButtons[m_CurrentGuess, i].Name)
                {
                    case "purpleButton":
                        sequence.Append(((char)eColors.Purple));
                        break;
                    case "redButton":
                        sequence.Append((char)eColors.Red);
                        break;
                    case "greenButton":
                        sequence.Append((char)eColors.Green);
                        break;
                    case "lightBlueButton":
                        sequence.Append((char)eColors.LightBlue);
                        break;
                    case "whiteButton":
                        sequence.Append((char)eColors.White);
                        break;
                    case "darkRedButton":
                        sequence.Append((char)eColors.DarkRed);
                        break;
                    case "yellowButton":
                        sequence.Append((char)eColors.Yellow);
                        break;
                    case "blueButton":
                        sequence.Append((char)eColors.Blue);
                        break;
                }
            }

            return sequence.ToString();
        }

        private void button_Click(object i_Sender, EventArgs i_E)
        {
            ColorsForm colorsForm = new ColorsForm();

            if (colorsForm.ShowDialog() == DialogResult.OK)
            {
                Button button = (i_Sender as Button);

                if (button.BackColor == Color.Transparent)
                {
                    m_CurrentColumn++;
                    if (m_CurrentColumn == k_NumberOfGuessesPerTurn)
                    {
                        r_CalculatingButtons[m_CurrentGuess].Enabled = true;
                    }
                }

                button.BackColor = colorsForm.ChosenColor;
                button.Name = colorsForm.ColorName;
            }
        }

        private void boardForm_Load(object i_Sender, EventArgs i_E)
        {

        }
    }
}
