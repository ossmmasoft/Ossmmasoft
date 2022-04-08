using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomAdministrativo
    {
        public decimal Id { get; set; }
        public decimal? CodigoPersona { get; set; }
        public decimal? CargoId { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public string TipoPago { get; set; }
        public decimal? BancoId { get; set; }
        public decimal? TipoCuentaId { get; set; }
        public string NroCuenta { get; set; }
        public string Turno { get; set; }
        public decimal? ProfesionId { get; set; }
        public string Status { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual NomDescriptiva Banco { get; set; }
        public virtual NomDescriptiva Cargo { get; set; }
        public virtual NomPersona CodigoPersonaNavigation { get; set; }
        public virtual NomDescriptiva TipoCuenta { get; set; }
    }
}
