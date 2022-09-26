using Bootcamp.ViewModel;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Queries.PersonRead
{
    public class PersonQueries : IPersonQueries
    {
        private readonly string _connectionString;

        public PersonQueries(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }

        public async Task<IEnumerable<PersonReadViewModel>> GetAll()
        {
            IEnumerable<PersonReadViewModel> result = new List<PersonReadViewModel>();

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.QueryAsync<PersonReadViewModel>("[dbo].[Usp_Sel_Read]", commandType: System.Data.CommandType.StoredProcedure);
            }

            return result;
        }
    }
}
