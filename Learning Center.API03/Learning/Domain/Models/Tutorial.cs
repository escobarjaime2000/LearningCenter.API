namespace Learning_Center.API03.Learning.Domain.Models;

public class Tutorial
{
    //colocamos el Id, Name Description 
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    //colocando la relacion con tutorial 
    //aplicando RelationShip
    //persistencia para Asp.Net core Entity Framework
    //es necesario que se indique el atributo que sera la contraparte a nivel de estructura de tabla
    public int CategoryId { get; set; }
    
    
    
    //aplicando POO
    public Category Category { get; set; }
}