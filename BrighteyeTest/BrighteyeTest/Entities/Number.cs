using System.ComponentModel.DataAnnotations;

namespace BrighteyeTest
{
    public class Number
    {
        [Key]
        public int ValueId { get; private set; }
        public int Value { get; set; }
    }
}

