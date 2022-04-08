namespace Ossmmasoft.UseCasesPorts.Local.PreTitulo
{
    public interface IGetAllPreTitulosOutputPort
    {
        Task Handle(IEnumerable<PreTituloDTO> preTitulos);
    }
}
