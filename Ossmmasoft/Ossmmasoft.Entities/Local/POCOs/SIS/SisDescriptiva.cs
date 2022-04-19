namespace Ossmmasoft.Entities.Local.POCOs.SIS
{
    public partial class SisDescriptiva
    {
        public SisDescriptiva()
        {
            SisEmpresaIdentificacions = new HashSet<SisEmpresa>();
            SisEmpresaMarcaServidors = new HashSet<SisEmpresa>();
            SisEmpresaSistemaOperativos = new HashSet<SisEmpresa>();
            SisEmpresaTipoEmpresas = new HashSet<SisEmpresa>();
            SisEmpresaVersionSistemas = new HashSet<SisEmpresa>();
        }

        public int Id { get; set; }
        public int? DescripcionPadreId { get; set; }
        public string Descripcion { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public string Codigo { get; set; }
        public int? CodigoEmpresa { get; set; }
        public int? Estatus { get; set; }

        public virtual ICollection<SisEmpresa> SisEmpresaIdentificacions { get; set; }
        public virtual ICollection<SisEmpresa> SisEmpresaMarcaServidors { get; set; }
        public virtual ICollection<SisEmpresa> SisEmpresaSistemaOperativos { get; set; }
        public virtual ICollection<SisEmpresa> SisEmpresaTipoEmpresas { get; set; }
        public virtual ICollection<SisEmpresa> SisEmpresaVersionSistemas { get; set; }
    }
}
