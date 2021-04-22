using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleReflaction.DaoReflaction
{
    public interface IQueryBuilder<TClass>
        where TClass: class
    {
        string Insert();
        string Update();
        string Delete();
        string Select();
    }
}
