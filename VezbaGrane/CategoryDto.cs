
namespace DemoProject.Dto;

public class CategoryDto
{ 
        //casdsdasd
        public required string Title { get; set; }
        public string? Description { get; set; }
        public required string Code { get; set; }
        
        public Guid? ParentCategory { get; set; }
}