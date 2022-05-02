/*
 * 
 * Yahtzee featuring a stats page
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

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void launchGameButton_Click(object sender, EventArgs e)
        {
            if (FormIsOpen(Application.OpenForms, typeof(StatsForm))
                || FormIsOpen(Application.OpenForms, typeof(GameForm)))
            {
                DialogResult dialog = MessageBox.Show("Error: Another form is already opened. " +
                    "Please close that form and try again.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GameForm game = new GameForm();
                game.Show();
            }
        }

        private void launchStatsButton_Click(object sender, EventArgs e)
        {
            if (FormIsOpen(Application.OpenForms, typeof(StatsForm)) 
                || FormIsOpen(Application.OpenForms, typeof(GameForm)))
            {
                DialogResult dialog = MessageBox.Show("Error: Another form is already opened. " +
                    "Please close that form and try again.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StatsForm stats = new StatsForm();
                stats.Show();
            }   
        }

        /***************************************
            Method FormIsOpen was found online, credit to Code Snippets
            Link: https://codesnippets.fesslersoft.de/check-if-a-form-is-open/#:~:text=To%20Check%20if%20a%20Form%20is%20open%20in,Form%29%20%28%29.Any%20%28Function%28openForm%29%20openForm.%20%5BGetType%5D%20%28%29%20%3D%20formType%29
        ***************************************/
        public static bool FormIsOpen(FormCollection application, Type formType)
        {
            //usage sample: FormIsOpen(Application.OpenForms,typeof(Form2)
            return Application.OpenForms.Cast<Form>().Any(openForm => openForm.GetType() == formType);
        }

        private void quitGameButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", 
                                                Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.Yes == dialog)
                Close();
        }
    }
}
