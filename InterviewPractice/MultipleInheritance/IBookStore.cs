
namespace Practice.MultipleInheritance
{
    interface IBookStore
    {
        string Address { get; }
        string Name { get; }
        decimal GetPrice(string bookName);
        string GetInformation();
    }
}
