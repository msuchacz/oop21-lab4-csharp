using Lab4.Interfaces;

namespace Lab4.Models
{
    public class Human
    {
        public decimal Cash { get; set; }
        public IDevice Phone { get; set; }
    }
}