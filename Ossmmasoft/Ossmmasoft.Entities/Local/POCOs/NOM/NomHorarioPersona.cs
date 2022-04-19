namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomHorarioPersona
    {
        public int Id { get; set; }
        public int? CodigoPersona { get; set; }
        public int? CodigoHdom { get; set; }
        public int? CodigoHlun { get; set; }
        public int? CodigoHmar { get; set; }
        public int? CodigoHmie { get; set; }
        public int? CodigoHjue { get; set; }
        public int? CodigoHvie { get; set; }
        public int? CodigoHsab { get; set; }
        public int? CodigoIcp { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }


        public virtual NomHorario CodigoHdomNavigation { get; set; }
        public virtual NomHorario CodigoHjueNavigation { get; set; }
        public virtual NomHorario CodigoHlunNavigation { get; set; }
        public virtual NomHorario CodigoHmarNavigation { get; set; }
        public virtual NomHorario CodigoHmieNavigation { get; set; }
        public virtual NomHorario CodigoHsabNavigation { get; set; }
        public virtual NomHorario CodigoHvieNavigation { get; set; }
        public virtual PreIndiceCatPrg CodigoIcpNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
    }
}
