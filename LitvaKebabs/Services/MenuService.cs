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
            if (!hasItems)
            {
                _menuItemTable.InsertBulk(new List<MenuItem>()
                    {
                        new()
                        {
                            Name = "\"CHICKEN DÖNER WRAP\"",
                            Price = 10.95M
                        },
                        new()
                        {
                            Name = "CHICKEN SHISH WRAP",
                            Price = 11.95M
                        },
                        new()
                        {
                            Name = "LAMB YAPRAK WRAP",
                            Price = 12.95M
                        },
                        new()
                        {
                            Name = "LAMB DÖNER WRAP",
                            Price = 10.95M
                        },
                        new()
                        {
                            Name = "LAMB SHISH WRAP",
                            Price = 12.95M
                        },
                        new()
                        {
                            Name = "MIX SHISH WRAP",
                            Price = 12.95M
                        },
                        new()
                        {
                            Name = "LAMB KÖFTE WRAP",
                            Price = 11.95M
                        },
                        new()
                        {
                            Name = "MINT SAUCE",
                            Price = 0.49M
                        },
                        new()
                        {
                            Name = "MAYO",
                            Price = 0.49M
                        },
                        new()
                        {
                            Name = "HUMMUS",
                            Price = 0.99M
                        },
                        new()
                        {
                            Name = "SALAD CREAM",
                            Price = 0.99M
                        },
                        new()
                        {
                            Name = "TAHINI",
                            Price = 0.99M
                        },
                        new()
                        {
                            Name = "LEMON AND LIME SAUCE",
                            Price = 0.99M
                        },
                        new()
                        {
                            Name = "AJVAR",
                            Price = 1.99M
                        },
                        new()
                        {
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
    }
}
