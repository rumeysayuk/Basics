namespace Basics.Models
{
    public class Employee {
    public int Id { get; set; }
    public int Age { get; set; }
    public String FirstName { get; set; } =String.Empty; 
    public String LastName { get; set; } =String.Empty;// shift+alt+ aşağı ok 
    public String FullName => $"{FirstName} {LastName.ToUpper()}";


    }
}