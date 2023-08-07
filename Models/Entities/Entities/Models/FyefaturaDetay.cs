using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FyefaturaDetay
{
    public int EinvoiceDetailId { get; set; }

    public int? FaturaId { get; set; }

    public string HeadId { get; set; } = null!;

    public string? InvoicedQuantityUnitCode { get; set; }

    public decimal? InvoicedQuantityAmount { get; set; }

    public string? LineExtensionAmountCurrencyId { get; set; }

    public decimal? LineExtensionAmountAmount { get; set; }

    public bool? AllowanceChargeChargeIndicator { get; set; }

    public decimal? AllowanceChargeMultiplierFactorNumeric { get; set; }

    public string? AllowanceChargeAmountCurrencyId { get; set; }

    public decimal? AllowanceChargeAmountAmount { get; set; }

    public string? AllowanceChargeBaseAmountCurrencyId { get; set; }

    public decimal? AllowanceChargeBaseAmountAmount { get; set; }

    public string? TaxTotalTaxAmountCurrencyId { get; set; }

    public decimal? TaxTotalTaxAmountAmount { get; set; }

    public decimal? TaxSubtotalTaxableAmountAmount { get; set; }

    public string? TaxSubtotalTaxableAmountCurrencyId { get; set; }

    public decimal? TaxSubtotalTaxAmountAmount { get; set; }

    public string? TaxSubtotalTaxAmountCurrencyId { get; set; }

    public decimal? TaxSubtotalPercent { get; set; }

    public string? TaxSubtotalTaxScheme { get; set; }

    public decimal? WitholdingTaxTotalTaxAmountAmount { get; set; }

    public string? WitholdingTaxTotalTaxAmountCurrencyId { get; set; }

    public decimal? WitholdingTaxTotalTaxSubTotalTaxableAmountAmount { get; set; }

    public string? WitholdingTaxTotalTaxSubTotalTaxableAmountCurrencyId { get; set; }

    public decimal? WitholdingTaxTotalTaxSubTotalTaxAmountAmount { get; set; }

    public string? WitholdingTaxTotalTaxSubTotalTaxAmountCurrencyId { get; set; }

    public decimal? WitholdingTaxTotalTaxSubTotalPercent { get; set; }

    public string? WitholdingTaxTotalTaxSubTotalTaxCategoryTaxScheme { get; set; }

    public string? ItemName { get; set; }

    public string? ItemSellersItemIdentification { get; set; }

    public string? ItemBuyersItemIdentification { get; set; }

    public string? ItemNote { get; set; }

    public int? ItemId { get; set; }

    public string? PriceAmountCurrencyId { get; set; }

    public decimal? PriceAmountAmount { get; set; }

    public int? GlaccountNumberId { get; set; }

    public long? SateklifSiparisTeslimatHareketiId { get; set; }

    public virtual Fyefatura? Fatura { get; set; }

    public virtual FyhesapPlani? GlaccountNumber { get; set; }

    public virtual Uyurunler? Item { get; set; }

    public virtual SateklifSiparisTeslimatHareketi? SateklifSiparisTeslimatHareketi { get; set; }
}
