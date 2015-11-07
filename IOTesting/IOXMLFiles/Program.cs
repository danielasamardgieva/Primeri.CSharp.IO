using System;
using System.Xml;
using System.Xml.Linq;

namespace IOXMLFiles
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string value = "", property = "";
			string path = System.IO.Path.Combine (AppDomain.CurrentDomain.BaseDirectory, "test.xml");

			//Прочитане на файл
			using (XmlReader reader = XmlReader.Create (path)) {
				while (reader.Read ()) {
					switch (reader.Name) {

					case "row":
						property = reader ["property"];
						value = reader.ReadInnerXml ();

						Console.WriteLine ("value= " + value);
						Console.WriteLine ("property= " + property);

						break;

					case "simpleRow":
						value = reader.ReadInnerXml ();
						Console.WriteLine ("value= " + value);

						break;

					}
				}

					}
				}
			}
}
