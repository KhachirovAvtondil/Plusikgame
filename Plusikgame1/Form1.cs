namespace Plusikgame1
{
    public partial class FormGame : Form
    {
        int TARGET = 15;
        int usernumb = 1;
        int Countstep = 0;
        public FormGame()
        {
            InitializeComponent();
        }
        int Optimum(int k)
        {
            int steps = 0;
            while (k != 1)
            {
                if (k % 2 == 0)
                {
                    k = k / 2;
                }
                else
                {
                    k = k - 1;
                }
                steps++;
            }
            return steps;
        }

        private void pictureBoxPlus_Click(object sender, EventArgs e)
        {
            usernumb++;
            Countstep++;
            labelUserNumber.Text = usernumb.ToString();
            labelSteps.Text = "Количество шагов " + Countstep.ToString();
            if (usernumb == TARGET)
            {
                if (Countstep == Optimum(TARGET))
                    MessageBox.Show("YOU WIN!");
                else
                    MessageBox.Show("YOU WIN BUT COULD HAVE BEEN FASTER");
            }
            else if (usernumb > TARGET)
            {
                MessageBox.Show("YOU LOSE! TRY AGAIN");
            }
        }

        private void pictureBoxMult_Click(object sender, EventArgs e)
        {
            usernumb *= 2;
            Countstep++;
            labelUserNumber.Text = usernumb.ToString();
            labelSteps.Text = "Количество шагов " + Countstep.ToString();
            if (usernumb == TARGET)
            {
                if (Countstep == Optimum(TARGET))
                    MessageBox.Show("YOU WIN!");
                else
                    MessageBox.Show("YOU WIN BUT COULD HAVE BEEN FASTER");
            }
            else if (usernumb > TARGET)
            {
                MessageBox.Show("YOU LOSE! TRY AGAIN");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Countstep = 0;
            labelSteps.Text = "Количество шагов " + Countstep.ToString();
            usernumb = 1;
            labelUserNumber.Text = usernumb.ToString();
        }

        private void buttonRandomNum_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            TARGET = number.Next(1, 100);
            labelTarget.Text = TARGET.ToString();
            Optimum(TARGET);
        }

        private void buttonSetNum_Click(object sender, EventArgs e)
        {
            TARGET = Convert.ToInt32(textBoxMyNumb.Text);
            labelTarget.Text = TARGET.ToString();
            Optimum(TARGET);
        }
    }
}
