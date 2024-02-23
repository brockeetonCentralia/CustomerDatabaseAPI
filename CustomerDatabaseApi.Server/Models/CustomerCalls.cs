using System.ComponentModel.DataAnnotations;

namespace CustomerDatabaseApi.Server.Models
{
    public class CustomerCalls
    {
        [Key]
        public int CallID { get; set; }
        public int CallAttempts { get; set; }
        public string CallNotes { get; set; }
        public int CustomerID { get; set; }
    }
}
