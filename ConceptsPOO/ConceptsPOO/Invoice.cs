namespace ConceptsPOO
{
    public class Invoice : Ipay
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public float Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal GetValueTopay()
        {
            return Price * (decimal)Quantity;
        }
        public override string ToString()
        {
            return $"{Id} - {Description} " +
                    $"\n\tQuantity..........: {$"{Quantity:N2}",20}" +
                    $"\n\tPrice.............: {$"{Price:C2}",20}" +
                    $"\n\tValue.............: {$"{GetValueTopay():C2}",20}";
        }
    }
}
