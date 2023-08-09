using System.ComponentModel.DataAnnotations.Schema;

namespace Dupus.Entity.Models.ProductionManagment
{
    [Table("P_UYIsEmriDurumu", Schema = "SistemAyarlari")]
    public class WorkOrderStatus
    {
        public byte IsEmriDurumId { get; set; }
        public string? Durum { get; set; }
    }
}
