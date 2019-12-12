using Microsoft.Glee.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MainFormUI
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        Graph graph;
        public MainForm()
        {
            InitializeComponent();
        }
        struct Edge
        {
            public int u, v;
        }

        static int[,] graphArr; 
        static List<int> MiST;
        static List<int> MaST;
        static List<Edge> minEdges;
        List<Edge> minEdge;
        int[] minLbl;
        static List<Edge> maxEdges;
        List<Edge> maxEdge;
        int[] maxLbl;

        public void MinKruskal()
        {
            int n = graphArr.GetLength(0);

            for (int i = 0; i < minEdge.Count - 1; i++)
            {
                for (int j = i + 1; j < minEdge.Count; j++)
                {
                    if (CompareEdge(minEdge[i], minEdge[j]) == 1)
                    {
                        Edge t = minEdge[i];
                        minEdge[i] = minEdge[j];
                        minEdge[j] = t;
                    }
                }
            }

            foreach (Edge e in minEdge)
            {
                if (minLbl[e.u] != minLbl[e.v])
                {
                    minEdges.Add(e);
                    string str = "Adding (" + e.u + ", " + e.v + ") to MiST nodes";
                    minTb.AppendText(str + Environment.NewLine);

                    if (!MiST.Contains(e.u)) MiST.Add(e.u);
                    if (!MiST.Contains(e.v)) MiST.Add(e.v);

                    int MainForm = (minLbl[e.u] < minLbl[e.v]) ? minLbl[e.u] : minLbl[e.v]; 
                    int lab2 = (minLbl[e.u] > minLbl[e.v]) ? minLbl[e.u] : minLbl[e.v];
                    for (int i = 0; i < n; i++)
                    {
                        if (minLbl[i] == lab2) minLbl[i] = MainForm;
                    }
                }
            }
        }

        public void MaxKruskal()
        {
            int n = graphArr.GetLength(0);

            for (int i = 0; i < maxEdge.Count - 1; i++)
            {
                for (int j = i + 1; j < maxEdge.Count; j++)
                {
                    if (CompareEdge(maxEdge[i], maxEdge[j]) == -1)
                    {
                        Edge t = maxEdge[i];
                        maxEdge[i] = maxEdge[j];
                        maxEdge[j] = t;
                    }
                }
            }

            foreach (Edge e in maxEdge)
            {
                if (maxLbl[e.u] != maxLbl[e.v])
                {
                    maxEdges.Add(e);
                    string str = "Adding (" + e.u + ", " + e.v + ") to MaST nodes";
                    maxTb.AppendText(str + Environment.NewLine);

                    if (!MaST.Contains(e.u)) MaST.Add(e.u);
                    if (!MaST.Contains(e.v)) MaST.Add(e.v);

                    int MainForm = (maxLbl[e.u] < maxLbl[e.v]) ? maxLbl[e.u] : maxLbl[e.v];
                    int lab2 = (maxLbl[e.u] > maxLbl[e.v]) ? maxLbl[e.u] : maxLbl[e.v];
                    for (int i = 0; i < n; i++)
                    {
                        if (maxLbl[i] == lab2) maxLbl[i] = MainForm;
                    }
                }
            }
        }

        static int CompareEdge(Edge e1, Edge e2)
        {
            if (graphArr[e1.u, e1.v] > graphArr[e2.u, e2.v]) return 1;
            else if (graphArr[e1.u, e1.v] == graphArr[e2.u, e2.v]) return 0;
            return -1;
        }

        public void Initialization()
        {
            MiST = new List<int>();
            MaST = new List<int>();
            minEdges = new List<Edge>();
            maxEdges = new List<Edge>();
        }

        public void Output()
        {
            int min = 0;
            int max = 0;
            minTb.AppendText("MiST: ");
            maxTb.AppendText("MaST: ");
            foreach (int i in MiST)
            {
               minTb.AppendText(i + " ");
            }
            minTb.AppendText(Environment.NewLine);
            foreach (int i in MaST)
            {
                maxTb.AppendText(i + " ");
            }
            maxTb.AppendText(Environment.NewLine);

            minTb.AppendText("MiST nodes: " + Environment.NewLine);
            maxTb.AppendText("MaST nodes: " + Environment.NewLine);
            foreach (Edge e in minEdges)
            {
                string str = "(" + e.u + ", " + e.v + ")";
                minTb.AppendText(str + Environment.NewLine);
                min += graphArr[e.u, e.v];
            }
            foreach (Edge e in maxEdges)
            {
                string str = "(" + e.u + ", " + e.v + ")";
                maxTb.AppendText(str + Environment.NewLine);
                max += graphArr[e.u, e.v];
            }
            minTb.AppendText("MiST weight: " + min + Environment.NewLine);
            maxTb.AppendText("MaST weight: " + max + Environment.NewLine);
        }

        private void readfileBtn_Click(object sender, EventArgs e)
        {
            ofd.FileName = "";
            ofd.Filter = "Text documents (*.txt) | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                graphRb.Checked = true;
                graph = new Graph("graph");
                fileTb.Clear();
                minTb.Clear();
                maxTb.Clear();
                string fileArr;
                fileLbl.Text = ofd.SafeFileName;
                fileArr = File.ReadAllText(ofd.FileName);
                int size = fileArr.Split('\n').Length;
                graphArr = new int[size, size];
                int i = 0, j = 0;
                foreach (var row in fileArr.Split('\n'))
                {
                    j = 0;
                    foreach (var col in row.Trim().Split(' '))
                    {
                        graphArr[i, j] = int.Parse(col.Trim());
                        j++;
                    }
                    i++;
                }

                i = 0; j = 0;
                foreach (var row in fileArr.Split('\n'))
                {
                    fileTb.AppendText(row.Trim() + Environment.NewLine);
                    i++;
                }

                int n = graphArr.GetLength(0);

                minEdge = new List<Edge>();
                minLbl = new int[n];
                maxEdge = new List<Edge>();
                maxLbl = new int[n];
                for (i = 0; i < n; i++)
                {
                    minLbl[i] = i;
                    maxLbl[i] = i;
                    for (j = i + 1; j < n; j++)
                    {
                        if (graphArr[i, j] != 0)
                        {
                            Edge edge = new Edge();
                            edge.u = i; edge.v = j;
                            minEdge.Add(edge);
                            maxEdge.Add(edge);
                        }
                    }
                }

                minTb.AppendText("Node and weight: (u, v) : w" + Environment.NewLine);
                maxTb.AppendText("Node and weight: (u, v) : w" + Environment.NewLine);
                foreach (Edge edge in minEdge)
                {
                    string str = "(" + edge.u + ", " + edge.v + ") : " + graphArr[edge.u, edge.v];
                    graph.AddEdge(edge.u.ToString(), graphArr[edge.u,edge.v].ToString(), edge.v.ToString());
                    minTb.AppendText(str + Environment.NewLine);
                    maxTb.AppendText(str + Environment.NewLine);
                }

                foreach (var edge in graph.Edges)
                {
                    edge.Attr.ArrowHeadAtTarget = ArrowStyle.None;
                    edge.Attr.LineWidth = 2;
                }

                graph.GraphAttr.Orientation = Microsoft.Glee.Drawing.Orientation.Landscape;
                graph.GraphAttr.LayerDirection = LayerDirection.LR;
                graphViewer.OutsideAreaBrush = Brushes.White;
                graphViewer.Graph = graph;

                minTb.AppendText(Environment.NewLine);
                maxTb.AppendText(Environment.NewLine);
            }
        }

        private void fullkruscalBtn_Click(object sender, EventArgs e)
        {
            Initialization();
            MinKruskal();
            MaxKruskal();
            Output();
            graphrbMp.Enabled = true;
        }

        private void graphRb_CheckedChanged(object sender, EventArgs e)
        {
            if (graphRb.Checked)
            {
                foreach (var edge in graph.Edges)
                {
                    edge.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.TargetNode.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.SourceNode.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.Attr.Fontcolor = Microsoft.Glee.Drawing.Color.Black;
                }

                graphViewer.Refresh();
            }
        }

        private void graph_minRb_CheckedChanged(object sender, EventArgs e)
        {
            if (graph_minRb.Checked)
            {
                foreach (var edge in graph.Edges)
                {
                    edge.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.TargetNode.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.SourceNode.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.Attr.Fontcolor = Microsoft.Glee.Drawing.Color.Black;
                }


                if (minEdges.Count > 0)
                {
                    foreach (var edge in graph.Edges)
                    {
                        foreach (var min_e in minEdges)
                        {
                            if (edge.Source == min_e.u.ToString() && edge.Target == min_e.v.ToString())
                            {
                                edge.Attr.Color = Microsoft.Glee.Drawing.Color.Green;
                                edge.Attr.Fontcolor = Microsoft.Glee.Drawing.Color.Green;
                                edge.TargetNode.Attr.Color = Microsoft.Glee.Drawing.Color.Green;
                                edge.SourceNode.Attr.Color = Microsoft.Glee.Drawing.Color.Green;
                            }
                        }
                    }
                }

            }
            graphViewer.Refresh();
        }

        private void graph_maxRb_CheckedChanged(object sender, EventArgs e)
        {
            if (graph_maxRb.Checked)
            {
                foreach (var edge in graph.Edges)
                {
                    edge.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.TargetNode.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.SourceNode.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.Attr.Fontcolor = Microsoft.Glee.Drawing.Color.Black;
                }

                if (maxEdges.Count > 0)
                {
                    foreach (var edge in graph.Edges)
                    {
                        foreach (var max_e in maxEdges)
                        {
                            if (edge.Source == max_e.u.ToString() && edge.Target == max_e.v.ToString())
                            {
                                edge.Attr.Color = Microsoft.Glee.Drawing.Color.Red;
                                edge.Attr.Fontcolor = Microsoft.Glee.Drawing.Color.Red;
                                edge.TargetNode.Attr.Color = Microsoft.Glee.Drawing.Color.Red;
                                edge.SourceNode.Attr.Color = Microsoft.Glee.Drawing.Color.Red;
                            }
                        }
                    }
                }

                graphViewer.Refresh();
            }
                
        }
    }
}
