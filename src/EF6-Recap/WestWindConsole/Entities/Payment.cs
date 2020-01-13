using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Payments")]
    class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [Required]
        public int PaymentDate { get; set; }

        [Required]
        public int Amount { get; set; }

        public int PaymentTypeID { get; set; } //fk

        public int OrderID { get; set; } //fk

        [Required]
        public int TransactionID { get; set; } //listed as "unique identifier" in the ERD
        
        public int ClearedDate { get; set; }

        #region Not-Mapped Properties

        #endregion

        #region Navigation Properties

        #endregion
    }
}
