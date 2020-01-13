using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public string CustomerID { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        [Required]
        public string ContactEmail { get; set; }

        [Required]
        public string AddressID { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Fax { get; set; }

        #region Not-Mapped Properties

        #endregion

        #region Navigation Properties

        #endregion
    }
}
