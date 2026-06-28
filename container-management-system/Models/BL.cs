namespace GerenciadorBLContainer.Models
{
    // Gabriel Afonso dos Santos - CB3026167
    public class BL
    {
        public int ID { get; set; }
        public string Numero { get; set; }
        public string Consignee { get; set; }
        public string Navio { get; set; }

        public virtual ICollection<Container> Containers { get; set; }
    }
}
