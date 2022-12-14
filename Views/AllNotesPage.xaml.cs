namespace maui_app.Views;

public partial class AllNotesPage : ContentPage
{
	public AllNotesPage()
	{
		InitializeComponent();

		BindingContext = new Models.AllNotes();
	}

    protected override async void OnAppearing()
    {
        ((Models.AllNotes)BindingContext).LoadNotes();
    }

	private async void AddClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(NotePage));
	}

	private async void notesCollectionSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection.Count != 0)
		{
            // Get the note model
            var note = (Models.Note)e.CurrentSelection[0];
            // Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
            await Shell.Current.GoToAsync($"{nameof(NotePage)}?{nameof(NotePage.ItemId)}={note.Filename}");
            // Unselect the UI
            notesCollection.SelectedItem = null;
        }
	}
}
