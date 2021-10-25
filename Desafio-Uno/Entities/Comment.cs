using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Uno.Entities
{
    class Comment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
    }
}
