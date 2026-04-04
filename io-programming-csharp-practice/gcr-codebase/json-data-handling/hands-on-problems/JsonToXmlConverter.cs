using System;
using Newtonsoft.Json;
using System.Xml.Linq;

class JsonToXmlConverter
{
    static void Main(string[] args)
    {
        string jsonData = "{ 'name':'Aniket', 'age':23 }";

        //Converting JSON to XML
        XNode xmlOutput = JsonConvert.DeserializeXNode(jsonData, "Root");

        Console.WriteLine(xmlOutput);
    }
}
