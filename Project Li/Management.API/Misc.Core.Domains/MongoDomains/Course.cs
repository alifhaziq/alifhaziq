using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Core.Domains.MongoDomains
{
    public class Course : BaseClass
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("shortName")] 
        public string ShortName { get; set; }
    }
}
