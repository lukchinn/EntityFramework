using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Model
{
    public class orderh
    {
        [Key]
        public int id { get; set; }

        [MaxLength(50)]
        public string doc_no { get; set; }
        public DateTime doc_date { get; set; }
        public double amount { get; set; }
        public double vat { get; set; }
        public double net_amount { get; set; }
        [ForeignKey("custumerid")]
        public int custumerid { get; set; }
        public customer customer { get; set; }
       
    }
   
}
