namespace PresentationModel;
public partial class AlbumForm : Form, IAlbumView
{
    private AlbumPresenterModel presenterModel;

    public event EventHandler Save;
    public event EventHandler SelectedAlbumChanged;
    public event EventHandler IsClassicalChanged;

    public AlbumForm()
    {
        InitializeComponent();
        presenterModel = new AlbumPresenterModel(this);
    }

    public string Title { get => this.Text; set => this.Text = value; }
    public string AlbumTitle { get => this.tbTitle.Text; set => tbTitle.Text = value; }
    public string AlbumArtist { get => this.tbArtist.Text; set => tbArtist.Text = value; }
    public string AlbumComposer { get => this.tbComposer.Text; set => tbComposer.Text = value; }
    public bool IsClassical { get => this.cbIsClassical.Checked; set => cbIsClassical.Checked = value; }

    public bool ComposerFieldEnabled { get => tbComposer.Enabled; set => tbComposer.Enabled = value; }

    private void AlbumForm_Load(object sender, EventArgs e)
    {

    }

    public void SetAlbumListBindingSource(BindingSource albumList)
    {
        dataGridView1.DataSource = albumList;

    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        Save?.Invoke(sender, e);
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {

    }

    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
        SelectedAlbumChanged?.Invoke(sender, e);
    }

    private void cbIsClassical_CheckedChanged(object sender, EventArgs e)
    {
        IsClassicalChanged?.Invoke(sender, e);
    }
}
public interface IAlbumView
{
    string Title { get; set; }
    string AlbumTitle { get; set; }
    string AlbumArtist { get; set; }
    string AlbumComposer { get; set; }
    bool IsClassical { get; set; }
    bool ComposerFieldEnabled { get; set; }

    event EventHandler Load;
    event EventHandler Save;
    event EventHandler SelectedAlbumChanged;
    event EventHandler IsClassicalChanged;


    void SetAlbumListBindingSource(BindingSource albumList);
}