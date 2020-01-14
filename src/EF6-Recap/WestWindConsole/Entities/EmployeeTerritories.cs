using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("EmployeeTerritories")]
    public class EmployeeTerritory
    {
        [Key, Column(Order = 1)] //fk
        public int EmployeeID { get; set; }
        [Key, Column(Order = 2)] //fk
        public string TerritoryID { get; set; }

        #region Not-Mapped Properties

        #endregion

        #region Navigation Properties
        public virtual Employee Employee { get; set; }
        //TODO: Territory relation
        #endregion
    }
}
