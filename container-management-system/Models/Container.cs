namespace GerenciadorBLContainer.Models
{
    // Gabriel Afonso dos Santos - CB3026167
    public class Container
    {
        public int ID { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; } // Representa Dry ou Reefer
        public int Tamanho { get; set; } // Representa 20 ou 40

        public int BLId { get; set; }
        public virtual BL BL { get; set; }
    }
}
