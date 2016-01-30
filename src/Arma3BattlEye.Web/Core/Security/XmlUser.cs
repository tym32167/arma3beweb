using System;
using System.Xml.Serialization;
using Arma3BattlEye.Web.Core.Data.Contract;

namespace Arma3BattlEye.Web.Core.Security
{
    [Serializable]
    public class XmlUser : IEntity<string>
    {
        [XmlAttribute]
        public string Id { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Password { get; set; }

        public string[] Roles { get; set; }
    }
}