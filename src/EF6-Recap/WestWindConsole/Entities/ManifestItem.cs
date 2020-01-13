using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("ManifestItems")]
    public class ManifestItem
    {
        [Key]
        public int ManifestItemID { get; set; }

        [Required]
        public int ShipmentID { get; set; } //fk

        [Required]
        public int ProductID { get; set; } //fk

        [Required]
        public int ShipQuantity { get; set; }

        #region Not-Mapped Properties

        #endregion

        #region Navigation Properties

        #endregion
    }
}
