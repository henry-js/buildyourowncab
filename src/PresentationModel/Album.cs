namespace PresentationModel;

public class Album
{
    public int Id { get; set; }
    public string Artist { get; set; }
    public string Title { get; set; }
    public bool IsClassical { get; set; }
    public string? Composer { get; set; }

    public static List<Album> AlbumDataSet()
    {
        var result = new List<Album>
        {
            new Album { Id = 1, Title = "HQ", Artist = "Roy Harper", IsClassical = false, Composer = null },
            new Album { Id = 2, Title = "The Rough Dancer and Cyclical Night", Artist = "Astor Piazzola", IsClassical = false, Composer = null },
            new Album { Id = 3, Title = "The Black Light", Artist = "Calexico", IsClassical = false, Composer = null },
            new Album { Id = 4, Title = "Symphony No.5", Artist = "Symphony No.5", IsClassical = false, Composer = null }
        };
        return result;
    }

    public bool IsComposerNull() => Composer == null;
}