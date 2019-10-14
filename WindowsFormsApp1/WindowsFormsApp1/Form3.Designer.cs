namespace WindowsFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полноеИмяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гражданствоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.весоваяКатегорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ростсмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p4PBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATADataSet = new WindowsFormsApp1.DATADataSet();
            this.p4PTableAdapter = new WindowsFormsApp1.DATADataSetTableAdapters.P4PTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4PBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.полноеИмяDataGridViewTextBoxColumn,
            this.гражданствоDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.весоваяКатегорияDataGridViewTextBoxColumn,
            this.ростсмDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.p4PBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 230);
            this.dataGridView1.TabIndex = 1;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // полноеИмяDataGridViewTextBoxColumn
            // 
            this.полноеИмяDataGridViewTextBoxColumn.DataPropertyName = "Полное имя";
            this.полноеИмяDataGridViewTextBoxColumn.HeaderText = "Полное имя";
            this.полноеИмяDataGridViewTextBoxColumn.Name = "полноеИмяDataGridViewTextBoxColumn";
            // 
            // гражданствоDataGridViewTextBoxColumn
            // 
            this.гражданствоDataGridViewTextBoxColumn.DataPropertyName = "Гражданство";
            this.гражданствоDataGridViewTextBoxColumn.HeaderText = "Гражданство";
            this.гражданствоDataGridViewTextBoxColumn.Name = "гражданствоDataGridViewTextBoxColumn";
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            // 
            // весоваяКатегорияDataGridViewTextBoxColumn
            // 
            this.весоваяКатегорияDataGridViewTextBoxColumn.DataPropertyName = "Весовая категория";
            this.весоваяКатегорияDataGridViewTextBoxColumn.HeaderText = "Весовая категория";
            this.весоваяКатегорияDataGridViewTextBoxColumn.Name = "весоваяКатегорияDataGridViewTextBoxColumn";
            // 
            // ростсмDataGridViewTextBoxColumn
            // 
            this.ростсмDataGridViewTextBoxColumn.DataPropertyName = "Рост(см)";
            this.ростсмDataGridViewTextBoxColumn.HeaderText = "Рост(см)";
            this.ростсмDataGridViewTextBoxColumn.Name = "ростсмDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "+/-";
            this.dataGridViewTextBoxColumn1.HeaderText = "+/-";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // p4PBindingSource
            // 
            this.p4PBindingSource.DataMember = "P4P";
            this.p4PBindingSource.DataSource = this.dATADataSet;
            // 
            // dATADataSet
            // 
            this.dATADataSet.DataSetName = "DATADataSet";
            this.dATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p4PTableAdapter
            // 
            this.p4PTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4PBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DATADataSet dATADataSet;
        private System.Windows.Forms.BindingSource p4PBindingSource;
        private DATADataSetTableAdapters.P4PTableAdapter p4PTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полноеИмяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гражданствоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn весоваяКатегорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ростсмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}