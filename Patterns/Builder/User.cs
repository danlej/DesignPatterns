using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text;

namespace DesignPatterns.Patterns.Builder;

public static class UserExtensions
{
    private static readonly JsonSerializerOptions _jsonSerializerOptions = new() { WriteIndented = true };

    public static string ToJson(this User user) => JsonSerializer.Serialize(user, _jsonSerializerOptions);
}

public class User
{
    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string? Name { get; private set; }

    [Required(ErrorMessage = "El apellido es obligatorio")]
    public string? LastName { get; private set; }

    [Required(ErrorMessage = "El email es obligatorio")]
    [EmailAddress(ErrorMessage = "El formato del email no es válido")]
    public string? Email { get; private set; }

    [Phone(ErrorMessage = "El formato del teléfono no es válido")]
    public string? Phone { get; private set; }

    public DateOnly? BirthDay { get; private set; }

    public string? Gender { get; private set; }

    public string? MaritalStatus { get; private set; }

    private User(Builder builder)
    {
        Name = builder.Name;
        LastName = builder.LastName;
        Email = builder.Email;
        Phone = builder.Phone;
        BirthDay = builder.BirthDay;
        Gender = builder.Gender;
        MaritalStatus = builder.MaritalStatus;
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine($"Apellido y Nombre: {LastName}, {Name}");
        sb.AppendLine($"Género: {Gender}");
        sb.AppendLine($"Nacimiento: {BirthDay?.ToString("ddd, dd/MM/yyyy")}");
        sb.AppendLine($"Estado Civil: {MaritalStatus}");
        sb.AppendLine($"Teléfono: {Phone}");
        sb.AppendLine($"Email: {Email}");
        return sb.ToString();
    }

    public class Builder
    {
        public string? Name { get; private set; }
        public string? LastName { get; private set; }
        public string? Email { get; private set; }
        public string? Phone { get; private set; }
        public DateOnly? BirthDay { get; private set; }
        public string? Gender { get; private set; }
        public string? MaritalStatus { get; private set; }

        public Builder SetName(string name)
        {
            Name = name;
            return this;
        }

        public Builder SetLastName(string lastName)
        {
            LastName = lastName;
            return this;
        }

        public Builder SetEmail(string email)
        {
            Email = email;
            return this;
        }

        public Builder SetPhone(string phone)
        {
            Phone = phone;
            return this;
        }

        public Builder SetBirthDay(DateOnly birthDay)
        {
            BirthDay = birthDay;
            return this;
        }

        public Builder SetGender(string gender)
        {
            Gender = gender;
            return this;
        }

        public Builder SetMaritalStatus(string maritalStatus)
        {
            MaritalStatus = maritalStatus;
            return this;
        }

        public User Build()
        {
            var user = new User(this);

            // Validar el objeto usando Data Annotations
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(user);

            if (!Validator.TryValidateObject(user, context, validationResults, true))
            {
                throw new ValidationException(string.Join("; ", validationResults.Select(vr => vr.ErrorMessage)));
            }

            return user;
        }
    }

}
