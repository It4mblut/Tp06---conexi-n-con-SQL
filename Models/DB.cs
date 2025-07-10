namespace PruebaDeDapperYSql.Models;
using Microsoft.Data.SqlClient;
using Dapper;

public static class DB
{
    private static string _connectionString = @"Server=localhost;DataBase=ORT Gourmet;Integrated Security=True;TrustServerCertificate=True";

    public static List<clientes> saveClients(){

        List<clientes> clientes = new List<clientes>();
        using(SqlConnection connection = new SqlConnection(_connectionString)){

            string query= "SELECT * FROM clientes";
            clientes = connection.Query<clientes>(query).ToList();

        }
        return clientes;
    }

    public static int deleteClient(clientes client){
        string query="DELETE FROM clientes WHERE idCliente = @idCliente";
        int modifiedRegisters = 0;
        using(SqlConnection connection = new SqlConnection(_connectionString)){

            modifiedRegisters=connection.Execute(query, new{idCliente=client.idCliente});
        }

        return modifiedRegisters;
    }
    public static int modifyWaiter(mozos waiter, string newSurname, string newName){
        int modifiedRegisters = 0;
        if(newName==null){
            newName=waiter.nombre;

        }
        if(newSurname==null){
            newSurname=waiter.apellido;

        }


        string query="UPDATE mozos SET nombre= @newName, apellido=@newSurname WHERE idMozo = @idMozo";

        using(SqlConnection connection = new SqlConnection(_connectionString)){

            modifiedRegisters=connection.Execute(query, new{newName, newSurname, idMozo=waiter.idMozo});
        }

        return modifiedRegisters;
    }












}


