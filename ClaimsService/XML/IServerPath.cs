using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsService.XML
{
    public interface IServerPath
    {
        string MapPath(string path);
    }
}
