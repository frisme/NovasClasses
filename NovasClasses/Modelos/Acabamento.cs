using LiteDB;

namespace LiteDBExample.Modelos;

public class Acabamento : Registro
{
  [BsonId]
  public string Tipo { get; set; }
  public string Quantidade {get; set ;}
  public string Cor { get; set; }
  public int Id { get; set; }
}