// See https://aka.ms/new-console-template for more information
using System.Xml;

XmlDocument doc = new XmlDocument();
doc.Load("C:\\Sample\\XML\\XML.xml");

// find a node - here the one with name='abc'
var nodes = doc.SelectNodes("/root/data");

foreach (XmlNode node in nodes)
{
    if (node != null)
    {
        var value = node.Attributes["name"].Value;

        if (!value.EndsWith(".Location"))
        {
            continue;
        }

        // get its parent node
        XmlNode parent = node.ParentNode;

        // remove the child node
        parent.RemoveChild(node);
    }
}



// verify the new XML structure
string newXML = doc.OuterXml;

// save to file or whatever....
doc.Save(@"C:\Sample\XML\new.xml");
