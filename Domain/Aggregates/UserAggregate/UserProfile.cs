using Domain.Common;
namespace Domain.Aggregates.UserAggregate;

public class UserProfile(string FirstName,
string LastName,
string Email,
string PhoneNumber,
bool IsMarried,
string Gender,
DateTime DateOfBirth,
string Address,
string City,
string State,
string Country,
string ZipCode,
string? SpouseFirstName,
string? SpouseLastName,
string? SpouseEmail,
string? SpousePhoneNumber) : AuditableWithBaseEntity<long>
{
    public string FirstName { get; set; } = FirstName;
    public string LastName { get; set; } = LastName;
    public string Email { get; set; } = Email;
    public string PhoneNumber { get; set; } = PhoneNumber;
    public bool IsMarried { get; set; } = IsMarried;
    public string Gender { get; set; } = Gender;
    public DateTime DateOfBirth { get; set; } = DateOfBirth;
    public string Address { get; set; } = Address;
    public string City { get; set; } = City;
    public string State { get; set; } = State;
    public string Country { get; set; } = Country;
    public string ZipCode { get; set; } = ZipCode;
    public string? SpouseFirstName { get; set; } = SpouseFirstName;
    public string? SpouseLastName { get; set; } = SpouseLastName;
    public string? SpouseEmail { get; set; } = SpouseEmail;
    public string? SpousePhoneNumber { get; set; } = SpousePhoneNumber;
}
