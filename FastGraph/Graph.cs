﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace FastGraph
{
    public class Graph
    {
        internal List<GraphNode> Nodes = new List<GraphNode>();
        internal List<Asymptote> Asymptotes = new List<Asymptote>();
        public AxesModel Axes;
        public Brush Background;

        public Graph()
        {
            Axes = new AxesModel("X", "Y");
            Background = new SolidBrush(Color.White);
        }
        public void AddNode(GraphNode node)
        {
            Nodes.Add(node);
        }
        public void AddAsymptote(Asymptote a)
        {
            Asymptotes.Add(a);
        }
        public Bitmap Render(int xStart, int yStart, int xSize, int ySize, Size imageSize)
        {
            return Rendering.Render.Image(xStart, yStart, xSize, ySize, imageSize, this);
        }
    }
}
