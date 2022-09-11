using System;
using System.Drawing;

namespace Course_Work_RegularGraph
{
    static public class Logic
    {
        /// <summary>
        /// Введення вершин у граф та його відмальовування
        /// </summary>
        /// <param name="g"></param> 
        /// <param name="p"></param>
        /// <param name="LAngleDist"></param>
        /// <param name="num"></param>
        /// <param name="graph"></param>
        /// <param name="vertNumMax"></param>
        /// <param name="VertexColor"></param>
        /// <returns></returns>
        static public bool EnterGraphVertex(ref Graphics g, PointF p, float LAngleDist, ref int num, ref Graph graph, int vertNumMax) {
            if (graph.vertex.Count < vertNumMax) 
            {
                p = new PointF(p.X,p.Y);
                for (int i = 0; i < graph.vertex.Count; i++)
                    if (graph.vertex[i].Item2.X < p.X + LAngleDist / (float)0.707 && graph.vertex[i].Item2.X > p.X - LAngleDist / (float)0.707 &&
                    graph.vertex[i].Item2.Y < p.Y + LAngleDist / (float)0.707 && graph.vertex[i].Item2.Y > p.Y - LAngleDist / (float)0.707) return false;

                graph.vertex.Add(new Tuple<string, PointF>(num.ToString(), p));
                g.FillEllipse(new Pen(Color.Azure).Brush, p.X - LAngleDist, p.Y - LAngleDist, 2 * LAngleDist / (float)1.414, 2 * LAngleDist / (float)1.414);
                g.DrawString(num.ToString(), new Font("Calibri", 10), new Pen(Color.Black).Brush, p.X - LAngleDist * (float)0.8, p.Y - LAngleDist * (float)0.8);
                num++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Повне перемальовування вершин з написами 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="LAngleDist"></param>
        /// <param name="graph"></param>
        /// <returns></returns>
        static public Graphics reDrawAllVertex(Graphics g, float LAngleDist, Graph graph) {
            for (int i = 0; i < graph.vertex.Count;i++)
            {
                g.FillEllipse(new Pen(Color.Azure).Brush, graph.vertex[i].Item2.X - LAngleDist, graph.vertex[i].Item2.Y - LAngleDist, 2 * LAngleDist / (float)1.414, 2 * LAngleDist / (float)1.414);
                g.DrawString(graph.vertex[i].Item1.ToString(), new Font("Calibri", 10), new Pen(Color.Black).Brush, graph.vertex[i].Item2.X - LAngleDist * (float)0.8, graph.vertex[i].Item2.Y - LAngleDist * (float)0.8);
            }
            return g;
        }

        /// <summary>
        /// Видалення вершини з графу та її замальовування у колір фону 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <param name="LAngleDist"></param>
        /// <param name="num"></param>
        /// <param name="graph"></param>
        /// <param name="BackGround"></param>
        /// <returns></returns>
        static public Graphics RemoveGraphVertexClick(Graphics g, PointF p, float LAngleDist, int num, ref Graph graph, Color BackGround)
        {
            for (int i = 0; i < graph.vertex.Count; i++) {
                if (graph.vertex[i].Item2.X < p.X + LAngleDist / (float)1.414 && graph.vertex[i].Item2.X > p.X - LAngleDist / (float)1.414 &&
                    graph.vertex[i].Item2.Y < p.Y + LAngleDist / (float)1.414 && graph.vertex[i].Item2.Y > p.Y - LAngleDist / (float)1.414)
                {
                    //Видалення всіх ребер, в яку входе вершина
                    for (int j = 0; j < graph.edge.Count; j++)
                    {
                        if (graph.edge[j].Item2 == graph.vertex[i].Item1 || graph.edge[j].Item1 == graph.vertex[i].Item1)
                        {
                            graph.edge.Remove(graph.edge[j]);
                            j--;
                        }
                    }

                    g.Clear(BackGround);
                    reDrawEdges(g, 15, graph);
                    graph.vertex.Remove(graph.vertex[i]);
                    reDrawAllVertex(g, 15, graph);
                    return g;
                }
            }
            return g;
        }

        /// <summary>
        /// Введення ребра у граф та його відмальовування 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="beginV"></param>
        /// <param name="endV"></param>
        /// <param name="LAngleDist"></param>
        /// <param name="graph"></param>
        /// <returns></returns>
        static public Graphics AddEdge(Graphics g, string beginV, string endV, float LAngleDist, ref Graph graph) {
            graph.edge.Add(new Tuple<string, string>(beginV, endV));

            PointF beginC, endC;
            bool check1, check2;
            check1 = check2 = false;
            beginC = endC = new PointF(0, 0);
            for (int i = 0; i < graph.vertex.Count; i++) {
                if (graph.vertex[i].Item1 == beginV) { beginC = graph.vertex[i].Item2; check1 = true; }
                if (graph.vertex[i].Item1 == endV) { endC = graph.vertex[i].Item2; check2 = true; }
                if (check1 && check2) break;
            }

            if (!(check1 && check2)) return g;
            
            //Здвиг точки кінця ребра до окружності з центру
            float r = (float)Math.Sqrt((endC.X - beginC.X) * (endC.X - beginC.X) + ((endC.Y - beginC.Y) * (endC.Y - beginC.Y)));
            endC = new PointF(endC.X + (beginC.X - endC.X)*LAngleDist / r, endC.Y + (beginC.Y - endC.Y) *LAngleDist / r);

            g.DrawLine(new Pen(Color.Black), beginC.X - (float)4.5, beginC.Y - (float)4.5, endC.X - (float)4.5, endC.Y - (float)4.5);

            reDrawAllVertex(g, LAngleDist, graph);
            return g;
        }

        /// <summary>
        /// Виделання ребра та подальше перемальвування всього графу
        /// </summary>
        /// <param name="g"></param>
        /// <param name="beginV"></param>
        /// <param name="endV"></param>
        /// <param name="graph"></param>
        /// <param name="backGround"></param>
        /// <returns></returns>
        static public Graphics removeEdge(Graphics g, string beginV, string endV, ref Graph graph, Color backGround)
        {
            graph.edge.Remove((new Tuple<string,string>(beginV,endV)));
            g.Clear(backGround);
            reDrawEdges(g, 15, graph);
            reDrawAllVertex(g, 15, graph);
            return g;
        }

        /// <summary>
        /// Перемальовування всіх ребер графу
        /// </summary>
        /// <param name="g"></param>
        /// <param name="LAngleDist"></param>
        /// <param name="graph"></param>
        /// <returns></returns>
        static public Graphics reDrawEdges(Graphics g, float LAngleDist, Graph graph) {
            for (int i = 0; i < graph.edge.Count;i++) {
                PointF beginC, endC;
                bool check1, check2;
                check1 = check2 = false;
                beginC = endC = new PointF(0, 0);
                for (int j = 0; j < graph.vertex.Count; j++)
                {
                    if (graph.vertex[j].Item1 == graph.edge[i].Item1) { beginC = graph.vertex[j].Item2; check1 = true; }
                    if (graph.vertex[j].Item1 == graph.edge[i].Item2) { endC = graph.vertex[j].Item2; check2 = true; }
                    if (check1 && check2) break;
                }
                if (!(check1 && check2)) return g;

                float r = (float)Math.Sqrt((endC.X - beginC.X) * (endC.X - beginC.X) + ((endC.Y - beginC.Y) * (endC.Y - beginC.Y)));
                endC = new PointF(endC.X + (beginC.X - endC.X) * LAngleDist / r, endC.Y + (beginC.Y - endC.Y) * LAngleDist / r);

                g.DrawLine(new Pen(Color.Black), beginC.X - (float)4.5, beginC.Y - (float)4.5, endC.X - (float)4.5, endC.Y - (float)4.5);
            }
            return g;
        }

        /// <summary>
        /// Генерація довільного графа з вказаною кількістю ребер та вершин
        /// </summary>
        /// <param name="g"></param>
        /// <param name="graph"></param>
        /// <param name="vertex_num"></param>
        /// <param name="edge_num"></param>
        /// <param name="pictureBoxHeight"></param>
        /// <param name="pictureBoxWidth"></param>
        /// <param name="LAngleDist"></param>
        /// <param name="BackGround"></param>
        /// <param name="VertexColor"></param>
        /// <returns></returns>
        static public Graphics randGeneration(ref Graphics g, ref Graph graph, int vertex_num, int edge_num, int pictureBoxHeight, int pictureBoxWidth, float LAngleDist, Color BackGround) {
            Random rand = new Random();
            graph = new Graph();
            g.Clear(BackGround);
            int num = 1; 
            string beginV, endV;
            for (int i = 0; i < vertex_num; i++)
                if(!EnterGraphVertex(ref g, new Point(rand.Next((int)LAngleDist,pictureBoxWidth- (int)LAngleDist ), rand.Next((int)LAngleDist,pictureBoxHeight- (int)LAngleDist)), LAngleDist, ref num,ref graph,vertex_num)) i--;
            for (int i = 0; i < edge_num; i+=2)
            {
                beginV = graph.vertex[rand.Next(graph.vertex.Count)].Item1;
                endV = graph.vertex[rand.Next(graph.vertex.Count)].Item1;
                if (beginV != endV && !graph.edge.Contains(new Tuple<string, string>(beginV, endV)))
                {
                    graph.edge.Add(new Tuple<string, string>(beginV, endV));
                    graph.edge.Add(new Tuple<string, string>(endV, beginV));
                }
                else i-=2;
            }
            reDrawEdges(g,LAngleDist, graph);
            reDrawAllVertex(g,LAngleDist,graph);
            
            return g;
        }

        /// <summary>
        /// Генерація FI подання графу
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public static string FI_Presentation(Graph graph)
        {
            string res = "";
            foreach (Tuple<string, PointF> vert in graph.vertex)
            {
                foreach (Tuple<string, string> edge in graph.edge)
                    if (edge.Item2 == vert.Item1) res += edge.Item1 + " ";
                res += "0 ";
            }
            return res;
        }

        /// <summary>
        /// Отримати свідчення про регулярність конкретного графа
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public static int getGraphRegular(Graph graph) {
            if(graph.vertex.Count==0)return -1;
            if (graph.edge.Count==0 || graph.vertex.Count<2) return 0;

            int[] vertPower = new int[graph.vertex.Count+1];
            foreach (Tuple<string, string> edge in graph.edge)
            {
                vertPower[Convert.ToInt32(graph.getIndexFromNum(graph, edge.Item1)+1)]++;
                vertPower[Convert.ToInt32(graph.getIndexFromNum(graph, edge.Item2)+1)]++;
            }

            int check = vertPower[1];
            for (int i = 1; i < vertPower.Length; i++)
                if (vertPower[i] != check) return -1;
                else check = vertPower[i];
                
            return check/2;
        }

        /// <summary>
        /// Отримати свідчення чи два отримані графи є обидва регулярними
        /// </summary>
        /// <param name="graph1"></param>
        /// <param name="graph2"></param>
        /// <returns></returns>
        public static bool isRegularGraphSameCheck(Graph graph1, Graph graph2) {
            return (getGraphRegular(graph1) == getGraphRegular(graph2));
        }

        /// <summary>
        /// Порівняння двох графів на регулярність та отримання строки з інформацією
        /// </summary>
        /// <param name="graph1"></param>
        /// <param name="graph2"></param>
        /// <returns></returns>
        public static string regularGraphsOutputInfo(Graph graph1, Graph graph2) {
            if (isRegularGraphSameCheck(graph1, graph2))
            {
                if (getGraphRegular(graph1) != -1) return $"Графи мають одну ступінь регулярності, яка дорівнює {getGraphRegular(graph1)}";
                else if (getGraphRegular(graph1) == -1) return "Обидва графи нерегулярні";
            }
            else
            {
                if (getGraphRegular(graph1) == -1 && getGraphRegular(graph2) != -1) return $"Графи мають різну ступінь регулярності: Перший граф не є регулярним, а другий граф має ступень регулярності {getGraphRegular(graph2)}";
                else if (getGraphRegular(graph1) != -1 && getGraphRegular(graph2) == -1) return $"Графи мають різну ступінь регулярності: Перший граф має ступінь регулярності {getGraphRegular(graph1)}, а другий граф не є регулярним";
                else return $"Графи мають різну ступінь регулярності: Перший граф має ступінь регулярності {getGraphRegular(graph1)}, а другий граф має ступень регулярності {getGraphRegular(graph2)}";
            }
            return "Помилка";
        }
    }
}
