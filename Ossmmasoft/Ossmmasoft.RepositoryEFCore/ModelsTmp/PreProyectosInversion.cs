using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreProyectosInversion
    {
        public decimal? CodigoProyectoInv { get; set; }
        public decimal? Ano { get; set; }
        public decimal? Escenario { get; set; }
        public decimal? CodigoIcp { get; set; }
        public decimal? FinanciadoId { get; set; }
        public string CodigoObra { get; set; }
        public string Denominacion { get; set; }
        public decimal? CodigoFuncionario { get; set; }
        public DateOnly? FechaIni { get; set; }
        public DateOnly? FechaFin { get; set; }
        public decimal? SituacionId { get; set; }
        public decimal? Costo { get; set; }
        public decimal? CompromisoAnterior { get; set; }
        public decimal? CompromisoVigente { get; set; }
        public decimal? EjecutadoAnterior { get; set; }
        public decimal? EjecutadoVigente { get; set; }
        public decimal? EstimadaPresupuesto { get; set; }
        public decimal? EstimadaPosterior { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public decimal? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public decimal? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
        public string Funcionario { get; set; }
    }
}
