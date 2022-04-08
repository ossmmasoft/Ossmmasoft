using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomHistoricoPersonalCargo
    {
        public decimal? CodigoPersona { get; set; }
        public decimal? Cedula { get; set; }
        public string Foto { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public string DescripcionNacionalidad { get; set; }
        public string Sexo { get; set; }
        public string Status { get; set; }
        public string DescripcionStatus { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string DescripcionSexo { get; set; }
        public decimal? CodigoRelacionCargo { get; set; }
        public decimal? CodigoCargo { get; set; }
        public string CargoCodigo { get; set; }
        public decimal? CodigoIcp { get; set; }
        public decimal? CodigoIcpUbicacion { get; set; }
        public decimal? Sueldo { get; set; }
        public string DescripcionCargo { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public string TipoNomina { get; set; }
        public decimal? FrecuenciaPagoId { get; set; }
        public string CodigoSector { get; set; }
        public string CodigoPrograma { get; set; }
        public decimal? TipoCuentaId { get; set; }
        public string DescripcionTipoCuenta { get; set; }
        public decimal? BancoId { get; set; }
        public string DescripcionBanco { get; set; }
        public string NroCuenta { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoPeriodo { get; set; }
        public DateOnly? FechaNomina { get; set; }
        public DateOnly? FechaIngreso { get; set; }
        public decimal Id { get; set; }
    }
}
