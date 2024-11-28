namespace SyncfusionCarouselVirtualization
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            var viewModel = new MainViewModel();
            viewModel.Initialize();

            BindingContext = viewModel;
        }


    }

}
