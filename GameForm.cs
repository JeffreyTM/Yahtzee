/*
 * 
 * Yahtzee game featuring a stats page
 * Coded by Jeffrey Michaels, 2022
 * https://github.com/JeffreyTM/Yahtzee
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Yahtzee
{

    public partial class GameForm : Form
    {

        public GameForm()
        {
            InitializeComponent();
        }

        /*
         * GLOBAL VARIABLES
         */

        //  Constructors
        //  allDice: Array that stores 5 DiceBlock objects: One for each rollable dice block in Yahtzee
        //  scorecard: Array that stores all 14 Scoring objects: One for each value on a Yahtzee scorecard
        DiceBlock[] allDice = new DiceBlock[5];
        Scoring[] scorecard = new Scoring[15];

        //  scoreTypes: Array that stores all 14 scores on a Yahtzee scorecard
        string[] scoreTypes = {"Aces", "Twos", "Threes", "Fours", "Fives", "Sixes",
                                "Three of a Kind" , "Four of a Kind", "Full House",
                                "Small Straight", "Large Straight", "Yahtzee", "Chance", "Bonus", "Total"};

        int turn = 1;
        bool isActive = false;
        int bonus = 0;
        bool hasBonus = false;

        /*    
         * turnsHeld: Stores each possible dice value as a key, value is the amount of turns the user has held the keyed dice roll
         * timesRolled: Stores each possible roll as a key, value is the amount of times the user has rolled the keyed dice roll
         *  - Note: timesRolled doesn't store the same roll multiple times if the user holds the dice block 
         */
        Dictionary<int, int> turnsHeld = new Dictionary<int, int>();
        Dictionary<int, int> timesRolled = new Dictionary<int, int>();

        private void GameWindow_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < allDice.Length; i++)
                allDice[i] = new DiceBlock(0, false);

            for (int i = 0; i < scorecard.Length; i++)
                scorecard[i] = new Scoring(0, false);

            // Set the isScored value of the last two values in scorecard (the bonus and total) to true because they're always scored
            scorecard[scorecard.Length - 2].IsScored = true;
            scorecard[scorecard.Length - 1].IsScored = true;

            for (int i = 1; i <= 6; i++)
            {
                turnsHeld.Add(i, 0);
                timesRolled.Add(i, 0);
            }
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            isActive = true;
            if (turn > 3)
            {
                DialogResult dialog = MessageBox.Show("Round over. Please select an area that you would like to score.",
                                     Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            Random rand = new Random();

            for (int i = 0; i < allDice.Length; i++)
            {
                if (allDice[i].DiceValue == 0)
                {
                    allDice[i].DiceValue = rand.Next(1, 7);
                    timesRolled[allDice[i].DiceValue]++;
                }

                else if (!allDice[i].IsHeld)
                {
                    allDice[i].DiceValue = rand.Next(1, 7);
                    timesRolled[allDice[i].DiceValue]++;
                }
                else
                {
                    turnsHeld[allDice[i].DiceValue]++;
                }

            }

            SetAllDiceImages();


            if (turn < 3)
                roundLabel.Text = "Turn " + turn + " of 3. Choose which blocks you would like to hold and roll again, " +
                                                    "or choose a category to score.";
            else
                roundLabel.Text = "Turn " + turn + " of 3. Choose which category you would like to score.";

            DisplayAllScores();
            turn++;

            /*  Debugging:
             * //Displays all the dice rolls and how many times each block has been rolled
            foreach (int diceBlock in timesRolled.Keys)
            {
                string value = scoreTypes[diceBlock - 1];
                listBox1.Items.Add(value + ": " + timesRolled[diceBlock] + " times rolled.");
            }

            //Displays all of the dice rolls and how many times they've been held in a turn. Stream to file
            foreach (int diceBlock in turnsHeld.Keys)
            {
                string value = scoreTypes[diceBlock - 1];
                listBox1.Items.Add(value + ": " + turnsHeld[diceBlock] + " times held in a turn.");
            }*/
        }

        private void statsButton_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                DialogResult dialog = MessageBox.Show("WARNING: Game in progress. The current game progress will be lost on exit."
                                      + " Are you sure you want to continue?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult.Yes == dialog)
                {
                    StatsForm statsForm = new StatsForm();
                    statsForm.Show();
                    this.Close();
                }
            }
            else
            {
                StatsForm statsForm = new StatsForm();
                statsForm.Show();
                this.Close();
            }
        }

        private void exitGameButton_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                DialogResult dialog = MessageBox.Show("WARNING: Game in progress. The current game progress will be lost on exit."
                                      + " Are you sure you want to continue?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult.Yes == dialog)
                    Close();
            }
            else
            {
                Close();
            }
        }

        private void SetAllDiceImages()
        {
            PictureBox[] dicePics = { dicePictureBox1, dicePictureBox2, dicePictureBox3, dicePictureBox4, dicePictureBox5 };


            for (int i = 0; i < allDice.Length; i++)
            {
                switch (allDice[i].DiceValue)
                {
                    case 1:
                        if (allDice[i].IsHeld)
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock1gray;
                        else
                        {
                            RollBlock(dicePics[i]);
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock1;
                        }
                        break;

                    case 2:
                        if (allDice[i].IsHeld)
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock2gray;
                        else
                        {
                            RollBlock(dicePics[i]);
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock2;
                        }
                        break;

                    case 3:
                        if (allDice[i].IsHeld)
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock3gray;
                        else
                        {
                            RollBlock(dicePics[i]);
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock3;
                        }
                        break;

                    case 4:
                        if (allDice[i].IsHeld)
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock4gray;
                        else
                        {
                            RollBlock(dicePics[i]);
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock4;
                        }
                        break;

                    case 5:
                        if (allDice[i].IsHeld)
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock5gray;
                        else
                        {
                            RollBlock(dicePics[i]);
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock5;
                        }
                        break;

                    case 6:
                        if (allDice[i].IsHeld)
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock6gray;
                        else
                        {
                            RollBlock(dicePics[i]);
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock6;
                        }
                        break;

                    case 0:
                        dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock1;
                        break;
                }
            }

        }

        private void ResetTurn()
        {
            foreach (DiceBlock singleDice in allDice)
            {
                singleDice.DiceValue = 0;
                singleDice.IsHeld = false;
            }

            SetAllDiceImages();
            ResetScoreLabels();

            turn = 1;
            roundLabel.Text = "Click \"Roll\" to Begin the Next Round";

        }

        private void RestartGame()
        {
            //  reset all information
            foreach (DiceBlock singleDice in allDice)
            {
                singleDice.DiceValue = 0;
                singleDice.IsHeld = false;
            }

            foreach (Scoring score in scorecard)
            {
                score.ScoreValue = 0;
                score.IsScored = false;
            }

            for (int i = 1; i <= 6; i++)
            {
                timesRolled[i] = 0;
                turnsHeld[i] = 0;
            }

            totalLabel.Text = "---";
            roundLabel.Text = "Click \"Roll\" to Begin.";
            turn = 1;
            SetAllDiceImages();
            ResetScoreLabels();
            bonus = 0;
            hasBonus = false;
            scorecard[scorecard.Length - 2].IsScored = true;
            scorecard[scorecard.Length - 1].IsScored = true;

        }
        
        private void EndGame()
        {
            SetGameData();
            SetScoreData();
            SetRollData();
            isActive = false;

            // Ask the user if they would like to play again
            DialogResult dialog = MessageBox.Show("Game over. Your total score was " + scorecard[scorecard.Length - 1].ScoreValue + "."
                                            + " Would you like to play again?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                DialogResult dialog2 = MessageBox.Show("Would you like to return to main menu?",
                                     Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog2 == DialogResult.Yes)
                {
                    //Output all data to file before closing the form
                    Close();
                }
            }
        }

        private void SetGameData()
        {
            // Format: ID,Date,Time,scores
            StreamReader readGameData = new StreamReader("GameData.txt");
            int ID = 0;

            while (!readGameData.EndOfStream)
            {
                string currentLine = readGameData.ReadLine();
                string[] fields = currentLine.Split(',');

                if (fields.Length > 1)
                {
                    ID = int.Parse(fields[0]);
                }
            }
            readGameData.Close();


            ID++;

            StreamWriter writeGameData = new StreamWriter("GameData.txt", true);

            // Append ID, Date, Time, and Total initially
            writeGameData.Write(string.Format("{0},{1},{2},{3}",
                                        ID, 
                                        DateTime.Now.ToString("MM/dd/yyyy"), 
                                        DateTime.Now.ToString("h:mm tt"), 
                                        scorecard[scorecard.Length - 1].ScoreValue));

            //  Append every score value in the loop. Out of the loop, append the bonus score
            for (int i = 0; i < scorecard.Length - 1; i++)
            {
                writeGameData.Write("," + scorecard[i].ScoreValue);
            }

            // End the line and close the StreamWriter
            writeGameData.WriteLine();
            writeGameData.Close();
        }

        private void SetScoreData()
        {
            StreamReader readScoreData = new StreamReader("ScoreData.txt");
            //  ScoreData format: scoreType,totalScore,timesScored

            int count = 0;
            List<string> valuesList = new List<string>();
            List<int> scoresList = new List<int>();
            List<int> timesScoredList = new List<int>();

            while (!readScoreData.EndOfStream)
            {
                string currentLine = readScoreData.ReadLine();

                string[] fields = currentLine.Split(',');
                if (fields.Length > 1)
                {


                    valuesList.Add(fields[0]);
                    scoresList.Add(int.Parse(fields[2]) + scorecard[count].ScoreValue);

                    // If the current score value was counted in this game, increment the timesScored total in the file
                    if (scorecard[count].ScoreValue > 0)
                    {
                        timesScoredList.Add(int.Parse(fields[1]) + 1);
                    }
                    else
                    {
                        timesScoredList.Add(int.Parse(fields[1]));
                    }

                    count++;
                }
            }
            readScoreData.Close();

            StreamWriter writeScoreData = new StreamWriter("ScoreData.txt", false);

            for (int i = 0; i < scoresList.Count; i++)
            {
                writeScoreData.WriteLine("{0},{1},{2}", valuesList[i], timesScoredList[i], scoresList[i]);
            }
            writeScoreData.Close();
        }

        private void SetRollData()
        {
            StreamReader readRollData = new StreamReader("RollData.txt");
            //  RollData format: scoreType,TimesRolled,turnsHeld,maxTimesRolled1Game,minTimesRolled1Game

            int count = 1;
            List<string> valuesList = new List<string>();

            //  scoreType,timesRolled,turnsHeld,maxRolled,minRolled
            List<Tuple<string, int, int, int, int>> valuesTotalList = new List<Tuple<string, int, int, int, int>>();

            List<int> rolledList = new List<int>();
            List<int> heldList = new List<int>();

            while (!readRollData.EndOfStream)
            {
                string currentLine = readRollData.ReadLine();

                String[] fields = currentLine.Split(',');
                if (fields.Length > 1)
                {
                    string currentScoreType = fields[0];
                    int currentRolledValue = int.Parse(fields[1]) + timesRolled[count];
                    int currentHeldValue = int.Parse(fields[2]) + turnsHeld[count];
                    int maxRolled = int.Parse(fields[3]);
                    int minRolled = int.Parse(fields[4]);

                    if (timesRolled[count] > maxRolled)
                        maxRolled = timesRolled[count];

                    if (timesRolled[count] < minRolled || minRolled == 0)
                        minRolled = timesRolled[count];


                    valuesTotalList.Add(new Tuple<string, int, int, int, int>(currentScoreType, currentRolledValue,
                                                                          currentHeldValue, maxRolled, minRolled));

                    count++;
                }
            }
            readRollData.Close();

            StreamWriter writeRollData = new StreamWriter("RollData.txt", false);

            for (int i = 0; i < valuesTotalList.Count; i++)
            {
                writeRollData.WriteLine(string.Format("{0},{1},{2},{3},{4}",
                                                 valuesTotalList[i].Item1,
                                                 valuesTotalList[i].Item2,
                                                 valuesTotalList[i].Item3,
                                                 valuesTotalList[i].Item4,
                                                 valuesTotalList[i].Item5));
            }
            writeRollData.Close();
        }

        private void DisplayAllScores()
        {
            Label[] labels = new Label[] { acesLabel, twosLabel, threesLabel, foursLabel, fivesLabel, sixesLabel,
                                           threeOfAKindLabel, fourOfAKindLabel, fullHouseLabel, smallStraightLabel,
                                           largeStraightLabel, yahtzeeLabel, chanceLabel};

            int[] scores = new int[] { ScoreAces(), ScoreTwos(), ScoreThrees(), ScoreFours(), ScoreFives(), ScoreSixes(),
                                     ScoreThreeOfAKind(), ScoreFourOfAKind(), ScoreFullHouse(), ScoreSmallStraight(),
                                     ScoreLargeStraight(), ScoreYahtzee(), ScoreChance()};

            for (int i = 0; i < labels.Length; i++)
            {
                if (scorecard[i].IsScored == false)
                {
                    labels[i].Text = scores[i].ToString();
                    labels[i].BackColor = Color.White;
                }    
            }

        }
 
        private void ResetScoreLabels()
        {
            Label[] labels = new Label[] { acesLabel, twosLabel, threesLabel, foursLabel, fivesLabel, sixesLabel,
                                           threeOfAKindLabel, fourOfAKindLabel, fullHouseLabel, smallStraightLabel,
                                           largeStraightLabel, yahtzeeLabel, chanceLabel};

            for (int i = 0; i < labels.Length; i++)
            {
                if (scorecard[i].IsScored == false)
                {
                    labels[i].Text = "---";
                    labels[i].BackColor = Color.Gainsboro;
                }
            }

        }

        private void DisplayBonus(int hoveredValue)
        {
            int tempBonus = bonus;
            tempBonus += hoveredValue;

            if (hasBonus == false)
            {
                bonusBGLabel.BackColor = Color.White;

                if (tempBonus >= 63)
                {
                    bonusBGLabel.Text = "Bonus (63/63): ";
                    bonusLabel.Text = "✓";
                    bonusLabel.Font = new System.Drawing.Font("Yu Gothic UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    bonusLabel.ForeColor = Color.Green;
                }
                else
                {
                    bonusBGLabel.Text = string.Format("Bonus ({0}/63): ", tempBonus);
                }
            }
        }

        private void ResetBonusLabelDisplay()
        {
            bonusBGLabel.BackColor = Color.Gainsboro;
            
            if (hasBonus == false)
            {
                bonusBGLabel.Text = string.Format("Bonus ({0}/63): ", bonus);
                bonusLabel.Text = "X";
                bonusLabel.ForeColor = Color.Red;
                bonusLabel.Font = bonusLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void ScoreBonus(int value)
        {
            bonus += value;

            if (bonus >= 63)
            {
                hasBonus = true;
                int index = Array.IndexOf(scoreTypes, "Bonus");

                scorecard[index].ScoreValue = 35;
                scorecard[scorecard.Length - 1].ScoreValue += 35;

                bonusBGLabel.Text = "Bonus (63/63):";
                bonusLabel.Text = "✓";
                bonusLabel.Font = new System.Drawing.Font("Yu Gothic UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                bonusLabel.ForeColor = Color.Green;
                bonusLabel.TextAlign = ContentAlignment.TopCenter;
            }
        }

        private void RollBlock(PictureBox currentDiceBlock)
        {
            roundLabel.Text = "Rolling...";
            Image[] allPics = { global::Yahtzee.Properties.Resources.diceblock1,
                            global::Yahtzee.Properties.Resources.diceblock2,
                            global::Yahtzee.Properties.Resources.diceblock3,
                            global::Yahtzee.Properties.Resources.diceblock4,
                            global::Yahtzee.Properties.Resources.diceblock5,
                            global::Yahtzee.Properties.Resources.diceblock6 };


            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {

                currentDiceBlock.Image = allPics[random.Next(allPics.Length)];
                Task.Delay(150).Wait();
            }

        }

        /*
         * 
         * ALL LABEL CLICK EVENT HANDLERS
         * 
         */

        private void acesBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Aces");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Default;
                acesBGLabel.BackColor = Color.Gainsboro;
                acesLabel.BackColor = Color.Gold;
                

                int acesTotal = ScoreAces();
                ScoreBonus(acesTotal);
                ResetBonusLabelDisplay();

                acesLabel.Text = acesTotal.ToString();

                scorecard[scorecard.Length - 1].ScoreValue += acesTotal;
                totalLabel.Text = scorecard[scorecard.Length - 1].ScoreValue.ToString();


                scorecard[index].ScoreValue = acesTotal;
                scorecard[index].IsScored = true;


                if (IsLastScore())
                {
                    EndGame();
                }
                else
                {
                    ResetTurn();
                }
            }
        }

        private void twosBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Twos");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Default;
                twosBGLabel.BackColor = Color.Gainsboro;
                twosLabel.BackColor = Color.Gold;

                int twosTotal = ScoreTwos();
                ScoreBonus(twosTotal);
                ResetBonusLabelDisplay();

                twosLabel.Text = twosTotal.ToString();

                scorecard[scorecard.Length - 1].ScoreValue += twosTotal;
                totalLabel.Text = scorecard[scorecard.Length - 1].ScoreValue.ToString();

                scorecard[index].ScoreValue = twosTotal;
                scorecard[index].IsScored = true;

                if (IsLastScore())
                {
                    EndGame();
                }
                else
                {
                    ResetTurn();
                }
            }
        }

        private void threesBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Threes");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Default;
                threesBGLabel.BackColor = Color.Gainsboro;
                threesLabel.BackColor = Color.Gold;

                int threesTotal = ScoreThrees();
                ScoreBonus(threesTotal);
                ResetBonusLabelDisplay();

                threesLabel.Text = threesTotal.ToString();

                scorecard[scorecard.Length - 1].ScoreValue += threesTotal;
                totalLabel.Text = scorecard[scorecard.Length - 1].ScoreValue.ToString();

                scorecard[index].ScoreValue = threesTotal;
                scorecard[index].IsScored = true;

                if (IsLastScore())
                {
                    EndGame();
                }
                else
                {
                    ResetTurn();
                }
            }

        }

        private void foursBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Fours");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Default;
                foursBGLabel.BackColor = Color.Gainsboro;
                foursLabel.BackColor = Color.Gold;

                int foursTotal = ScoreFours();
                ScoreBonus(foursTotal);
                ResetBonusLabelDisplay();

                foursLabel.Text = foursTotal.ToString();

                scorecard[scorecard.Length - 1].ScoreValue += foursTotal;
                totalLabel.Text = scorecard[scorecard.Length - 1].ScoreValue.ToString();

                scorecard[index].ScoreValue = foursTotal;
                scorecard[index].IsScored = true;



                if (IsLastScore())
                {
                    EndGame();
                }
                else
                {
                    ResetTurn();
                }
            }
        }

        private void fivesBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Fives");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Default;
                fivesBGLabel.BackColor = Color.Gainsboro;
                fivesLabel.BackColor = Color.Gold;


                int fivesTotal = ScoreFives();
                ScoreBonus(fivesTotal);
                ResetBonusLabelDisplay();

                fivesLabel.Text = fivesTotal.ToString();

                scorecard[scorecard.Length - 1].ScoreValue += fivesTotal;
                totalLabel.Text = scorecard[scorecard.Length - 1].ScoreValue.ToString();

                scorecard[index].ScoreValue = fivesTotal;
                scorecard[index].IsScored = true;


                if (IsLastScore())
                {
                    EndGame();
                }
                else
                {
                    ResetTurn();
                }
            }
        }

        private void sixesBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Sixes");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Default;
                sixesBGLabel.BackColor = Color.Gainsboro;
                sixesLabel.BackColor = Color.Gold;

                int sixesTotal = ScoreSixes();
                ScoreBonus(sixesTotal);
                ResetBonusLabelDisplay();

                sixesLabel.Text = sixesTotal.ToString();

                scorecard[scorecard.Length - 1].ScoreValue += sixesTotal;
                totalLabel.Text = scorecard[scorecard.Length - 1].ScoreValue.ToString();

                scorecard[index].ScoreValue = sixesTotal;
                scorecard[index].IsScored = true;



                if (IsLastScore())
                {
                    EndGame();
                }
                else
                {
                    ResetTurn();
                }
            }
        }

        private void threeKindBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Three of a Kind");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Default;
                threeKindBGLabel.BackColor = Color.Gainsboro;
                threeOfAKindLabel.BackColor = Color.Gold;

                int threeOfAKindTotal = ScoreThreeOfAKind();
                threeOfAKindLabel.Text = threeOfAKindTotal.ToString();

                scorecard[scorecard.Length - 1].ScoreValue += threeOfAKindTotal;
                totalLabel.Text = scorecard[scorecard.Length - 1].ScoreValue.ToString();

                scorecard[index].ScoreValue = threeOfAKindTotal;
                scorecard[index].IsScored = true;



                if (IsLastScore())
                {
                    EndGame();
                }
                else
                {
                    ResetTurn();
                }
            }
        }

        private void fourKindBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Four of a Kind");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Default;
                fourKindBGLabel.BackColor = Color.Gainsboro;
                fourOfAKindLabel.BackColor = Color.Gold;

                int fourOfAKindTotal = ScoreFourOfAKind();
                fourOfAKindLabel.Text = fourOfAKindTotal.ToString();

                scorecard[scorecard.Length - 1].ScoreValue += fourOfAKindTotal;
                totalLabel.Text = scorecard[scorecard.Length - 1].ScoreValue.ToString();

                scorecard[index].ScoreValue = fourOfAKindTotal;
                scorecard[index].IsScored = true;



                if (IsLastScore())
                {
                    EndGame();
                }
                else
                {
                    ResetTurn();
                }
            }
        }

        private void fullHouseBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Full House");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Default;
                fullHouseBGLabel.BackColor = Color.Gainsboro;
                fullHouseLabel.BackColor = Color.Gold;

                int fullHouseTotal = ScoreFullHouse();
                scorecard[index].ScoreValue = fullHouseTotal;
                scorecard[scorecard.Length - 1].ScoreValue += fullHouseTotal;
                scorecard[index].IsScored = true;


                fullHouseLabel.Text = fullHouseTotal.ToString();
                totalLabel.Text = scorecard[scorecard.Length - 1].ScoreValue.ToString();

                if (IsLastScore())
                {
                    EndGame();
                }
                else
                {
                    ResetTurn();
                }
            }
        }

        private void smallStraightBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Small Straight");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Default;
                smallStraightBGLabel.BackColor = Color.Gainsboro;
                smallStraightLabel.BackColor = Color.Gold;

                int smallStraightTotal = ScoreSmallStraight();
                smallStraightLabel.Text = smallStraightTotal.ToString();

                scorecard[scorecard.Length - 1].ScoreValue += smallStraightTotal;
                totalLabel.Text = scorecard[scorecard.Length - 1].ScoreValue.ToString();

                scorecard[index].ScoreValue = smallStraightTotal;
                scorecard[index].IsScored = true;



                if (IsLastScore())
                {
                    EndGame();
                }
                else
                {
                    ResetTurn();
                }
            }
        }

        private void largeStraightBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Large Straight");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Default;
                largeStraightBGLabel.BackColor = Color.Gainsboro;
                largeStraightLabel.BackColor = Color.Gold;

                int largeStraightTotal = ScoreLargeStraight();
                largeStraightLabel.Text = largeStraightTotal.ToString();

                scorecard[scorecard.Length - 1].ScoreValue += largeStraightTotal;
                totalLabel.Text = scorecard[scorecard.Length - 1].ScoreValue.ToString();


                scorecard[index].ScoreValue = largeStraightTotal;
                scorecard[index].IsScored = true;



                if (IsLastScore())
                {
                    EndGame();
                }
                else
                {
                    ResetTurn();
                }
            }
        }

        private void yahtzeeBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Yahtzee");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Default;
                yahtzeeBGLabel.BackColor = Color.Gainsboro;
                yahtzeeLabel.BackColor = Color.Gold;

                int yahtzeeTotal = ScoreYahtzee();
                yahtzeeLabel.Text = yahtzeeTotal.ToString();

                scorecard[scorecard.Length - 1].ScoreValue += yahtzeeTotal;
                totalLabel.Text = scorecard[scorecard.Length - 1].ScoreValue.ToString();

                scorecard[index].ScoreValue = yahtzeeTotal;
                scorecard[index].IsScored = true;



                if (IsLastScore())
                {
                    EndGame();
                }
                else
                {
                    ResetTurn();
                }
            }
        }

        private void chanceBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Chance");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Default;
                chanceBGLabel.BackColor = Color.Gainsboro;
                chanceLabel.BackColor = Color.Gold;

                int chanceTotal = ScoreChance();
                chanceLabel.Text = chanceTotal.ToString();

                scorecard[scorecard.Length - 1].ScoreValue += chanceTotal;
                totalLabel.Text = scorecard[scorecard.Length - 1].ScoreValue.ToString();

                scorecard[index].ScoreValue = chanceTotal;
                scorecard[index].IsScored = true;



                if (IsLastScore())
                {
                    EndGame();
                }
                else
                {
                    ResetTurn();
                }
            }
        }


        /*
         * 
         * ALL SCORECARD LOGIC
         * 
         */

        private bool IsLastScore()
        {
            //Use to determine if the scorecard is completely full

            foreach (Scoring score in scorecard)
            {
                if (score.IsScored == false)
                    return false;
            }

            return true;
        }

        private int ScoreAces()
        {
            int score = 0;

            foreach (DiceBlock dice in allDice)
            {
                if (dice.DiceValue == 1)
                    score += 1;
            }
            
            return score;
        }

        private int ScoreTwos()
        {
            int score = 0;

            foreach (DiceBlock dice in allDice)
            {
                if (dice.DiceValue == 2)
                    score += 2;
            }

            return score;
        }

        private int ScoreThrees()
        {
            int score = 0;

            foreach (DiceBlock dice in allDice)
            {
                if (dice.DiceValue == 3)
                    score += 3;
            }

            return score;
        }

        private int ScoreFours()
        {
            int score = 0;

            foreach (DiceBlock dice in allDice)
            {
                if (dice.DiceValue == 4)
                    score += 4;
            }

           return score;
        }

        private int ScoreFives()
        {
            int score = 0;

            foreach (DiceBlock dice in allDice)
            {
                if (dice.DiceValue == 5)
                    score += 5;
            }

            return score;
        }

        private int ScoreSixes()
        {
            int score = 0;

            foreach (DiceBlock dice in allDice)
            {
                if (dice.DiceValue == 6)
                    score += 6;
            }

            return score;
        }

        private int ScoreThreeOfAKind()
        {
            int score = 0;
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (DiceBlock dice in allDice)
            {
                if (counts.ContainsKey(dice.DiceValue)) //If the value dice is already a key value
                {
                    //Increment the key value's count by 1
                    counts[dice.DiceValue]++;
                }
                else //If the value dice is not already a key value
                {
                    //Add the key value and set the count equal to 1
                    counts[dice.DiceValue] = 1;
                }
            }

            foreach (int key in counts.Keys)
            {
                //If one of the key values has a count of at least 4
                if (counts[key] >= 3)
                {
                    foreach (DiceBlock dice in allDice)
                        score += dice.DiceValue;
                }
            }

            return score;

        }

        private int ScoreFourOfAKind()
        {
            int score = 0;
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (DiceBlock dice in allDice)
            {
                if (counts.ContainsKey(dice.DiceValue)) //If the value dice is already a key value
                {
                    //Increment the key value's count by 1
                    counts[dice.DiceValue]++;
                }
                else //If the value dice is not already a key value
                {
                    //Add the key value and set the count equal to 1
                    counts[dice.DiceValue] = 1;
                }
            }

            foreach (int key in counts.Keys)
            {
                //If one of the key values has a count of at least 4
                if (counts[key] >= 4)
                {
                    foreach (DiceBlock dice in allDice)
                        score += dice.DiceValue;
                }
            }

            return score;

        }

        private int ScoreFullHouse()
        {
            int score = 0;
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (DiceBlock dice in allDice)
            {
                if (counts.ContainsKey(dice.DiceValue)) //If the value dice is already a key value
                {
                    //Increment the key value's count by 1
                    counts[dice.DiceValue]++;
                }
                else //If the value dice is not already a key value
                {
                    //Add the key value and set the count equal to 1
                    counts[dice.DiceValue] = 1;
                }
            }

            bool hasThree = false;
            bool hasTwo = false;

            foreach (int key in counts.Keys)
            {
                //If one of the key values has a count of 3
                if (counts[key] == 3)
                    hasThree = true;
            }

            foreach (int key in counts.Keys)
            {
                //If one of the key values has a count of 2
                if (counts[key] == 2 && hasThree)
                    hasTwo = true;
            }

            if (hasThree && hasTwo)
                score = 25;

            return score;

        }

        private int ScoreSmallStraight()
        {
            int score = 0;
            int[] tempValues = new int[allDice.Length];

            for (int i = 0; i < allDice.Length; i++)
            {
                tempValues[i] = allDice[i].DiceValue;
            }

            if (tempValues.Contains(1) && tempValues.Contains(2) && tempValues.Contains(3)
                && tempValues.Contains(4))
            {
                score = 30;
            }
            // If array contains 3, 4, 5, and either 2 or 6
            else if ((tempValues.Contains(3) && tempValues.Contains(4) && tempValues.Contains(5))
                        && (tempValues.Contains(6) || tempValues.Contains(2)))
            {
                score = 30;
            }

            return score;

        }

        private int ScoreLargeStraight()
        {
            int score = 0;
            int[] tempValues = new int[allDice.Length];

            for (int i = 0; i < allDice.Length; i++)
            {
                tempValues[i] = allDice[i].DiceValue;
            }

            if (tempValues.Contains(1) && tempValues.Contains(2) && tempValues.Contains(3)
                && tempValues.Contains(4) && tempValues.Contains(5))
            {
                score = 40;
            }
            else if (tempValues.Contains(2) && tempValues.Contains(3) && tempValues.Contains(4)
                    && tempValues.Contains(5) && tempValues.Contains(6))
            {
                score = 40;
            }

            return score;

        }

        private int ScoreYahtzee()
        {
            int score = 50;

            for (int i = 0; i < allDice.Length; i++)
            {
                for (int j = 1; j < allDice.Length; j++)
                {
                    if (allDice[i].DiceValue != allDice[j].DiceValue)
                        score = 0;
                }
            }

            return score;
        }

        private int ScoreChance()
        {
            int score = 0;

            foreach (DiceBlock dice in allDice)
                score += dice.DiceValue;

            return score;
        }


        /*
         * 
         * ALL PICTURE BOX CLICK EVENT HANDLERS
         * 
         */

        private void dicePictureBox1_Click(object sender, EventArgs e)
        {
            if (turn > 1)
            {
                if (allDice[0].IsHeld == false)
                {
                    allDice[0].IsHeld = true;
                    SetCurrentDiceImage(dicePictureBox1, 0);
                }
                else
                {
                    allDice[0].IsHeld = false;
                    SetCurrentDiceImage(dicePictureBox1, 0);
                }
            }
        }

        private void dicePictureBox2_Click(object sender, EventArgs e)
        {
            if (turn > 1)
            {
                if (allDice[1].IsHeld == false)
                {
                    allDice[1].IsHeld = true;
                    SetCurrentDiceImage(dicePictureBox2, 1);
                }
                else
                {
                    allDice[1].IsHeld = false;
                    SetCurrentDiceImage(dicePictureBox2, 1);
                }
            }
        }

        private void dicePictureBox3_Click(object sender, EventArgs e)
        {
            if (turn > 1)
            {
                if (allDice[2].IsHeld == false)
                {
                    allDice[2].IsHeld = true;
                    SetCurrentDiceImage(dicePictureBox3, 2);
                }
                else
                {
                    allDice[2].IsHeld = false;
                    SetCurrentDiceImage(dicePictureBox3, 2);
                }
            }
        }

        private void dicePictureBox4_Click(object sender, EventArgs e)
        {
            if (turn > 1)
            {
                if (allDice[3].IsHeld == false)
                {
                    allDice[3].IsHeld = true;
                    SetCurrentDiceImage(dicePictureBox4, 3);
                }
                else
                {
                    allDice[3].IsHeld = false;
                    SetCurrentDiceImage(dicePictureBox4, 3);
                }
            }
        }

        private void dicePictureBox5_Click(object sender, EventArgs e)
        {
            if (turn > 1)
            {
                if (allDice[4].IsHeld == false)
                {
                    allDice[4].IsHeld = true;
                    SetCurrentDiceImage(dicePictureBox5, 4);
                }
                else
                {
                    allDice[4].IsHeld = false;
                    SetCurrentDiceImage(dicePictureBox5, 4);
                }
            }             
        }


        /*
         * 
         * ALL LABEL MOUSE ENTER / MOUSE LEAVE EVENT HANDLERS
         * 
         */

        

        private void acesBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file

            int index = Array.IndexOf(scoreTypes, "Aces");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Hand;
                acesBGLabel.BackColor = Color.White;
                acesLabel.BackColor = Color.White;

                if (hasBonus == false)
                {
                    DisplayBonus(ScoreAces());
                }
            }
        }

        private void acesBGLabel_MouseLeave(object sender, EventArgs e)
        {
            acesBGLabel.BackColor = Color.Gainsboro;
            ResetBonusLabelDisplay();

            int index = Array.IndexOf(scoreTypes, "Aces");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                acesLabel.BackColor = Color.White;
            }
            else if (scorecard[index].IsScored == false)
            {
                acesLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                acesLabel.BackColor = Color.Gold;
            }
        }

        private void twosBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Twos");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Hand;
                twosBGLabel.BackColor = Color.White;
                twosLabel.BackColor = Color.White;

                if (hasBonus == false)
                {
                    DisplayBonus(ScoreTwos());
                }
            }
        }

        private void twosBGLabel_MouseLeave(object sender, EventArgs e)
        {
            twosBGLabel.BackColor= Color.Gainsboro;
            ResetBonusLabelDisplay();

            int index = Array.IndexOf(scoreTypes, "Twos");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                twosLabel.BackColor = Color.White;
            }
            else if (scorecard[index].IsScored == false)
            {
                twosLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                twosLabel.BackColor = Color.Gold;
            }
        }

        private void threesBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Threes");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Hand;
                threesBGLabel.BackColor = Color.White;
                threesLabel.BackColor = Color.White;

                if (hasBonus == false)
                {
                    DisplayBonus(ScoreThrees());
                }
            }
        }

        private void threesBGLabel_MouseLeave(object sender, EventArgs e)
        {
            threesBGLabel.BackColor = Color.Gainsboro;
            ResetBonusLabelDisplay();

            int index = Array.IndexOf(scoreTypes, "Threes");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                threesLabel.BackColor = Color.White;
            }
            else if (scorecard[index].IsScored == false)
            {
                threesLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                threesLabel.BackColor = Color.Gold;
            }
        }

        private void foursBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Fours");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Hand;
                foursBGLabel.BackColor = Color.White;
                foursLabel.BackColor = Color.White;

                if (hasBonus == false)
                {
                    DisplayBonus(ScoreFours());
                }
            }
        }

        private void foursBGLabel_MouseLeave(object sender, EventArgs e)
        {
            foursBGLabel.BackColor = Color.Gainsboro;
            ResetBonusLabelDisplay();

            int index = Array.IndexOf(scoreTypes, "Fours");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                foursLabel.BackColor = Color.White;
            }
            else if (scorecard[index].IsScored == false)
            {
                foursLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                foursLabel.BackColor = Color.Gold;
            }
        }

        private void fivesBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Fives");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Hand;
                fivesBGLabel.BackColor = Color.White;
                fivesLabel.BackColor = Color.White;

                if (hasBonus == false)
                {
                    DisplayBonus(ScoreFives());
                }
            }
        }

        private void fivesBGLabel_MouseLeave(object sender, EventArgs e)
        {
            fivesBGLabel.BackColor = Color.Gainsboro;
            ResetBonusLabelDisplay();

            int index = Array.IndexOf(scoreTypes, "Fives");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                fivesLabel.BackColor = Color.White;
            }
            else if (scorecard[index].IsScored == false)
            {
                fivesLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                fivesLabel.BackColor = Color.Gold;
            }
        }

        private void sixesBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Sixes");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Hand;
                sixesBGLabel.BackColor = Color.White;
                sixesLabel.BackColor = Color.White;

                if (hasBonus == false)
                {
                    DisplayBonus(ScoreSixes());
                }
            }
        }

        private void sixesBGLabel_MouseLeave(object sender, EventArgs e)
        {
            sixesBGLabel.BackColor = Color.Gainsboro;
            ResetBonusLabelDisplay();

            int index = Array.IndexOf(scoreTypes, "Sixes");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                sixesLabel.BackColor = Color.White;
            }
            else if (scorecard[index].IsScored == false)
            {
                sixesLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                sixesLabel.BackColor = Color.Gold;
            }
        }

        private void threeKindBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Three of a Kind");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Hand;
                threeKindBGLabel.BackColor = Color.White;
                threeOfAKindLabel.BackColor = Color.White;
            }
        }

        private void threeKindBGLabel_MouseLeave(object sender, EventArgs e)
        {
            threeKindBGLabel.BackColor = Color.Gainsboro;

            int index = Array.IndexOf(scoreTypes, "Three of a Kind");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                threeOfAKindLabel.BackColor = Color.White;
            }
            else if (scorecard[index].IsScored == false)
            {
                threeOfAKindLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                threeOfAKindLabel.BackColor = Color.Gold;
            }
        }

        private void fourKindBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Four of a Kind");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Hand;
                fourKindBGLabel.BackColor = Color.White;
                fourOfAKindLabel.BackColor = Color.White;
            }
        }

        private void fourKindBGLabel_MouseLeave(object sender, EventArgs e)
        {
            fourKindBGLabel.BackColor = Color.Gainsboro;

            int index = Array.IndexOf(scoreTypes, "Four of a Kind");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                fourOfAKindLabel.BackColor = Color.White;
            }
            else if (scorecard[index].IsScored == false)
            {
                fourOfAKindLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                fourOfAKindLabel.BackColor = Color.Gold;
            }
        }

        private void fullHouseBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Full House");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Hand;
                fullHouseBGLabel.BackColor = Color.White;
                fullHouseLabel.BackColor = Color.White;
            }
        }

        private void fullHouseBGLabel_MouseLeave(object sender, EventArgs e)
        {
            fullHouseBGLabel.BackColor = Color.Gainsboro;

            int index = Array.IndexOf(scoreTypes, "Full House");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                fullHouseLabel.BackColor = Color.White;
            }
            else if (scorecard[index].IsScored == false)
            {
                fullHouseLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                fullHouseLabel.BackColor = Color.Gold;
            }
        }

        private void smallStraightBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Small Straight");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Hand;
                smallStraightBGLabel.BackColor = Color.White;
                smallStraightLabel.BackColor = Color.White;
            }
        }

        private void smallStraightBGLabel_MouseLeave(object sender, EventArgs e)
        {
            smallStraightBGLabel.BackColor = Color.Gainsboro;

            int index = Array.IndexOf(scoreTypes, "Small Straight");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                smallStraightLabel.BackColor = Color.White;
            }
            else if (scorecard[index].IsScored == false)
            {
                smallStraightLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                smallStraightLabel.BackColor = Color.Gold;
            }
        }

        private void largeStraightBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Large Straight");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Hand;
                largeStraightBGLabel.BackColor = Color.White;
                largeStraightLabel.BackColor = Color.White;
            }
        }

        private void largeStraightBGLabel_MouseLeave(object sender, EventArgs e)
        {
            largeStraightBGLabel.BackColor = Color.Gainsboro;

            int index = Array.IndexOf(scoreTypes, "Large Straight");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                largeStraightLabel.BackColor = Color.White;
            }
            else if (scorecard[index].IsScored == false)
            {
                largeStraightLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                largeStraightLabel.BackColor = Color.Gold;
            }
        }

        private void yahtzeeBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Yahtzee");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Hand;
                yahtzeeBGLabel.BackColor = Color.White;
                yahtzeeLabel.BackColor = Color.White;
            }
        }

        private void yahtzeeBGLabel_MouseLeave(object sender, EventArgs e)
        {
            yahtzeeBGLabel.BackColor = Color.Gainsboro;

            int index = Array.IndexOf(scoreTypes, "Yahtzee");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                yahtzeeLabel.BackColor = Color.White;
            }
            else if (scorecard[index].IsScored == false)
            {
                yahtzeeLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                yahtzeeLabel.BackColor = Color.Gold;
            }
        }

        private void chanceBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            int index = Array.IndexOf(scoreTypes, "Chance");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                Cursor = Cursors.Hand;
                chanceBGLabel.BackColor = Color.White;
                chanceLabel.BackColor = Color.White;
            }
        }

        private void chanceBGLabel_MouseLeave(object sender, EventArgs e)
        {
            chanceBGLabel.BackColor = Color.Gainsboro;

            int index = Array.IndexOf(scoreTypes, "Chance");

            if (scorecard[index].IsScored == false && turn > 1)
            {
                chanceLabel.BackColor = Color.White;
            }
            else if (scorecard[index].IsScored == false)
            {
                chanceLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                chanceLabel.BackColor = Color.Gold;
            }
        }



        /*
         * 
         * ALL PICTUREBOX MOUSE ENTER / MOUSE LEAVE EVENT HANDLERS
         * 
         */

        private void SetCurrentDiceImage(PictureBox pictureBox, int index)
        {
            switch (allDice[index].DiceValue)
            {
                case 1:
                    if (allDice[index].IsHeld)
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock1graygold;
                    else
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock1gold;
                    break;
                case 2:
                    if (allDice[index].IsHeld)
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock2graygold;
                    else
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock2gold; 
                    break;
                case 3:
                    if (allDice[index].IsHeld)
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock3graygold;
                    else
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock3gold; 
                    break;
                case 4:
                    if (allDice[index].IsHeld)
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock4graygold;
                    else
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock4gold; 
                    break;
                case 5:
                    if (allDice[index].IsHeld)
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock5graygold;
                    else
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock5gold; 
                    break;
                case 6:
                    if (allDice[index].IsHeld)
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock6graygold;
                    else
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock6gold;
                    break;
                default:
                    DialogResult dialog = MessageBox.Show("Error: Cannot set dice image.",
                                     Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void LeaveImage(PictureBox pictureBox, int index)
        {
            switch (allDice[index].DiceValue)
            {
                case 1:
                    if (allDice[index].IsHeld)
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock1gray;
                    else
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock1;
                    break;
                case 2:
                    if (allDice[index].IsHeld)
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock2gray;
                    else
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock2;
                    break;
                case 3:
                    if (allDice[index].IsHeld)
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock3gray;
                    else
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock3;
                    break;
                case 4:
                    if (allDice[index].IsHeld)
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock4gray;
                    else
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock4;
                    break;
                case 5:
                    if (allDice[index].IsHeld)
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock5gray;
                    else
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock5;
                    break;
                case 6:
                    if (allDice[index].IsHeld)
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock6gray;
                    else
                        pictureBox.Image = global::Yahtzee.Properties.Resources.diceblock6;
                    break;
                default:
                    DialogResult dialog = MessageBox.Show("Error: Cannot set dice image.",
                                     Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void dicePictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (turn > 1)
            {
                Cursor = Cursors.Hand;
                SetCurrentDiceImage(dicePictureBox1, 0);
            }
        }

        private void dicePictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (turn > 1)
            {
                Cursor = Cursors.Default;
                LeaveImage(dicePictureBox1, 0);
            }
        }

        private void dicePictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if (turn > 1)
            {
                Cursor = Cursors.Hand;
                SetCurrentDiceImage(dicePictureBox2, 1);
            }
        }

        private void dicePictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (turn > 1)
            {
                Cursor = Cursors.Default;
                LeaveImage(dicePictureBox2, 1);
            }
        }

        private void dicePictureBox3_MouseEnter(object sender, EventArgs e)
        {
            if (turn > 1)
            {
                Cursor = Cursors.Hand;
                SetCurrentDiceImage(dicePictureBox3, 2);
            }
        }

        private void dicePictureBox3_MouseLeave(object sender, EventArgs e)
        {
            if (turn > 1)
            {
                Cursor = Cursors.Default;
                LeaveImage(dicePictureBox3, 2);
            }
        }

        private void dicePictureBox4_MouseEnter(object sender, EventArgs e)
        {
            if (turn > 1)
            {
                Cursor = Cursors.Hand;
                SetCurrentDiceImage(dicePictureBox4, 3);
            }
        }

        private void dicePictureBox4_MouseLeave(object sender, EventArgs e)
        {
            if (turn > 1)
            {
                Cursor = Cursors.Default;
                LeaveImage(dicePictureBox4, 3);
            }
        }

        private void dicePictureBox5_MouseEnter(object sender, EventArgs e)
        {
            if (turn > 1)
            {
                Cursor = Cursors.Hand;
                SetCurrentDiceImage(dicePictureBox5, 4);
            }
        }

        private void dicePictureBox5_MouseLeave(object sender, EventArgs e)
        {
            if (turn > 1)
            {
                Cursor = Cursors.Default;
                LeaveImage(dicePictureBox5, 4);
            }
        }
    }
}
