using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class LoadingScreen : Form
    {
        private int loaBarValue;
        public LoadingScreen()
        {
            //Inittilaise 
            InitializeComponent();


        }
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            loadingbarTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loaBarValue += 1;

            loadingProgressBar.Value = loaBarValue;
            lblLoaProgress.Text      = loaBarValue.ToString() + "%";
            
            if (loaBarValue >= loadingProgressBar.Maximum)
            {
                loadingbarTimer.Stop(); //finish loading
                                            //Show MainMenu screen

                MainMenuScreen mainMenuScreen = new MainMenuScreen();

                mainMenuScreen.Show();

                this.Hide();



            }
            
        }

      
    }
}
