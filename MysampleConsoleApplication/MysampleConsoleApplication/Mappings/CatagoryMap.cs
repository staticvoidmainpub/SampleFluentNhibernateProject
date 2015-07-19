using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MysampleConsoleApplication.Model;

namespace MysampleConsoleApplication.Mappings
{
    class CatagoryMap : ClassMap<Catagory>
    {
        public CatagoryMap()
        { 
        Id(id => id.CatagoryID);
        Map(x=>x.Name);
        }
    }
}
