namespace PresentationModel;

partial class AlbumForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lTitle = new System.Windows.Forms.Label();
            this.lArtist = new System.Windows.Forms.Label();
            this.lComposer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbIsClassical = new System.Windows.Forms.CheckBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.tbComposer = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Location = new System.Drawing.Point(35, 32);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(32, 15);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Title:";
            // 
            // lArtist
            // 
            this.lArtist.AutoSize = true;
            this.lArtist.Location = new System.Drawing.Point(29, 78);
            this.lArtist.Name = "lArtist";
            this.lArtist.Size = new System.Drawing.Size(38, 15);
            this.lArtist.TabIndex = 2;
            this.lArtist.Text = "Artist:";
            // 
            // lComposer
            // 
            this.lComposer.AutoSize = true;
            this.lComposer.Location = new System.Drawing.Point(2, 170);
            this.lComposer.Name = "lComposer";
            this.lComposer.Size = new System.Drawing.Size(65, 15);
            this.lComposer.TabIndex = 4;
            this.lComposer.Text = "Composer:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cbIsClassical);
            this.groupBox1.Controls.Add(this.tbArtist);
            this.groupBox1.Controls.Add(this.tbComposer);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Controls.Add(this.lComposer);
            this.groupBox1.Controls.Add(this.lTitle);
            this.groupBox1.Controls.Add(this.lArtist);
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 192);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(275, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(275, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbIsClassical
            // 
            this.cbIsClassical.AutoSize = true;
            this.cbIsClassical.Location = new System.Drawing.Point(82, 125);
            this.cbIsClassical.Name = "cbIsClassical";
            this.cbIsClassical.Size = new System.Drawing.Size(82, 19);
            this.cbIsClassical.TabIndex = 8;
            this.cbIsClassical.Text = "Is Classical";
            this.cbIsClassical.UseVisualStyleBackColor = true;
            this.cbIsClassical.CheckedChanged += new System.EventHandler(this.cbIsClassical_CheckedChanged);
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(73, 75);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(100, 23);
            this.tbArtist.TabIndex = 7;
            // 
            // tbComposer
            // 
            this.tbComposer.Location = new System.Drawing.Point(73, 167);
            this.tbComposer.Name = "tbComposer";
            this.tbComposer.Size = new System.Drawing.Size(100, 23);
            this.tbComposer.TabIndex = 6;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(73, 29);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 23);
            this.tbTitle.TabIndex = 5;
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AlbumForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AlbumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion
    private DataGridView dataGridView1;
    private Label lTitle;
    private Label lArtist;
    private Label lComposer;
    private GroupBox groupBox1;
    private CheckBox cbIsClassical;
    private TextBox tbArtist;
    private TextBox tbComposer;
    private TextBox tbTitle;
    private Button btnCancel;
    private Button btnSave;
}