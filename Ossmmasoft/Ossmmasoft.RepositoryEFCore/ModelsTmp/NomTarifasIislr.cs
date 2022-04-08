using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomTarifasIislr
    {
        public decimal Id { get; set; }
        public decimal? NumeroTarifa { get; set; }
        public decimal? TarifaMin { get; set; }
        public decimal? TarifaMax { get; set; }
        public decimal? PorTarifa { get; set; }
        public decimal? SustraendoUt { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
    }
}
