using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace game
{
    internal class Target
    {
        private int left;
        private int top;
        private SolidBrush brush;
        private int radius ;
        public int Radius { get { return radius; } set{ radius = value; } }
        private uint point_price;
        public uint Points_price { get { return point_price; } set { point_price = value;}}
        private uint time_existence = 5;

        public Target(int left, int top, int radius, Color c, uint p)
        {
            this.left = left;
            this.top = top;
            this.radius = radius;
            this.brush = new SolidBrush(c);
            this.Points_price = p;

        }

  
        public void Draw(Graphics g)
        {
            g.FillEllipse(brush, left - radius, top - radius, radius * 2, radius * 2);
        }
      

        public bool IsPointInside(int x, int y)
        {
            int dx = x - left;
            int dy = y - top;
            return dx * dx + dy * dy <= radius * radius;
        }
        public void SetPosition(int left, int top)
        {
            this.left = left;
            this.top = top;
        }
    }
   
}
