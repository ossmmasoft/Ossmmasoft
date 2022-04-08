using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreCargo
    {
        public PreCargo()
        {
            NomRelacionCargos = new HashSet<NomRelacionCargo>();
        }

        public decimal Id { get; set; }
        public decimal? TipoPersonalId { get; set; }
        public decimal? TipoCargoId { get; set; }
        public string Denominacion { get; set; }
        public string Descripcion { get; set; }
        public decimal? Grado { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public decimal? CodigoPresupuesto { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual PreDescriptiva TipoCargo { get; set; }
        public virtual PreDescriptiva TipoPersonal { get; set; }
        public virtual ICollection<NomRelacionCargo> NomRelacionCargos { get; set; }
    }
}
