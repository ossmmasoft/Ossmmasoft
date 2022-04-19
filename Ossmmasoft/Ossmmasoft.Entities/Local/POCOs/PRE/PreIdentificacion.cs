namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreIdentificacion
    {
        public int Id { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string Municipio { get; set; }
        public string DomicilioLegal { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Fax3 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public string Complemnto1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacio { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? CodigoPresupuesto { get; set; }
        public string DenominacionOnp { get; set; }
        public string DenominacionOmp { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
        public virtual PrePresupuesto CodigoPresupuestoNavigation { get; set; }
    }
}
