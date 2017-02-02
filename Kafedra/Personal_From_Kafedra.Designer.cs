namespace Kafedra
{
    partial class Personal_From_Kafedra
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
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalTableAdapter = new Kafedra.KafedraDataSetTableAdapters.PersonalTableAdapter();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrazovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn,
            this.obrazovanieDataGridViewTextBoxColumn,
            this.specialnostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(451, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // kafedraDataSet
            // 
            this.kafedraDataSet.DataSetName = "KafedraDataSet";
            this.kafedraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.kafedraDataSet;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obrazovanieDataGridViewTextBoxColumn
            // 
            this.obrazovanieDataGridViewTextBoxColumn.DataPropertyName = "Obrazovanie";
            this.obrazovanieDataGridViewTextBoxColumn.HeaderText = "Образование";
            this.obrazovanieDataGridViewTextBoxColumn.Name = "obrazovanieDataGridViewTextBoxColumn";
            this.obrazovanieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specialnostDataGridViewTextBoxColumn
            // 
            this.specialnostDataGridViewTextBoxColumn.DataPropertyName = "Specialnost";
            this.specialnostDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.specialnostDataGridViewTextBoxColumn.Name = "specialnostDataGridViewTextBoxColumn";
            this.specialnostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Personal_From_Kafedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Personal_From_Kafedra";
            this.Text = "Список преподавателей";
            this.Load += new System.EventHandler(this.Personal_From_Kafedra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KafedraDataSet kafedraDataSet;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private KafedraDataSetTableAdapters.PersonalTableAdapter personalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrazovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialnostDataGridViewTextBoxColumn;
    }
}