namespace Learning_Center.API03.Learning.Domain.Models;

public class Category
{
    //usaremos el patron de diseño de identity field 
    public int Id { get; set; }
    public string Name { get; set; }
    //como ya existe un tutorial y como category puede abarcar varios tutoriales 
    //debemos representar esa relacion a traves de clases 
    
    //de esta manera establecemos la relacion de asociacion de uno a muchos 
    public IList<Tutorial> Tutorials { get; set; } = new List<Tutorial>();
}
