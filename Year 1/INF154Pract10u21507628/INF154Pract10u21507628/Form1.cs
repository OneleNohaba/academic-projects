namespace INF154Pract10u21507628
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Dice rolls array as gobal for easy access
        int[] DiceRolls = new int[10];

        private void btnDiceRoll_Click(object sender, EventArgs e)
        {
            //int rolled for the value that is rolled(generated)
            int rolled;

            //condition to disable the button if the items are at 10
            if (lboRolls.Items.Count == 10)
            {
                btnDiceRoll.Enabled = false;
            }
            else
            {
                //generate and add the random number to list and use it to display corresp. image in the imageList
                Random dice = new Random();
                rolled = dice.Next(1, 7);

                pictureBox1.Image = imageList1.Images[rolled - 1];

                lboRolls.Items.Add(rolled);
            }

        }

        //Define public method that gets the sum of the rolls stored in an array and return a sum integer
        public int SumOfRolls()
        {
            int sum = 0;
            for (int i = 0; i < DiceRolls.Length; i++)
            {
                sum += DiceRolls[i];
            }

            return sum;
        }

        //define a public method that gets the average of all the rolls stored in the DiceRolls array
        public double AverageOfRolls()
        {
            double Average = 0;
            Average = DiceRolls.Average();
            return Average;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //add list items to the gobal array DiceRolls
            for (int i = 0; i < lboRolls.Items.Count; i++)
            {
                DiceRolls[i] = Convert.ToInt32(lboRolls.Items[i]);
            }

            //do this when Average radbtn is checked
            if (radAvg.Checked == true)
            {
                rtbDisplay.AppendText("\nThe avagerage of rolls is: " + Convert.ToString(AverageOfRolls()));
            }

            //do this when sum radbtn is checked
            else if (radSumRolls.Checked == true)
            {
                rtbDisplay.AppendText("\nThe sum of rolls is: " + SumOfRolls());
            }

            //do this when groupRolls radbtn is checked
            else if (radGroupRolls.Checked == true)
            {
                //create string array of word numbers starting from zero to offset the array for referrencing
                string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

                //create a integer counts array to store the counts of each number using the position to respond to the dice number itself.
                int[] counts = new int[6];


                for (int i = 1; i <= counts.Length; i++)
                {
                    int counter = 0;
                    for (int j = 0; j < DiceRolls.Length; j++)
                    {
                        if (DiceRolls[j] == i)
                        {
                            counter++;
                        }
                    }

                    //counts[i-1] because first for loop starts at 1 and the last number is included
                    counts[i - 1] = counter;

                    rtbDisplay.Text += "\nThere were " + numbers[counts[i - 1]] + " " + i + "'s.";
                }
            }
            //do this when NaN radbtn are checked
            else
            {
                MessageBox.Show("Please pick one form of data analysis.");
            }
        }
    }
}