namespace SaveStuff;

public partial class MainPage : ContentPage
{
    

    public MainPage()
    {
        InitializeComponent();
    }


    private void Save_OnClicked(object sender, EventArgs e)
    {
        Preferences.Set("Username", txtUsername.Text); // Stores username. Key = Username , Value = txtUsername.Text
    }

    private void Read_OnClicked(object sender, EventArgs e)
    {
        txtUsername.Text = Preferences.Get("Username", ""); // Retrieves username from preferences
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtUsername.Text = String.Empty;
    }
}