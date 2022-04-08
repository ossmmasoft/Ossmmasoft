using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class RhHRelacionCargo
    {
        public decimal? CodigoRelacionCargo { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public decimal? CodigoIcp { get; set; }
        public decimal? CodigoIcpUbicacion { get; set; }
        public decimal? CodigoCargo { get; set; }
        public string CargoCodigo { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? Sueldo { get; set; }
        public DateOnly? FechaIni { get; set; }
        public DateOnly? FechaFin { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public decimal? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public decimal? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal CodigoRelacionCargoPre { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
        public DateOnly? FechaIniVigencia { get; set; }
        public DateOnly? FechaFinVigencia { get; set; }
        public decimal? CodigoHRelacionCargo { get; set; }
        public DateOnly? FechaInsH { get; set; }
        public decimal? UsuarioInsH { get; set; }
    }
}
