using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomVacacionesContrato
    {
        public decimal Id { get; set; }
        public decimal? NumeroAño { get; set; }
        public decimal? DiasHabiles { get; set; }
        public decimal? DiasBono { get; set; }
        public decimal? TipoNominaId { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomDescriptiva TipoNomina { get; set; }
    }
}
