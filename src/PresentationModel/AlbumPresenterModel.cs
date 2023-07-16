using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PresentationModel;
public class AlbumPresenterModel : INotifyPropertyChanged
{
    private List<Album> _data;
    private int _selectedAlbumNumber;
    private readonly IAlbumView _albumView;

    public AlbumPresenterModel(IAlbumView albumView)
    {
        _data = Album.AlbumDataSet();
        _selectedAlbumNumber = 0;
        _albumView = albumView;
        _albumView.Load += _albumView_Load;

    }

    private void _albumView_Load(object? sender, EventArgs e)
    {
        _albumView.Data = _data;
    }



    public List<Album> AlbumsData => _data;

    public string Title
    {
        get => SelectedAlbum.Title;
        set
        {
            if (SelectedAlbum.Title != value)
            {
                SelectedAlbum.Title = value;
                fireChanged();
            }
        }
    }
    public string Artist
    {
        get { return SelectedAlbum.Artist; }
        set
        {
            if (SelectedAlbum.Artist != value)
            {
                SelectedAlbum.Artist = value;
                fireChanged();
            }
        }
    }

    public bool IsClassical
    {
        get { return SelectedAlbum.IsClassical; }
        set { SelectedAlbum.IsClassical = value; }
    }

    public string Composer
    {
        get
        {
            return SelectedAlbum.IsComposerNull() ? "" : SelectedAlbum?.Composer;
        }
        set
        {
            if (IsClassical) SelectedAlbum.Composer = value;
        }
    }
    public Album? SelectedAlbum => _data[_selectedAlbumNumber];

    public string FormTitle => $"Album: {Title}";

    public bool IsComposerFieldEnabled => IsClassical;

    private void fireChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }


    public event PropertyChangedEventHandler? PropertyChanged;

}

