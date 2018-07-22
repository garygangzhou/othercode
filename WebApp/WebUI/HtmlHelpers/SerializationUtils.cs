using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace WebUI.HtmlHelpers
{
    public class SerializationUtils
    {
        public static string Serialize(object obj)
        {
            // Note: obj must be marked [Serializable] or implement ISerializable
            StringWriter writer = new StringWriter();
            new LosFormatter().Serialize(writer, obj);
            return writer.ToString();
        }
        public static object Deserialize(string data)
        {
            if (data == null)
                return null;
            return (new LosFormatter()).Deserialize(data);
        }
    }
}
