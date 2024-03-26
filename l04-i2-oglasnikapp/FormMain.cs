namespace OglasnikApp;

public partial class FormMain : Form {
  private AdRepository adRepository;
  public FormMain() {
    InitializeComponent();
    adRepository = new AdRepository();
  }

  private void btnAdd_Click(object sender, EventArgs e) {
    if (cbPicture.Checked && cbVideo.Checked) {
      MessageBox.Show("Nije moguæe oznaèiti i slikovni i video oglas", "Greška",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
    } else if (cbPicture.Checked) {
      adRepository.NewAd(new PictureAd(tbTitle.Text, tbContent.Text, tbPictureUrl.Text));
    } else if (cbVideo.Checked) {
      adRepository.NewAd(new VideoAd(tbTitle.Text, tbContent.Text, tbVideoUrl.Text));
    } else {
      adRepository.NewAd(new Ad(tbTitle.Text, tbContent.Text));
    }
    RefreshAdsList();
  }

  private void RefreshAdsList() {
    // clear all items already added
    lbAds.Items.Clear();

    // foreach (Ad ad in adRepository.AllAds)
    foreach (var ad in adRepository.AllAds) {
      lbAds.Items.Add(ad);
    }

    // lbAds.Items.AddRange(adRepository.AllAds.ToArray());
  }

  private void lbAds_Click(object sender, EventArgs e) {
    Ad ad = (Ad) lbAds.SelectedItem;
    if (ad != null) {
      MessageBox.Show(string.Format("Odabrali ste oglas: {0}", ad.ToString()));
    }
  }
}