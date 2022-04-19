namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomDescuentoLey
    {
        public NomDescuentoLey()
        {
            NomDescuentoLeyTrabajadors = new HashSet<NomDescuentoLeyTrabajador>();
        }

        public int Id { get; set; }
        public int CodigoTipoNomina { get; set; }
        public int CodigoConcepto { get; set; }
        public int CodigoDescuentoLeyId { get; set; }
        public int LeyId { get; set; }
        public DateOnly? FechaVigenciaLey { get; set; }
        public decimal? PorMinTrabajador { get; set; }
        public decimal? PorMaxTrabajador { get; set; }
        public decimal? PorMinPatrono { get; set; }
        public decimal? PorMaxPatrono { get; set; }
        public decimal? MontoMinCalculado { get; set; }
        public decimal? MontoMaxCalculado { get; set; }
        public int CodigoConceptoPendiente { get; set; }
        public int CodigoConceptoReintegro { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }

        public virtual NomConcepto CodigoConceptoNavigation { get; set; }
        public virtual NomDescriptiva CodigoDescuentoLey { get; set; }
        public virtual NomTiposNomina CodigoTipoNominaNavigation { get; set; }
        public virtual NomDescriptiva Ley { get; set; }
        public virtual ICollection<NomDescuentoLeyTrabajador> NomDescuentoLeyTrabajadors { get; set; }
    }
}
