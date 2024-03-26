namespace OglasnikApp;
public class Ad {
  public Ad(string title, string content) {
    Title = title;
    Content = content;
  }

  public override string ToString() {
    return string.Format("{0} - {1}", Title, Content);
  }

  public string Title { get; set; }
  public string Content { get; set; }
}

