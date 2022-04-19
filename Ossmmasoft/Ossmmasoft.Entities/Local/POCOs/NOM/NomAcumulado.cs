namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomAcumulado
    {
        public int Id { get; set; }
        public int? CodigoPersona { get; set; }
        public int? TipoAcumuladoId { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public decimal Monto { get; set; }
        public string Compplemento1 { get; set; } = String.Empty;
        public string Compplemto2 { get; set; } = String.Empty;
        public string Compplemento3 { get; set; } = String.Empty;
        public string Complemento4 { get; set; } = String.Empty;
        public string Complemento5 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? Fechacreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }


        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva TipoAcumulado { get; set; }
    }
}
