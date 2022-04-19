namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomDescuentoLeyTrabajador
    {
        public int Id { get; set; }
        public int CodigoDescuentoLey { get; set; }
        public int CodigoPersona { get; set; }
        public int PorDesLeyTrabajador { get; set; }
        public int PorDesLeyPatrono { get; set; }
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public string Complemento4 { get; set; } = String.Empty;
        public string Complemento5 { get; set; } = String.Empty;
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }

        public virtual NomDescuentoLey CodigoDescuentoLeyNavigation { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
    }
}
