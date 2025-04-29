namespace DemoProject.Data.Model;

public class Category (String title, String description, String code, Guid? parent)
{
    

    
    public void Update(Category category)
    {
        //Nema nista
        Title = category.Title;
        Description = category.Description;
        Code = category.Code;
        ParentCategory = category.ParentCategory;
    }
}