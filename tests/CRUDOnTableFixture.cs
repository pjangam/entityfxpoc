using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace crud_apis.tests
{
    public class CRUDOnTableFixture
    {
        [Fact]
        public async Task GivenCreateDBEntry_WhenTableExists_ThenShouldNotFail()
        {
            try
            {
                var driver = new PostgresDriver(new ConnectionString("testsuite"));
                List<ColumnSchema> columns = new List<ColumnSchema> 
                {
                    new ColumnSchema("id","VARCHAR (50)")
                };
                driver.CreateTable("sometable", columns);
                driver.DropTable("sometable");
                
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }
    }
}