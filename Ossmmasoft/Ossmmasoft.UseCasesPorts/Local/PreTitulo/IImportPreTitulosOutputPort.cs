namespace Ossmmasoft.UseCasesPorts.Local.PreTitulo
{
    public interface IImportPreTitulosOutputPort
    {
        Task Handle(IEnumerable<PreTitulosDTO> preTitulos);
    }
}
