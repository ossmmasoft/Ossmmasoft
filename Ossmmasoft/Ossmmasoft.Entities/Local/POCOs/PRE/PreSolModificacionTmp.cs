namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreSolModificacionTmp
    {
        public int? Id { get; set; }
        public int? TipoModificacionId { get; set; }
        public DateOnly FechaSolicitud { get; set; }
        public int? Ano { get; set; }
        public string NumeroSolModificacion { get; set; } = String.Empty;
        public string CodigoOficio { get; set; } = String.Empty;
        public int? CodigoSolicitante { get; set; }
        public string Motivo { get; set; } = String.Empty;
        public string Status { get; set; } = String.Empty;
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public int? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? NumeroCorrelativo { get; set; }
        public int? CodigoPresupuesto { get; set; }
    }
}
