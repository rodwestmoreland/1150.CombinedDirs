using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public abstract class EntityBase
    {
        public enum EntitityStateOption
        {
            Active,
            Disabled
        }
        public EntitityStateOption EntityState { get; set; }
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public bool IsValid => ValidateInput();
        public abstract bool ValidateInput();
    }
}
