using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomMovCajaAhorro
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public DateOnly? FechaMov { get; set; }
        public decimal? CodigoMovId { get; set; }
        public decimal? CodigoPreCajaAho { get; set; }
        public decimal? Monto { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual NomDescriptiva CodigoMov { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual PrePresupuesto CodigoPreCajaAhoNavigation { get; set; }
    }
}
