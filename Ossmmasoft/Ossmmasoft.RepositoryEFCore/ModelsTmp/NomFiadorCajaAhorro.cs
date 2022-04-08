using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomFiadorCajaAhorro
    {
        public decimal Id { get; set; }
        public decimal? CodigoPreCajaAho { get; set; }
        public decimal? CodigoPersonaFiador { get; set; }
        public decimal? MontoFianza { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacions { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }
    }
}
