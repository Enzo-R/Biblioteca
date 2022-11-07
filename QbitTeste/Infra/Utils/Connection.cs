using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QbitTeste.Infra.Utils
{
    public class Connection
    {
        public static string ConnectionString { get; set; } = @"Data Source=Enzo-ThinkPad\SQLEXPRESS;Initial Catalog=teste;Integrated Security=True;MultipleActiveResultSets=True;";
    }
}
