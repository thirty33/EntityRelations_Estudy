using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityRelations_EstudyOne.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
        public DateTime CreationDate { get; set; }
        public int UserForeingKey { get; set; }

        [ForeignKey("BlogForeignKey")]
        public User User { get; set; }
    }
}
