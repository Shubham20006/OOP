using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementDemo
{
    public class InventoryDetails
    {
        public List<TypesOfShare>typesOfShare;
       
    }
    public class TypesOfShare
    {
        public string name;
        public int NumOfShare;
        public int price;
    }
   
}