namespace PruebaDeDapperYSql.Models;
using Microsoft.Data.SqlClient;
public class registroMesasComidas
{
    public int idRegistroMesaComida { get;private set; }
    public int idRegistroMesa { get;private set; }
    public int idComida { get;private set; }
    public int cantidad { get;private set; }
    public double precio { get;private set; }
}
