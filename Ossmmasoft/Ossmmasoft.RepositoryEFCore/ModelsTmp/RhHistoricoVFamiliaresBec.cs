using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class RhHistoricoVFamiliaresBec
    {
        public decimal? CodigoHistoricoFamBec { get; set; }
        public decimal? CodigoFamiliar { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? CedulaFamiliar { get; set; }
        public string Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateOnly? FechaNacimiento { get; set; }
        public decimal? ParienteId { get; set; }
        public string Pariente { get; set; }
        public string Sexo { get; set; }
        public decimal? NivelEducativoId { get; set; }
        public string NivelEducativo { get; set; }
        public decimal? Grado { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public decimal? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public decimal? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoPeriodo { get; set; }
        public DateOnly? FechaNomina { get; set; }
    }
}
