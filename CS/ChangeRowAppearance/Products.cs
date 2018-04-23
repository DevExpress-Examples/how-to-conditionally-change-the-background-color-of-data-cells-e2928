using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

public class Product : INotifyPropertyChanged {
    private string fProductName;
    public string ProductName {
        get { return fProductName; }
        set {
            fProductName = value;
            OnChanged("ProductName");
        }
    }

    private double fUnitPrice;
    public double UnitPrice {
        get { return fUnitPrice; }
        set {
            fUnitPrice = value;
            OnChanged("UnitPrice");
        }
    }

    private int fQuantity;
    public int Quantity {
        get { return fQuantity; }
        set {
            fQuantity = value;
            OnChanged("Quantity");
        }
    }

    private void OnChanged(string p) {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(p));
    }

    #region INotifyPropertyChanged Members

    public event PropertyChangedEventHandler PropertyChanged;

    #endregion
}

public class ProductList : ObservableCollection<Product> {
    public ProductList()
        : base() {
        Add(new Product() { ProductName = "Chang", UnitPrice = 19, Quantity = 5 });
        Add(new Product() { ProductName = "Gravad lax", UnitPrice = 12.5, Quantity = 16 });
        Add(new Product() { ProductName = "Ravioli Angelo", UnitPrice = 19, Quantity = 12 });
        Add(new Product() { ProductName = "Tarte au sucre", UnitPrice = 22, Quantity = 150 });
        Add(new Product() { ProductName = "Steeleye Stout", UnitPrice = 18, Quantity = 20 });
        Add(new Product() { ProductName = "Pavlova", UnitPrice = 21, Quantity = 52 });
        Add(new Product() { ProductName = "Longlife Tofu", UnitPrice = 7.75, Quantity = 120 });
        Add(new Product() { ProductName = "Alice Mutton", UnitPrice = 21, Quantity = 4 });
        Add(new Product() { ProductName = "Alice Mutton", UnitPrice = 44, Quantity = 16 });
    }
}
