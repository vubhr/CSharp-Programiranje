namespace OglasnikApp;
public class PictureAd : Ad {
  public PictureAd(string title, string content, string pictureURL) : base(title, content) {
    PictureURL = pictureURL;
  }

  public override string ToString() {
    return string.Format("P: {0} - {1}", base.ToString(), PictureURL);
  }

  public string PictureURL { get; set; }
}

