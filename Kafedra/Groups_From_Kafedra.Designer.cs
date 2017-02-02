namespace Kafedra
{
    partial class Groups_From_Kafedra
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kafedraDataSet = new Kafedra.KafedraDataSet();
            this.gruppaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruppaTableAdapter = new Kafedra.KafedraDataSetTableAdapters.GruppaTableAdapter();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazvanieDataGridViewTextBoxColumn,
            this.specialnostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gruppaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(406, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // kafedraDataSet
            // 
            this.kafedraDataSet.DataSetName = "KafedraDataSet";
            this.kafedraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gruppaBindingSource
            // 
            this.gruppaBindingSource.DataMember = "Gruppa";
            this.gruppaBindingSource.DataSource = this.kafedraDataSet;
            // 
            // gruppaTableAdapter
            // 
            this.gruppaTableAdapter.ClearBeforeFill = true;
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "Название группы";
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            this.nazvanieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specialnostDataGridViewTextBoxColumn
            // 
            this.specialnostDataGridViewTextBoxColumn.DataPropertyName = "Specialnost";
            this.specialnostDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.specialnostDataGridViewTextBoxColumn.Name = "specialnostDataGridViewTextBoxColumn";
            this.specialnostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Groups_From_Kafedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 259);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Groups_From_Kafedra";
            this.Text = "Список групп";
            this.Load += new System.EventHandler(this.Groups_From_Kafedra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KafedraDataSet kafedraDataSet;
        private System.Windows.Forms.BindingSource gruppaBindingSource;
        private KafedraDataSetTableAdapters.GruppaTableAdapter gruppaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialnostDataGridViewTextBoxColumn;
    }
}