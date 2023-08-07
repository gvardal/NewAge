using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Fyefatura
{
    public int FaturaId { get; set; }

    public string EinvoiceId { get; set; } = null!;

    public long? AktarilanFaturaId { get; set; }

    public bool? Aktarildi { get; set; }

    public DateTime? AktarimTarihi { get; set; }

    public int? AktaranId { get; set; }

    public string? IssueDate { get; set; }

    public string? InvoiceTypeCode { get; set; }

    public string? FaturaTuruId { get; set; }

    public string? Uuid { get; set; }

    public string? DocumentCurrencyCode { get; set; }

    public decimal? ExchangeRate { get; set; }

    public byte? LineCountNumeric { get; set; }

    public string? CopyIndicator { get; set; }

    public string? PartyName { get; set; }

    public int? AccountId { get; set; }

    public string? SalesOrderId { get; set; }

    public string? WayBillNo { get; set; }

    public int? OnayYetkilisiId { get; set; }

    public string? StreetName { get; set; }

    public string? BuildingName { get; set; }

    public string? BuildingNumber { get; set; }

    public string? CitySubdivisionName { get; set; }

    public string? CityName { get; set; }

    public string? PostalZone { get; set; }

    public string? Region { get; set; }

    public string? Country { get; set; }

    public string? TaxNumber { get; set; }

    public string? TaxOffice { get; set; }

    public string? Telephone { get; set; }

    public string? TeleFax { get; set; }

    public string? ElectronicMail { get; set; }

    public string? Website { get; set; }

    public string? InvoiceNotes { get; set; }

    public decimal? AllowanceChargeAmountAmount { get; set; }

    public string? AllowanceChargeAmountCurrencyId { get; set; }

    public bool? AllowanceChargeChargeIndicator { get; set; }

    public string? TaxTotalTaxAmountCurrencyId { get; set; }

    public decimal? TaxTotalTaxAmountAmount { get; set; }

    public string? TaxTotalTaxSubtotalTaxableAmountCurrencyId { get; set; }

    public decimal? TaxTotalTaxSubtotalTaxableAmountAmount { get; set; }

    public string? TaxTotalTaxSubtotalTaxAmountCurrencyId { get; set; }

    public decimal? TaxTotalTaxSubtotalTaxAmountAmount { get; set; }

    public string? TaxTotalTaxSubtotalTaxAmountTaxCategoryTaxScheme { get; set; }

    public decimal? WitholdingTaxTotalTaxAmountAmount { get; set; }

    public string? WitholdingTaxTotalTaxAmountCurrencyId { get; set; }

    public decimal? WitholdingTaxTotalTaxSubTotalTaxableAmountAmount { get; set; }

    public string? WitholdingTaxTotalTaxSubTotalTaxableAmountCurrencyId { get; set; }

    public decimal? WitholdingTaxTotalTaxSubTotalTaxAmountAmount { get; set; }

    public string? WitholdingTaxTotalTaxSubTotalTaxAmountCurrencyId { get; set; }

    public decimal? WitholdingTaxTotalTaxSubTotalPercent { get; set; }

    public string? WitholdingTaxTotalTaxSubTotalTaxCategoryTaxScheme { get; set; }

    public string? LegalMonetaryTotalLineExtensionAmountCurrencyId { get; set; }

    public decimal? LegalMonetaryTotalLineExtensionAmountAmount { get; set; }

    public string? LegalMonetaryTotalTaxExclusiveAmountCurrencyId { get; set; }

    public decimal? LegalMonetaryTotalTaxExclusiveAmountAmount { get; set; }

    public string? LegalMonetaryTotalTaxInclusiveAmountCurrencyId { get; set; }

    public decimal? LegalMonetaryTotalTaxInclusiveAmountAmount { get; set; }

    public string? LegalMonetaryTotalAllowanceTotalAmountCurrencyId { get; set; }

    public decimal? LegalMonetaryTotalAllowanceTotalAmountAmount { get; set; }

    public string? LegalMonetaryTotalPayableAmountCurrencyId { get; set; }

    public decimal? LegalMonetaryTotalPayableAmountAmount { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual Miysahesaplar? Account { get; set; }

    public virtual Ikcalisanlar? Aktaran { get; set; }

    public virtual Fyfatura? AktarilanFatura { get; set; }

    public virtual ICollection<Dybyevraklar> Dybyevraklars { get; set; } = new List<Dybyevraklar>();

    public virtual PFyfaturaTuru? FaturaTuru { get; set; }

    public virtual ICollection<FyefaturaDetay> FyefaturaDetays { get; set; } = new List<FyefaturaDetay>();

    public virtual Ikcalisanlar? OnayYetkilisi { get; set; }
}
