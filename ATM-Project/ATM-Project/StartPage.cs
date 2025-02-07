namespace ATM_Project
{
    public partial class StartPage:Form
    {
        public StartPage()
        {
            InitializeComponent();
        }
        int starting = 0;
        private void timer1_Tick(object sender,EventArgs e)
        {
            starting += 5;
            MyProgress.Value = starting;
            lbl_ProgressBar.Text = $"{starting}%";
            if(MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                ChooseCardOrWallets chooseCardOrWallets = new ChooseCardOrWallets();
                this.Hide();
                chooseCardOrWallets.Show();
            }
        }

        private void StartPage_Load(object sender,EventArgs e)
        {
            timer1.Start();
        }
    }
}
