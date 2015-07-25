using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace lmgreadapp2.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string ICP { get; set; }
        public string MeterNo { get; set; }
        public double MeterRead { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
