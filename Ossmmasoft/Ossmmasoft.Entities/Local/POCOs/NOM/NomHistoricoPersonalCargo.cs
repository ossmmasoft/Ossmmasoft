namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomHistoricoPersonalCargo
    {
        public int Id { get; set; }
        public int? CodigoPersona { get; set; }
        public int? Cedula { get; set; }
        public string Foto { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Nacionalidad { get; set; } = string.Empty;
        public string DescripcionNacionalidad { get; set; } = string.Empty;
        public string Sexo { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string DescripcionStatus { get; set; } = string.Empty;
        public int? CodigoEmpresa { get; set; }
        public string DescripcionSexo { get; set; } = string.Empty;
        public int? CodigoRelacionCargo { get; set; }
        public int? CodigoCargo { get; set; }
        public string CargoCodigo { get; set; } = string.Empty;
        public int? CodigoIcp { get; set; }
        public int? CodigoIcpUbicacion { get; set; }
        public decimal? Sueldo { get; set; }
        public string DescripcionCargo { get; set; } = string.Empty;
        public int? CodigoTipoNomina { get; set; }
        public string TipoNomina { get; set; } = string.Empty;
        public int? FrecuenciaPagoId { get; set; }
        public string CodigoSector { get; set; } = string.Empty;
        public string CodigoPrograma { get; set; } = string.Empty;
        public int? TipoCuentaId { get; set; }
        public string DescripcionTipoCuenta { get; set; } = string.Empty;
        public int? BancoId { get; set; }
        public string DescripcionBanco { get; set; } = string.Empty;
        public string NroCuenta { get; set; } = string.Empty;
        public string Complemento1 { get; set; } = string.Empty;
        public string Complemento2 { get; set; } = string.Empty;
        public string Complemento3 { get; set; } = string.Empty;
        public string Complemento4 { get; set; } = string.Empty;
        public string Complemento5 { get; set; } = string.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int? CodigoPeriodo { get; set; }
        public DateOnly? FechaNomina { get; set; }
        public DateOnly? FechaIngreso { get; set; }

    }
}
