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
        string query="DELETE FROM clientes WHERE idCliente = @client";
        int modifiedRegisters = 0;
        using(SqlConnection connection = new SqlConnection(_connectionString)){

            modifiedRegisters=connection.Execute(query, new{client.idCliente});
        }

        return modifiedRegisters;
    }
    public static void modifyWaiter(string waiterName){

        string query="DELETE FROM clientes WHERE nombre = @client";
        int modifiedRegisters = 0;
        using(SqlConnection connection = new SqlConnection(_connectionString)){

            modifiedRegisters=connection.Execute(query, new{clientName});
        }

        return modifiedRegisters;
    }












}


