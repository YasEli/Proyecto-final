namespace TicketsdeBus
{
    partial class Form5
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label impuestoLabel;
            System.Windows.Forms.Label subtotalLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.listaDeTicketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaDeTicketsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.listaDeTicketsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.impuestoTextBox = new System.Windows.Forms.TextBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.listadeClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadeViajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadeBusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.listadeAsientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.asientosBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadeAsientosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            activoLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            impuestoLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeTicketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeTicketsBindingNavigator)).BeginInit();
            this.listaDeTicketsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeViajesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeBusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeAsientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeAsientosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(10, 114);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Location = new System.Drawing.Point(10, 62);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(42, 13);
            clienteIdLabel.TabIndex = 3;
            clienteIdLabel.Text = "Cliente:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(10, 89);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 5;
            fechaLabel.Text = "Fecha:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(10, 36);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // impuestoLabel
            // 
            impuestoLabel.AutoSize = true;
            impuestoLabel.Location = new System.Drawing.Point(400, 362);
            impuestoLabel.Name = "impuestoLabel";
            impuestoLabel.Size = new System.Drawing.Size(53, 13);
            impuestoLabel.TabIndex = 9;
            impuestoLabel.Text = "Impuesto:";
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Location = new System.Drawing.Point(400, 336);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new System.Drawing.Size(49, 13);
            subtotalLabel.TabIndex = 11;
            subtotalLabel.Text = "Subtotal:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(400, 388);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 13;
            totalLabel.Text = "Total:";
            // 
            // listaDeTicketsBindingSource
            // 
            this.listaDeTicketsBindingSource.DataSource = typeof(TicketsdeBus.Modelos.Ticket);
            // 
            // listaDeTicketsBindingNavigator
            // 
            this.listaDeTicketsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaDeTicketsBindingNavigator.BindingSource = this.listaDeTicketsBindingSource;
            this.listaDeTicketsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaDeTicketsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaDeTicketsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaDeTicketsBindingNavigatorSaveItem});
            this.listaDeTicketsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaDeTicketsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaDeTicketsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaDeTicketsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaDeTicketsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaDeTicketsBindingNavigator.Name = "listaDeTicketsBindingNavigator";
            this.listaDeTicketsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaDeTicketsBindingNavigator.Size = new System.Drawing.Size(870, 25);
            this.listaDeTicketsBindingNavigator.TabIndex = 0;
            this.listaDeTicketsBindingNavigator.Text = "bindingNavigator1";
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
            // listaDeTicketsBindingNavigatorSaveItem
            // 
            this.listaDeTicketsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaDeTicketsBindingNavigatorSaveItem.Enabled = false;
            this.listaDeTicketsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaDeTicketsBindingNavigatorSaveItem.Image")));
            this.listaDeTicketsBindingNavigatorSaveItem.Name = "listaDeTicketsBindingNavigatorSaveItem";
            this.listaDeTicketsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaDeTicketsBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaDeTicketsBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(70, 109);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.Text = "checkBox1";
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaDeTicketsBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(70, 85);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeTicketsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(70, 33);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // impuestoTextBox
            // 
            this.impuestoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeTicketsBindingSource, "Impuesto", true));
            this.impuestoTextBox.Location = new System.Drawing.Point(460, 359);
            this.impuestoTextBox.Name = "impuestoTextBox";
            this.impuestoTextBox.Size = new System.Drawing.Size(200, 20);
            this.impuestoTextBox.TabIndex = 10;
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeTicketsBindingSource, "Subtotal", true));
            this.subtotalTextBox.Location = new System.Drawing.Point(460, 333);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.Size = new System.Drawing.Size(200, 20);
            this.subtotalTextBox.TabIndex = 12;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeTicketsBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(460, 385);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalTextBox.TabIndex = 14;
            // 
            // listadeClientesBindingSource
            // 
            this.listadeClientesBindingSource.DataSource = typeof(TicketsdeBus.Modelos.Cliente);
            // 
            // listadeViajesBindingSource
            // 
            this.listadeViajesBindingSource.DataSource = typeof(TicketsdeBus.Modelos.Viaje);
            // 
            // listadeBusesBindingSource
            // 
            this.listadeBusesBindingSource.DataSource = typeof(TicketsdeBus.Modelos.Bus);
            // 
            // ticketsDetalleBindingSource
            // 
            this.ticketsDetalleBindingSource.DataMember = "TicketsDetalle";
            this.ticketsDetalleBindingSource.DataSource = this.listaDeTicketsBindingSource;
            // 
            // ticketsDetalleDataGridView
            // 
            this.ticketsDetalleDataGridView.AutoGenerateColumns = false;
            this.ticketsDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsDetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.ticketsDetalleDataGridView.DataSource = this.ticketsDetalleBindingSource;
            this.ticketsDetalleDataGridView.Location = new System.Drawing.Point(13, 139);
            this.ticketsDetalleDataGridView.Name = "ticketsDetalleDataGridView";
            this.ticketsDetalleDataGridView.Size = new System.Drawing.Size(647, 151);
            this.ticketsDetalleDataGridView.TabIndex = 15;
            this.ticketsDetalleDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketsDetalleDataGridView_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ViajeId";
            this.dataGridViewTextBoxColumn2.DataSource = this.listadeViajesBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Destino";
            this.dataGridViewTextBoxColumn2.HeaderText = "Viaje";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Asiento";
            this.dataGridViewTextBoxColumn7.DataSource = this.listadeAsientosBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Asiento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "Id";
            // 
            // listadeAsientosBindingSource
            // 
            this.listadeAsientosBindingSource.DataSource = typeof(TicketsdeBus.Modelos.Asiento);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaDeTicketsBindingSource, "ClienteId", true));
            this.comboBox1.DataSource = this.listadeClientesBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Id";
            // 
            // asientosBLBindingSource
            // 
            this.asientosBLBindingSource.DataSource = typeof(TicketsdeBus.BL.AsientosBL);
            // 
            // listadeAsientosBindingSource1
            // 
            this.listadeAsientosBindingSource1.DataMember = "ListadeAsientos";
            this.listadeAsientosBindingSource1.DataSource = this.asientosBLBindingSource;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 443);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ticketsDetalleDataGridView);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(clienteIdLabel);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(impuestoLabel);
            this.Controls.Add(this.impuestoTextBox);
            this.Controls.Add(subtotalLabel);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.listaDeTicketsBindingNavigator);
            this.Name = "Form5";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaDeTicketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeTicketsBindingNavigator)).EndInit();
            this.listaDeTicketsBindingNavigator.ResumeLayout(false);
            this.listaDeTicketsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeViajesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeBusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeAsientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeAsientosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaDeTicketsBindingSource;
        private System.Windows.Forms.BindingNavigator listaDeTicketsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaDeTicketsBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox impuestoTextBox;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.BindingSource listadeClientesBindingSource;
        private System.Windows.Forms.BindingSource listadeViajesBindingSource;
        private System.Windows.Forms.BindingSource listadeBusesBindingSource;
        private System.Windows.Forms.BindingSource ticketsDetalleBindingSource;
        private System.Windows.Forms.DataGridView ticketsDetalleDataGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource listadeAsientosBindingSource;
        private System.Windows.Forms.BindingSource asientosBLBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource listadeAsientosBindingSource1;
    }
}