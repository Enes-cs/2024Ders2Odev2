namespace Interfaces
{
    public class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
