using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_de_Adyacencia
{
    internal class Graph
    {
        public List<string> Vertex { get; set; }

        public List<Tuple<string, string, bool,int?>> Edges { get; set; }



        public int[,] Matrix { get; set; }

        public Graph()
        {
            Vertex = new List<string>();
            Edges = new List<Tuple<string, string, bool,int?>>();
            Matrix = new int[0, 0];
        }

        public void AddVertex(string vertex)
        {
            if (!Vertex.Contains(vertex))
            {
                Vertex.Add(vertex);
                ResizeMatrix(Vertex.Count);
            }

        }

        public void ResizeMatrix(int newsize)
        {
            int[,] newMatrix = new int[newsize, newsize];

            // Copiamos los valores antiguos en la nueva matriz
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = Matrix[i, j];
                }
            }

            Matrix = newMatrix;

        }

        public void AddEdge(string vertex1, string vertex2, bool isDirected)
        {
            if (Vertex.Contains(vertex1) && Vertex.Contains(vertex2))
            {
                int i = Vertex.IndexOf(vertex1);
                int j = Vertex.IndexOf(vertex2);

                // Arista en la matriz de adyacencia
                Matrix[i, j] = 1;

                if (!isDirected) // Si no es dirigida, agregamos la arista en ambas direcciones
                {
                    Matrix[j, i] = 1;
                }

                // Agregar la arista a la lista de aristas
                Edges.Add(new Tuple<string, string, bool,int?>(vertex1, vertex2, isDirected,null));
            }
        }
        // Método para agregar una arista con peso
        public void AddEdgeWithWeight(string vertex1, string vertex2, bool isDirected, int weight)
        {
            if (Vertex.Contains(vertex1) && Vertex.Contains(vertex2))
            {
                int index1 = Vertex.IndexOf(vertex1);
                int index2 = Vertex.IndexOf(vertex2);

                // Añadir conexión con peso en la matriz de adyacencia
                Matrix[index1, index2] = weight; // Establece el peso

                if (!isDirected)
                {
                    Matrix[index2, index1] = weight; // Conexión recíproca si no es dirigido
                }

                // Actualiza la lista de aristas
                Edges.Add(new Tuple<string, string, bool, int?>(vertex1, vertex2, isDirected, weight));
            }
        }

        public void RemoveVertex(string vertex)
        {
            if (Vertex.Contains(vertex))
            {
                int index = Vertex.IndexOf(vertex);

                // Eliminar el vértice de la lista
                Vertex.RemoveAt(index);

                // Crear una nueva matriz de adyacencia sin el vértice eliminado
                int[,] newAdjMatrix = new int[Vertex.Count, Vertex.Count];

                // Copiar los datos de la matriz original a la nueva matriz
                for (int i = 0, newI = 0; i < Matrix.GetLength(0); i++)
                {
                    if (i != index)
                    {
                        for (int j = 0, newJ = 0; j < Matrix.GetLength(1); j++)
                        {
                            if (j != index)
                            {
                                newAdjMatrix[newI, newJ] = Matrix[i, j];
                                newJ++;
                            }
                        }
                        newI++;
                    }
                }

                // Asignar la nueva matriz de adyacencia
                Matrix = newAdjMatrix;

                // Eliminar las aristas relacionadas (si es necesario)
                Edges.RemoveAll(e => e.Item1 == vertex || e.Item2 == vertex);
            }
        }

        public void RemoveEdge(string vertex1, string vertex2, bool isDirected)
        {
            if (Vertex.Contains(vertex1) && Vertex.Contains(vertex2))
            {
                int index1 = Vertex.IndexOf(vertex1);
                int index2 = Vertex.IndexOf(vertex2);

                // Eliminar la conexión en la matriz de adyacencia
                Matrix[index1, index2] = 0; // Establecer el peso a 0 para indicar que no hay conexión

                if (!isDirected)
                {
                    Matrix[index2, index1] = 0; // Conexión recíproca si no es dirigida
                }

                // Actualiza la lista de aristas (si estás usando una lista para mantenerlas)
                Edges.RemoveAll(e => (e.Item1 == vertex1 && e.Item2 == vertex2) || (e.Item1 == vertex2 && e.Item2 == vertex1 && !isDirected));
            }
        }



    }

}
