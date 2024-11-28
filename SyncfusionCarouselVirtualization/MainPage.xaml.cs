
namespace SyncfusionCarouselVirtualization
{
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel viewModel;
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            viewModel = new MainViewModel();
            viewModel.Initialize();

            BindingContext = viewModel;

            theCarousel.SizeChanged += TheCarousel_SizeChanged;
        }

        private void TheCarousel_SizeChanged(object? sender, EventArgs e)
        {
            theCarousel.ItemHeight = (int)theCarousel.Height;
            theCarousel.ItemWidth = (int)theCarousel.Width;
        }
    }

}
