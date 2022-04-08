using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreParticipaFinancieraOrg
    {
        public decimal? CodigoParticipaFinancOrg { get; set; }
        public decimal? Ano { get; set; }
        public decimal? CodigoOrganismo { get; set; }
        public decimal? CodigoIcp { get; set; }
        public decimal? CuotaParticipacion { get; set; }
        public string Observaciones { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public decimal? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public decimal? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoPuc { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
    }
}
