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

namespace _7_4Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void readscore(List<int> scorelist)
        {
            try
            {

                // open the txt file

                StreamReader input = File.OpenText("score.txt");

                while (!input.EndOfStream)
                {
                    scorelist.Add(int.Parse(input.ReadLine()));
                }


                // close the file
                input.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void Displayscore(List<int> scorelist)
        {
            foreach (int score in scorelist)
            {
                ScoresListBox.Items.Add(score);
            }

            // the average method returns the average of the values in the list 


        }

        private double Average(List<int> scorelist)
        {
            int total = 0;
            double average;


            foreach (int score in scorelist)
            {
                total += score;


            }

            average = (double)total / scorelist.Count;

            //return the average 
            return average;
        }

        // another method named above average returns the number of above average scores 

        private int Aboveavg(List<int> scorelist)
        {

            int numabove = 0;       // accumulator 

            // get the avg score

            double avg = Average(scorelist);

            // count the number of above avg scores 

            foreach (int score in scorelist)
            {

                if (score > avg)
                {
                    numabove++;
                }

            }

            // return the number of above avg

            return numabove;
        }

        // now ge the below average number of scores 

        private int Belowavg(List<int> scorelist)
        {
            int numbelow = 0;

            // get the avg score 

            double avg = Average(scorelist);

            foreach (int score in scorelist)
            {
                if (score < avg)
                {
                    numbelow++;
                }

            }

            return numbelow;



        }
            private void ScoresButton_Click(object sender, EventArgs e)
            {
            double avgscore;
            int aboveavg;
            int belowavg;

            //create a list to hold the scores
            List<int> scorelist = new List<int>();

            //read the scores from the file onto the list 
            readscore(scorelist);

            // display the score 
            Displayscore(scorelist);


            // display the avg score 

            avgscore = Average(scorelist);
            AvgLabel.Text = avgscore.ToString("n1");

            // display the above avg score

            aboveavg = Aboveavg(scorelist);
            AboveAvgLabel.Text = aboveavg.ToString();


            // display the below avg score 

            belowavg = Belowavg(scorelist);
            BelowAvgLabel.Text = belowavg.ToString();

            
           

            }
        }
    }

