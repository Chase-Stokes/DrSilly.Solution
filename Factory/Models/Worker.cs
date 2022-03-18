using System.Collections.Generic;

namespace Factory.Models
{
  public class Worker
  {

    public Worker()
        {
            this.JoinEntities = new HashSet<WorkerMachine>();
        }
    public int WorkerId { get; set; }
    public string Name { get; set; }
    public int MachineId { get; set; }
    public virtual ICollection<WorkerMachine> JoinEntities { get;}
  }
}  