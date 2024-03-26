namespace OglasnikApp {
  partial class FormMain {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      lblTitle = new Label();
      tbTitle = new TextBox();
      lblContent = new Label();
      tbContent = new TextBox();
      cbPicture = new CheckBox();
      tbPictureUrl = new TextBox();
      tbVideoUrl = new TextBox();
      cbVideo = new CheckBox();
      btnAdd = new Button();
      pnlSeparator = new Panel();
      lbAds = new ListBox();
      lblAds = new Label();
      SuspendLayout();
      // 
      // lblTitle
      // 
      lblTitle.AutoSize = true;
      lblTitle.Location = new Point(10, 7);
      lblTitle.Name = "lblTitle";
      lblTitle.Size = new Size(46, 15);
      lblTitle.TabIndex = 0;
      lblTitle.Text = "Naslov:";
      // 
      // tbTitle
      // 
      tbTitle.Location = new Point(10, 24);
      tbTitle.Margin = new Padding(3, 2, 3, 2);
      tbTitle.Name = "tbTitle";
      tbTitle.Size = new Size(196, 23);
      tbTitle.TabIndex = 1;
      // 
      // lblContent
      // 
      lblContent.AutoSize = true;
      lblContent.Location = new Point(10, 63);
      lblContent.Name = "lblContent";
      lblContent.Size = new Size(47, 15);
      lblContent.TabIndex = 2;
      lblContent.Text = "Sadržaj:";
      // 
      // tbContent
      // 
      tbContent.Location = new Point(10, 80);
      tbContent.Margin = new Padding(3, 2, 3, 2);
      tbContent.Multiline = true;
      tbContent.Name = "tbContent";
      tbContent.Size = new Size(196, 140);
      tbContent.TabIndex = 3;
      // 
      // cbPicture
      // 
      cbPicture.AutoSize = true;
      cbPicture.Location = new Point(10, 255);
      cbPicture.Margin = new Padding(3, 2, 3, 2);
      cbPicture.Name = "cbPicture";
      cbPicture.Size = new Size(98, 19);
      cbPicture.TabIndex = 4;
      cbPicture.Text = "Slikovni oglas";
      cbPicture.UseVisualStyleBackColor = true;
      // 
      // tbPictureUrl
      // 
      tbPictureUrl.Location = new Point(10, 278);
      tbPictureUrl.Margin = new Padding(3, 2, 3, 2);
      tbPictureUrl.Name = "tbPictureUrl";
      tbPictureUrl.Size = new Size(196, 23);
      tbPictureUrl.TabIndex = 5;
      // 
      // tbVideoUrl
      // 
      tbVideoUrl.Location = new Point(10, 352);
      tbVideoUrl.Margin = new Padding(3, 2, 3, 2);
      tbVideoUrl.Name = "tbVideoUrl";
      tbVideoUrl.Size = new Size(196, 23);
      tbVideoUrl.TabIndex = 7;
      // 
      // cbVideo
      // 
      cbVideo.AutoSize = true;
      cbVideo.Location = new Point(10, 329);
      cbVideo.Margin = new Padding(3, 2, 3, 2);
      cbVideo.Name = "cbVideo";
      cbVideo.Size = new Size(87, 19);
      cbVideo.TabIndex = 6;
      cbVideo.Text = "Video oglas";
      cbVideo.UseVisualStyleBackColor = true;
      // 
      // btnAdd
      // 
      btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      btnAdd.Location = new Point(10, 408);
      btnAdd.Margin = new Padding(3, 2, 3, 2);
      btnAdd.Name = "btnAdd";
      btnAdd.Size = new Size(196, 43);
      btnAdd.TabIndex = 8;
      btnAdd.Text = "Dodaj oglas";
      btnAdd.UseVisualStyleBackColor = true;
      btnAdd.Click += btnAdd_Click;
      // 
      // pnlSeparator
      // 
      pnlSeparator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      pnlSeparator.BorderStyle = BorderStyle.Fixed3D;
      pnlSeparator.Location = new Point(225, 24);
      pnlSeparator.Margin = new Padding(3, 2, 3, 2);
      pnlSeparator.Name = "pnlSeparator";
      pnlSeparator.Size = new Size(10, 428);
      pnlSeparator.TabIndex = 9;
      // 
      // lbAds
      // 
      lbAds.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      lbAds.FormattingEnabled = true;
      lbAds.ItemHeight = 15;
      lbAds.Location = new Point(253, 24);
      lbAds.Margin = new Padding(3, 2, 3, 2);
      lbAds.Name = "lbAds";
      lbAds.Size = new Size(327, 424);
      lbAds.TabIndex = 10;
      lbAds.Click += lbAds_Click;
      // 
      // lblAds
      // 
      lblAds.AutoSize = true;
      lblAds.Location = new Point(253, 7);
      lblAds.Name = "lblAds";
      lblAds.Size = new Size(43, 15);
      lblAds.TabIndex = 11;
      lblAds.Text = "Oglasi:";
      // 
      // FormMain
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(598, 465);
      Controls.Add(lblAds);
      Controls.Add(lbAds);
      Controls.Add(pnlSeparator);
      Controls.Add(btnAdd);
      Controls.Add(tbVideoUrl);
      Controls.Add(cbVideo);
      Controls.Add(tbPictureUrl);
      Controls.Add(cbPicture);
      Controls.Add(tbContent);
      Controls.Add(lblContent);
      Controls.Add(tbTitle);
      Controls.Add(lblTitle);
      Margin = new Padding(3, 2, 3, 2);
      Name = "FormMain";
      Text = "Oglasnik";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lblTitle;
    private TextBox tbTitle;
    private Label lblContent;
    private TextBox tbContent;
    private CheckBox cbPicture;
    private TextBox tbPictureUrl;
    private TextBox tbVideoUrl;
    private CheckBox cbVideo;
    private Button btnAdd;
    private Panel pnlSeparator;
    private ListBox lbAds;
    private Label lblAds;
  }
}