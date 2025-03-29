using Core.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concretes
{
    [Table("tournaments")]
    public class Tournament : IEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string name { get; set; }
    }
}
