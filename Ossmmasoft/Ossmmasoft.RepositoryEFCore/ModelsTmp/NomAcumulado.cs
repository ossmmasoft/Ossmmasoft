using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomAcumulado
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? TipoAcumuladoId { get; set; }
        public decimal? Año { get; set; }
        public decimal? Mes { get; set; }
        public decimal Monto { get; set; }
        public string Compplemento1 { get; set; }
        public string Compplemto2 { get; set; }
        public string Compplemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? Fechacreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva TipoAcumulado { get; set; }
    }
}
