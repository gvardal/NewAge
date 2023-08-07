using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities.Dupus.Entity.Models
{
    [Table("P_UYIsEmriDurumu", Schema = "SistemAyarlari")]
    public class UYIsEmriDurumu
    {
        public byte IsEmriDurumId { get; set; }
        public string? Durum { get; set; }
    }
}
