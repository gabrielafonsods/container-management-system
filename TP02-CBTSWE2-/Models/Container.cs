namespace GerenciadorBLContainer.Models
{
    // Bruno Souza (CB3025411)
    // Gabriela Wandenkolk (CB3026108)
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
