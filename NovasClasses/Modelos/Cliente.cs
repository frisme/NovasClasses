using LiteDB;

namespace NovasClasses.Modelos;

public class Cliente : Registro
{
  [BsonId]
  public string Senha { get; set; }
  public string Nome {get; set ;}
  public string Email { get; set; }
  public string Endereco { get; set; }
  public string ConfirmarSenha { get; set;}
  public int Id { get; set; }
}