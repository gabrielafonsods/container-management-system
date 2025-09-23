namespace GerenciadorBLContainer.Models
{
    // Bruno Souza (CB3025411)
    // Gabriela Wandenkolk (CB3026108)
    public class BL
    {
        public int ID { get; set; }
        public string Numero { get; set; }
        public string Consignee { get; set; }
        public string Navio { get; set; }

        public virtual ICollection<Container> Containers { get; set; }
    }
}
