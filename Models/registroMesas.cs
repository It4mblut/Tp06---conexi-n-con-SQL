namespace PruebaDeDapperYSql.Models;
using Microsoft.Data.SqlClient;
public class registroMesas
{
    public int idRegistroMesa { get; set; }
    public DateTime fecha { get; set; }
    public int idMesa { get; set; }
    public int idCliente { get; set; }
    public int idMozo { get; set; }
}
