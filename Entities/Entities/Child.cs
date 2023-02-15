using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
   
    public class Child
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Tz { get; set; }
      //  public virtual Person Parent { get; set; }
     //   public int ParentId { get; set; }
      
    }
}
