using CassavaRoots.Models;

namespace CassavaRoots.ViewModels
{
    [INotifyPropertyChanged]
    public partial class HomeViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<Product> _products;

        public string[] Categories { get; set; }

        [ObservableProperty]
        public string _categorySelectedValue;


        public ICommand FlyoutCommand { get; set; }

        partial void OnCategorySelectedValueChanged(string value)
        {
            Debug.WriteLine(value);
        }
        public HomeViewModel()
        {
            DetailCommand = new Command(OnDetailCommand);
            FlyoutCommand = new Command(OnFlyoutCommand);
        }

        private async void OnFlyoutCommand(object obj)
        {
            Shell.Current.FlyoutIsPresented = !Shell.Current.FlyoutIsPresented;
        }

        public ICommand DetailCommand { get; }
        private async void OnDetailCommand(object obj)
        {
            Debug.WriteLine(obj);
            await Shell.Current.GoToAsync($"detail", new Dictionary<string, object> { ["SelectedProduct"] = (Product)obj });
        }

        public override Task Initialize()
        {
            CategorySelectedValue = "All";
            Categories = Enum.GetNames(typeof(CoffeCategory)).Cast<string>().Select(x => x.ToString()).ToArray();
            Products = new ObservableCollection<Product>(ProductService.Instance.GetProducts());
            return Task.CompletedTask;
        }

        public override Task Stop()
        {
            return Task.CompletedTask;
        }
        [RelayCommand]
        async Task ProductSelected(Product product)
        {
            await Shell.Current.GoToAsync($"detail?", new Dictionary<string, object> { ["SelectedProduct"] = product });
        }
    }
}
