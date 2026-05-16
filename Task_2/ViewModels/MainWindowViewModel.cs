using System.Collections.Generic;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Task_2.Models;
namespace Task_2.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public List<Product> Products { get; set; }
    private Product? _selectedProduct;
    
    public ICommand SelectProductCommand { get; }
    public ICommand DeleteCommand { get; }
    public ICommand SaveCommand { get; }

    public MainWindowViewModel()
    {
        Products = new List<Product>
        {
            new Product("Lamp", null, null, null,null),
            new Product("Laptop", "67", "1200", "1000",null),
            new Product("Burger", null, "5", null,"Delicious"),
            new Product("Laptop2", "67", "1200", "1000",null),
            new Product("Laptop3", "67", "1200", "1000",null),
            new Product("Laptop4", "67", "1200", "1000",null),
            new Product("Laptop5", "67", "1200", "1000",null),
            new Product("Laptop6", "67", "1200", "1000",null),
            new Product("Laptop7", "67", "1200", "1000",null),
        };

        SelectedProduct = Products[0];
        
        SelectProductCommand = new RelayCommand<Product>(SelectProduct);
        DeleteCommand = new RelayCommand(Delete);
        SaveCommand = new RelayCommand(Save);
    }
    
    public Product? SelectedProduct
    {
        get => _selectedProduct;
        set
        {
            _selectedProduct = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Articular));
            OnPropertyChanged(nameof(Cost));
            OnPropertyChanged(nameof(Quantity));
            OnPropertyChanged(nameof(Description));
        }
    }

    public string Name
    {
        get => _selectedProduct?.Name ?? "";
        set
        {
            if (_selectedProduct == null)
                return;

            if (_selectedProduct.Name == value)
                return;

            _selectedProduct.Name = value;
            OnPropertyChanged();
        }
    }
    
    public string Articular
    {
        get => _selectedProduct?.Articular ?? "";
        set
        {
            if (_selectedProduct == null)
                return;

            if (_selectedProduct.Articular == value)
                return;

            _selectedProduct.Articular = value;
            OnPropertyChanged();
        }
    }
    
    public string Cost
    {
        get => _selectedProduct?.Cost ?? "";
        set
        {
            if (_selectedProduct == null)
                return;

            if (_selectedProduct.Cost == value)
                return;

            _selectedProduct.Cost = value;
            OnPropertyChanged();
        }
    }
    
    public string Quantity
    {
        get => _selectedProduct?.Quantity ?? "";
        set
        {
            if (_selectedProduct == null)
                return;

            if (_selectedProduct.Quantity == value)
                return;

            _selectedProduct.Quantity = value;
            OnPropertyChanged();
        }
    }
    
    public string Description
    {
        get => _selectedProduct?.Description ?? "";
        set
        {
            if (_selectedProduct == null)
                return;

            if (_selectedProduct.Description == value)
                return;

            _selectedProduct.Description = value;
            OnPropertyChanged();
        }
    }
    
    private void SelectProduct(Product? product)
    {
        if (product == null)
            return;

        SelectedProduct = product;
    }
    
    private void Delete()
    {
        if (_selectedProduct == null)
            return;

        Name = "";
        Articular = "";
        Cost = "";
        Quantity = "";
        Description = "";
    }


    private void Save()
    {
        if (SelectedProduct == null)
            return;
    }
}