namespace Ossmmasoft.Entities.Local.POCOs.PRE
{
    public partial class PreNivelesPuc
    {
        public int Id { get; set; }
        public string Nivel1 { get; set; }
        public string Nivel2 { get; set; }
        public string Nivel3 { get; set; }
        public string Nivel4 { get; set; }
        public string Nivel5 { get; set; }
        public string Nivel6 { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActulizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }

        public virtual SisEmpresa CodigoEmpresaNavigation { get; set; }
    }
}
