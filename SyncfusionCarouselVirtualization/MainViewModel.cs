using System.ComponentModel;

namespace SyncfusionCarouselVirtualization;

public class MainViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public List<string> Images { get; set; } = [];

    public void Initialize()
    {
        Images.Add("https://www.vestlisfiske.se/cdn/shop/products/125544428_862999684496992_5561859146186305022_n_180x.jpg");
        Images.Add("https://www.vestlisfiske.se/cdn/shop/products/125551113_662176627792109_2544092497685221070_n_180x.jpg");
        Images.Add("https://www.vestlisfiske.se/cdn/shop/products/125468301_698153097787245_8764399019182476480_n_180x.jpg");
        Images.Add("https://www.vestlisfiske.se/cdn/shop/products/125496914_291134272160070_900723531207916581_n_180x.jpg");
        Images.Add("https://www.vestlisfiske.se/cdn/shop/files/385529468_678623534073851_7169349284788087412_n_180x.jpg");
        Images.Add("https://www.vestlisfiske.se/cdn/shop/files/343723560_987743625728264_6543982852032492315_n_180x.jpg");

        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Images)));
    }

    public void RaisePropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
