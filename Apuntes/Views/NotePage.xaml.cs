namespace Apuntes.Views;

[QueryProperty(nameof(ItemId), nameof(ItemId))]
public partial class NotePage : ContentPage
{
	public NotePage()
	{
		InitializeComponent();
        string appDataPath = FileSystem.AppDataDirectory;
        string randomfileName = $"{Path.GetRandomFileName()}.apuntes.txt";

        LoadNote(Path.Combine(appDataPath, randomfileName));
	}

    private async void Guardar_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Notes note)
        {
            File.WriteAllText(note.FileName, TextEditor.Text);
            await Shell.Current.GoToAsync("..");
        }
    }

    private async void Delete_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Notes note)
        {

            if (File.Exists(note.FileName))
            {
                File.Delete(note.FileName);
            }
            await Shell.Current.GoToAsync("..");
        }
    }

    private void LoadNote(string fileName)
    {
        Models.Notes noteModel = new Models.Notes();
        noteModel.FileName = fileName;
        if (File.Exists(fileName))
        {
            noteModel.Date = File.GetCreationTime(fileName);
            noteModel.Text = File.ReadAllText(fileName);
        }
        BindingContext = noteModel;
    }

    public string ItemId
    {
        set { LoadNote(value); }
    }
}