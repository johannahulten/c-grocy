namespace CGrocy;

public interface GrocyAPI
{
    GenericEntityInteractions GenericEntityInteractions { get; }

    System System { get; }

    UserManagement UserManagement { get; }

    CurrentUser CurrentUser { get; }

    Stock Stock { get; }

    StockByBarcode StockByBarcode { get; }

    Recipes Recipes { get; }

    Chores Chores { get; }

    Batteries Batteries { get; }

    Tasks Tasks { get; }

    Calendar Calendar { get; }

    Files Files { get; }

    Print Print { get; }
}