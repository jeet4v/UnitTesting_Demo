using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject
{
    public interface IRepository
    {
        string GetData(int id);
    }
}
