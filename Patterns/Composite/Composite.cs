namespace DesignPatterns.Patterns.Composite;

public class Composite : Component
{
    private List<Component> Ingredients = [];

    public Composite(string _name, decimal _cost = 0) : base(_name, _cost)
    {

    }

    public decimal TotalCost
    {
        get
        {
            decimal _cost = 0;
            foreach (var item in Ingredients)
            {
                if (item.GetType().Name == "Composite")
                    _cost += ((Composite)item).TotalCost;
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