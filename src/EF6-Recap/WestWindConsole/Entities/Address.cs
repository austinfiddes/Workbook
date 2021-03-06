﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        [Required]
        [Column("Address")] // Tell EF that the database column name is "Address"
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        [Required]
        public string Country { get; set; }

        // TODO: Finish the other column/property mappings...

        #region Not-Mapped Properties

        #endregion

        #region Navigation Properties
        public virtual ICollection<Supplier> Suppliers { get; set; } = new HashSet<Supplier>();
        #endregion
    }
}