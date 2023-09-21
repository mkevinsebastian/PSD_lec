using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KevinErvanKenji_LabPSD.Factory;
using KevinErvanKenji_LabPSD.Model;
using KevinErvanKenji_LabPSD.Repository;

namespace KevinErvanKenji_LabPSD.View
{
    public partial class cartPage : System.Web.UI.Page
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        TransactionRepos tr = new TransactionRepos();
        public List<Customer> allCustomer = new List<Customer>();
        public List<TransactionHeader> allTH = new List<TransactionHeader>();
        public List<Album> allAlbum = new List<Album>();
        protected void Page_Load(object sender, EventArgs e)
        {
            allCustomer = tr.getCustomer();
            allTH = tr.getTH();
            allAlbum = tr.getAlbum();
        }

       
    }
}