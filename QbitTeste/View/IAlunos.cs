using System;
using System.Collections.Generic;
using System.Text;

namespace testeQbit.View
{
    public interface IAlunos
    {
        string NomeTxt { get; set; }
        string EmailTxt { get; set; }
        string TelefoneTxt { get; set; }
        DateTime DataDeNascimentoData { get; set; }

    }
}
