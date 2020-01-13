using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("BuildVersions")]
    public class BuildVersion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Major { get; set; }

        [Required]
        public int Minor { get; set; }

        [Required]
        public int Build { get; set; }

        [Required]
        public int ReleaseDate { get; set; }

        #region Not-Mapped Properties

        #endregion

        #region Navigation Properties

        #endregion
    }
}
