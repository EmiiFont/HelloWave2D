using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using WaveEngine.Common.Math;
using WaveEngine.Components.Animation;

namespace WaveEngineGame5Project
{
    class RyuXml : ISpriteSheetLoader
    {
        public Rectangle[] Parse(string path)
        {
            var xml = XDocument.Load(path);
            var animation = xml.Descendants(XName.Get("sprite"))
                .Select(l => new Rectangle
                                 {
                                     X = int.Parse(l.Attribute("x").Value),
                                     Y = int.Parse(l.Attribute("y").Value),
                                     Height = int.Parse(l.Attribute("h").Value),
                                     Width = int.Parse(l.Attribute("w").Value),
                                 }).ToArray();
            return animation;
        }
    }
}
