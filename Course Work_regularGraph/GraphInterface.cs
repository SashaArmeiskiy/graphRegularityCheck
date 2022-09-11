using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Course_Work_RegularGraph
{
    public partial class GraphInterface : Form
    {
        /// <summary>
        /// Поле збереження характеристик графу, що створений у input1
        /// </summary>
        Graph graph1 = new Graph();

        /// <summary>
        /// Поле збереження характеристик графу, що створений у input2
        /// </summary>
        Graph graph2 = new Graph();

        /// <summary>
        /// Порядкровий номер вершини, яка чекає на введення графу, що створений у input1
        /// </summary>
        int numVert1 = 1;

        /// <summary>
        /// Порядкровий номер вершини, яка чекає на введення графу, що створений у input2
        /// </summary>
        int numVert2 = 1;

        /// <summary>
        /// Відстань від центру вершини, до кута квадрата, що описує вершину
        /// </summary>
        int radius = 15;

        /// <summary>
        /// Поле збереження максимальної кількості вершин для введення
        /// </summary>
        int vertNumMax = 20;

        /// <summary>
        /// Поле збереження максимальної кількості ребер для введення
        /// </summary>
        int edgeNumMax = 50;

        /// <summary>
        /// Конструктор класу форми mainForm
        /// </summary>
        public GraphInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обробник подій, який викликає створення нової вершини graph
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void input_MouseDown(object sender, MouseEventArgs e)
        {
            if ((PictureBox)sender == input1)
            {
                Graphics g1 = input1.CreateGraphics();
                g1.SmoothingMode = SmoothingMode.AntiAlias;
                if (radioButton1.Checked)
                    if (Logic.EnterGraphVertex(ref g1, e.Location, radius, ref numVert1, ref graph1, vertNumMax))
                    {
                        updateTable(graph1, input1Matrix);
                    }
                if (radioButton2.Checked)
                {
                    Logic.RemoveGraphVertexClick(g1, e.Location, radius, numVert1, ref graph1, input1.BackColor);
                    updateTable(graph1, input1Matrix);
                }
            }
            else if ((PictureBox)sender == input2) {
                Graphics g1 = input2.CreateGraphics();
                g1.SmoothingMode = SmoothingMode.AntiAlias;
                if (radioButton4.Checked)
                    if (Logic.EnterGraphVertex(ref g1, e.Location, radius, ref numVert2, ref graph2, vertNumMax))
                        updateTable(graph2, input2Matrix);
                if (radioButton3.Checked)
                {
                    Logic.RemoveGraphVertexClick(g1, e.Location, radius, numVert2, ref graph2, input2.BackColor);
                    updateTable(graph2, input2Matrix);
                }
            }
            generalOutput.Text = Logic.regularGraphsOutputInfo(graph1, graph2);
        }

        /// <summary>
        /// Функція оновлення таблиці, яка відображає введенні ребра
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="dataGrid"></param>
        private void updateTable(Graph graph, DataGridView dataGrid) {
            dataGrid.Columns.Clear();
            for (int i = 0; i < graph.vertex.Count; i++)
            {
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn(false);
                dataGrid.Columns.Add(checkColumn);
                dataGrid.Columns[i].HeaderCell.Value = graph.vertex[i].Item1;
                dataGrid.Rows.Add();
                dataGrid.Rows[i].HeaderCell.Value = graph.vertex[i].Item1;
                dataGrid[i, i].ValueType =typeof(string);
                dataGrid[i, i].Style.BackColor = Color.Red;
            }

            for (int i = 0; i < graph.edge.Count; i++)
                for (int j = 0; j < dataGrid.Rows.Count; j++)
                    if (dataGrid.Rows[j].HeaderCell.Value.ToString() == graph.edge[i].Item1)
                        for (int k = 0; k < dataGrid.Columns.Count; k++)
                            if (dataGrid.Rows[k].HeaderCell.Value.ToString() == graph.edge[i].Item2)
                                { dataGrid[k, j].Value = true; dataGrid[k, j].Style.BackColor = Color.LightGreen; }
        }

        /// <summary>
        /// Обробник подій відмальовування всіх елементів форми, які мають бути відмальовані (input1, input2)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainForm_Paint(object sender, PaintEventArgs e)
        {
            updateTable(graph1, input1Matrix);
            updateTable(graph2, input2Matrix);

            Graphics g1 = input1.CreateGraphics();
            g1.SmoothingMode = SmoothingMode.AntiAlias;
            g1.Clear(input1.BackColor);
            Logic.reDrawEdges(g1, radius, graph1);
            Logic.reDrawAllVertex(g1, radius, graph1);

            Graphics g2 = input2.CreateGraphics();
            g2.SmoothingMode = SmoothingMode.AntiAlias;
            g2.Clear(input2.BackColor);
            Logic.reDrawEdges(g2, radius, graph2);
            Logic.reDrawAllVertex(g2, radius, graph2);
        }

        /// <summary>
        /// Обробник подій натискання на комірку таблиці, що відображає ребра графу, що створений у input, та подальший виклик функції видалення/створення ребра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((DataGridView)sender == input1Matrix)
            {
                updateTable(graph1, input1Matrix);
                Graphics g1 = input1.CreateGraphics();
                g1.SmoothingMode = SmoothingMode.AntiAlias;
                if (graph1.edge.Count < edgeNumMax)
                {
                    if (e.ColumnIndex == e.RowIndex) return;
                    else if (input1Matrix[e.ColumnIndex, e.RowIndex].Value == null || !(bool)input1Matrix[e.ColumnIndex, e.RowIndex].Value)
                    {
                        Logic.AddEdge(g1, input1Matrix.Rows[e.RowIndex].HeaderCell.Value.ToString(), input1Matrix.Columns[e.ColumnIndex].HeaderText, radius, ref graph1);
                        Logic.AddEdge(g1, input1Matrix.Columns[e.ColumnIndex].HeaderText, input1Matrix.Rows[e.RowIndex].HeaderCell.Value.ToString(), radius, ref graph1);
                        input1Matrix[e.ColumnIndex, e.RowIndex].Value = true;
                        input1Matrix[e.RowIndex, e.ColumnIndex].Value = true;
                        input1Matrix[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.LightGreen;
                        input1Matrix[e.RowIndex, e.ColumnIndex].Style.BackColor = Color.LightGreen;
                        generalOutput.Text = Logic.regularGraphsOutputInfo(graph1, graph2);
                        return;
                    }
                }
                if (input1Matrix[e.ColumnIndex, e.RowIndex].Value != null && (bool)input1Matrix[e.ColumnIndex, e.RowIndex].Value) 
                {
                    Logic.removeEdge(g1, input1Matrix.Rows[e.RowIndex].HeaderCell.Value.ToString(), input1Matrix.Columns[e.ColumnIndex].HeaderText, ref graph1, input1.BackColor);
                    Logic.removeEdge(g1,  input1Matrix.Columns[e.ColumnIndex].HeaderText, input1Matrix.Rows[e.RowIndex].HeaderCell.Value.ToString(), ref graph1, input1.BackColor);
                    input1Matrix[e.ColumnIndex, e.RowIndex].Value = false;
                    input1Matrix[e.RowIndex, e.ColumnIndex].Value = false;
                    input1Matrix[e.ColumnIndex, e.RowIndex].Style.BackColor = DataGridView.DefaultBackColor;
                    input1Matrix[e.RowIndex, e.ColumnIndex].Style.BackColor = DataGridView.DefaultBackColor;
                }
                
            }
            else if ((DataGridView)sender == input2Matrix) {
                updateTable(graph2, input2Matrix);
                Graphics g1 = input2.CreateGraphics();
                g1.SmoothingMode = SmoothingMode.AntiAlias;
                if (graph2.edge.Count < edgeNumMax)
                {
                    if (e.ColumnIndex == e.RowIndex) return;
                    else if (input2Matrix[e.ColumnIndex, e.RowIndex].Value == null || !(bool)input2Matrix[e.ColumnIndex, e.RowIndex].Value)
                    {
                        Logic.AddEdge(g1, input2Matrix.Rows[e.RowIndex].HeaderCell.Value.ToString(), input2Matrix.Columns[e.ColumnIndex].HeaderText, radius, ref graph2);
                        Logic.AddEdge(g1, input2Matrix.Columns[e.ColumnIndex].HeaderText, input2Matrix.Rows[e.RowIndex].HeaderCell.Value.ToString(), radius, ref graph2);
                        input2Matrix[e.ColumnIndex, e.RowIndex].Value = true;
                        input2Matrix[e.RowIndex, e.ColumnIndex].Value = true;
                        input2Matrix[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.LightGreen;
                        input2Matrix[e.RowIndex, e.ColumnIndex].Style.BackColor = Color.LightGreen;
                        generalOutput.Text = Logic.regularGraphsOutputInfo(graph1, graph2);
                        return;
                    }
                }
                 if (input2Matrix[e.ColumnIndex, e.RowIndex].Value != null && (bool)input2Matrix[e.ColumnIndex, e.RowIndex].Value)
                {
                    Logic.removeEdge(g1, input2Matrix.Rows[e.RowIndex].HeaderCell.Value.ToString(), input2Matrix.Columns[e.ColumnIndex].HeaderText, ref graph2, input2.BackColor);
                    Logic.removeEdge(g1, input2Matrix.Columns[e.ColumnIndex].HeaderText, input2Matrix.Rows[e.RowIndex].HeaderCell.Value.ToString(), ref graph2, input2.BackColor);
                    input2Matrix[e.ColumnIndex, e.RowIndex].Value = false;
                    input2Matrix[e.RowIndex, e.ColumnIndex].Value = false;
                    input2Matrix[e.ColumnIndex, e.RowIndex].Style.BackColor = DataGridView.DefaultBackColor;
                    input2Matrix[e.RowIndex, e.ColumnIndex].Style.BackColor = DataGridView.DefaultBackColor;
                }
            }
            generalOutput.Text = Logic.regularGraphsOutputInfo(graph1, graph2);
        }

        /// <summary>
        /// Обробник подій додавання/видалення вершини графу, що створений у input, за допомогою вводу координат з клавіатури
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyboardEnter_Click(object sender, EventArgs e)
        {
            if ((Button)sender == keyboardEnter1)
            {
                Graphics g1 = input1.CreateGraphics();
                g1.SmoothingMode = SmoothingMode.AntiAlias;
                childInputForm CIF = new childInputForm($"Введіть координату Х вершини (max = {input1.Width - (int)radius } )", 0, input1.Width - (int)radius, $"Введіть координату Y вершини (max = {input1.Height - (int)radius })", 0, input1.Height - (int)radius);
                CIF.ShowDialog();
                if (radioButton1.Checked)
                    if (!Logic.EnterGraphVertex(ref g1, new PointF(CIF.val1, CIF.val2), radius, ref numVert1, ref graph1, vertNumMax))
                        MessageBox.Show("Ви не можете поставити вершину на цій координаті!");
                    else updateTable(graph1, input1Matrix);
                if (radioButton2.Checked)
                {
                    Logic.RemoveGraphVertexClick(g1, new PointF(CIF.val1, CIF.val2), radius, numVert1, ref graph1, input1.BackColor);
                    updateTable(graph1, input1Matrix);
                }
            }

            if ((Button)sender == keyboardEnter2) {
                Graphics g1 = input2.CreateGraphics();
                g1.SmoothingMode = SmoothingMode.AntiAlias;

                childInputForm CIF = new childInputForm($"Введіть координату Х вершини (max = {input2.Width - (int)radius } )", 0, input2.Width - (int)radius, $"Введіть координату Y вершини (max = {input2.Height - (int)radius })", 0, input2.Height - (int)radius);
                CIF.ShowDialog();
                if (radioButton4.Checked)
                    if (!Logic.EnterGraphVertex(ref g1, new PointF(CIF.val1, CIF.val2), radius, ref numVert2, ref graph2, vertNumMax))
                        MessageBox.Show("Ви не можете поставити вершину на цій координаті!");
                    else updateTable(graph2, input2Matrix);
                if (radioButton3.Checked)
                {
                    Logic.RemoveGraphVertexClick(g1, new PointF(CIF.val1, CIF.val2), radius, numVert2, ref graph2, input2.BackColor);
                    updateTable(graph2, input2Matrix);
                }
            }
            generalOutput.Text = Logic.regularGraphsOutputInfo(graph1, graph2);
        }

        /// <summary>
        /// Обробник подій, що створює довільний граф у input, за допомогою вводу кількості вершин та ребер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void randGenerateGraph_Click(object sender, EventArgs e)
        {
            if ((Button)sender == randGenerateGraph1)
            {
                if (graph1.vertex.Count == 0 || MessageBox.Show("Ця дія призведе до видалення вже введеного графа у полі. Продовжити?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    childInputForm CIF = new childInputForm(edgeNumMax, $"Введіть кількість вершин (max = {vertNumMax} )", 0, vertNumMax, $"Введіть кількість ребер (max = 0)", 0);
                    CIF.ShowDialog();
                    Graphics g1 = input1.CreateGraphics();
                    g1.SmoothingMode = SmoothingMode.AntiAlias;
                    Logic.randGeneration(ref g1, ref graph1, CIF.val1, CIF.val2, input1.Height, input1.Width, radius, input1.BackColor);
                    numVert1 = CIF.val1 + 1;
                    updateTable(graph1, input1Matrix);
                }
            }
            else if ((Button)sender == randGenerateGraph2) {
                if (graph2.vertex.Count == 0 || MessageBox.Show("Ця дія призведе до видалення вже введеного графа у полі. Продовжити?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    childInputForm CIF = new childInputForm(edgeNumMax, $"Введіть координату кількість вершин (max = {vertNumMax} )", 0, vertNumMax, $"Введіть кількість ребер (max = 0)", 0);
                    CIF.ShowDialog();
                    Graphics g1 = input2.CreateGraphics();
                    g1.SmoothingMode = SmoothingMode.AntiAlias;
                    Logic.randGeneration(ref g1, ref graph2, CIF.val1, CIF.val2, input2.Height, input2.Width, radius, input2.BackColor);
                    numVert2 = CIF.val1 + 1;
                    updateTable(graph2, input2Matrix);
                }
            }
            generalOutput.Text = Logic.regularGraphsOutputInfo(graph1, graph2);
        }

        /// <summary>
        /// Обробник подій, що видаляє граф у input та стирає input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            if ((Button)sender == clear1Button)
            {
                numVert1 = 1;
                Graphics g1 = input1.CreateGraphics();
                g1.SmoothingMode = SmoothingMode.AntiAlias;
                graph1 = new Graph();
                input1Matrix.Columns.Clear();
                g1.Clear(input1.BackColor);
            }
            else if ((Button)sender == clear2Button) {
                numVert2 = 1;
                Graphics g1 = input2.CreateGraphics();
                graph2 = new Graph();
                input2Matrix.Columns.Clear();
                g1.Clear(input2.BackColor);
            }
            generalOutput.Text = Logic.regularGraphsOutputInfo(graph1, graph2);
        }

        /// <summary>
        /// Обробник подій, що виводить коротку інформацію щодо програми та автора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Програма створена для побудови графів та визначення характеристики регулярності графа, а також формує FI подання графу{Environment.NewLine}{Environment.NewLine}" +
                $"Програма має обмеження на кількість вершин, що вводяться - 20 вершин і на кількість ребер - 50 ребер. Якщо після натискання на СheckBox комірка не розфарбувалась зеленим, то ребро не додадано та при наступному оновлені таблиці галочка зникне{Environment.NewLine}{Environment.NewLine}" +
                $"Програма та супутні матеріали були написані студентом Національного аерокосмічного університету ім.М.Є.Жуковського \"Харківський авіаційний інститут\" групи 525В Армейським А.О. під кураторством наукового керівника Дуже В.В. для курсової роботи у 2022 р.","Про програму",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void RegularCheck_Click(object sender, EventArgs e)
        {
            if ((Button)sender == RegularCheck1)
                if (Logic.getGraphRegular(graph1) != -1) MessageBox.Show($"Граф є {Logic.getGraphRegular(graph1)} - регулярним");
                else MessageBox.Show("Граф HE є регулярним");
            else
                if (Logic.getGraphRegular(graph2) != -1) MessageBox.Show($"Граф є {Logic.getGraphRegular(graph2)} - регулярним");
                else MessageBox.Show("Граф HE є регулярним");
        }

        private void FI_Presentation_Click(object sender, EventArgs e)
        {
            if((Button)sender== FI_Presentation1)
            MessageBox.Show($"FI подання графу: <{Logic.FI_Presentation(graph1)}>");
            else MessageBox.Show($"FI подання графу: <{Logic.FI_Presentation(graph2)}>");
        }
    }
}
