namespace MyPrivateFinance
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payments
    {
        public int Id { get; set; }

        [StringLength(45)]
        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public bool IsIncome { get; set; }

        public int CategoryId { get; set; }

        public virtual Categories Categories { get; set; }
    }
}
