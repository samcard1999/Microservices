using CommandsService.Models;

namespace CommandsService.Data
{
    public interface IcommandRepo
    {
        bool SaveChanges();
        //Platforms
        IEnumerable<Platform> GetAllPlatforms();
        void CreatePlatform(Platform plat);
        bool PlatformExist(int platformId);
        bool ExternalPlatformExist(int externalPlatformId);

        //Commands
        IEnumerable<Command> GetCommandsForPlatform(int plawtformId);
        Command GetComand(int platformId, int commandId);
        void CreateCommand(int platfomrId, Command command);

    }
}
