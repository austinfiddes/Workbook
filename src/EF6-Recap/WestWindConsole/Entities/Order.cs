using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        public int SalesRepID { get; set; } //fk

        public string CustomerID { get; set; } //fk

        public int OrderDate { get; set; }

        public int RequiredDate { get; set; }

        public int PaymentDueDate { get; set; }

        public int Freight { get; set; }

        [Required]
        public int Shipped { get; set; }

        public string ShipName { get; set; }

        public int ShipAddressID { get; set; }

        public string Comments { get; set; }

        #region Not-Mapped Properties

        #endregion

        #region Navigation Properties

        #endregion
    }
}
