using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class RhTmpBecado
    {
        public decimal? CodigoPeriodo { get; set; }
        public decimal? CodigoTipoNomina { get; set; }
        public DateOnly? FechaNomina { get; set; }
        public decimal? CodigoBecado { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? CodigoFamiliar { get; set; }
        public decimal? Monto { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public decimal? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public decimal? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Observacion { get; set; }
    }
}
