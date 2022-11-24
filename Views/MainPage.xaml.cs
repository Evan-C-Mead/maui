namespace maui_app.Views;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void PlusCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 0)
			ClickedCount.Text = "Up, up, up!";
		else
            ClickedCount.Text = $"The count is: {count}";

        SemanticScreenReader.Announce(ClickedCount.Text);
	}

	private void MinusCounterClicked(Object sender, EventArgs e)
	{
		count--;

        if (count == 0)
            ClickedCount.Text = "Going down?";
        else
            ClickedCount.Text = $"The count is: {count}";

        SemanticScreenReader.Announce(ClickedCount.Text);
    }
}
