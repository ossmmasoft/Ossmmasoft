namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomPromociones
    {
        public int Id { get; set; }
        public int CodigoPersona { get; set; }
        public int CodigoRelacionCargoOld { get; set; }
        public int CodigoRelacionCargoNew { get; set; }
        public string NumeroOficio { get; set; } = string.Empty;
        public DateOnly? FechaOficio { get; set; }
        public string Observacion { get; set; } = string.Empty;
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
        public int? IsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoEmpresa { get; set; }


        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomRelacionCargo CodigoRelacionCargoNewNavigation { get; set; }
        public virtual NomRelacionCargo CodigoRelacionCargoOldNavigation { get; set; }
    }
}
