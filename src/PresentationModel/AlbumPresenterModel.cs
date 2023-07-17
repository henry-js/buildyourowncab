using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PresentationModel;
public class AlbumPresenterModel
{
    private List<Album> _data;
    private Album? _currentAlbum;
    private BindingSource _albumBindingSource;
    //private int _selectedAlbumNumber;
    private readonly IAlbumView _albumView;

    public AlbumPresenterModel(IAlbumView albumView)
    {
        _albumBindingSource = new BindingSource();
        _data = Album.AlbumDataSet();
        //_selectedAlbumNumber = 0;
        _albumView = albumView;
        _albumView.Load += _albumView_Load;
        _albumView.Save += _albumView_Save;
        _albumView.IsClassicalChanged += _albumView_IsClassicalChanged;
        _albumView.SelectedAlbumChanged += _albumView_SelectionChanged;
        _albumBindingSource.CurrentChanged += _albumBindingSource_CurrentChanged;
    }

    private void _albumView_IsClassicalChanged(object? sender, EventArgs e)
    {
        _albumView.ComposerFieldEnabled = _albumView.IsClassical;
        SelectedAlbum.IsClassical = _albumView.IsClassical;
        Debug.WriteLine(SelectedAlbum);
    }

    private void _albumView_SelectionChanged(object? sender, EventArgs e)
    {
        _albumView.AlbumTitle = SelectedAlbum.Title;
        _albumView.AlbumArtist = SelectedAlbum.Artist;
        _albumView.AlbumComposer = SelectedAlbum.Composer;
        _albumView.IsClassical = SelectedAlbum.IsClassical;
        _albumView.ComposerFieldEnabled = SelectedAlbum.IsClassical;
        Debug.WriteLine(SelectedAlbum.ToString());

    }

    private void _albumView_Save(object? sender, EventArgs e)
    {
        Debug.WriteLine(SelectedAlbum.ToString());
    }

    private void _albumBindingSource_CurrentChanged(object? sender, EventArgs e)
    {
        Debug.WriteLine(SelectedAlbum.ToString());
    }

    private void _albumView_Load(object? sender, EventArgs e)
    {
        _albumBindingSource.DataSource = _data;
        _albumView.SetAlbumListBindingSource(_albumBindingSource);
        _albumView.Title = FormTitle;
    }


    public Album? SelectedAlbum => _albumBindingSource.Current as Album;

    public string FormTitle => $"Albums";
    public bool IsComposerFieldEnabled => _currentAlbum?.IsClassical ?? false;





}

