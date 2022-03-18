using System.Collections.Generic;

namespace Factory.Models
{
    public class Machine
    {
        public Machine()
        {
            this.JoinEntities = new HashSet<WorkerMachine>();
        }

        public int MachineId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<WorkerMachine> JoinEntities { get; set; }
    }
}