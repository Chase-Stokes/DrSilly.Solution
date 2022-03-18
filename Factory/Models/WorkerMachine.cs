namespace Factory.Models
{
  public class WorkerMachine
    {       
        public int WorkerMachineId { get; set; }
        public int WorkerId { get; set; }
        public int MachineId { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual Machine Machine { get; set; }
    }
}