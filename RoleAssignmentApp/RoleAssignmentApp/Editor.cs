using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleAssignmentApp
{
    public class Editor
    {
        [Key]
        public int EditorId { get; set; }
        public string EditorName { get; set; }
        public string Password { get; set; }
        public bool? CanCreate { get; set; }
        public bool? CanRead { get; set; }
        public bool? CanUpdate { get; set; }
        public bool? CanDelete { get; set; }

    }
}
