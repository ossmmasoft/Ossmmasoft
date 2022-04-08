using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomEscalaHcm
    {
        public decimal Id { get; set; }
        public decimal? AseguradoraId { get; set; }
        public decimal? ParienteId { get; set; }
        public char? Sexo { get; set; }
        public decimal? EdadMin { get; set; }
        public decimal? EdadMax { get; set; }
        public decimal Prima { get; set; }
        public string Observacion { get; set; }
        public DateOnly? FechaDesde { get; set; }
        public DateOnly? FechaHasta { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActuaclizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }

        public virtual NomDescriptiva Aseguradora { get; set; }
        public virtual NomDescriptiva Pariente { get; set; }
    }
}
