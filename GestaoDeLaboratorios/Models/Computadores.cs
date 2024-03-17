using System.ComponentModel.DataAnnotations;

namespace GestaoDeLaboratorios.Models
{
    public class Computadores
    {
        private int _id;
        private string? _marca;
        private string? _processador;
        private string? _placaMae;
        private string? _memoria;
        private string? _hd;
        private string? _numeroPatrimonio;
        private DateTime _dataCompra;

        public Computadores()
        {
            // Construtor vazio
        }

        public Computadores(int id, string marca, string processador, string placaMae, string memoria, string hd, string numeroPatrimonio, DateTime dataCompra)
        {
            _id = id;
            _marca = marca;
            _processador = processador;
            _placaMae = placaMae;
            _memoria = memoria;
            _hd = hd;
            _numeroPatrimonio = numeroPatrimonio;
            _dataCompra = dataCompra;
        }

        [Key]
        [Display(Name = "ID")]
        public int Id { get => _id; set => _id = value; }

        [Required]
        public string Marca { get => _marca; set => _marca = value; }

        [Required]
        public string Processador { get => _processador; set => _processador = value; }

        [Required]
        [Display(Name = "Placa-Mãe")]
        public string PlacaMae { get => _placaMae; set => _placaMae = value; }

        [Required]
        [Display(Name = "Memória")]
        public string Memoria { get => _memoria; set => _memoria = value; }

        [Required]
        [Display(Name = "HD")]
        public string Hd { get => _hd; set => _hd = value; }

        [Required]
        [Display(Name = "Número do Patrimônio")]
        public string NumeroPatrimonio { get => _numeroPatrimonio; set => _numeroPatrimonio = value; }

        [Required]
        [Display(Name = "Data de Compra")]
        [DataType(DataType.Date)] // Apenas a data será exibida no frontend
        public DateTime DataCompra { get => _dataCompra; set => _dataCompra = value.Date; } // Armazenar apenas a data (sem horário)
    }
}