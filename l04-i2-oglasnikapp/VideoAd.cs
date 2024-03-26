namespace OglasnikApp;
public class VideoAd : Ad {
  public VideoAd(string title, string content, string videoURL, int length = 15) : base(title, content) {
    VideoURL = videoURL;
    Length = length;
  }

  public override string ToString() {
    return string.Format("V: {0} - {1}/{2}sec", base.ToString(), VideoURL, Length);
  }

  public string VideoURL { get; set; }
  public int Length { get; set; } // length in seconds
}

