using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Performance_evaluation.Models
{
    public class Performance
    {
        public string Item { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        List<UserModel> listuser = new List<UserModel>();

        UserModel users = new UserModel();
    }
    
}