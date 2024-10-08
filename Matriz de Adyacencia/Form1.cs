namespace Matriz_de_Adyacencia
{
    public partial class Form1 : Form
    {
        private Graph graph;
        public Form1()
        {
            InitializeComponent();
            graph = new Graph();
            cbDirected.Items.Add("Dirigido");
            cbDirected.Items.Add("No dirigido");
            cbDirected.SelectedIndex = 0; // P
        }

        private void Add_vertex_btn1_Click(object sender, EventArgs e)
        {
            string newVertex = txtVertex.Text.Trim();

            if (!string.IsNullOrEmpty(newVertex))
            {
                // Agregar v�rtice a la clase Grafo
                graph.AddVertex(newVertex);

                // Actualizar el DataGridView
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un v�rtice v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtVertex.Clear();
        }

        private void Add_Edge_btn2_Click(object sender, EventArgs e)
        {

            string vertex1 = txtvertex1.Text.Trim();
            string vertex2 = txtvertex2.Text.Trim();
            bool isDirected = cbDirected.Text == "Dirigido";  // Determinar si la arista es dirigida

            if (!string.IsNullOrEmpty(vertex1) && !string.IsNullOrEmpty(vertex2) && vertex1 != vertex2)
            {
                if (graph.Vertex.Contains(vertex1) && graph.Vertex.Contains(vertex2))
                {
                    // Agregar la arista al grafo
                    graph.AddEdge(vertex1, vertex2, isDirected);

                    // Actualizar el DataGridView
                    UpdateDataGridView();
                }
                else
                {
                    MessageBox.Show("Los v�rtices deben existir en el grafo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese v�rtices v�lidos y diferentes para conectar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Weight_btn3_Click(object sender, EventArgs e)
        {
            string vertex1 = txtVertex1Weight.Text.Trim();
            string vertex2 = txtVertex2Weight.Text.Trim();
            bool isDirected = cbDirected.Text == "Dirigido";  // Determinar si la arista es dirigida
            int weight;

            // Validar que los v�rtices sean diferentes y el peso sea v�lido
            if (!string.IsNullOrEmpty(vertex1) && !string.IsNullOrEmpty(vertex2) && vertex1 != vertex2 && int.TryParse(txtWeight.Text, out weight))
            {
                if (graph.Vertex.Contains(vertex1) && graph.Vertex.Contains(vertex2))
                {
                    // Agregar la arista con el peso al grafo
                    graph.AddEdgeWithWeight(vertex1, vertex2, isDirected, weight);

                    // Actualizar el DataGridView
                    UpdateDataGridView();
                }
                else
                {
                    MessageBox.Show("Los v�rtices deben existir en el grafo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese v�rtices v�lidos, diferentes y un peso num�rico v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataGridView()
        {
            // Limpiar el DataGridView
            dgvMatrix.Columns.Clear();
            dgvMatrix.Rows.Clear();

            // Agregar las columnas (v�rtices) para la matriz de adyacencia
            dgvMatrix.Columns.Add("", ""); // Columna vac�a para el encabezado
            foreach (var vertex in graph.Vertex)
            {
                dgvMatrix.Columns.Add(vertex, vertex);
            }

            // Agregar las filas (v�rtices y valores de la matriz de adyacencia)
            for (int i = 0; i < graph.Vertex.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvMatrix);

                // La primera celda de cada fila es el nombre del v�rtice
                row.Cells[0].Value = graph.Vertex[i];

                // Las dem�s celdas son los valores de la matriz de adyacencia
                for (int j = 0; j < graph.Vertex.Count; j++)
                {
                    // Mostrar el peso o 0 si no hay conexi�n
                    row.Cells[j + 1].Value = graph.Matrix[i, j].ToString();
                }

                dgvMatrix.Rows.Add(row);
            }
        }

        private void Delete_Vertex_btn4_Click(object sender, EventArgs e)
        {
            string vertexToRemove = txtVertexToRemove.Text.Trim();

            if (!string.IsNullOrEmpty(vertexToRemove) && graph.Vertex.Contains(vertexToRemove))
            {
                // Eliminar el v�rtice del grafo
                graph.RemoveVertex(vertexToRemove);

                // Actualizar el DataGridView
                UpdateDataGridView();

                MessageBox.Show($"El v�rtice '{vertexToRemove}' ha sido eliminado.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese un v�rtice v�lido que exista en el grafo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Edge_btn5_Click(object sender, EventArgs e)
        {
            string vertex1 = deletevtxt1.Text.Trim();
            string vertex2 = deletevtxt1.Text.Trim();
            bool isDirected = cbDirected.Text == "Dirigido"; // Determinar si la arista es dirigida

            // Validar que ambos v�rtices son diferentes y existen
            if (!string.IsNullOrEmpty(vertex1) && !string.IsNullOrEmpty(vertex2) && vertex1 != vertex2)
            {
                if (graph.Vertex.Contains(vertex1) && graph.Vertex.Contains(vertex2))
                {
                    // Eliminar la arista del grafo
                    graph.RemoveEdge(vertex1, vertex2, isDirected);

                    // Actualizar el DataGridView
                    UpdateDataGridView();

                    MessageBox.Show($"La arista entre '{vertex1}' y '{vertex2}' ha sido eliminada.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ambos v�rtices deben existir en el grafo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese dos v�rtices v�lidos y diferentes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
       
    

