using System;

using System.Collections.Generic;

using System.Linq;
using System.IO;
using System.Text;

using System.Xml;

namespace Tesetxml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader(@"C:\Users\nicho\source\repos\Tesetxml\Tesetxml\bin\Debug\books.xml");
            while (reader.Read())
            {
                //   Console.WriteLine(reader.Name);

                //name of nodes
                if (reader.Name != "")
                {
                    Console.WriteLine();
                    Console.WriteLine("NAME:");
                    Console.WriteLine(reader.Name);
                }
              


                //says id names
                if (reader.GetAttribute("id") != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("ID:");
                    Console.WriteLine(reader.GetAttribute("id"));
                }
              

          
           
                /*
                                switch (reader.NodeType)
                                {
                                    case XmlNodeType.Element: // The node is an element.
                                        Console.Write("<" + reader.Name);
                                        Console.WriteLine("> is a Element " + reader.);
                                        break;
                                    case XmlNodeType.Text: //Display the text in each element.
                                        Console.WriteLine(reader.Value + " is a text");
                                        break;
                                    case XmlNodeType.Comment: //Display the end of the element.
                                        Console.Write( reader.Name);
                                        Console.WriteLine("is a comment");
                                        break;
       */
            }
            Console.ReadLine();
        }
    }
}
