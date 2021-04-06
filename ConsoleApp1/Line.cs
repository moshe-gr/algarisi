using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Line
    {
        public Point startLine;
        public Point endLine;
        public double lineWidth;

        public Line()
        {

        }
        public Line(Point startLine, Point endLine, double lineWidth)
        {
            this.startLine = startLine;
            this.endLine = endLine;
            this.lineWidth = lineWidth;
        }
        public override string ToString()
        {
            return "Line {start: " + startLine + ", end: " + endLine + "}";
        }
    }
}
