namespace Yahtzee
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.rollButton = new System.Windows.Forms.Button();
            this.exitGameButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.largeStraightLabel = new System.Windows.Forms.Label();
            this.yahtzeeLabel = new System.Windows.Forms.Label();
            this.chanceLabel = new System.Windows.Forms.Label();
            this.largeStraightBGLabel = new System.Windows.Forms.Label();
            this.yahtzeeBGLabel = new System.Windows.Forms.Label();
            this.chanceBGLabel = new System.Windows.Forms.Label();
            this.acesLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.twosLabel = new System.Windows.Forms.Label();
            this.totalBGLabel = new System.Windows.Forms.Label();
            this.fullHouseLabel = new System.Windows.Forms.Label();
            this.smallStraightLabel = new System.Windows.Forms.Label();
            this.sixesLabel = new System.Windows.Forms.Label();
            this.threeOfAKindLabel = new System.Windows.Forms.Label();
            this.fourOfAKindLabel = new System.Windows.Forms.Label();
            this.threesLabel = new System.Windows.Forms.Label();
            this.foursLabel = new System.Windows.Forms.Label();
            this.fivesLabel = new System.Windows.Forms.Label();
            this.acesBGLabel = new System.Windows.Forms.Label();
            this.fourKindBGLabel = new System.Windows.Forms.Label();
            this.sixesBGLabel = new System.Windows.Forms.Label();
            this.fullHouseBGLabel = new System.Windows.Forms.Label();
            this.fivesBGLabel = new System.Windows.Forms.Label();
            this.smallStraightBGLabel = new System.Windows.Forms.Label();
            this.foursBGLabel = new System.Windows.Forms.Label();
            this.threesBGLabel = new System.Windows.Forms.Label();
            this.threeKindBGLabel = new System.Windows.Forms.Label();
            this.twosBGLabel = new System.Windows.Forms.Label();
            this.instructionsButton = new System.Windows.Forms.Button();
            this.roundLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dicePictureBox1 = new System.Windows.Forms.PictureBox();
            this.dicePictureBox5 = new System.Windows.Forms.PictureBox();
            this.dicePictureBox2 = new System.Windows.Forms.PictureBox();
            this.dicePictureBox4 = new System.Windows.Forms.PictureBox();
            this.dicePictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollButton.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.Location = new System.Drawing.Point(95, 687);
            this.rollButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(188, 121);
            this.rollButton.TabIndex = 2;
            this.rollButton.Text = "Roll";
            this.toolTip1.SetToolTip(this.rollButton, "Roll the dice");
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // exitGameButton
            // 
            this.exitGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitGameButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitGameButton.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitGameButton.Location = new System.Drawing.Point(551, 687);
            this.exitGameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(188, 121);
            this.exitGameButton.TabIndex = 4;
            this.exitGameButton.Text = "Main Menu";
            this.toolTip1.SetToolTip(this.exitGameButton, "Return to the main menu");
            this.exitGameButton.UseVisualStyleBackColor = true;
            this.exitGameButton.Click += new System.EventHandler(this.exitGameButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(382, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 575);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scorecard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.largeStraightLabel);
            this.panel1.Controls.Add(this.yahtzeeLabel);
            this.panel1.Controls.Add(this.chanceLabel);
            this.panel1.Controls.Add(this.largeStraightBGLabel);
            this.panel1.Controls.Add(this.yahtzeeBGLabel);
            this.panel1.Controls.Add(this.chanceBGLabel);
            this.panel1.Controls.Add(this.acesLabel);
            this.panel1.Controls.Add(this.totalLabel);
            this.panel1.Controls.Add(this.twosLabel);
            this.panel1.Controls.Add(this.totalBGLabel);
            this.panel1.Controls.Add(this.fullHouseLabel);
            this.panel1.Controls.Add(this.smallStraightLabel);
            this.panel1.Controls.Add(this.sixesLabel);
            this.panel1.Controls.Add(this.threeOfAKindLabel);
            this.panel1.Controls.Add(this.fourOfAKindLabel);
            this.panel1.Controls.Add(this.threesLabel);
            this.panel1.Controls.Add(this.foursLabel);
            this.panel1.Controls.Add(this.fivesLabel);
            this.panel1.Controls.Add(this.acesBGLabel);
            this.panel1.Controls.Add(this.fourKindBGLabel);
            this.panel1.Controls.Add(this.sixesBGLabel);
            this.panel1.Controls.Add(this.fullHouseBGLabel);
            this.panel1.Controls.Add(this.fivesBGLabel);
            this.panel1.Controls.Add(this.smallStraightBGLabel);
            this.panel1.Controls.Add(this.foursBGLabel);
            this.panel1.Controls.Add(this.threesBGLabel);
            this.panel1.Controls.Add(this.threeKindBGLabel);
            this.panel1.Controls.Add(this.twosBGLabel);
            this.panel1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(76, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 494);
            this.panel1.TabIndex = 1;
            // 
            // largeStraightLabel
            // 
            this.largeStraightLabel.Location = new System.Drawing.Point(151, 354);
            this.largeStraightLabel.Name = "largeStraightLabel";
            this.largeStraightLabel.Size = new System.Drawing.Size(45, 27);
            this.largeStraightLabel.TabIndex = 21;
            this.largeStraightLabel.Text = "---";
            this.largeStraightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.largeStraightLabel.Click += new System.EventHandler(this.largeStraightBGLabel_Click);
            this.largeStraightLabel.MouseEnter += new System.EventHandler(this.largeStraightBGLabel_MouseEnter);
            this.largeStraightLabel.MouseLeave += new System.EventHandler(this.largeStraightBGLabel_MouseLeave);
            // 
            // yahtzeeLabel
            // 
            this.yahtzeeLabel.Location = new System.Drawing.Point(151, 389);
            this.yahtzeeLabel.Name = "yahtzeeLabel";
            this.yahtzeeLabel.Size = new System.Drawing.Size(45, 27);
            this.yahtzeeLabel.TabIndex = 23;
            this.yahtzeeLabel.Text = "---";
            this.yahtzeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yahtzeeLabel.Click += new System.EventHandler(this.yahtzeeBGLabel_Click);
            this.yahtzeeLabel.MouseEnter += new System.EventHandler(this.yahtzeeBGLabel_MouseEnter);
            this.yahtzeeLabel.MouseLeave += new System.EventHandler(this.yahtzeeBGLabel_MouseLeave);
            // 
            // chanceLabel
            // 
            this.chanceLabel.Location = new System.Drawing.Point(151, 424);
            this.chanceLabel.Name = "chanceLabel";
            this.chanceLabel.Size = new System.Drawing.Size(45, 27);
            this.chanceLabel.TabIndex = 25;
            this.chanceLabel.Text = "---";
            this.chanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chanceLabel.Click += new System.EventHandler(this.chanceBGLabel_Click);
            this.chanceLabel.MouseEnter += new System.EventHandler(this.chanceBGLabel_MouseEnter);
            this.chanceLabel.MouseLeave += new System.EventHandler(this.chanceBGLabel_MouseLeave);
            // 
            // largeStraightBGLabel
            // 
            this.largeStraightBGLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.largeStraightBGLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.largeStraightBGLabel.Location = new System.Drawing.Point(4, 354);
            this.largeStraightBGLabel.Name = "largeStraightBGLabel";
            this.largeStraightBGLabel.Size = new System.Drawing.Size(191, 28);
            this.largeStraightBGLabel.TabIndex = 20;
            this.largeStraightBGLabel.Text = "Large Straight:";
            this.largeStraightBGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.largeStraightBGLabel.Click += new System.EventHandler(this.largeStraightBGLabel_Click);
            this.largeStraightBGLabel.MouseEnter += new System.EventHandler(this.largeStraightBGLabel_MouseEnter);
            this.largeStraightBGLabel.MouseLeave += new System.EventHandler(this.largeStraightBGLabel_MouseLeave);
            // 
            // yahtzeeBGLabel
            // 
            this.yahtzeeBGLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.yahtzeeBGLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yahtzeeBGLabel.Location = new System.Drawing.Point(4, 389);
            this.yahtzeeBGLabel.Name = "yahtzeeBGLabel";
            this.yahtzeeBGLabel.Size = new System.Drawing.Size(190, 28);
            this.yahtzeeBGLabel.TabIndex = 22;
            this.yahtzeeBGLabel.Text = "Yahtzee:";
            this.yahtzeeBGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yahtzeeBGLabel.Click += new System.EventHandler(this.yahtzeeBGLabel_Click);
            this.yahtzeeBGLabel.MouseEnter += new System.EventHandler(this.yahtzeeBGLabel_MouseEnter);
            this.yahtzeeBGLabel.MouseLeave += new System.EventHandler(this.yahtzeeBGLabel_MouseLeave);
            // 
            // chanceBGLabel
            // 
            this.chanceBGLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.chanceBGLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chanceBGLabel.Location = new System.Drawing.Point(4, 424);
            this.chanceBGLabel.Name = "chanceBGLabel";
            this.chanceBGLabel.Size = new System.Drawing.Size(190, 28);
            this.chanceBGLabel.TabIndex = 24;
            this.chanceBGLabel.Text = "Chance:";
            this.chanceBGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chanceBGLabel.Click += new System.EventHandler(this.chanceBGLabel_Click);
            this.chanceBGLabel.MouseEnter += new System.EventHandler(this.chanceBGLabel_MouseEnter);
            this.chanceBGLabel.MouseLeave += new System.EventHandler(this.chanceBGLabel_MouseLeave);
            // 
            // acesLabel
            // 
            this.acesLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.acesLabel.Location = new System.Drawing.Point(151, 4);
            this.acesLabel.Name = "acesLabel";
            this.acesLabel.Size = new System.Drawing.Size(45, 27);
            this.acesLabel.TabIndex = 1;
            this.acesLabel.Text = "---";
            this.acesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.acesLabel.Click += new System.EventHandler(this.acesBGLabel_Click);
            this.acesLabel.MouseEnter += new System.EventHandler(this.acesBGLabel_MouseEnter);
            this.acesLabel.MouseLeave += new System.EventHandler(this.acesBGLabel_MouseLeave);
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(151, 460);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(45, 27);
            this.totalLabel.TabIndex = 27;
            this.totalLabel.Text = "---";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twosLabel
            // 
            this.twosLabel.Location = new System.Drawing.Point(151, 39);
            this.twosLabel.Name = "twosLabel";
            this.twosLabel.Size = new System.Drawing.Size(45, 27);
            this.twosLabel.TabIndex = 3;
            this.twosLabel.Text = "---";
            this.twosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.twosLabel.Click += new System.EventHandler(this.twosBGLabel_Click);
            this.twosLabel.MouseEnter += new System.EventHandler(this.twosBGLabel_MouseEnter);
            this.twosLabel.MouseLeave += new System.EventHandler(this.twosBGLabel_MouseLeave);
            // 
            // totalBGLabel
            // 
            this.totalBGLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalBGLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalBGLabel.Location = new System.Drawing.Point(4, 460);
            this.totalBGLabel.Name = "totalBGLabel";
            this.totalBGLabel.Size = new System.Drawing.Size(191, 28);
            this.totalBGLabel.TabIndex = 26;
            this.totalBGLabel.Text = "Total:";
            this.totalBGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fullHouseLabel
            // 
            this.fullHouseLabel.Location = new System.Drawing.Point(151, 284);
            this.fullHouseLabel.Name = "fullHouseLabel";
            this.fullHouseLabel.Size = new System.Drawing.Size(45, 27);
            this.fullHouseLabel.TabIndex = 17;
            this.fullHouseLabel.Text = "---";
            this.fullHouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fullHouseLabel.Click += new System.EventHandler(this.fullHouseBGLabel_Click);
            this.fullHouseLabel.MouseEnter += new System.EventHandler(this.fullHouseBGLabel_MouseEnter);
            this.fullHouseLabel.MouseLeave += new System.EventHandler(this.fullHouseBGLabel_MouseLeave);
            // 
            // smallStraightLabel
            // 
            this.smallStraightLabel.Location = new System.Drawing.Point(151, 319);
            this.smallStraightLabel.Name = "smallStraightLabel";
            this.smallStraightLabel.Size = new System.Drawing.Size(45, 27);
            this.smallStraightLabel.TabIndex = 19;
            this.smallStraightLabel.Text = "---";
            this.smallStraightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.smallStraightLabel.Click += new System.EventHandler(this.smallStraightBGLabel_Click);
            this.smallStraightLabel.MouseEnter += new System.EventHandler(this.smallStraightBGLabel_MouseEnter);
            this.smallStraightLabel.MouseLeave += new System.EventHandler(this.smallStraightBGLabel_MouseLeave);
            // 
            // sixesLabel
            // 
            this.sixesLabel.Location = new System.Drawing.Point(151, 179);
            this.sixesLabel.Name = "sixesLabel";
            this.sixesLabel.Size = new System.Drawing.Size(45, 27);
            this.sixesLabel.TabIndex = 11;
            this.sixesLabel.Text = "---";
            this.sixesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sixesLabel.Click += new System.EventHandler(this.sixesBGLabel_Click);
            this.sixesLabel.MouseEnter += new System.EventHandler(this.sixesBGLabel_MouseEnter);
            this.sixesLabel.MouseLeave += new System.EventHandler(this.sixesBGLabel_MouseLeave);
            // 
            // threeOfAKindLabel
            // 
            this.threeOfAKindLabel.Location = new System.Drawing.Point(151, 214);
            this.threeOfAKindLabel.Name = "threeOfAKindLabel";
            this.threeOfAKindLabel.Size = new System.Drawing.Size(45, 27);
            this.threeOfAKindLabel.TabIndex = 13;
            this.threeOfAKindLabel.Text = "---";
            this.threeOfAKindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.threeOfAKindLabel.Click += new System.EventHandler(this.threeKindBGLabel_Click);
            this.threeOfAKindLabel.MouseEnter += new System.EventHandler(this.threeKindBGLabel_MouseEnter);
            this.threeOfAKindLabel.MouseLeave += new System.EventHandler(this.threeKindBGLabel_MouseLeave);
            // 
            // fourOfAKindLabel
            // 
            this.fourOfAKindLabel.Location = new System.Drawing.Point(151, 249);
            this.fourOfAKindLabel.Name = "fourOfAKindLabel";
            this.fourOfAKindLabel.Size = new System.Drawing.Size(45, 27);
            this.fourOfAKindLabel.TabIndex = 15;
            this.fourOfAKindLabel.Text = "---";
            this.fourOfAKindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fourOfAKindLabel.Click += new System.EventHandler(this.fourKindBGLabel_Click);
            this.fourOfAKindLabel.MouseEnter += new System.EventHandler(this.fourKindBGLabel_MouseEnter);
            this.fourOfAKindLabel.MouseLeave += new System.EventHandler(this.fourKindBGLabel_MouseLeave);
            // 
            // threesLabel
            // 
            this.threesLabel.Location = new System.Drawing.Point(151, 74);
            this.threesLabel.Name = "threesLabel";
            this.threesLabel.Size = new System.Drawing.Size(45, 27);
            this.threesLabel.TabIndex = 5;
            this.threesLabel.Text = "---";
            this.threesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.threesLabel.Click += new System.EventHandler(this.threesBGLabel_Click);
            this.threesLabel.MouseEnter += new System.EventHandler(this.threesBGLabel_MouseEnter);
            this.threesLabel.MouseLeave += new System.EventHandler(this.threesBGLabel_MouseLeave);
            // 
            // foursLabel
            // 
            this.foursLabel.Location = new System.Drawing.Point(151, 109);
            this.foursLabel.Name = "foursLabel";
            this.foursLabel.Size = new System.Drawing.Size(45, 27);
            this.foursLabel.TabIndex = 7;
            this.foursLabel.Text = "---";
            this.foursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.foursLabel.Click += new System.EventHandler(this.foursBGLabel_Click);
            this.foursLabel.MouseEnter += new System.EventHandler(this.foursBGLabel_MouseEnter);
            this.foursLabel.MouseLeave += new System.EventHandler(this.foursBGLabel_MouseLeave);
            // 
            // fivesLabel
            // 
            this.fivesLabel.Location = new System.Drawing.Point(151, 144);
            this.fivesLabel.Name = "fivesLabel";
            this.fivesLabel.Size = new System.Drawing.Size(45, 27);
            this.fivesLabel.TabIndex = 9;
            this.fivesLabel.Text = "---";
            this.fivesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fivesLabel.Click += new System.EventHandler(this.fivesBGLabel_Click);
            this.fivesLabel.MouseEnter += new System.EventHandler(this.fivesBGLabel_MouseEnter);
            this.fivesLabel.MouseLeave += new System.EventHandler(this.fivesBGLabel_MouseLeave);
            // 
            // acesBGLabel
            // 
            this.acesBGLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.acesBGLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acesBGLabel.Location = new System.Drawing.Point(4, 4);
            this.acesBGLabel.Name = "acesBGLabel";
            this.acesBGLabel.Size = new System.Drawing.Size(190, 28);
            this.acesBGLabel.TabIndex = 0;
            this.acesBGLabel.Text = "Aces:";
            this.acesBGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acesBGLabel.Click += new System.EventHandler(this.acesBGLabel_Click);
            this.acesBGLabel.MouseEnter += new System.EventHandler(this.acesBGLabel_MouseEnter);
            this.acesBGLabel.MouseLeave += new System.EventHandler(this.acesBGLabel_MouseLeave);
            // 
            // fourKindBGLabel
            // 
            this.fourKindBGLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.fourKindBGLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fourKindBGLabel.Location = new System.Drawing.Point(4, 249);
            this.fourKindBGLabel.Name = "fourKindBGLabel";
            this.fourKindBGLabel.Size = new System.Drawing.Size(191, 28);
            this.fourKindBGLabel.TabIndex = 14;
            this.fourKindBGLabel.Text = "Four of a Kind:";
            this.fourKindBGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fourKindBGLabel.Click += new System.EventHandler(this.fourKindBGLabel_Click);
            this.fourKindBGLabel.MouseEnter += new System.EventHandler(this.fourKindBGLabel_MouseEnter);
            this.fourKindBGLabel.MouseLeave += new System.EventHandler(this.fourKindBGLabel_MouseLeave);
            // 
            // sixesBGLabel
            // 
            this.sixesBGLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.sixesBGLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sixesBGLabel.Location = new System.Drawing.Point(4, 179);
            this.sixesBGLabel.Name = "sixesBGLabel";
            this.sixesBGLabel.Size = new System.Drawing.Size(190, 28);
            this.sixesBGLabel.TabIndex = 10;
            this.sixesBGLabel.Text = "Sixes:";
            this.sixesBGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sixesBGLabel.Click += new System.EventHandler(this.sixesBGLabel_Click);
            this.sixesBGLabel.MouseEnter += new System.EventHandler(this.sixesBGLabel_MouseEnter);
            this.sixesBGLabel.MouseLeave += new System.EventHandler(this.sixesBGLabel_MouseLeave);
            // 
            // fullHouseBGLabel
            // 
            this.fullHouseBGLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.fullHouseBGLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fullHouseBGLabel.Location = new System.Drawing.Point(4, 284);
            this.fullHouseBGLabel.Name = "fullHouseBGLabel";
            this.fullHouseBGLabel.Size = new System.Drawing.Size(190, 28);
            this.fullHouseBGLabel.TabIndex = 16;
            this.fullHouseBGLabel.Text = "Full House:";
            this.fullHouseBGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fullHouseBGLabel.Click += new System.EventHandler(this.fullHouseBGLabel_Click);
            this.fullHouseBGLabel.MouseEnter += new System.EventHandler(this.fullHouseBGLabel_MouseEnter);
            this.fullHouseBGLabel.MouseLeave += new System.EventHandler(this.fullHouseBGLabel_MouseLeave);
            // 
            // fivesBGLabel
            // 
            this.fivesBGLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.fivesBGLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fivesBGLabel.Location = new System.Drawing.Point(4, 144);
            this.fivesBGLabel.Name = "fivesBGLabel";
            this.fivesBGLabel.Size = new System.Drawing.Size(190, 28);
            this.fivesBGLabel.TabIndex = 8;
            this.fivesBGLabel.Text = "Fives:";
            this.fivesBGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fivesBGLabel.Click += new System.EventHandler(this.fivesBGLabel_Click);
            this.fivesBGLabel.MouseEnter += new System.EventHandler(this.fivesBGLabel_MouseEnter);
            this.fivesBGLabel.MouseLeave += new System.EventHandler(this.fivesBGLabel_MouseLeave);
            // 
            // smallStraightBGLabel
            // 
            this.smallStraightBGLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.smallStraightBGLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.smallStraightBGLabel.Location = new System.Drawing.Point(4, 319);
            this.smallStraightBGLabel.Name = "smallStraightBGLabel";
            this.smallStraightBGLabel.Size = new System.Drawing.Size(190, 28);
            this.smallStraightBGLabel.TabIndex = 18;
            this.smallStraightBGLabel.Text = "Small Straight:";
            this.smallStraightBGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.smallStraightBGLabel.Click += new System.EventHandler(this.smallStraightBGLabel_Click);
            this.smallStraightBGLabel.MouseEnter += new System.EventHandler(this.smallStraightBGLabel_MouseEnter);
            this.smallStraightBGLabel.MouseLeave += new System.EventHandler(this.smallStraightBGLabel_MouseLeave);
            // 
            // foursBGLabel
            // 
            this.foursBGLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.foursBGLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foursBGLabel.Location = new System.Drawing.Point(4, 109);
            this.foursBGLabel.Name = "foursBGLabel";
            this.foursBGLabel.Size = new System.Drawing.Size(190, 28);
            this.foursBGLabel.TabIndex = 6;
            this.foursBGLabel.Text = "Fours:";
            this.foursBGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foursBGLabel.Click += new System.EventHandler(this.foursBGLabel_Click);
            this.foursBGLabel.MouseEnter += new System.EventHandler(this.foursBGLabel_MouseEnter);
            this.foursBGLabel.MouseLeave += new System.EventHandler(this.foursBGLabel_MouseLeave);
            // 
            // threesBGLabel
            // 
            this.threesBGLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.threesBGLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.threesBGLabel.Location = new System.Drawing.Point(4, 74);
            this.threesBGLabel.Name = "threesBGLabel";
            this.threesBGLabel.Size = new System.Drawing.Size(190, 30);
            this.threesBGLabel.TabIndex = 4;
            this.threesBGLabel.Text = "Threes:";
            this.threesBGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.threesBGLabel.Click += new System.EventHandler(this.threesBGLabel_Click);
            this.threesBGLabel.MouseEnter += new System.EventHandler(this.threesBGLabel_MouseEnter);
            this.threesBGLabel.MouseLeave += new System.EventHandler(this.threesBGLabel_MouseLeave);
            // 
            // threeKindBGLabel
            // 
            this.threeKindBGLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.threeKindBGLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.threeKindBGLabel.Location = new System.Drawing.Point(4, 214);
            this.threeKindBGLabel.Name = "threeKindBGLabel";
            this.threeKindBGLabel.Size = new System.Drawing.Size(190, 28);
            this.threeKindBGLabel.TabIndex = 12;
            this.threeKindBGLabel.Text = "Three of a Kind:";
            this.threeKindBGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.threeKindBGLabel.Click += new System.EventHandler(this.threeKindBGLabel_Click);
            this.threeKindBGLabel.MouseEnter += new System.EventHandler(this.threeKindBGLabel_MouseEnter);
            this.threeKindBGLabel.MouseLeave += new System.EventHandler(this.threeKindBGLabel_MouseLeave);
            // 
            // twosBGLabel
            // 
            this.twosBGLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.twosBGLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.twosBGLabel.Location = new System.Drawing.Point(4, 39);
            this.twosBGLabel.Name = "twosBGLabel";
            this.twosBGLabel.Size = new System.Drawing.Size(190, 28);
            this.twosBGLabel.TabIndex = 2;
            this.twosBGLabel.Text = "Twos:";
            this.twosBGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.twosBGLabel.Click += new System.EventHandler(this.twosBGLabel_Click);
            this.twosBGLabel.MouseEnter += new System.EventHandler(this.twosBGLabel_MouseEnter);
            this.twosBGLabel.MouseLeave += new System.EventHandler(this.twosBGLabel_MouseLeave);
            // 
            // instructionsButton
            // 
            this.instructionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instructionsButton.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsButton.Location = new System.Drawing.Point(321, 687);
            this.instructionsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.instructionsButton.Name = "instructionsButton";
            this.instructionsButton.Size = new System.Drawing.Size(188, 121);
            this.instructionsButton.TabIndex = 3;
            this.instructionsButton.Text = "How to Play";
            this.toolTip1.SetToolTip(this.instructionsButton, "Instructions for how to play Yahtzee");
            this.instructionsButton.UseVisualStyleBackColor = true;
            // 
            // roundLabel
            // 
            this.roundLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundLabel.Location = new System.Drawing.Point(37, 22);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(764, 41);
            this.roundLabel.TabIndex = 0;
            this.roundLabel.Text = "Click \"Roll\" to Begin";
            this.roundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 544);
            this.listBox1.TabIndex = 1;
            // 
            // dicePictureBox1
            // 
            this.dicePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.dicePictureBox1.Image = global::Yahtzee.Properties.Resources.diceblock1;
            this.dicePictureBox1.Location = new System.Drawing.Point(182, 100);
            this.dicePictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dicePictureBox1.Name = "dicePictureBox1";
            this.dicePictureBox1.Size = new System.Drawing.Size(102, 102);
            this.dicePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dicePictureBox1.TabIndex = 4;
            this.dicePictureBox1.TabStop = false;
            this.dicePictureBox1.Click += new System.EventHandler(this.dicePictureBox1_Click);
            this.dicePictureBox1.MouseEnter += new System.EventHandler(this.dicePictureBox1_MouseEnter);
            this.dicePictureBox1.MouseLeave += new System.EventHandler(this.dicePictureBox1_MouseLeave);
            // 
            // dicePictureBox5
            // 
            this.dicePictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.dicePictureBox5.Image = global::Yahtzee.Properties.Resources.diceblock1;
            this.dicePictureBox5.Location = new System.Drawing.Point(182, 548);
            this.dicePictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dicePictureBox5.Name = "dicePictureBox5";
            this.dicePictureBox5.Size = new System.Drawing.Size(102, 104);
            this.dicePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dicePictureBox5.TabIndex = 8;
            this.dicePictureBox5.TabStop = false;
            this.dicePictureBox5.Click += new System.EventHandler(this.dicePictureBox5_Click);
            this.dicePictureBox5.MouseEnter += new System.EventHandler(this.dicePictureBox5_MouseEnter);
            this.dicePictureBox5.MouseLeave += new System.EventHandler(this.dicePictureBox5_MouseLeave);
            // 
            // dicePictureBox2
            // 
            this.dicePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.dicePictureBox2.Image = global::Yahtzee.Properties.Resources.diceblock1;
            this.dicePictureBox2.Location = new System.Drawing.Point(182, 210);
            this.dicePictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dicePictureBox2.Name = "dicePictureBox2";
            this.dicePictureBox2.Size = new System.Drawing.Size(101, 102);
            this.dicePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dicePictureBox2.TabIndex = 5;
            this.dicePictureBox2.TabStop = false;
            this.dicePictureBox2.Click += new System.EventHandler(this.dicePictureBox2_Click);
            this.dicePictureBox2.MouseEnter += new System.EventHandler(this.dicePictureBox2_MouseEnter);
            this.dicePictureBox2.MouseLeave += new System.EventHandler(this.dicePictureBox2_MouseLeave);
            // 
            // dicePictureBox4
            // 
            this.dicePictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.dicePictureBox4.Image = global::Yahtzee.Properties.Resources.diceblock1;
            this.dicePictureBox4.Location = new System.Drawing.Point(182, 438);
            this.dicePictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dicePictureBox4.Name = "dicePictureBox4";
            this.dicePictureBox4.Size = new System.Drawing.Size(102, 102);
            this.dicePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dicePictureBox4.TabIndex = 7;
            this.dicePictureBox4.TabStop = false;
            this.dicePictureBox4.Click += new System.EventHandler(this.dicePictureBox4_Click);
            this.dicePictureBox4.MouseEnter += new System.EventHandler(this.dicePictureBox4_MouseEnter);
            this.dicePictureBox4.MouseLeave += new System.EventHandler(this.dicePictureBox4_MouseLeave);
            // 
            // dicePictureBox3
            // 
            this.dicePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.dicePictureBox3.Image = global::Yahtzee.Properties.Resources.diceblock1;
            this.dicePictureBox3.Location = new System.Drawing.Point(182, 326);
            this.dicePictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dicePictureBox3.Name = "dicePictureBox3";
            this.dicePictureBox3.Size = new System.Drawing.Size(102, 102);
            this.dicePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dicePictureBox3.TabIndex = 6;
            this.dicePictureBox3.TabStop = false;
            this.dicePictureBox3.Click += new System.EventHandler(this.dicePictureBox3_Click);
            this.dicePictureBox3.MouseEnter += new System.EventHandler(this.dicePictureBox3_MouseEnter);
            this.dicePictureBox3.MouseLeave += new System.EventHandler(this.dicePictureBox3_MouseLeave);
            // 
            // GameForm
            // 
            this.AcceptButton = this.rollButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.CancelButton = this.exitGameButton;
            this.ClientSize = new System.Drawing.Size(838, 831);
            this.ControlBox = false;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dicePictureBox1);
            this.Controls.Add(this.dicePictureBox5);
            this.Controls.Add(this.dicePictureBox2);
            this.Controls.Add(this.dicePictureBox4);
            this.Controls.Add(this.dicePictureBox3);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.instructionsButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exitGameButton);
            this.Controls.Add(this.rollButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yahtzee Game";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button exitGameButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label acesBGLabel;
        private System.Windows.Forms.Button instructionsButton;
        private System.Windows.Forms.PictureBox dicePictureBox3;
        private System.Windows.Forms.PictureBox dicePictureBox2;
        private System.Windows.Forms.PictureBox dicePictureBox4;
        private System.Windows.Forms.PictureBox dicePictureBox1;
        private System.Windows.Forms.PictureBox dicePictureBox5;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label fourKindBGLabel;
        private System.Windows.Forms.Label fullHouseBGLabel;
        private System.Windows.Forms.Label smallStraightBGLabel;
        private System.Windows.Forms.Label threeKindBGLabel;
        private System.Windows.Forms.Label twosBGLabel;
        private System.Windows.Forms.Label threesBGLabel;
        private System.Windows.Forms.Label foursBGLabel;
        private System.Windows.Forms.Label fivesBGLabel;
        private System.Windows.Forms.Label sixesBGLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalBGLabel;
        private System.Windows.Forms.Label acesLabel;
        private System.Windows.Forms.Label twosLabel;
        private System.Windows.Forms.Label chanceLabel;
        private System.Windows.Forms.Label fullHouseLabel;
        private System.Windows.Forms.Label smallStraightLabel;
        private System.Windows.Forms.Label yahtzeeLabel;
        private System.Windows.Forms.Label sixesLabel;
        private System.Windows.Forms.Label threeOfAKindLabel;
        private System.Windows.Forms.Label fourOfAKindLabel;
        private System.Windows.Forms.Label threesLabel;
        private System.Windows.Forms.Label foursLabel;
        private System.Windows.Forms.Label fivesLabel;
        private System.Windows.Forms.Label largeStraightLabel;
        private System.Windows.Forms.Label largeStraightBGLabel;
        private System.Windows.Forms.Label yahtzeeBGLabel;
        private System.Windows.Forms.Label chanceBGLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}