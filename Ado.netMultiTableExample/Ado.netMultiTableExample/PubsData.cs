using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netMultiTableExample
{
    class PubsData
    {
        PubsDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        PubsDataSetTableAdapters.storesTableAdapter storesTableAdapter;
        PubsDataSet pubsDataSet;

        public PubsData()
        { }

        public PubsDataSet getDataSet()
        {
            //table adapter holds tables and data sets hold the tables
            salesTableAdapter = new PubsDataSetTableAdapters.salesTableAdapter();
            storesTableAdapter = new PubsDataSetTableAdapters.storesTableAdapter();
            pubsDataSet = new PubsDataSet();

            //data is filled via the table adapters into the pubs data set. The data set will
            //hold a property for each table
            salesTableAdapter.Fill(pubsDataSet.sales);
            storesTableAdapter.Fill(pubsDataSet.stores);

            return pubsDataSet;
            
        }
    }
}
