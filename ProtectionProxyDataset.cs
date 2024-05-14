using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___LV5
{
    public class ProtectionProxyDataset : IDataset
    {
        private Dataset dataset;
        private List<int> allowedIDs;
        public User user { private get; set; }
        public ProtectionProxyDataset(User user)
        {
            this.allowedIDs = new List<int>(new int[] { 1, 3, 5 });
            this.user = user;
        }
        private bool AuthenticateUser()
        {
            return allowedIDs.Contains(this.user.ID);
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (this.AuthenticateUser())
            {
                if (this.dataset == null)
                {
                    this.dataset = new Dataset("C:\\Users\\student\\source\\repos\\RPPOON - LV5\\CSV.txt");
                }
                return this.dataset.GetData();
            }
            return null;
        }
    }
}
