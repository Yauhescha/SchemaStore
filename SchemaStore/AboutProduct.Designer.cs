﻿namespace SchemaStore
{
    partial class AboutProduct
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.iDТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.остатокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годсКоличествомDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предзаказаноDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ожидаетсяОтПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.виртуальныйОстатокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new SchemaStore.DatabaseDataSet();
            this.нНDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сокращенноDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаBYNБезНдсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаRUBБезНдсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приЗаказе19DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приЗаказе1049DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приЗаказе5099DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приЗаказеОт100DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new SchemaStore.DatabaseDataSetTableAdapters.ТоварTableAdapter();
            this.складTableAdapter = new SchemaStore.DatabaseDataSetTableAdapters.СкладTableAdapter();
            this.проданныеТоварыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.проданныеТоварыTableAdapter = new SchemaStore.DatabaseDataSetTableAdapters.ПроданныеТоварыTableAdapter();
            this.товарDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПроданногоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаПроданногоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.закупленныеТоварыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.закупленныеТоварыTableAdapter = new SchemaStore.DatabaseDataSetTableAdapters.ЗакупленныеТоварыTableAdapter();
            this.товарDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоЗакупленногоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаЗакупленногоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.проданныеТоварыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.закупленныеТоварыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.нНDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.сокращенноDataGridViewTextBoxColumn,
            this.ценаBYNБезНдсDataGridViewTextBoxColumn,
            this.ценаRUBБезНдсDataGridViewTextBoxColumn,
            this.приЗаказе19DataGridViewTextBoxColumn,
            this.приЗаказе1049DataGridViewTextBoxColumn,
            this.приЗаказе5099DataGridViewTextBoxColumn,
            this.приЗаказеОт100DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.товарBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 147);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТовараDataGridViewTextBoxColumn,
            this.остатокDataGridViewTextBoxColumn,
            this.годсКоличествомDataGridViewTextBoxColumn,
            this.предзаказаноDataGridViewTextBoxColumn,
            this.ожидаетсяОтПоставщикаDataGridViewTextBoxColumn,
            this.виртуальныйОстатокDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.складBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1114, 53);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 166);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Товары";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(9, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1120, 72);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Склад";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.dataGridView4);
            this.groupBox3.Location = new System.Drawing.Point(9, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(559, 145);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Продано";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.товарDataGridViewTextBoxColumn,
            this.количествоПроданногоDataGridViewTextBoxColumn,
            this.суммаПроданногоDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.проданныеТоварыBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 16);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(553, 126);
            this.dataGridView4.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dataGridView5);
            this.groupBox4.Location = new System.Drawing.Point(574, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(552, 145);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Закуплено";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.товарDataGridViewTextBoxColumn1,
            this.количествоЗакупленногоDataGridViewTextBoxColumn,
            this.суммаЗакупленногоDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.закупленныеТоварыBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(3, 16);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(546, 126);
            this.dataGridView5.TabIndex = 1;
            // 
            // iDТовараDataGridViewTextBoxColumn
            // 
            this.iDТовараDataGridViewTextBoxColumn.DataPropertyName = "IDТовара";
            this.iDТовараDataGridViewTextBoxColumn.HeaderText = "IDТовара";
            this.iDТовараDataGridViewTextBoxColumn.Name = "iDТовараDataGridViewTextBoxColumn";
            this.iDТовараDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDТовараDataGridViewTextBoxColumn.Width = 80;
            // 
            // остатокDataGridViewTextBoxColumn
            // 
            this.остатокDataGridViewTextBoxColumn.DataPropertyName = "Остаток";
            this.остатокDataGridViewTextBoxColumn.HeaderText = "Остаток";
            this.остатокDataGridViewTextBoxColumn.Name = "остатокDataGridViewTextBoxColumn";
            this.остатокDataGridViewTextBoxColumn.ReadOnly = true;
            this.остатокDataGridViewTextBoxColumn.Width = 74;
            // 
            // годсКоличествомDataGridViewTextBoxColumn
            // 
            this.годсКоличествомDataGridViewTextBoxColumn.DataPropertyName = "Год(сКоличеством)";
            this.годсКоличествомDataGridViewTextBoxColumn.HeaderText = "Год(сКоличеством)";
            this.годсКоличествомDataGridViewTextBoxColumn.Name = "годсКоличествомDataGridViewTextBoxColumn";
            this.годсКоличествомDataGridViewTextBoxColumn.ReadOnly = true;
            this.годсКоличествомDataGridViewTextBoxColumn.Width = 129;
            // 
            // предзаказаноDataGridViewTextBoxColumn
            // 
            this.предзаказаноDataGridViewTextBoxColumn.DataPropertyName = "Предзаказано";
            this.предзаказаноDataGridViewTextBoxColumn.HeaderText = "Предзаказано";
            this.предзаказаноDataGridViewTextBoxColumn.Name = "предзаказаноDataGridViewTextBoxColumn";
            this.предзаказаноDataGridViewTextBoxColumn.ReadOnly = true;
            this.предзаказаноDataGridViewTextBoxColumn.Width = 106;
            // 
            // ожидаетсяОтПоставщикаDataGridViewTextBoxColumn
            // 
            this.ожидаетсяОтПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "ОжидаетсяОтПоставщика";
            this.ожидаетсяОтПоставщикаDataGridViewTextBoxColumn.HeaderText = "ОжидаетсяОтПоставщика";
            this.ожидаетсяОтПоставщикаDataGridViewTextBoxColumn.Name = "ожидаетсяОтПоставщикаDataGridViewTextBoxColumn";
            this.ожидаетсяОтПоставщикаDataGridViewTextBoxColumn.ReadOnly = true;
            this.ожидаетсяОтПоставщикаDataGridViewTextBoxColumn.Width = 166;
            // 
            // виртуальныйОстатокDataGridViewTextBoxColumn
            // 
            this.виртуальныйОстатокDataGridViewTextBoxColumn.DataPropertyName = "ВиртуальныйОстаток";
            this.виртуальныйОстатокDataGridViewTextBoxColumn.HeaderText = "ВиртуальныйОстаток";
            this.виртуальныйОстатокDataGridViewTextBoxColumn.Name = "виртуальныйОстатокDataGridViewTextBoxColumn";
            this.виртуальныйОстатокDataGridViewTextBoxColumn.ReadOnly = true;
            this.виртуальныйОстатокDataGridViewTextBoxColumn.Width = 141;
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "Склад";
            this.складBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // нНDataGridViewTextBoxColumn
            // 
            this.нНDataGridViewTextBoxColumn.DataPropertyName = "НН";
            this.нНDataGridViewTextBoxColumn.HeaderText = "НН";
            this.нНDataGridViewTextBoxColumn.Name = "нНDataGridViewTextBoxColumn";
            this.нНDataGridViewTextBoxColumn.ReadOnly = true;
            this.нНDataGridViewTextBoxColumn.Width = 48;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            this.наименованиеDataGridViewTextBoxColumn.Width = 108;
            // 
            // сокращенноDataGridViewTextBoxColumn
            // 
            this.сокращенноDataGridViewTextBoxColumn.DataPropertyName = "Сокращенно";
            this.сокращенноDataGridViewTextBoxColumn.HeaderText = "Сокращенно";
            this.сокращенноDataGridViewTextBoxColumn.Name = "сокращенноDataGridViewTextBoxColumn";
            this.сокращенноDataGridViewTextBoxColumn.ReadOnly = true;
            this.сокращенноDataGridViewTextBoxColumn.Width = 96;
            // 
            // ценаBYNБезНдсDataGridViewTextBoxColumn
            // 
            this.ценаBYNБезНдсDataGridViewTextBoxColumn.DataPropertyName = "ЦенаBYNБезНдс";
            this.ценаBYNБезНдсDataGridViewTextBoxColumn.HeaderText = "ЦенаBYNБезНдс";
            this.ценаBYNБезНдсDataGridViewTextBoxColumn.Name = "ценаBYNБезНдсDataGridViewTextBoxColumn";
            this.ценаBYNБезНдсDataGridViewTextBoxColumn.ReadOnly = true;
            this.ценаBYNБезНдсDataGridViewTextBoxColumn.Width = 119;
            // 
            // ценаRUBБезНдсDataGridViewTextBoxColumn
            // 
            this.ценаRUBБезНдсDataGridViewTextBoxColumn.DataPropertyName = "ЦенаRUBБезНдс";
            this.ценаRUBБезНдсDataGridViewTextBoxColumn.HeaderText = "ЦенаRUBБезНдс";
            this.ценаRUBБезНдсDataGridViewTextBoxColumn.Name = "ценаRUBБезНдсDataGridViewTextBoxColumn";
            this.ценаRUBБезНдсDataGridViewTextBoxColumn.ReadOnly = true;
            this.ценаRUBБезНдсDataGridViewTextBoxColumn.Width = 120;
            // 
            // приЗаказе19DataGridViewTextBoxColumn
            // 
            this.приЗаказе19DataGridViewTextBoxColumn.DataPropertyName = "ПриЗаказе1-9";
            this.приЗаказе19DataGridViewTextBoxColumn.HeaderText = "ПриЗаказе1-9";
            this.приЗаказе19DataGridViewTextBoxColumn.Name = "приЗаказе19DataGridViewTextBoxColumn";
            this.приЗаказе19DataGridViewTextBoxColumn.ReadOnly = true;
            this.приЗаказе19DataGridViewTextBoxColumn.Width = 104;
            // 
            // приЗаказе1049DataGridViewTextBoxColumn
            // 
            this.приЗаказе1049DataGridViewTextBoxColumn.DataPropertyName = "ПриЗаказе10-49";
            this.приЗаказе1049DataGridViewTextBoxColumn.HeaderText = "ПриЗаказе10-49";
            this.приЗаказе1049DataGridViewTextBoxColumn.Name = "приЗаказе1049DataGridViewTextBoxColumn";
            this.приЗаказе1049DataGridViewTextBoxColumn.ReadOnly = true;
            this.приЗаказе1049DataGridViewTextBoxColumn.Width = 116;
            // 
            // приЗаказе5099DataGridViewTextBoxColumn
            // 
            this.приЗаказе5099DataGridViewTextBoxColumn.DataPropertyName = "ПриЗаказе50-99";
            this.приЗаказе5099DataGridViewTextBoxColumn.HeaderText = "ПриЗаказе50-99";
            this.приЗаказе5099DataGridViewTextBoxColumn.Name = "приЗаказе5099DataGridViewTextBoxColumn";
            this.приЗаказе5099DataGridViewTextBoxColumn.ReadOnly = true;
            this.приЗаказе5099DataGridViewTextBoxColumn.Width = 116;
            // 
            // приЗаказеОт100DataGridViewTextBoxColumn
            // 
            this.приЗаказеОт100DataGridViewTextBoxColumn.DataPropertyName = "ПриЗаказеОт100";
            this.приЗаказеОт100DataGridViewTextBoxColumn.HeaderText = "ПриЗаказеОт100";
            this.приЗаказеОт100DataGridViewTextBoxColumn.Name = "приЗаказеОт100DataGridViewTextBoxColumn";
            this.приЗаказеОт100DataGridViewTextBoxColumn.ReadOnly = true;
            this.приЗаказеОт100DataGridViewTextBoxColumn.Width = 120;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.databaseDataSet;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // проданныеТоварыBindingSource
            // 
            this.проданныеТоварыBindingSource.DataMember = "ПроданныеТовары";
            this.проданныеТоварыBindingSource.DataSource = this.databaseDataSet;
            // 
            // проданныеТоварыTableAdapter
            // 
            this.проданныеТоварыTableAdapter.ClearBeforeFill = true;
            // 
            // товарDataGridViewTextBoxColumn
            // 
            this.товарDataGridViewTextBoxColumn.DataPropertyName = "Товар";
            this.товарDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.товарDataGridViewTextBoxColumn.Name = "товарDataGridViewTextBoxColumn";
            this.товарDataGridViewTextBoxColumn.ReadOnly = true;
            this.товарDataGridViewTextBoxColumn.Width = 63;
            // 
            // количествоПроданногоDataGridViewTextBoxColumn
            // 
            this.количествоПроданногоDataGridViewTextBoxColumn.DataPropertyName = "КоличествоПроданного";
            this.количествоПроданногоDataGridViewTextBoxColumn.HeaderText = "КоличествоПроданного";
            this.количествоПроданногоDataGridViewTextBoxColumn.Name = "количествоПроданногоDataGridViewTextBoxColumn";
            this.количествоПроданногоDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоПроданногоDataGridViewTextBoxColumn.Width = 152;
            // 
            // суммаПроданногоDataGridViewTextBoxColumn
            // 
            this.суммаПроданногоDataGridViewTextBoxColumn.DataPropertyName = "СуммаПроданного";
            this.суммаПроданногоDataGridViewTextBoxColumn.HeaderText = "СуммаПроданного";
            this.суммаПроданногоDataGridViewTextBoxColumn.Name = "суммаПроданногоDataGridViewTextBoxColumn";
            this.суммаПроданногоDataGridViewTextBoxColumn.ReadOnly = true;
            this.суммаПроданногоDataGridViewTextBoxColumn.Width = 127;
            // 
            // закупленныеТоварыBindingSource
            // 
            this.закупленныеТоварыBindingSource.DataMember = "ЗакупленныеТовары";
            this.закупленныеТоварыBindingSource.DataSource = this.databaseDataSet;
            // 
            // закупленныеТоварыTableAdapter
            // 
            this.закупленныеТоварыTableAdapter.ClearBeforeFill = true;
            // 
            // товарDataGridViewTextBoxColumn1
            // 
            this.товарDataGridViewTextBoxColumn1.DataPropertyName = "Товар";
            this.товарDataGridViewTextBoxColumn1.HeaderText = "Товар";
            this.товарDataGridViewTextBoxColumn1.Name = "товарDataGridViewTextBoxColumn1";
            this.товарDataGridViewTextBoxColumn1.ReadOnly = true;
            this.товарDataGridViewTextBoxColumn1.Width = 63;
            // 
            // количествоЗакупленногоDataGridViewTextBoxColumn
            // 
            this.количествоЗакупленногоDataGridViewTextBoxColumn.DataPropertyName = "КоличествоЗакупленного";
            this.количествоЗакупленногоDataGridViewTextBoxColumn.HeaderText = "КоличествоЗакупленного";
            this.количествоЗакупленногоDataGridViewTextBoxColumn.Name = "количествоЗакупленногоDataGridViewTextBoxColumn";
            this.количествоЗакупленногоDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоЗакупленногоDataGridViewTextBoxColumn.Width = 162;
            // 
            // суммаЗакупленногоDataGridViewTextBoxColumn
            // 
            this.суммаЗакупленногоDataGridViewTextBoxColumn.DataPropertyName = "СуммаЗакупленного";
            this.суммаЗакупленногоDataGridViewTextBoxColumn.HeaderText = "СуммаЗакупленного";
            this.суммаЗакупленногоDataGridViewTextBoxColumn.Name = "суммаЗакупленногоDataGridViewTextBoxColumn";
            this.суммаЗакупленногоDataGridViewTextBoxColumn.ReadOnly = true;
            this.суммаЗакупленногоDataGridViewTextBoxColumn.Width = 137;
            // 
            // AboutProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 414);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AboutProduct";
            this.Text = "О товарах";
            this.Load += new System.EventHandler(this.AboutProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.проданныеТоварыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.закупленныеТоварыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private DatabaseDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn нНDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сокращенноDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаBYNБезНдсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаRUBБезНдсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn приЗаказе19DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn приЗаказе1049DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn приЗаказе5099DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn приЗаказеОт100DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource складBindingSource;
        private DatabaseDataSetTableAdapters.СкладTableAdapter складTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn остатокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годсКоличествомDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предзаказаноDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ожидаетсяОтПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn виртуальныйОстатокDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource проданныеТоварыBindingSource;
        private DatabaseDataSetTableAdapters.ПроданныеТоварыTableAdapter проданныеТоварыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn товарDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПроданногоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаПроданногоDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource закупленныеТоварыBindingSource;
        private DatabaseDataSetTableAdapters.ЗакупленныеТоварыTableAdapter закупленныеТоварыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn товарDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоЗакупленногоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаЗакупленногоDataGridViewTextBoxColumn;
    }
}