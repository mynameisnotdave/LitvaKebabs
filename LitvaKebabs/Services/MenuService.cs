using LiteDB;
using LitvaKebabs.Models;

namespace LitvaKebabs.Services
{
    public class MenuService
    {
        private ILiteCollection<MenuItem> _menuItemTable;

        public MenuService()
        {
            LiteDatabase database = new(@"Filename=./mydatabase; Connection=shared");

            _menuItemTable = database.GetCollection<MenuItem>("menuItems");
            var hasItems = _menuItemTable.Query().ToList().Count != 0;
            int id = 0;
            if (!hasItems)
            {
                _menuItemTable.InsertBulk(new List<MenuItem>()
                    {
                        new()
                        {
                            Id = id++,
                            Name = "\"CHICKEN DÖNER WRAP\"",
                            Price = 10.95M
                        },
                        new()
                        {
                            Id = id++,
                            Name = "CHICKEN SHISH WRAP",
                            Price = 11.95M
                        },
                        new()
                        {
                            Id = id++,
                            Name = "LAMB YAPRAK WRAP",
                            Price = 12.95M
                        },
                        new()
                        {
                            Id = id++,
                            Name = "LAMB DÖNER WRAP",
                            Price = 10.95M
                        },
                        new()
                        {
                            Id = id++,
                            Name = "LAMB SHISH WRAP",
                            Price = 12.95M
                        },
                        new()
                        {
                            Id = id++,
                            Name = "MIX SHISH WRAP",
                            Price = 12.95M
                        },
                        new()
                        {
                            Id = id++,
                            Name = "LAMB KÖFTE WRAP",
                            Price = 11.95M
                        },
                        new()
                        {
                            Id = id++,
                            Name = "MINT SAUCE",
                            Price = 0.49M
                        },
                        new()
                        {
                            Id = id++,
                            Name = "MAYO",
                            Price = 0.49M
                        },
                        new()
                        {
                            Id = id++,
                            Name = "HUMMUS",
                            Price = 0.99M
                        },
                        new()
                        {
                            Id = id++,
                            Name = "SALAD CREAM",
                            Price = 0.99M
                        },
                        new()
                        {
                            Id = id++,
                            Name = "TAHINI",
                            Price = 0.99M
                        },
                        new()
                        {
                            Id = id++,
                            Name = "LEMON AND LIME SAUCE",
                            Price = 0.99M
                        },
                        new()
                        {
                            Id = id++,
                            Name = "AJVAR",
                            Price = 1.99M
                        },
                        new()
                        {
                            Id = id++,
                            Name = "KAJMAK",
                            Price = 2.49M
                        }
                    });

            }

        }
        public List<MenuItem> GetMenuItems()
        {
            return _menuItemTable.Query().ToList();
        }

        public void UpsertMenuItem(MenuItem menuItem)
        {
            _menuItemTable.Upsert(menuItem);
        }

        public void DeleteMenuItem(int id)
        {
            _menuItemTable.Delete(id);
        }
    }
}
