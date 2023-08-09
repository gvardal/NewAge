using System.ComponentModel.DataAnnotations.Schema;

namespace Dupus.Entity.Models.ProductionManagment
{
    [Table("UYKonumTuru", Schema = "UretimYonetimi")]
    public class LocationsType
    {
        public byte KonumTuruID { get; set; }
        public string? Ad { get; set; }
    }
}
