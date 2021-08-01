using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        //  인터페이스에서 repository 구현해야할 spec만 정의한다. 
        //  구현은 imple class 에서 한다.

        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int Id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
    }
}