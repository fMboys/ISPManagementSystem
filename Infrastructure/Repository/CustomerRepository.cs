using Core.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Infrastructure.Repository
{
    public class CustomerRepository
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        //DAL dbConnection = new DAL();

        public CustomerRepository(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public async Task<Customer?> GetCustomerByIdAsync(int? customerId)
        {
            const string sql = """
                                SELECT
                                    CustomerID,
                                    CustomerName,
                                    PhoneNumber,
                                    Address,
                                    Package,
                                    Amount,
                                    ConnectionDate,
                                    IsActive,
                                    CreatedDate,
                                    ModifiedBy
                                FROM tblCustomers
                                WHERE CustomerID = @CustomerID;
                                """;

            await using var connection = sqlConnection;

            return await connection.QuerySingleOrDefaultAsync<Customer>(sql, new { CustomerID = customerId });
        }

        public async Task<List<Customer>> GetÀllCustomerAsync()
        {
            const string sql = "SELECT * FROM tblCustomers WHERE IsActive = 1";

            await using var connection = sqlConnection;
            var customers = await connection.QueryAsync<Customer>(sql);

            return customers.ToList();
        }
    }
}
