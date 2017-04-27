using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace CMSAdminWeb.WebUI.HelpClasses
{
    public static class XMLReader
    {
        public static List<XmlNode> XmlInfo(IEnumerable<XElement> elements)
        {
            List<XmlNode> nodelist = new List<XmlNode>();
            foreach(var ele in elements)
            {
                XmlNode node = new XmlNode();
                node.Nodes = new List<Node>();
                node.NodeName = ele.Attribute("Name").Value;
                var nodeRole=(ele.Attribute("Role")??ele.Attribute("Name")).Value;
                node.Role = nodeRole == node.NodeName ? "all" : nodeRole;
                node.Title= ele.Element("title").Value;
                foreach (XElement xele in ele.Elements("li"))
                {
                    Node nodee = new Node(){
                                Text = xele.Value,
                                Name = xele.Attribute("Name").Value,
                                };
                    var role =( xele.Attribute("Role") ?? xele.Attribute("Name")).Value;
                    nodee.Role=role==nodee.Name?"all":role;
                    node.Nodes.Add(nodee);
                }
                nodelist.Add(node);
            }
            return nodelist;
        }
        public static List<XmlNode> ReadXml()
        {
           string path=HttpContext.Current.Request.PhysicalApplicationPath;
            XElement xe = XElement.Load(path+"\\App_Data\\XMLSources.xml");
            IEnumerable<XElement> elements= xe.Elements("ul").Select(ele=>ele);
            return XmlInfo(elements);
        }
    }
   
    public class XmlNode
    {
        public string Title { get; set; }
        public string Role { get; set; }

        public string NodeName
        {
            get;
            set;
        }
        public List<Node> Nodes
        {
            get;
            set;
        }
    }
    public class Node
    {
        public string Text { get; set;}
        public string Name { get; set; }
        public string Role { get; set; }
    }

}