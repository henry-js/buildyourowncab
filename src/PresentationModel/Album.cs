using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace PresentationModel;

public class Album : INotifyPropertyChanged
{
    private string _title;
    private string _artist;
    private bool _isClassical;
    private string _composer;

    public int Id { get; set; }
    public string Title
    {
        get => _title;
        set
        {
            if (_title != value)
            {
                _title = value;
                fireChanged();
            }
        }
    }
    public string Artist
    {
        get { return _artist; }
        set
        {
            if (_artist != value)
            {
                _artist = value;
                fireChanged();
            }
        }
    }
    public bool IsClassical
    {
        get { return _isClassical; }
        set { _isClassical = value; }
    }
    public string Composer
    {
        get
        {
            return _composer;
        }
        set
        {
            if (_composer != value)
            {
                _composer = value;
                fireChanged();
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void fireChanged([CallerMemberName] string? name = null)
    {
        Debug.WriteLine(this.ToString());
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public static List<Album> AlbumDataSet()
    {
        var result = new List<Album>
        {
            new Album { Id = 1, Title = "HQ", Artist = "Roy Harper", IsClassical = false, Composer = null },
            new Album { Id = 2, Title = "The Rough Dancer and Cyclical Night", Artist = "Astor Piazzola", IsClassical = true, Composer = null },
            new Album { Id = 3, Title = "The Black Light", Artist = "Calexico", IsClassical = false, Composer = null },
            new Album { Id = 4, Title = "Symphony No.5", Artist = "Symphony No.5", IsClassical = true, Composer = null }
        };
        return result;
    }


    public override string ToString()
    {
        return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true});
    }
}