﻿using System;
using System.Collections.Generic;

namespace Ossmmasoft.RepositoryEFCore.ModelsTmp
{
    public partial class NomMoneda
    {
        public decimal Id { get; set; }
        public decimal? Valor { get; set; }
        public string Denominacion { get; set; }
        public decimal? TipoMonedaId { get; set; }
        public DateOnly? FechaInicioCirculacion { get; set; }
        public DateOnly? FechaFinCirculacion { get; set; }
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
    }
}