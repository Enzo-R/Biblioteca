using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QbitTeste.Models
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }
        public DateTime DataDeRetirada { get; set; }
        public DateTime DataDeEntrega { get; set; }
    }
}
