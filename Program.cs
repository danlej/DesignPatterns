using DesignPatterns.Patterns;

// 1. Singleton
// Console.WriteLine(Singleton.Instance.message);
// Singleton.Instance.message = "Hello Mars!";
// Console.WriteLine(Singleton.Instance.message);

// 2. Prototype
Prototype oveja = new()
{
    Nombre = "Dolly",
    Patas = 4,
    Rasgos = new() { Color = "Blanca", Raza = "Oveja" }
};

Prototype? perro = oveja.Clone() as Prototype;
if (perro != null && perro.Rasgos != null)
{
    perro.Rasgos.Color = "Negro";
    perro.Rasgos.Raza = "Perro";
    perro.Nombre = "Tommy";
}

Console.WriteLine($"La {oveja.Rasgos.Raza} {oveja.Nombre} es de color {oveja.Rasgos.Color}");
Console.WriteLine($"El {perro?.Rasgos?.Raza} {perro?.Nombre} es de color {perro?.Rasgos?.Color}");

// 3. Factory
/* Shape? shape = ShapeFactory.Create(ShapeFactory.SQUARE);
if (shape != null) Console.WriteLine(shape.GetSides()); */

// 4.a Strategy
/* StrategySortingContext sortable = new StrategySortingContext();
sortable.Sort();
sortable.SetQuickSortStrategy();
sortable.Sort(); */

// 4.b Strategy
/* StrategySortingContext2 sortable = new();
sortable.Sort(Behavior.BubbleSortStrategy);
sortable.Sort(Behavior.QuickSortStrategy); */

// 5. Mediator
/* Mediator mediator = new();
IColleague oPepe = new User(mediator);
IColleague oAdmin = new UserAdmin(mediator);
mediator.Add(oPepe);
mediator.Add(oAdmin);
oPepe.Communicate("Oye admin tengo un problema!"); */

// 6. State
/* ServerContext server = new()
{
    State = new AvailableServerState()
};

server.AttendRequest();

server.State = new OverflowServerState();
server.AttendRequest();
server.AttendRequest();

server.State = new UnavailableServerState();
server.AttendRequest();
server.AttendRequest(); */

// 7. Composite
// Ingredient ingredient1 = new("Flour", 5, 200, "Oz");
// Ingredient ingredient2 = new("Milk", 3, 1, "Litre");
// Ingredient ingredient3 = new("Eggs", 2, 1, "Pound");

// CompositePie lemonPie = new("Lemon Pie");
// lemonPie.Add(ingredient1);
// lemonPie.Add(ingredient2);
// lemonPie.Add(ingredient3);

// Console.WriteLine($"Cost of Lemon Pie: {lemonPie.TotalCost}");

// Ingredient ingredient4 = new("Chocolate", 7, 1, "Oz");
// CompositePie chocolatePie = new("Chocolate Pie");

// chocolatePie.Add(ingredient4);
// chocolatePie.Add(lemonPie);

// Console.WriteLine($"Cost of Chocolate Pie: {chocolatePie.TotalCost}");