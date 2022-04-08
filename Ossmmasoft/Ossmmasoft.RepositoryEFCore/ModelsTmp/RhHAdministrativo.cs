using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class RhHAdministrativo
    {
        public decimal? CodigoHAdministrativo { get; set; }
        public decimal? CodigoAdministrativo { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? CargoId { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public string TipoPago { get; set; }
        public decimal? BancoId { get; set; }
        public decimal? TipoCuentaId { get; set; }
        public string NoCuenta { get; set; }
        public string Turno { get; set; }
        public decimal? ProfesionId { get; set; }
        public string Status { get; set; }
        public decimal? UsuarioIns { get; set; }
        public DateOnly? FechaIns { get; set; }
        public decimal? UsuarioHIns { get; set; }
        public DateOnly? FechaHIns { get; set; }
        public decimal? UsuarioUpd { get; set; }
        public DateOnly? FechaUpd { get; set; }
        public decimal? CodigoEmpresa { get; set; }
    }
}
