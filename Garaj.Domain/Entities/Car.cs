using Garaj.Domain.Entities.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaj.Domain.Entities
{
    public class Car
    {
        public Guid Id = Guid.NewGuid();
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid OwnerId { get; set; }
        public bool isSold { get; set; } = false;

        [ForeignKey(nameof(OwnerId))]
        public virtual User Owner { get; set; }

    }
}
