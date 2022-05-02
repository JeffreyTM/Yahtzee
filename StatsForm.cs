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

namespace Yahtzee
{

    // Learn how to get rid of border on tab control
    // ***ERROR HANDLING FOR IF A FILE IS DELETED

    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        //  scoreTypes: Array that stores all 14 scores on a Yahtzee scorecard
        string[] scoreTypes = {"Aces", "Twos", "Threes", "Fours", "Fives", "Sixes",
                                "Three of a Kind" , "Four of a Kind", "Full House",
                                "Small Straight", "Large Straight", "Yahtzee", "Chance", "Bonus", "Total"};

        // int is the game ID, int[] holds all scoreType values and mirrors scoreType order
        Dictionary<int, int[]> gameScoringData = new Dictionary<int, int[]>();


        int gamesPlayed = 0;
        bool isResetting = false;

        private void StatsForm_Load(object sender, EventArgs e)
        {
            LoadGameData();

            //  Add logic telling the user they have no games played
            if (gamesPlayed != 0)
            {
                LoadScoreData();
                LoadRollData();
            }
        }

        private void LoadGameData()
        {
            StreamReader srGameData = new StreamReader("GameData.txt");
            while (!srGameData.EndOfStream)
            {
                string currentLine = srGameData.ReadLine();
                string[] fields = currentLine.Split(',');


                if (fields.Length > 1)
                {
                    string[] dataGridViewValues = new string[] { fields[0], fields[1], fields[2], fields[3] };
                    int[] scores = new int[15];

                    for (int i = 4; i < fields.Length; i++)
                    {
                        scores[i - 4] = int.Parse(fields[i]);
                    }

                    // Append Total to the last value of scores[]
                    scores[scores.Length - 1] = int.Parse(fields[3]);

                    gameScoringData.Add(int.Parse(fields[0]), scores);

                    gameDataGridView.Rows.Add(dataGridViewValues);

                    gamesPlayed++;
                }
            }
            srGameData.Close();
        }

        private void LoadScoreData()
        {
            StreamReader srScoreData = new StreamReader("ScoreData.txt");
            while (!srScoreData.EndOfStream)
            {
                string currentLine = srScoreData.ReadLine();
                string[] fields = currentLine.Split(',');

                if (fields.Length > 1)
                {
                    double average = Math.Round((double.Parse(fields[2]) / gamesPlayed), 2);

                    string[] dataGridViewValues = { fields[0], fields[1], fields[2], average.ToString() };
                    scoringDataGridView.Rows.Add(dataGridViewValues);
                }

            }
            srScoreData.Close();
        }

        private void LoadRollData()
        {
            //this.rollsDataGridView.Columns["Roll Type:"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            StreamReader srRollData = new StreamReader("RollData.txt");

            string[] titles = { "Times Rolled:", "Turns Held:", "Average Rolls Per Game:",
                                        "Most Times Rolled in One Game:", "Least Times Rolled in One Game:" };
            int[] timesRolled = new int[6];
            int[] turnsHeld = new int[6];
            double[] average = new double[6];
            int[] mostTimesRolled = new int[6];
            int[] leastTimesRolled = new int[6];
            int index = 0;

            while (!srRollData.EndOfStream)
            {
                string currentLine = srRollData.ReadLine();

                // scoreType, timesRolled, turnsHeld, mostRolls, leastRolls
                string[] fields = currentLine.Split(',');

                if (fields.Length > 1)
                {
                    // Times Rolled, Turns Held, Average Rolls Per Game, Most times rolled in one game, Least times rolled in one game
                    timesRolled[index] = int.Parse(fields[1]);
                    turnsHeld[index] = int.Parse(fields[2]);
                    average[index] = Math.Round((double)timesRolled[index] / gamesPlayed, 2);
                    mostTimesRolled[index] = int.Parse(fields[3]);
                    leastTimesRolled[index] = int.Parse(fields[4]);

                    index++;
                }
                else
                {
                    return;
                }
            }
            srRollData.Close();

            // Append values to listView
            for (int i = 0; i < titles.Length; i++)
            {
                string[] dataGridViewValues = new string[7];
                dataGridViewValues[0] = titles[i].ToString();

                switch (i)
                {
                    case 0:
                        for (int j = 0; j < timesRolled.Length; j++)
                            dataGridViewValues[j + 1] = timesRolled[j].ToString();
                        break;
                    case 1:
                        for (int j = 0; j < turnsHeld.Length; j++)
                            dataGridViewValues[j + 1] = turnsHeld[j].ToString();
                        break;
                    case 2:
                        for (int j = 0; j < average.Length; j++)
                            dataGridViewValues[j + 1] = average[j].ToString();
                        break;
                    case 3:
                        for (int j = 0; j < mostTimesRolled.Length; j++)
                            dataGridViewValues[j + 1] = mostTimesRolled[j].ToString();
                        break;
                    case 4:
                        for (int j = 0; j < leastTimesRolled.Length; j++)
                            dataGridViewValues[j + 1] = leastTimesRolled[j].ToString();
                        break;
                }
                rollsDataGridView.Rows.Add(dataGridViewValues);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //  Add confirmation
           /* DialogResult dialog = MessageBox.Show("Are you sure you want to ",
                                     Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);*/
            Close();
        }

        private void resetStatsButton_Click(object sender, EventArgs e)
        {
            //Require extra confirmation (maybe ask user to type "Agree" or something
            DialogResult dialog = MessageBox.Show("WARNING: All stats will be lost. Are you sure you want to delete all stats?",
                                     Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                isResetting = true;
                ResetGameData();
                ResetScoreData();
                ResetRollData();
                gamesPlayed = 0;

                gameDataGridView.Rows.Clear();
                scorecardListBox.Items.Clear();
                scoringDataGridView.Rows.Clear();
                rollsDataGridView.Rows.Clear();

                isResetting = false;


            }
           
        }

        private void ResetGameData()
        {
            StreamWriter swGameData = new StreamWriter("GameData.txt", false);

            swGameData.Write("");

            swGameData.Close();
        }

        private void ResetScoreData()
        {
            StreamWriter swScoreData = new StreamWriter("ScoreData.txt", false);

            for (int i = 0; i < scoreTypes.Length; i++)
                swScoreData.WriteLine(scoreTypes[i] + ",0,0");

            swScoreData.Close();
        }

        private void ResetRollData()
        {
            StreamWriter swRollData = new StreamWriter("RollData.txt", false);

            for (int i = 0; i < 6; i++)
                swRollData.WriteLine(scoreTypes[i] + ",0,0,0,0");

            swRollData.Close();
        }

        private void gameDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            if (gameDataGridView.Rows.Count > 0 && isResetting == false)
            {
                scorecardListBox.Items.Clear();
                int currentGameIndex = int.Parse(gameDataGridView.SelectedCells[0].Value.ToString());

                scorecardListBox.Items.Add("Game " + currentGameIndex + " Scorecard");

                for (int i = 0; i < gameScoringData[currentGameIndex].Length; i++)
                {
                    scorecardListBox.Items.Add(scoreTypes[i] + ": " + gameScoringData[currentGameIndex][i]);
                }
            }


            /*listBox1.Items.Add("Played on " + dateColumn. + " at "
                + dateColumn.ToString());*//*

            // Add the logic for displaying scores here
        }*/
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
            this.Close();
        }
    }
}
