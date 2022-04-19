namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomCajaAhorro
    {
        public int Id { get; set; }
        public int CodigoPersona { get; set; }
        public int CodigoPeriodoInicio { get; set; }
        public int CodigoPeriodoFin { get; set; }
        public DateOnly? FechaIngreso { get; set; }
        public DateOnly? FechaEgreso { get; set; }
        public int CodigoBanco { get; set; }
        public int TipoCuentaId { get; set; }
        public string NumeroCuenta { get; set; } = String.Empty;
        public decimal PorcAporteTrabajador { get; set; }
        public decimal PorcAportePatron { get; set; }
        public DateOnly? FechaLiq { get; set; }
        public decimal MontoLiq { get; set; }
        public int NumeroChLiq { get; set; }
        public int CodigoBancoLiq { get; set; }
        public string NumeroCuentaLiq { get; set; } = String.Empty;
        public decimal? SaldoHaber { get; set; }
        public decimal? SaldoDeuda { get; set; }
        public string Complemento1 { get; set; } = String.Empty;
        public string Complemento2 { get; set; } = String.Empty;
        public string Complemento3 { get; set; } = String.Empty;
        public int? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }

        public virtual NomPeriodo? CodigoPeriodoFinNavigation { get; set; }
        public virtual NomPeriodo? CodigoPeriodoInicioNavigation { get; set; }
        public virtual NomPersona? CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva? TipoCuenta { get; set; }
    }
}
