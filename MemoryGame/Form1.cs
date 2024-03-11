using System.Globalization;


namespace MemoryGame
{
    public partial class GameScreen : Form
    {

        List<int> nums = new List<int> { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9 };
        string firstPick;
        string secondPick;
        int p1Score = 0;
        int p2Score = 0;
        List<PictureBox> pics = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        int pickTime = 5;
        int picShowTime = 5;
        bool gameOver = false;
        int currentPlayer = 2;

        public GameScreen()
        {
            InitializeComponent();
            LoadPics();
        }

        private void TimerEvent(object sender, EventArgs e)
        {

            if (firstPick != null)
            {
                pickTime--;
            }

            picShowTime--;


            if (picShowTime > 0)
            {
                foreach (PictureBox i in pics)
                {

                    if (i.Tag != null)
                    {
                        i.Image = Image.FromFile("imgs/" + (string)i.Tag + ".png");
                    }

                }
            }

            if (picShowTime == 0)
            {
                foreach (PictureBox i in pics)
                {

                    if (i.Tag != null)
                    {
                        i.Image = null;
                    }

                }
            }


            LabelTimer.Text = "Time Left: " + pickTime;

            //Makes pic blank

            if (pickTime < 0)
            {
                picA.Image = null;
                if(picB.Image != null)
                {
                    picB.Image = null;
                }
                currentPlayer++;
                pickTime = 5;
            }

        }



        private void RestartGameEvent(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void LoadPics()
        {
            int leftPos = 250;
            int topPos = 150;
            int row = 0;

            for (int i = 0; i < 20; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 60;
                newPic.Width = 60;
                newPic.BackColor = Color.Gray;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPicClick;
                pics.Add(newPic);

                if (row < 5)
                {
                    row++;
                    newPic.Left = leftPos;
                    newPic.Top = topPos;
                    this.Controls.Add(newPic);
                    leftPos += 80;

                }

                if (row == 5)
                {
                    leftPos = 250;
                    topPos += 80;
                    row = 0;
                }
            }

            RestartGame();

        }

        private void NewPicClick(object? sender, EventArgs e)
        {

            CheckCurrentPlayer();

            if (gameOver)
            {
                return;
            }

            if (firstPick == null)
            {

                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    picA.Image = Image.FromFile("imgs/" + (string)picA.Tag + ".png");
                    firstPick = (string)picA.Tag;
                }
            }
            else if (secondPick == null)
            {
                picB = sender as PictureBox;

                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = Image.FromFile("imgs/" + (string)picB.Tag + ".png");
                    secondPick = (string)picB.Tag;

                }
            }
            else
            {

                CheckPics(picA, picB);

            }

        }

        private void RestartGame()
        {

            var randomList = nums.OrderBy(x => Guid.NewGuid()).ToList();
            nums = randomList;

            for (int i = 0; i < pics.Count; i++)
            {

                pics[i].Image = null;
                pics[i].Tag = nums[i].ToString();
            }

            int p1Score = 0;
            LabelScoreP1.Text = "Score: " + p1Score;

            int p2Score = 0;
            LabelScoreP2.Text = "Score: " + p2Score;

            gameOver = false;

            picShowTime = 5;

            TimerGame.Start();

        }

        private void CheckCurrentPlayer()
        {

            if (currentPlayer % 2 == 0)

            {
                LabelP1Turn.ForeColor = Color.Red;
                LabelP2Turn.ForeColor = Color.White;

            }

            if (currentPlayer % 2 != 0)

            {
                LabelP1Turn.ForeColor = Color.White;
                LabelP2Turn.ForeColor = Color.Blue;

            }
        }

        private void AddScore()
        {
            if (currentPlayer % 2 == 0)

            {

                p1Score++;
                LabelScoreP1.Text = "Score: " + p1Score;
            }

            if (currentPlayer % 2 != 0)

            {

                p2Score++;
                LabelScoreP2.Text = "Score: " + p2Score;
            }
        }

        private void CheckPics(PictureBox A, PictureBox B)
        {


            //if(firstPick != null && pickTime < 0)
            //{

            //    A.Image = null;
            //    pickTime = 5;

            //}

            if (firstPick == secondPick)
            {
                A.Tag = null;
                B.Tag = null;
                AddScore();
                pickTime = 5;

            }


            firstPick = null;
            secondPick = null;



            foreach (PictureBox pic in pics.ToList())
            {

                if (pic.Tag != null)
                {
                    pic.Image = null;
                }

            }

            if (pics.All(i => i.Tag == pics[0].Tag))
            {
                if (p1Score > p2Score)
                {
                    GameOver("Player1 won!!");
                }
                if (p2Score > p1Score)
                {
                    GameOver("Player2 won!!");
                }
            }

        }

        private void GameOver(string msg)
        {
            TimerGame.Stop();
            gameOver = true;
            MessageBox.Show(msg);
        }


    }
}