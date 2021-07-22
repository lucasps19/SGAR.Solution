using System.ComponentModel.DataAnnotations;

namespace SGAR.Model.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
