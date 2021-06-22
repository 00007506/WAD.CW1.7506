using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAD.WebApp._7506.DAL.DTO
{
    public class Branch
    {
        public int BranchId { get; set; }

        [DisplayName("Branch Name")]
        public string BranchName { get; set; }

        [DisplayName("Branch Email")]
        public string BranchEmail { get; set; }

        [DisplayName("Branch Address")]
        public string BranchAddress { get; set; }
    }
}
