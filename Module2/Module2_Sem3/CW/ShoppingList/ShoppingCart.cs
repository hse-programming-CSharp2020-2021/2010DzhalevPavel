public class ShoppingCart {
    
    private int _itemCount; // количество предметов в корзине
    private double _totalPrice; // цена всех предметов в корзине
    private int _capacity;
    private Item[] _cart;// текущая вместимость корзины

    /// <summary>
    /// Создаёт новый экземпляр корзины с вместимостью в 5 элементов
    /// </summary>
    public ShoppingCart()
    {
        _capacity = 5;
        _itemCount = 0;
        _totalPrice = 0.0;
        _cart = new Item[_capacity];
    }

    /// <summary>
    /// Добавляет предмет в корзину
    /// </summary>
    /// <param name="itemName">Название предмета</param>
    /// <param name="price">Цена предмета</param>
    /// <param name="quantity">Количество предметов</param>
    public void AddToCart(string itemName, double price, int quantity) { }

    /// <summary>
    /// Увеличивает вместимость корзины на 3
    /// </summary>
    private void IncreaseSize(Item[] cart)
    {
        Item[] newCart = new Item[cart.Length+3];
        int count = 0;
        foreach (Item item in cart)
        {
            newCart[count] = item;
            count++;
        }
        _cart = newCart;
    }
    

    /// <summary>
    /// Возвращает предметы в корзине с дополнительной информацией
    /// </summary>
    public override string ToString()
    {
        string contents = "\nShopping Cart\n";

        contents += "\nItem\t\tUnit Price\tQuantity\tTotal\n";

        for (int i = 0; i < _itemCount; i++)
            contents += _cart[i] + "\n";

        contents += $"\nTotal Price: {_totalPrice:C}\n";

        return contents;
    }
}