namespace MauiScrollViewIssue;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void btnScrollIssue(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ScrollIssuePage());
    }

    private void btnScrollWorking(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ScrollWorkingPage());
    }
}

