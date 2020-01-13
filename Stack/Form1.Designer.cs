namespace Stack
{
  partial class Form1
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
            this.HTMLOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusLabel = new System.Windows.Forms.Label();
            this.tagsListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.processMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.processCheckTagsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HTMLOpenFileDialog
            // 
            this.HTMLOpenFileDialog.FileName = "openFileDialog1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 35);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 24);
            this.statusLabel.TabIndex = 0;
            // 
            // tagsListBox
            // 
            this.tagsListBox.FormattingEnabled = true;
            this.tagsListBox.ItemHeight = 24;
            this.tagsListBox.Location = new System.Drawing.Point(12, 99);
            this.tagsListBox.Name = "tagsListBox";
            this.tagsListBox.Size = new System.Drawing.Size(497, 364);
            this.tagsListBox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.processMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpenMenu,
            this.fileExitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // fileOpenMenu
            // 
            this.fileOpenMenu.Name = "fileOpenMenu";
            this.fileOpenMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.fileOpenMenu.Size = new System.Drawing.Size(180, 22);
            this.fileOpenMenu.Text = "&Open File";
            this.fileOpenMenu.Click += new System.EventHandler(this.fileOpenMenu_Click);
            // 
            // fileExitMenu
            // 
            this.fileExitMenu.Name = "fileExitMenu";
            this.fileExitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.fileExitMenu.Size = new System.Drawing.Size(180, 22);
            this.fileExitMenu.Text = "E&xit";
            this.fileExitMenu.Click += new System.EventHandler(this.fileExitMenu_Click);
            // 
            // processMenu
            // 
            this.processMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processCheckTagsMenu});
            this.processMenu.Name = "processMenu";
            this.processMenu.Size = new System.Drawing.Size(80, 20);
            this.processMenu.Text = "&Process File";
            // 
            // processCheckTagsMenu
            // 
            this.processCheckTagsMenu.Name = "processCheckTagsMenu";
            this.processCheckTagsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.processCheckTagsMenu.Size = new System.Drawing.Size(180, 22);
            this.processCheckTagsMenu.Text = "&Check Tags";
            this.processCheckTagsMenu.Click += new System.EventHandler(this.processCheckTagsMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 482);
            this.Controls.Add(this.tagsListBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "HTML Tag Checker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog HTMLOpenFileDialog;
    private System.Windows.Forms.Label statusLabel;
    private System.Windows.Forms.ListBox tagsListBox;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileMenu;
    private System.Windows.Forms.ToolStripMenuItem fileOpenMenu;
    private System.Windows.Forms.ToolStripMenuItem fileExitMenu;
    private System.Windows.Forms.ToolStripMenuItem processMenu;
    private System.Windows.Forms.ToolStripMenuItem processCheckTagsMenu;
  }
}

