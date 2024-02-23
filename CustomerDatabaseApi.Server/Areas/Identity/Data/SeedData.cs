using CustomerDatabaseApi.Server.Data;
using CustomerDatabaseApi.Server.Models;
using Microsoft.AspNetCore.Identity;

namespace CustomerDatabaseApi.Server.Areas.Identity.Data
{
    public class SeedData
    {
        public static async Task EnsurePopulated(IServiceProvider serviceProvider)
        {
            CustomerDatabaseApiContext context = serviceProvider.GetService<CustomerDatabaseApiContext>();

            if (context == null)
            {
                throw new NullReferenceException("No Context Available.");
            }

            if (context.CustomerInfo.Any())
            {


                return;
            }else
            {
                CustomerInfo customerInfo = new CustomerInfo
                {
                    FirstName = "Willy",
                    LastName = "Wonka",
                    PhoneNumber = "1234567890",
                    Address = "123 Candy Lane",
                    Email = "willywonka@gmail.com"
                };

                List<CustomerInfo> list = new List<CustomerInfo>();
                list.Add(customerInfo);
                list.Add(new CustomerInfo { FirstName = "Oompa", LastName = "Loompa", PhoneNumber = "0987654321", Address = "123 Candy Lane", Email = "oompaloompa@hotmail.com" });
                list.Add(new CustomerInfo { FirstName = "Charlie", LastName = "Bucket", PhoneNumber = "9078636232", Address = "121 Bucket Lane", Email = "goldenboi@gmail.com" });
                list.Add(new CustomerInfo { FirstName = "Mike", LastName = "Teevee", PhoneNumber = "89045322234", Address = "143 WildWest Lane", Email = "teevee@gmail.com" });


                context.CustomerInfo.Add(customerInfo);
                await context.SaveChangesAsync();
            }            
        } 
    }
}
