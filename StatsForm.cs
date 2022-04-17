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
    public partial class StatsForm : Form 
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        //  scoreTypes: Array that stores all 14 scores on a Yahtzee scorecard
        string[] scoreTypes = {"Aces", "Twos", "Threes", "Fours", "Fives", "Sixes",
                                "Three of a Kind" , "Four of a Kind", "Full House",
                                "Small Straight", "Large Straight", "Yahtzee", "Chance", "Total"};
        
        // int is the game ID, int[] holds all scoreType values and mirrors scoreType order
        Dictionary<int, int[]> gameScoringData = new Dictionary<int, int[]>();

        private void StatsForm_Load(object sender, EventArgs e)
        {
            //statsTabControl.



            StreamReader srGameData = new StreamReader("GameData.txt");

            while (!srGameData.EndOfStream)
            {
                string currentLine = srGameData.ReadLine();
                string[] fields = currentLine.Split(',');


                string[] listViewData = new string[] { fields[0], fields[1], fields[2], fields[3] };
                int[] scores = new int[14];


                if (fields.Length > 1)
                {
                    for (int i = 4; i < fields.Length; i++)
                        scores[i - 4] = int.Parse(fields[i]);
                    scores[scores.Length - 1] = int.Parse(fields[3]);

                    gameScoringData.Add(int.Parse(fields[0]), scores);

                    ListViewItem gameDataLVI = new ListViewItem(listViewData);
                    gameHistoryListView.Items.Add(gameDataLVI);
                }
            }
            srGameData.Close();

            // LOAD srScoreData AND DISPLAY IT ON THE TAB

            // LOAD srRollData AND DISPLAY IT ON THE TAB



            /*for (int j = 1; j <= gameScoringData.Count; j++)
            {
                for (int i = 0; i < gameScoringData[j].Length; i++)
                {
                    listBox1.Items.Add(scoreTypes[i] + ", " + gameScoringData[j][i]);
                }
            }*/
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    private void resetStatsButton_Click(object sender, EventArgs e)
        {
            ResetGameData();
            ResetScoreData();
            ResetRollData();
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
                swScoreData.WriteLine(scoreTypes[i] + ",0");
            
            swScoreData.Close();
        }

        private void ResetRollData()
        {
            StreamWriter swRollData = new StreamWriter("RollData.txt", false);

            for (int i = 0; i < 6; i++)
                swRollData.WriteLine(scoreTypes[i] + ",0,0");

            swRollData.Close();
        }

        private void gameHistoryListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = gameHistoryListView.Columns[e.ColumnIndex].Width;
        }

        private void gameHistoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(gameHistoryListView.SelectedItems.Count > 0)
            {
                scorecardListBox.Items.Clear();

                
                int test = int.Parse(gameHistoryListView.SelectedItems[0].Text);
                scorecardListBox.Items.Add("Game " + test);

                for (int i = 0; i < gameScoringData[test].Length; i++)
                {
                    scorecardListBox.Items.Add(scoreTypes[i] + ": " + gameScoringData[test][i]);
                }

                /*string[] selected = new string[] {  };

                foreach (string item in selected)
                    listBox1.Items.Add(item + ", ");*/

                /*listBox1.Items.Add("Played on " + dateColumn. + " at "
                    + dateColumn.ToString());*/
                    
                    // Add the logic for displaying scores here
            }

        }
    }
}
