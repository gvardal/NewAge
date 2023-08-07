using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Saihaleler
{
    public int IhaleId { get; set; }

    public string? IhaleKodu { get; set; }

    public DateTime? IhaleTarihi { get; set; }

    public string? Aciklama { get; set; }

    public string? IdariSartname { get; set; }

    public string? TeknikSartname { get; set; }

    public bool? Aktif { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<SateklifSipari> SateklifSiparis { get; set; } = new List<SateklifSipari>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<Sysasozlesmeler> Sysasozlesmelers { get; set; } = new List<Sysasozlesmeler>();
}
