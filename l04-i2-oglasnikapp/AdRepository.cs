using System.Collections.Immutable;

namespace OglasnikApp;
public class AdRepository {
  public AdRepository() {
    ads = new List<Ad>();
  }

  public void NewAd(Ad ad) {
    ads.Add(ad);
  }

  public IImmutableList<Ad> AllAds {
    get => ads.ToImmutableList();
  }

  private readonly List<Ad> ads;
}
