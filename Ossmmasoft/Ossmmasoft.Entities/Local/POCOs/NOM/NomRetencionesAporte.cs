namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomRetencionesAporte
    {
        public int Id { get; set; }
        public int CodigoPersona { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public int CodigoTipoNomina { get; set; }
        public string CodigoRetencion { get; set; } = string.Empty;
        public DateOnly? FechaNomina { get; set; }
        public decimal? MontoBase { get; set; }
        public decimal? MontoRt { get; set; }
        public decimal? MontoAp { get; set; }
        public decimal? MontoTotal { get; set; }
        public int? UsuarioCeacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
    }
}
