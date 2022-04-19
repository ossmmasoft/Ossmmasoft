namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomTarifasIislr
    {
        public int Id { get; set; }
        public int NumeroTarifa { get; set; }
        public decimal? TarifaMin { get; set; }
        public decimal? TarifaMax { get; set; }
        public decimal? PorTarifa { get; set; }
        public int SustraendoUt { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }
    }
}
