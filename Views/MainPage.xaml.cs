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
			ClickedCount.Text = "Let's count";
		else
            ClickedCount.Text = $"The count is: {count}";

        SemanticScreenReader.Announce(ClickedCount.Text);
	}

	private void MinusCounterClicked(Object sender, EventArgs e)
	{
		count--;

        if (count == 0)
            ClickedCount.Text = "Let's count";
        else
            ClickedCount.Text = $"The count is: {count}";

        SemanticScreenReader.Announce(ClickedCount.Text);
    }
}
