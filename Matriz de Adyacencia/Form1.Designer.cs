namespace Matriz_de_Adyacencia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Add_vertex_btn1 = new Button();
            txtVertex = new TextBox();
            Add_Edge_btn2 = new Button();
            Add_Weight_btn3 = new Button();
            Delete_Vertex_btn4 = new Button();
            txtvertex1 = new TextBox();
            txtVertex1Weight = new TextBox();
            txtVertexToRemove = new TextBox();
            txtVertex2Weight = new TextBox();
            txtWeight = new TextBox();
            Delete_Edge_btn5 = new Button();
            deletevtxt1 = new TextBox();
            txtvertex2 = new TextBox();
            deletevtxt2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            dgvMatrix = new DataGridView();
            cbDirected = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).BeginInit();
            SuspendLayout();
            // 
            // Add_vertex_btn1
            // 
            Add_vertex_btn1.Location = new Point(12, 45);
            Add_vertex_btn1.Name = "Add_vertex_btn1";
            Add_vertex_btn1.Size = new Size(104, 23);
            Add_vertex_btn1.TabIndex = 0;
            Add_vertex_btn1.Text = "Add Vertex";
            Add_vertex_btn1.UseVisualStyleBackColor = true;
            Add_vertex_btn1.Click += Add_vertex_btn1_Click;
            // 
            // txtVertex
            // 
            txtVertex.Location = new Point(143, 45);
            txtVertex.Name = "txtVertex";
            txtVertex.Size = new Size(100, 23);
            txtVertex.TabIndex = 1;
            // 
            // Add_Edge_btn2
            // 
            Add_Edge_btn2.Location = new Point(12, 158);
            Add_Edge_btn2.Name = "Add_Edge_btn2";
            Add_Edge_btn2.Size = new Size(104, 23);
            Add_Edge_btn2.TabIndex = 2;
            Add_Edge_btn2.Text = "Add Edge";
            Add_Edge_btn2.UseVisualStyleBackColor = true;
            Add_Edge_btn2.Click += Add_Edge_btn2_Click;
            // 
            // Add_Weight_btn3
            // 
            Add_Weight_btn3.Location = new Point(11, 230);
            Add_Weight_btn3.Name = "Add_Weight_btn3";
            Add_Weight_btn3.Size = new Size(104, 23);
            Add_Weight_btn3.TabIndex = 3;
            Add_Weight_btn3.Text = "Add Weight";
            Add_Weight_btn3.UseVisualStyleBackColor = true;
            Add_Weight_btn3.Click += Add_Weight_btn3_Click;
            // 
            // Delete_Vertex_btn4
            // 
            Delete_Vertex_btn4.Location = new Point(12, 311);
            Delete_Vertex_btn4.Name = "Delete_Vertex_btn4";
            Delete_Vertex_btn4.Size = new Size(104, 23);
            Delete_Vertex_btn4.TabIndex = 4;
            Delete_Vertex_btn4.Text = "Delete Vertex";
            Delete_Vertex_btn4.UseVisualStyleBackColor = true;
            Delete_Vertex_btn4.Click += Delete_Vertex_btn4_Click;
            // 
            // txtvertex1
            // 
            txtvertex1.Location = new Point(143, 159);
            txtvertex1.Name = "txtvertex1";
            txtvertex1.Size = new Size(39, 23);
            txtvertex1.TabIndex = 5;
            // 
            // txtVertex1Weight
            // 
            txtVertex1Weight.Location = new Point(143, 231);
            txtVertex1Weight.Name = "txtVertex1Weight";
            txtVertex1Weight.Size = new Size(39, 23);
            txtVertex1Weight.TabIndex = 7;
            // 
            // txtVertexToRemove
            // 
            txtVertexToRemove.Location = new Point(143, 311);
            txtVertexToRemove.Name = "txtVertexToRemove";
            txtVertexToRemove.Size = new Size(56, 23);
            txtVertexToRemove.TabIndex = 8;
            // 
            // txtVertex2Weight
            // 
            txtVertex2Weight.Location = new Point(204, 231);
            txtVertex2Weight.Name = "txtVertex2Weight";
            txtVertex2Weight.Size = new Size(39, 23);
            txtVertex2Weight.TabIndex = 9;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(277, 231);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(55, 23);
            txtWeight.TabIndex = 10;
            // 
            // Delete_Edge_btn5
            // 
            Delete_Edge_btn5.Location = new Point(12, 374);
            Delete_Edge_btn5.Name = "Delete_Edge_btn5";
            Delete_Edge_btn5.Size = new Size(104, 23);
            Delete_Edge_btn5.TabIndex = 12;
            Delete_Edge_btn5.Text = "Delete Edge";
            Delete_Edge_btn5.UseVisualStyleBackColor = true;
            Delete_Edge_btn5.Click += Delete_Edge_btn5_Click;
            // 
            // deletevtxt1
            // 
            deletevtxt1.Location = new Point(143, 375);
            deletevtxt1.Name = "deletevtxt1";
            deletevtxt1.Size = new Size(39, 23);
            deletevtxt1.TabIndex = 13;
            // 
            // txtvertex2
            // 
            txtvertex2.Location = new Point(212, 159);
            txtvertex2.Name = "txtvertex2";
            txtvertex2.Size = new Size(39, 23);
            txtvertex2.TabIndex = 14;
            // 
            // deletevtxt2
            // 
            deletevtxt2.Location = new Point(229, 374);
            deletevtxt2.Name = "deletevtxt2";
            deletevtxt2.Size = new Size(38, 23);
            deletevtxt2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 16;
            label1.Text = "Create a vertex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(271, 15);
            label2.TabIndex = 17;
            label2.Text = "Select whether the edge is Directet or Not directed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 212);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 18;
            label3.Text = "Add weight to an edge";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 141);
            label6.Name = "label6";
            label6.Size = new Size(164, 15);
            label6.TabIndex = 21;
            label6.Text = "Select the vertices to connect ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 257);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 23;
            label5.Text = "V1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(223, 257);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 24;
            label7.Text = "V2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(289, 256);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 25;
            label8.Text = "weight";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(144, 401);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 26;
            label9.Text = "V1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(247, 400);
            label10.Name = "label10";
            label10.Size = new Size(20, 15);
            label10.TabIndex = 27;
            label10.Text = "V2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(144, 185);
            label11.Name = "label11";
            label11.Size = new Size(20, 15);
            label11.TabIndex = 28;
            label11.Text = "V1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(229, 185);
            label12.Name = "label12";
            label12.Size = new Size(20, 15);
            label12.TabIndex = 29;
            label12.Text = "V2";
            // 
            // dgvMatrix
            // 
            dgvMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatrix.Location = new Point(361, 6);
            dgvMatrix.Name = "dgvMatrix";
            dgvMatrix.Size = new Size(572, 432);
            dgvMatrix.TabIndex = 30;
            // 
            // cbDirected
            // 
            cbDirected.FormattingEnabled = true;
            cbDirected.Location = new Point(17, 106);
            cbDirected.Name = "cbDirected";
            cbDirected.Size = new Size(121, 23);
            cbDirected.TabIndex = 33;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 450);
            Controls.Add(cbDirected);
            Controls.Add(dgvMatrix);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deletevtxt2);
            Controls.Add(txtvertex2);
            Controls.Add(deletevtxt1);
            Controls.Add(Delete_Edge_btn5);
            Controls.Add(txtWeight);
            Controls.Add(txtVertex2Weight);
            Controls.Add(txtVertexToRemove);
            Controls.Add(txtVertex1Weight);
            Controls.Add(txtvertex1);
            Controls.Add(Delete_Vertex_btn4);
            Controls.Add(Add_Weight_btn3);
            Controls.Add(Add_Edge_btn2);
            Controls.Add(txtVertex);
            Controls.Add(Add_vertex_btn1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add_vertex_btn1;
        private TextBox txtVertex;
        private Button Add_Edge_btn2;
        private Button Add_Weight_btn3;
        private Button Delete_Vertex_btn4;
        private TextBox txtvertex1;
        private TextBox txtVertex1Weight;
        private TextBox txtVertexToRemove;
        private TextBox txtVertex2Weight;
        private TextBox txtWeight;
        private Button Delete_Edge_btn5;
        private TextBox deletevtxt1;
        private TextBox txtvertex2;
        private TextBox deletevtxt2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridView dgvMatrix;
        private ComboBox cbDirected;
    }
}
