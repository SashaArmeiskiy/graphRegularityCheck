using System;
using System.Collections.Generic;
using System.Drawing;

namespace Course_Work_RegularGraph
{
    public class Graph
    {
        /// <summary>
        /// Конструктор нового екземпляру класу Graph
        /// </summary>
        public Graph() {
            vertex = new List<Tuple<string, PointF>>();
            edge = new List<Tuple<string, string>>();
        }

        /// <summary>
        /// Конструктор нового екземпляру класу Graph на основі існуючого
        /// </summary>
        public Graph(List<Tuple<string, PointF>> v, List<Tuple<string, string>>e)
        {
            vertex = new List<Tuple<string, PointF>>();
            edge = new List<Tuple<string, string>>();

            foreach (Tuple<string, PointF> val in v)
                vertex.Add(val);
            edge = e;
        }

        /// <summary>
        /// Отримання індексу вершини, маючи номер вершини
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public int getIndexFromNum(Graph graph, string num) {
            int res = 0;
            foreach (Tuple<string, PointF> vert in graph.vertex)
                if (vert.Item1 == num) return res;
                else res++;
            return -1;
        }

        /// <summary>
        /// Поле зберігання харакетиристик вершин (назва та кордината розташування)
        /// </summary>
        public List<Tuple<string, PointF>> vertex;

        /// <summary>
        /// Поле зберіганя характеристик ребер (назва початку та назва кінця)
        /// </summary>
        public List<Tuple<string, string>> edge;
    }
}
