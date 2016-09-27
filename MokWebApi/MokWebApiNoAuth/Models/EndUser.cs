using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MokWebApiNoAuth.Models
{
    [Table("EndUser")]
    public partial class EndUser
    {
        [Key]
        [StringLength(25)]
        public string user_name { get; set; }

        [Required]
        [StringLength(1)]
        public string user_password { get; set; }

        [Required]
        [StringLength(1)]
        public string user_email { get; set; }
    }
}
