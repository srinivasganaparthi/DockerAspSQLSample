using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DockerAspSQLSample.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string Text { get; set; }
    }
}
