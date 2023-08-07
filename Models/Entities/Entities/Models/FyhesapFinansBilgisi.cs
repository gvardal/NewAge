using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FyhesapFinansBilgisi
{
    public int HesapId { get; set; }

    public byte? FirmaId { get; set; }

    public decimal? KrediLimiti { get; set; }

    public decimal? AlacakSigortasi { get; set; }

    public decimal? KullanilabilirKredi { get; set; }

    public short? GecikenGun { get; set; }

    public short? OrtalamaVade { get; set; }

    public DateTime? SonTahsilatTarihi { get; set; }

    public decimal? SonTahsilatTutari { get; set; }

    public DateTime? SonOdemeTarihi { get; set; }

    public decimal? SonOdemeTutari { get; set; }

    public decimal? OnaylananSiparis { get; set; }

    public decimal? OnaylananSatinAlmaSiparisi { get; set; }

    public decimal? MevcutBakiye { get; set; }

    public decimal? YavadesiGecmis { get; set; }

    public decimal? Ya30alti { get; set; }

    public decimal? Ya30ustu { get; set; }

    public decimal? Ya60ustu { get; set; }

    public decimal? Ya90ustu { get; set; }

    public decimal? Ya120ustu { get; set; }

    public decimal? Ya150ustu { get; set; }

    public decimal? Ya180ustu { get; set; }

    public DateTime? SonSatisTarihi { get; set; }

    public decimal? SonSatisTutari { get; set; }

    public decimal? YilbasindanBeriSatisTutari { get; set; }

    public decimal? OncekiYilSatisTutari { get; set; }

    public decimal? ToplamSatisTutari { get; set; }

    public decimal? OncekiYilTahsilatTutari { get; set; }

    public decimal? ToplamTahsilatTutari { get; set; }

    public decimal? YilbasindanBeriTahsilatTutari { get; set; }

    public decimal? TahsilEdilemeyenAlacakTutariYb { get; set; }

    public decimal? OncekiYilTahsilEdilemeyenAlacakTutari { get; set; }

    public decimal? ToplamTahsilEdilemeyenAlacakTutari { get; set; }

    public decimal? YilbasindanBeriFaturaTutari { get; set; }

    public decimal? OncekiYilFaturaTutari { get; set; }

    public decimal? ToplamFaturaTutari { get; set; }

    public decimal? SonAlacakDekontuTutari { get; set; }

    public DateTime? SonAlacakDekontuTarihi { get; set; }

    public decimal? YilbasindanBeriAlacakDekontuTutari { get; set; }

    public decimal? OncekiYilAlacakDekontuTutari { get; set; }

    public decimal? ToplamAlacakDekontuTutari { get; set; }

    public decimal? SonIadeTutari { get; set; }

    public DateTime? SonIadeTarihi { get; set; }

    public decimal? YilbasindanBeriIadeTutari { get; set; }

    public decimal? OncekiYilIadeTutari { get; set; }

    public decimal? ToplamIadeTutari { get; set; }

    public DateTime? SonSatinAlmaTarihi { get; set; }

    public decimal? SonSatinAlmaTutari { get; set; }

    public decimal? YilbasindanBeriSatinAlmaTutari { get; set; }

    public decimal? OncekiYilSatinAlmaTutari { get; set; }

    public decimal? ToplamSatinAlmaTutari { get; set; }

    public decimal? OncekiYilOdemeTutari { get; set; }

    public decimal? ToplamOdemeTutari { get; set; }

    public decimal? YilbasindanBeriOdemeTutari { get; set; }

    public decimal? YilbasindanBeriSafaturaTutari { get; set; }

    public decimal? OncekiYilSafaturaTutari { get; set; }

    public decimal? ToplamSafaturaTutari { get; set; }

    public decimal? SonBorcDekontuTutari { get; set; }

    public DateTime? SonBorcDekontuTarihi { get; set; }

    public decimal? YilbasindanBeriBorcDekontuTutari { get; set; }

    public decimal? OncekiYilBorcDekontuTutari { get; set; }

    public decimal? ToplamBorcDekontuTutari { get; set; }

    public decimal? SonSaiadeTutari { get; set; }

    public DateTime? SonSaiadeTarihi { get; set; }

    public decimal? YilbasindanBeriSaiadeTutari { get; set; }

    public decimal? OncekiYilSaiadeTutari { get; set; }

    public decimal? ToplamSaiadeTutari { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual Miysahesaplar Hesap { get; set; } = null!;
}
