using System.Xml.Serialization;

namespace Oxyz.Xml.Serializable
{
    /// <summary>
    /// Определяет промежуточную точку на замкнутых и незамкнутых трассах и задает стиль для следующего участка. 
    /// </summary>
    public class CheckPoint
    {
        [XmlAttribute("x")]
        public float X { get; set; }

        [XmlAttribute("y")]
        public float Y { get; set; }

        [XmlAttribute("style")]
        public string Style { get; set; } = "";
    }
}