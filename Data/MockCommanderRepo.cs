using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
               new Command{Id=0, Howto="Get directory info", Line="ls -al", Platform="RHEL"},
               new Command{Id=1, Howto="Get cpu&mem", Line="top", Platform="RHEL"},
               new Command{Id=2, Howto="Get ip", Line="ifconfig", Platform="RHEL"} 
            };   
            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command{Id=0, Howto="Get directory info", Line="ls -al", Platform="RHEL"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            //Nothing
        }
    }
}