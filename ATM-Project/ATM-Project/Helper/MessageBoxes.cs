namespace ATM_Project.Helper;
internal static class MessageBoxes
{
    public static void MissingData()
    {
        MessageBox.Show(
            "Missing Data!!",
            "Warning",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
    }
    public static void InvalidCredentials()
    {
        MessageBox.Show(
            "Invalid Credentials!!",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }
    public static void BalanceCanNotBeNegative()
    {
        MessageBox.Show(
            "Balance Can Not Be Negative!!",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }
}
