namespace Catalog.ValueObjects;

public enum Categories 
{
    Normal = 0,
    Rare = 1,
    Legendary = 2
}

public class Category 
{
    public Categories myCategory;

    public Category(int category)
    {
        myCategory = (Categories)category;
    }

    public string Get()
    {
        return myCategory.ToString();
    }
}