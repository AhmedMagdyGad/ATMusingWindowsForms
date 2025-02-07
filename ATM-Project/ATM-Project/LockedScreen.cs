namespace ATM_Project;
public partial class LockedScreen:Form
{
    public LockedScreen()
    {
        InitializeComponent();
    }

    private void lbl_CloseApplication_Click(object sender,EventArgs e)
    {
        Application.Exit();
    }
}
