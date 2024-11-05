using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DatabaseAbstraction.Entities;

namespace RepositoryPattern.DataAccess;

/// <summary>
/// A repository for a salesorder to execute CRUD operations on a IDBConnection with Dapper.
/// </summary>
public sealed class OrderRepository: IRepository<SalesOrder>
{

    private IDbConnection Connection { get; }

    public OrderRepository(IDbConnection connection)
    {
        if (connection.State != ConnectionState.Open)
        {
            throw new InvalidOperationException("Connection is not open.");
        }
        Connection = connection;
    }

    public Task GetAsync(SalesOrder entity)
    {
        // Use Dapper's extension methods on IDBConnection to execute an insert query.
        var query = "INSERT INTO Orders (Id, Customer, OrderDate) VALUES (@Id, @Customer, @OrderDate)";
        return Connection.ExecuteAsync(query, entity);
    }

    public Task AddAsync(SalesOrder entity)
    {
        throw new NotImplementedException();
    }

    public Task DropAsync(SalesOrder entity)
    {
        throw new NotImplementedException();
    }
}

