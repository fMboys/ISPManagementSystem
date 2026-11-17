using Core.DTOs;
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

        public async Task<List<InvoicePDFDto>> GetLatestBillingsByCustomerAsync()
        {
            try
            {
                const string sql = @"WITH LatestBilling AS
                                    (
                                        SELECT *,
                                               ROW_NUMBER() OVER (
                                                   PARTITION BY CustomerID
                                                   ORDER BY BillDate DESC, BillID DESC
                                               ) AS RN
                                        FROM tblBillings
                                    )
                                    SELECT
                                        c.CustomerID, c.CustomerName, c.CNIC, c.PhoneNumber, c.Address, c.Package, c.ConnectionDate, c.IsActive,
                                        b.*
                                    FROM tblCustomers c
                                    LEFT JOIN LatestBilling b
                                        ON c.CustomerID = b.CustomerID
                                        AND b.RN = 1
                                    WHERE c.IsActive = 1;";

                await using var connection = _sqlConnection;

                var invoiceDtos = await connection.QueryAsync<InvoicePDFDto>(sql);
                return invoiceDtos.ToList();
            }
            catch (SqlException sqlEx)
            {

                throw;
            }
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
