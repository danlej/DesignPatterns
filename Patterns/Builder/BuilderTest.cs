using System.ComponentModel.DataAnnotations;

namespace DesignPatterns.Patterns.Builder;

public class BuilderTest
{
    public static void Run()
    {
        User user = new User.Builder()
                                    .SetName("Juan")
                                    .SetEmail("ejemplo@gmail.com")
                                    .SetLastName("Rodriguez")
                                    .SetBirthDay(new DateOnly(2000, 10, 14))
                                    .SetGender("Masculino")
                                    .SetMaritalStatus("Casado")
                                    .SetPhone("+54 9 3562 000123")
                                    .Build();

        Console.WriteLine(user.ToString());

        Console.WriteLine(user.ToJson());
    }
}