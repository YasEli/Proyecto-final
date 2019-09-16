namespace TicketsdeBus
{
    partial class Form2
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
            System.Windows.Forms.Label capacidadLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label rutaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listadeBusesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.listadeBusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listadeBusesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.capacidadTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.rutaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listadeViajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadeBusesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            capacidadLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            rutaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadeBusesBindingNavigator)).BeginInit();
            this.listadeBusesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadeBusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeViajesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeBusesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // capacidadLabel
            // 
            capacidadLabel.AutoSize = true;
            capacidadLabel.Location = new System.Drawing.Point(23, 158);
            capacidadLabel.Name = "capacidadLabel";
            capacidadLabel.Size = new System.Drawing.Size(61, 13);
            capacidadLabel.TabIndex = 1;
            capacidadLabel.Text = "Capacidad:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(23, 47);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(23, 73);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 5;
            marcaLabel.Text = "Marca:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(23, 99);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 7;
            modeloLabel.Text = "Modelo:";
            // 
            // rutaLabel
            // 
            rutaLabel.AutoSize = true;
            rutaLabel.Location = new System.Drawing.Point(23, 129);
            rutaLabel.Name = "rutaLabel";
            rutaLabel.Size = new System.Drawing.Size(33, 13);
            rutaLabel.TabIndex = 9;
            rutaLabel.Text = "Ruta:";
            // 
            // listadeBusesBindingNavigator
            // 
            this.listadeBusesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listadeBusesBindingNavigator.BindingSource = this.listadeBusesBindingSource;
            this.listadeBusesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listadeBusesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listadeBusesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listadeBusesBindingNavigatorSaveItem});
            this.listadeBusesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listadeBusesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listadeBusesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listadeBusesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listadeBusesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listadeBusesBindingNavigator.Name = "listadeBusesBindingNavigator";
            this.listadeBusesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listadeBusesBindingNavigator.Size = new System.Drawing.Size(702, 25);
            this.listadeBusesBindingNavigator.TabIndex = 0;
            this.listadeBusesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // listadeBusesBindingSource
            // 
            this.listadeBusesBindingSource.AllowNew = true;
            this.listadeBusesBindingSource.DataSource = typeof(TicketsdeBus.Modelos.Bus);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // listadeBusesBindingNavigatorSaveItem
            // 
            this.listadeBusesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listadeBusesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listadeBusesBindingNavigatorSaveItem.Image")));
            this.listadeBusesBindingNavigatorSaveItem.Name = "listadeBusesBindingNavigatorSaveItem";
            this.listadeBusesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listadeBusesBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // capacidadTextBox
            // 
            this.capacidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeBusesBindingSource, "Capacidad", true));
            this.capacidadTextBox.Location = new System.Drawing.Point(104, 155);
            this.capacidadTextBox.Name = "capacidadTextBox";
            this.capacidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.capacidadTextBox.TabIndex = 5;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeBusesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(104, 44);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeBusesBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(104, 70);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(100, 20);
            this.marcaTextBox.TabIndex = 2;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeBusesBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(104, 96);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(100, 20);
            this.modeloTextBox.TabIndex = 3;
            // 
            // rutaTextBox
            // 
            this.rutaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeBusesBindingSource, "Ruta", true));
            this.rutaTextBox.Location = new System.Drawing.Point(104, 126);
            this.rutaTextBox.Name = "rutaTextBox";
            this.rutaTextBox.Size = new System.Drawing.Size(100, 20);
            this.rutaTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Viaje Destino: ";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listadeBusesBindingSource, "ViajeId", true));
            this.comboBox1.DataSource = this.listadeViajesBindingSource;
            this.comboBox1.DisplayMember = "Destino";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "Id";
            // 
            // listadeViajesBindingSource
            // 
            this.listadeViajesBindingSource.DataSource = typeof(TicketsdeBus.Modelos.Viaje);
            // 
            // listadeBusesDataGridView
            // 
            this.listadeBusesDataGridView.AutoGenerateColumns = false;
            this.listadeBusesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadeBusesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.listadeBusesDataGridView.DataSource = this.listadeBusesBindingSource;
            this.listadeBusesDataGridView.Location = new System.Drawing.Point(26, 260);
            this.listadeBusesDataGridView.Name = "listadeBusesDataGridView";
            this.listadeBusesDataGridView.Size = new System.Drawing.Size(645, 220);
            this.listadeBusesDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Capacidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Capacidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ruta";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ruta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn5.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ViajeId";
            this.dataGridViewTextBoxColumn7.DataSource = this.listadeViajesBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Destino";
            this.dataGridViewTextBoxColumn7.HeaderText = "Viaje";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Viaje Origen:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listadeBusesBindingSource, "ViajeId", true));
            this.comboBox2.DataSource = this.listadeViajesBindingSource;
            this.comboBox2.DisplayMember = "Origen";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 182);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "Id";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 501);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listadeBusesDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(capacidadLabel);
            this.Controls.Add(this.capacidadTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(rutaLabel);
            this.Controls.Add(this.rutaTextBox);
            this.Controls.Add(this.listadeBusesBindingNavigator);
            this.Name = "Form2";
            this.Text = "Bus";
            ((System.ComponentModel.ISupportInitialize)(this.listadeBusesBindingNavigator)).EndInit();
            this.listadeBusesBindingNavigator.ResumeLayout(false);
            this.listadeBusesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadeBusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeViajesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeBusesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listadeBusesBindingSource;
        private System.Windows.Forms.BindingNavigator listadeBusesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listadeBusesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox capacidadTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox rutaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource listadeViajesBindingSource;
        private System.Windows.Forms.DataGridView listadeBusesDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
    }
}