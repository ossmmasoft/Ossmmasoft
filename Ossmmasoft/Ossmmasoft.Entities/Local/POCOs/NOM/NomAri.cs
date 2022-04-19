namespace Ossmmasoft.Entities.Local.POCOs.NOM
{
    public partial class NomAri
    {
        public int Id { get; set; }
        public int CodigoPersona { get; set; }
        public DateOnly? FechaAri { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public decimal Ut { get; set; }
        public string EmpresaA { get; set; } = String.Empty;
        public string EmpresaB { get; set; } = String.Empty;
        public string EmpresaC { get; set; } = String.Empty;
        public string EmpresaD { get; set; } = String.Empty;
        public decimal AABs { get; set; }
        public decimal ABBs { get; set; }
        public decimal ACBs { get; set; }
        public decimal ADBs { get; set; }
        public decimal C1Bs { get; set; }
        public decimal C2Bs { get; set; }
        public decimal C3Bs { get; set; }
        public decimal C4Bs { get; set; }
        public decimal EUt { get; set; }
        public decimal H1Ut { get; set; }
        public decimal CargaFamiliar { get; set; }
        public decimal H3Bs { get; set; }
        public decimal K1Bs { get; set; }
        public decimal K2Bs { get; set; }
        public string Extra1 { get; set; } = String.Empty;
        public string Extra2 { get; set; } = String.Empty;
        public string Extra3 { get; set; } = String.Empty;
        public int UsuarioCreacion { get; set; }
        public DateOnly? FechaCreacion { get; set; }
        public int UsuarioActualizacion { get; set; }
        public DateOnly? FechaActualizacion { get; set; }
        public int CodigoEmpresa { get; set; }
        public decimal JPor { get; set; }
        public decimal KPor { get; set; }

        public virtual NomPersona? CodigoPersonaNavigation { get; set; }
    }
}
