using LiteDB;


namespace NovasClasses.Modelos;

public class Costureira : Registro
{
  [BsonId]
  public string Name {get; set ;}
  public int Id { get; set; }
  public string Fornecedor { get; set; }
  public string Quantidade { get; set;}
}