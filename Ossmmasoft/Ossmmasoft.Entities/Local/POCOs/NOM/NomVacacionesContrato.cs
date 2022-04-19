namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomVacacionesContrato
    {
        public int Id { get; set; }
        public int NumeroAño { get; set; }
        public int DiasHabiles { get; set; }
        public int DiasBono { get; set; }
        public int TipoNominaId { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }

        public virtual NomDescriptiva TipoNomina { get; set; }
    }
}
