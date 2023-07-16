using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationModel;
public partial class AlbumForm : Form, IAlbumView
{
    private AlbumPresenterModel presenterModel;

    public AlbumForm()
    {
        InitializeComponent();
        presenterModel = new AlbumPresenterModel(this);
    }

    public string Title { get => this.Text; set => this.Text = value; }
    public List<Album> Data
    {
        get => bindingSource1.DataSource as List<Album>;
        set
        {
            bindingSource1.DataSource = value;
            dataGridView1.DataSource = bindingSource1;
        }
    }

    private void AlbumForm_Load(object sender, EventArgs e)
    {

    }
}
public interface IAlbumView
{
    string Title { get; set; }
    List<Album> Data { get; set; }

    event EventHandler Load;

    //void LoadFromPresenter();
}