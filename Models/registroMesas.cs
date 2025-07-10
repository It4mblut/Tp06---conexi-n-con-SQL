namespace PruebaDeDapperYSql.Models;
using Microsoft.Data.SqlClient;
public class registroMesas
{
    public int idRegistroMesa { get;private set; }
    public DateTime fecha { get;private set; }
    public int idMesa { get;private set; }
    public int idCliente { get;private set; }
    public int idMozo { get;private set; }
}
