using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpiderNetAPI.Models
{
    public record MissaoAranha(
        int Id,
        string VilaoEnfrentado,
        string Localizacao,
        int NivelPerigo,
        bool Resolvido
    );
}