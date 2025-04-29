namespace DemoProject.Data.Model;

public class Category (String title, String description, String code, Guid? parent, int Broj)
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = title;
    public string Description { get; set; } = description;
    public string Code {get; set;} = code;
    public Guid? ParentCategory { get; set; } = parent;
    
    public List<Category> SubCategories { get; set; } = new();
    public int Broj { get; set; } = Broj;
    
    public void Update(Category category)
    {
        Title = category.Title;
        Description = category.Description;
        Code = category.Code;
        ParentCategory = category.ParentCategory;
        Broj = category.Broj;
    }
}