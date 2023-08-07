using ProjectServices.Dupus.Services.Contracts;

namespace ProjectServices.Dupus.Services.Contracts
{
    public interface IServiceManager
    {
        IIsEmriService IsEmriService { get; }
        IIsEmriRotaService IsEmriRotaService { get; }
        IKonumTuruService KonumTuruService { get; }
        IKonumService KonumService { get; }
        IUrunlerService UrunlerService { get; }
    }
}
