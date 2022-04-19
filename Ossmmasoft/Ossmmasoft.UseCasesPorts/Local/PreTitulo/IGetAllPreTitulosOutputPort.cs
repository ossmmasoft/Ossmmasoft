namespace Ossmmasoft.UseCasesPorts.Local.PreTitulo
{
    public interface IGetAllPreTitulosOutputPort
    {
        Task Handle(IEnumerable<PreTitulosDTO> preTitulos);
    }
}
