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
      this.lblTitle = new System.Windows.Forms.Label();
      this.tbTitle = new System.Windows.Forms.TextBox();
      this.lblContent = new System.Windows.Forms.Label();
      this.tbContent = new System.Windows.Forms.TextBox();
      this.cbPicture = new System.Windows.Forms.CheckBox();
      this.tbPictureUrl = new System.Windows.Forms.TextBox();
      this.tbVideoUrl = new System.Windows.Forms.TextBox();
      this.cbVideo = new System.Windows.Forms.CheckBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.pnlSeparator = new System.Windows.Forms.Panel();
      this.lbAds = new System.Windows.Forms.ListBox();
      this.lblAds = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Location = new System.Drawing.Point(12, 9);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(57, 20);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "Naslov:";
      // 
      // tbTitle
      // 
      this.tbTitle.Location = new System.Drawing.Point(12, 32);
      this.tbTitle.Name = "tbTitle";
      this.tbTitle.Size = new System.Drawing.Size(224, 27);
      this.tbTitle.TabIndex = 1;
      // 
      // lblContent
      // 
      this.lblContent.AutoSize = true;
      this.lblContent.Location = new System.Drawing.Point(12, 84);
      this.lblContent.Name = "lblContent";
      this.lblContent.Size = new System.Drawing.Size(61, 20);
      this.lblContent.TabIndex = 2;
      this.lblContent.Text = "Sadržaj:";
      // 
      // tbContent
      // 
      this.tbContent.Location = new System.Drawing.Point(12, 107);
      this.tbContent.Multiline = true;
      this.tbContent.Name = "tbContent";
      this.tbContent.Size = new System.Drawing.Size(224, 185);
      this.tbContent.TabIndex = 3;
      // 
      // cbPicture
      // 
      this.cbPicture.AutoSize = true;
      this.cbPicture.Location = new System.Drawing.Point(12, 340);
      this.cbPicture.Name = "cbPicture";
      this.cbPicture.Size = new System.Drawing.Size(122, 24);
      this.cbPicture.TabIndex = 4;
      this.cbPicture.Text = "Slikovni oglas";
      this.cbPicture.UseVisualStyleBackColor = true;
      // 
      // tbPictureUrl
      // 
      this.tbPictureUrl.Location = new System.Drawing.Point(12, 370);
      this.tbPictureUrl.Name = "tbPictureUrl";
      this.tbPictureUrl.Size = new System.Drawing.Size(224, 27);
      this.tbPictureUrl.TabIndex = 5;
      // 
      // tbVideoUrl
      // 
      this.tbVideoUrl.Location = new System.Drawing.Point(12, 469);
      this.tbVideoUrl.Name = "tbVideoUrl";
      this.tbVideoUrl.Size = new System.Drawing.Size(224, 27);
      this.tbVideoUrl.TabIndex = 7;
      // 
      // cbVideo
      // 
      this.cbVideo.AutoSize = true;
      this.cbVideo.Location = new System.Drawing.Point(12, 439);
      this.cbVideo.Name = "cbVideo";
      this.cbVideo.Size = new System.Drawing.Size(110, 24);
      this.cbVideo.TabIndex = 6;
      this.cbVideo.Text = "Video oglas";
      this.cbVideo.UseVisualStyleBackColor = true;
      // 
      // btnAdd
      // 
      this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnAdd.Location = new System.Drawing.Point(12, 544);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(224, 57);
      this.btnAdd.TabIndex = 8;
      this.btnAdd.Text = "Dodaj oglas";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // pnlSeparator
      // 
      this.pnlSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.pnlSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pnlSeparator.Location = new System.Drawing.Point(257, 32);
      this.pnlSeparator.Name = "pnlSeparator";
      this.pnlSeparator.Size = new System.Drawing.Size(11, 569);
      this.pnlSeparator.TabIndex = 9;
      // 
      // lbAds
      // 
      this.lbAds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbAds.FormattingEnabled = true;
      this.lbAds.ItemHeight = 20;
      this.lbAds.Location = new System.Drawing.Point(289, 32);
      this.lbAds.Name = "lbAds";
      this.lbAds.Size = new System.Drawing.Size(373, 564);
      this.lbAds.TabIndex = 10;
      // 
      // lblAds
      // 
      this.lblAds.AutoSize = true;
      this.lblAds.Location = new System.Drawing.Point(289, 9);
      this.lblAds.Name = "lblAds";
      this.lblAds.Size = new System.Drawing.Size(54, 20);
      this.lblAds.TabIndex = 11;
      this.lblAds.Text = "Oglasi:";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(684, 620);
      this.Controls.Add(this.lblAds);
      this.Controls.Add(this.lbAds);
      this.Controls.Add(this.pnlSeparator);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.tbVideoUrl);
      this.Controls.Add(this.cbVideo);
      this.Controls.Add(this.tbPictureUrl);
      this.Controls.Add(this.cbPicture);
      this.Controls.Add(this.tbContent);
      this.Controls.Add(this.lblContent);
      this.Controls.Add(this.tbTitle);
      this.Controls.Add(this.lblTitle);
      this.Name = "FormMain";
      this.Text = "Oglasnik";
      this.ResumeLayout(false);
      this.PerformLayout();

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