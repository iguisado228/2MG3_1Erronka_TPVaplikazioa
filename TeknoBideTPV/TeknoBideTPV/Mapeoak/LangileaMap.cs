using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TeknoBideTPV.Domain;

namespace TeknoBideTPV.Mappings
{
    public class LangileaMap : ClassMap<Langilea>
    {
        public LangileaMap() 
        {
            Table("langileak");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Izena);
            Map(x => x.Erabiltzaile_izena);
            Map(x => x.Pasahitza);
            Map(x => x.Gerentea);
        }
    }
}
