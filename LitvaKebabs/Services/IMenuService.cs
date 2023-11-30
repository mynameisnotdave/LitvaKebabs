using LiteDB;
using LitvaKebabs.Models;

namespace LitvaKebabs.Services
{
    public interface IMenuService
    {
        public List<MenuItem> GetMenuItems();

        public void UpsertMenuItem(MenuItem menuItem);

        public void DeleteMenuItem(ObjectId id);

    }
}
