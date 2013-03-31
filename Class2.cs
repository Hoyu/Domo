using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace WindowsFormsApplication1
{
    class Class2
    {
        public Class2(List<Propiedades> propiedades, string img, string[] imagenes)
        {
            XmlTextWriter writer;
            writer = new XmlTextWriter("hola.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument(false);

            writer.WriteStartElement("root");

            writer.WriteStartElement("Images");
            for (int i=0;i<8 ;i++ )
            {
                writer.WriteStartElement("Img");
                writer.WriteAttributeString("id", ""+ (i+1));
                writer.WriteAttributeString("filename", imagenes[i]);
                writer.WriteEndElement();
            }

            //Comprobar cuantos planos existen e identificarlos a partir del 10
            //Implementar cuando se tengan mas planos
            writer.WriteStartElement("Img");
            writer.WriteAttributeString("id", "10");
            writer.WriteAttributeString("filename", img);
            writer.WriteEndElement();

            writer.WriteEndElement();

            writer.WriteStartElement("PageList");
            writer.WriteStartElement("Page");
            writer.WriteAttributeString("backgroundImg", img);
            writer.WriteAttributeString("name", "plantaBaja");
            foreach (Propiedades p in propiedades)
            {
                writer.WriteStartElement(p.getTipo());
                writer.WriteAttributeString("Codigo", p.getCodigo());
                writer.WriteAttributeString("X", p.getLocationX().ToString());
                writer.WriteAttributeString("Y", p.getLocationY().ToString());
                writer.WriteEndElement();
            }
           
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();

            /*writer.WriteStartElement("ejemplo");
            writer.WriteAttributeString("caca", "culo");
            writer.WriteStartElement("otro");
            writer.WriteAttributeString("caca1", "culo");
            writer.WriteElementString("nodo1", "texto del nodo1");
            writer.WriteElementString("nodo2", "texto del nodo2");
            writer.WriteEndElement();
            writer.WriteEndElement();
            //writer.WriteFullEndElement();
            writer.WriteStartElement("ejemplo1");
            writer.WriteAttributeString("caca", "culo");
            writer.WriteStartElement("otro");
            writer.WriteAttributeString("caca1", "culo");
            writer.WriteElementString("nodo1", "texto del nodo1");
            writer.WriteElementString("nodo2", "texto del nodo2");
            writer.WriteEndElement();
            writer.WriteEndElement();
            //writer.WriteFullEndElement();*/
           
            /*  XDocument miXML = new XDocument(
             new XDeclaration("1.0", "utf-8", "yes"),
             new XComment("Lista de Alumnos"),
             new XElement("Alumnos",
                                 new XElement("Alumno",
                                     new XAttribute("NoControl", "05231104"),
                                     new XElement("Nombre", "Edison García"),
                                     new XElement("Semestre", "7")),

                                  new XElement("Alumno",
                                     new XAttribute("NoControl", "05231106"),
                                     new XElement("Nombre", "Abraham Gomez García"),
                                     new XElement("Semestre", "9")),

                                 new XElement("Alumno",
                                     new XAttribute("NoControl", "05231108"),
                                     new XElement("Nombre", "Alejandre Carvajal"),
                                     new XElement("Semestre", "7")),

                                 new XElement("Alumno",
                                     new XAttribute("NoControl", "06231110"),
                                     new XElement("Nombre", "Luis Armando"),
                                     new XElement("Semestre", "10"))
                    )
             );*/
            // miXML.Save(@"C:\Users\Libre\Desktop\miXML.xml");
            // miXML.Add(new XElement("Holamellamolola", "yono"));
        }
        void CrearDocumentoXML()
        {


        }
    }
}
