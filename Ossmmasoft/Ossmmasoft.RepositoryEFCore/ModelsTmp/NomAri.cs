using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomAri
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public DateOnly? FechaAri { get; set; }
        public decimal? Mes { get; set; }
        public decimal? Año { get; set; }
        public decimal Ut { get; set; }
        public string EmpresaA { get; set; }
        public string EmpresaB { get; set; }
        public string EmpresaC { get; set; }
        public string EmpresaD { get; set; }
        public decimal AABs { get; set; }
        public decimal? ABBs { get; set; }
        public decimal? ACBs { get; set; }
        public decimal? ADBs { get; set; }
        public decimal? C1Bs { get; set; }
        public decimal? C2Bs { get; set; }
        public decimal? C3Bs { get; set; }
        public decimal? C4Bs { get; set; }
        public decimal? EUt { get; set; }
        public decimal? H1Ut { get; set; }
        public decimal? CargaFamiliar { get; set; }
        public decimal? H3Bs { get; set; }
        public decimal? K1Bs { get; set; }
        public decimal? K2Bs { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? JPor { get; set; }
        public decimal? KPor { get; set; }

        public virtual NomPersona CodigoPersonaNavigation { get; set; }
    }
}
