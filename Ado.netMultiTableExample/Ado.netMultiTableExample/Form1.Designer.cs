namespace Ado.netMultiTableExample
{
    partial class Form1
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
            System.Windows.Forms.Label stor_idLabel;
            System.Windows.Forms.Label stor_nameLabel;
            System.Windows.Forms.Label stor_addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pubsDataSet = new Ado.netMultiTableExample.PubsDataSet();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesTableAdapter = new Ado.netMultiTableExample.PubsDataSetTableAdapters.storesTableAdapter();
            this.tableAdapterManager = new Ado.netMultiTableExample.PubsDataSetTableAdapters.TableAdapterManager();
            this.salesTableAdapter = new Ado.netMultiTableExample.PubsDataSetTableAdapters.salesTableAdapter();
            this.storesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.storesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSalesView = new System.Windows.Forms.DataGridView();
            this.storidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paytermsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStoreId = new System.Windows.Forms.ComboBox();
            stor_idLabel = new System.Windows.Forms.Label();
            stor_nameLabel = new System.Windows.Forms.Label();
            stor_addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingNavigator)).BeginInit();
            this.storesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesView)).BeginInit();
            this.SuspendLayout();
            // 
            // stor_idLabel
            // 
            stor_idLabel.AutoSize = true;
            stor_idLabel.Location = new System.Drawing.Point(45, 52);
            stor_idLabel.Name = "stor_idLabel";
            stor_idLabel.Size = new System.Drawing.Size(49, 13);
            stor_idLabel.TabIndex = 1;
            stor_idLabel.Text = "Store ID:";
            // 
            // stor_nameLabel
            // 
            stor_nameLabel.AutoSize = true;
            stor_nameLabel.Location = new System.Drawing.Point(45, 78);
            stor_nameLabel.Name = "stor_nameLabel";
            stor_nameLabel.Size = new System.Drawing.Size(66, 13);
            stor_nameLabel.TabIndex = 3;
            stor_nameLabel.Text = "Store Name:";
            // 
            // stor_addressLabel
            // 
            stor_addressLabel.AutoSize = true;
            stor_addressLabel.Location = new System.Drawing.Point(45, 104);
            stor_addressLabel.Name = "stor_addressLabel";
            stor_addressLabel.Size = new System.Drawing.Size(48, 13);
            stor_addressLabel.TabIndex = 5;
            stor_addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(45, 130);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(26, 13);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "city:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(45, 156);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(33, 13);
            stateLabel.TabIndex = 9;
            stateLabel.Text = "state:";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(45, 182);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(23, 13);
            zipLabel.TabIndex = 11;
            zipLabel.Text = "zip:";
            // 
            // pubsDataSet
            // 
            this.pubsDataSet.DataSetName = "PubsDataSet";
            this.pubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataMember = "stores";
            this.storesBindingSource.DataSource = this.pubsDataSet;
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.discountsTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.jobsTableAdapter = null;
            this.tableAdapterManager.pub_infoTableAdapter = null;
            this.tableAdapterManager.publishersTableAdapter = null;
            this.tableAdapterManager.royschedTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = this.salesTableAdapter;
            this.tableAdapterManager.storesTableAdapter = this.storesTableAdapter;
            this.tableAdapterManager.titleauthorTableAdapter = null;
            this.tableAdapterManager.titlesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ado.netMultiTableExample.PubsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // storesBindingNavigator
            // 
            this.storesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.storesBindingNavigator.BindingSource = this.storesBindingSource;
            this.storesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.storesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.storesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.storesBindingNavigatorSaveItem});
            this.storesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.storesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.storesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.storesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.storesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.storesBindingNavigator.Name = "storesBindingNavigator";
            this.storesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.storesBindingNavigator.Size = new System.Drawing.Size(485, 25);
            this.storesBindingNavigator.TabIndex = 0;
            this.storesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // storesBindingNavigatorSaveItem
            // 
            this.storesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.storesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("storesBindingNavigatorSaveItem.Image")));
            this.storesBindingNavigatorSaveItem.Name = "storesBindingNavigatorSaveItem";
            this.storesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.storesBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storesBindingSource, "stor_name", true));
            this.txtName.Location = new System.Drawing.Point(118, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storesBindingSource, "stor_address", true));
            this.txtAddress.Location = new System.Drawing.Point(118, 101);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storesBindingSource, "city", true));
            this.txtCity.Location = new System.Drawing.Point(118, 127);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 8;
            // 
            // txtState
            // 
            this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storesBindingSource, "state", true));
            this.txtState.Location = new System.Drawing.Point(118, 153);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 10;
            // 
            // txtZip
            // 
            this.txtZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storesBindingSource, "zip", true));
            this.txtZip.Location = new System.Drawing.Point(118, 179);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 12;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.pubsDataSet;
            // 
            // dgvSalesVoew
            // 
            this.dgvSalesView.AutoGenerateColumns = false;
            this.dgvSalesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storidDataGridViewTextBoxColumn,
            this.ordnumDataGridViewTextBoxColumn,
            this.orddateDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.paytermsDataGridViewTextBoxColumn,
            this.titleidDataGridViewTextBoxColumn});
            this.dgvSalesView.DataSource = this.salesBindingSource;
            this.dgvSalesView.Location = new System.Drawing.Point(12, 205);
            this.dgvSalesView.Name = "dgvSalesVoew";
            this.dgvSalesView.Size = new System.Drawing.Size(461, 220);
            this.dgvSalesView.TabIndex = 13;
            // 
            // storidDataGridViewTextBoxColumn
            // 
            this.storidDataGridViewTextBoxColumn.DataPropertyName = "stor_id";
            this.storidDataGridViewTextBoxColumn.HeaderText = "stor_id";
            this.storidDataGridViewTextBoxColumn.Name = "storidDataGridViewTextBoxColumn";
            // 
            // ordnumDataGridViewTextBoxColumn
            // 
            this.ordnumDataGridViewTextBoxColumn.DataPropertyName = "ord_num";
            this.ordnumDataGridViewTextBoxColumn.HeaderText = "ord_num";
            this.ordnumDataGridViewTextBoxColumn.Name = "ordnumDataGridViewTextBoxColumn";
            // 
            // orddateDataGridViewTextBoxColumn
            // 
            this.orddateDataGridViewTextBoxColumn.DataPropertyName = "ord_date";
            this.orddateDataGridViewTextBoxColumn.HeaderText = "ord_date";
            this.orddateDataGridViewTextBoxColumn.Name = "orddateDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // paytermsDataGridViewTextBoxColumn
            // 
            this.paytermsDataGridViewTextBoxColumn.DataPropertyName = "payterms";
            this.paytermsDataGridViewTextBoxColumn.HeaderText = "payterms";
            this.paytermsDataGridViewTextBoxColumn.Name = "paytermsDataGridViewTextBoxColumn";
            // 
            // titleidDataGridViewTextBoxColumn
            // 
            this.titleidDataGridViewTextBoxColumn.DataPropertyName = "title_id";
            this.titleidDataGridViewTextBoxColumn.HeaderText = "title_id";
            this.titleidDataGridViewTextBoxColumn.Name = "titleidDataGridViewTextBoxColumn";
            // 
            // txtStoreId
            // 
            this.txtStoreId.FormattingEnabled = true;
            this.txtStoreId.Location = new System.Drawing.Point(118, 43);
            this.txtStoreId.Name = "txtStoreId";
            this.txtStoreId.Size = new System.Drawing.Size(100, 21);
            this.txtStoreId.TabIndex = 14;
            this.txtStoreId.SelectionChangeCommitted += new System.EventHandler(this.TxtStoreId_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 486);
            this.Controls.Add(this.txtStoreId);
            this.Controls.Add(this.dgvSalesView);
            this.Controls.Add(stor_idLabel);
            this.Controls.Add(stor_nameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(stor_addressLabel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.txtState);
            this.Controls.Add(zipLabel);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.storesBindingNavigator);
            this.Name = "Form1";
            this.Text = "Pubs and Store Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingNavigator)).EndInit();
            this.storesBindingNavigator.ResumeLayout(false);
            this.storesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PubsDataSet pubsDataSet;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private PubsDataSetTableAdapters.storesTableAdapter storesTableAdapter;
        private PubsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator storesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton storesBindingNavigatorSaveItem;
        private PubsDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Windows.Forms.DataGridView dgvSalesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn storidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paytermsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox txtStoreId;
    }
}

