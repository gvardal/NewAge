using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities.Dupus.Entity.Models
{
    [Table("UYKonumTuru", Schema = "UretimYonetimi")]
    public class UYKonumTuru
    {
        public byte KonumTuruID { get; set; }
        public string? Ad { get; set; }
    }
}
