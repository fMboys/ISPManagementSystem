using Core.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class BillingsRepository
    {
        private SqlConnection _sqlConnection;
        SqlCommand sqlCommand = new SqlCommand();

        public BillingsRepository(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
        }

        public async Task<Billings> GetLatestBillingsByCustomerIDAsync(int customerId)
        {
            try
            {
                const string sql = @"
                                    SELECT TOP 1 *
                                    FROM tblBillings
                                    WHERE CustomerID = @CustomerID
                                    ORDER BY BillDate DESC, BillID DESC; ";

                await using var connection = _sqlConnection;

                return await connection.QuerySingleOrDefaultAsync<Billings>(sql, new { CustomerID = customerId });

            }
            catch (SqlException sqlEx)
            {

                throw;
            }
        }
    }
}
