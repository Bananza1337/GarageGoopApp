
namespace GarageGoopApp.View.OwnerForms
{
    partial class ServicesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.myDataSet = new GarageGoopApp.MyDataSet();
            this.моиУслугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.моиУслугиTableAdapter = new GarageGoopApp.MyDataSetTableAdapters.МоиУслугиTableAdapter();
            this.моиУслугиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Кооператива = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.моиУслугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.моиУслугиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Мои услуги";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.моиУслугиDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 342);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // моиУслугиBindingSource
            // 
            this.моиУслугиBindingSource.DataMember = "МоиУслуги";
            this.моиУслугиBindingSource.DataSource = this.myDataSet;
            // 
            // моиУслугиTableAdapter
            // 
            this.моиУслугиTableAdapter.ClearBeforeFill = true;
            // 
            // моиУслугиDataGridView
            // 
            this.моиУслугиDataGridView.AllowUserToAddRows = false;
            this.моиУслугиDataGridView.AllowUserToDeleteRows = false;
            this.моиУслугиDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.моиУслугиDataGridView.AutoGenerateColumns = false;
            this.моиУслугиDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.моиУслугиDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.моиУслугиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.моиУслугиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.ID_Кооператива});
            this.моиУслугиDataGridView.DataSource = this.моиУслугиBindingSource;
            this.моиУслугиDataGridView.Location = new System.Drawing.Point(8, 19);
            this.моиУслугиDataGridView.Name = "моиУслугиDataGridView";
            this.моиУслугиDataGridView.ReadOnly = true;
            this.моиУслугиDataGridView.Size = new System.Drawing.Size(861, 317);
            this.моиУслугиDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование услуги";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn3.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ID_Кооператива
            // 
            this.ID_Кооператива.DataPropertyName = "ID_Кооператива";
            this.ID_Кооператива.HeaderText = "Номер кооператива";
            this.ID_Кооператива.Name = "ID_Кооператива";
            this.ID_Кооператива.ReadOnly = true;
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ServicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мои услуги";
            this.Load += new System.EventHandler(this.ServicesForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.моиУслугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.моиУслугиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MyDataSet myDataSet;
        private System.Windows.Forms.BindingSource моиУслугиBindingSource;
        private MyDataSetTableAdapters.МоиУслугиTableAdapter моиУслугиTableAdapter;
        private System.Windows.Forms.DataGridView моиУслугиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Кооператива;
    }
}