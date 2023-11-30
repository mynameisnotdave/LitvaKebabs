using LiteDB;
using LitvaKebabs.Models;

namespace LitvaKebabs.Services
{
    public interface IMenuService
    {
        public List<MenuItem> GetMenuItems();

        public void InsertMenuItem(MenuItem menuItem);

        public void UpdateMenuItem(MenuItem menuItem);

        public void DeleteMenuItem(ObjectId id);

    }
}
