using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.netMultiTableExample
{
    public partial class Form1 : Form
    {
        PubsDataSet pubDataSet;
        BindingSource saleBindingSource;
        BindingSource storeBindingSource;
        PubsData clsPubsData;

        Boolean gridInitialized;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            clsPubsData = new PubsData();
            pubsDataSet = clsPubsData.getDataSet();

            //binding source that references the stores table in the dataset
            storesBindingSource = new BindingSource();
            storesBindingSource.DataSource = pubsDataSet;
            storesBindingSource.DataMember = "stores";

            //binding source that reference the sales table in the dataset
            salesBindingSource = new BindingSource();
            saleBindingSource.DataSource = pubDataSet;
            saleBindingSource.DataMember = "sales";

            //combo box
            //the combo box will refrence the store name and store id column from the
            //the store data source that this will be bound to.
            txtStoreId.DataSource = storesBindingSource;
            txtStoreId.DisplayMember = "stor_name";
            txtStoreId.ValueMember = "stor_id";

            //bind other controls
            //the controls here are having data bindings that are text type, from the store data source against different columns
            txtAddress.DataBindings.Add("text", storesBindingSource, "stor_name");
            txtCity.DataBindings.Add("text", storesBindingSource, "city");
            txtState.DataBindings.Add("text", storesBindingSource.DataSource, "state");
            txtZip.DataBindings.Add("text", storesBindingSource.DataSource, "zip");

            //fires the event here when a selection change is made in the combobox
            TxtStoreId_SelectionChangeCommitted(txtStoreId, e);

        }

        private void TxtStoreId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //when the store name is selected, we convert the 
            string storeNameSelected = txtStoreId.SelectedItem.ToString();

            if(!gridInitialized)
            {
                dgvSalesView.DataSource = salesBindingSource;
                gridInitialized = true;

                ChangeGridColumns();
            }

            saleBindingSource.Filter = $"store_id '{storeNameSelected}'";
        }

        //this method changes the properties of the grid columns
        private void ChangeGridColumns()
        {
            dgvSalesView.Columns["stor_id"].Visible = false;
            dgvSalesView.Columns["ord_num"].HeaderText = "Order Number";
            dgvSalesView.Columns["ord_date"].HeaderText = "Date";
            dgvSalesView.Columns["qty"].HeaderText = "Quantity";
            dgvSalesView.Columns["payterms"].HeaderText = "Terms";
            dgvSalesView.Columns["title_id"].HeaderText = "Title";
        }
    }
}
