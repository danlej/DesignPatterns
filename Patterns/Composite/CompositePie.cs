namespace DesignPatterns.Patterns;

public class CompositePie : Component
{
    private List<Component> Ingredients = new();

    public CompositePie(string _name, decimal _cost = 0) : base(_name, _cost)
    {

    }

    public decimal TotalCost
    {
        get
        {
            decimal _cost = 0;
            foreach (var item in Ingredients)
            {
                if (item.GetType().Name == "CompositePie")
                    _cost += ((CompositePie)item).TotalCost;
                else
                    _cost += item.Cost;
            }
            return _cost;
        }
    }

    public void Add(Component item)
    {
        Ingredients.Add(item);
    }

    public void Remove(Component item)
    {
        Ingredients.Remove(item);
    }
}