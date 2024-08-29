using LiteDB;

namespace NovasClasses.Modelos;

public class Item : Registro
{
  [BsonId]
  public string Tipo {get; set ;}
  public int Id { get; set; }
  public string Fornecedor { get; set; }
  public string Quantidade { get; set;}
}