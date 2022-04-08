using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class PreDescriptiva
    {
        public PreDescriptiva()
        {
            NomEscalaUtilEscolars = new HashSet<NomEscalaUtilEscolar>();
            PreCargoTipoCargos = new HashSet<PreCargo>();
            PreCargoTipoPersonals = new HashSet<PreCargo>();
            PreModificacions = new HashSet<PreModificacion>();
            PreOrganismos = new HashSet<PreOrganismo>();
            PreSaldos = new HashSet<PreSaldo>();
            PreSolModificacions = new HashSet<PreSolModificacion>();
            PreTransferencia = new HashSet<PreTransferencia>();
        }

        public decimal Id { get; set; }
        public decimal? DescripcionPadreId { get; set; }
        public decimal? PreTituloId { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public string Complemento1 { get; set; }
        public string Complemento2 { get; set; }
        public string Complemento3 { get; set; }
        public decimal? UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public decimal? UsuarioActuualizacion { get; set; }
        public DateOnly? FfechaActualizacion { get; set; }
        public decimal? CodigoEmpresa { get; set; }
        public string Complemento4 { get; set; }
        public string Complemento5 { get; set; }

        public virtual PreTitulo PreTitulo { get; set; }
        public virtual ICollection<NomEscalaUtilEscolar> NomEscalaUtilEscolars { get; set; }
        public virtual ICollection<PreCargo> PreCargoTipoCargos { get; set; }
        public virtual ICollection<PreCargo> PreCargoTipoPersonals { get; set; }
        public virtual ICollection<PreModificacion> PreModificacions { get; set; }
        public virtual ICollection<PreOrganismo> PreOrganismos { get; set; }
        public virtual ICollection<PreSaldo> PreSaldos { get; set; }
        public virtual ICollection<PreSolModificacion> PreSolModificacions { get; set; }
        public virtual ICollection<PreTransferencia> PreTransferencia { get; set; }
    }
}
