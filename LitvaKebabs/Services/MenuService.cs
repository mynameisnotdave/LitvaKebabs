using LiteDB;
using LitvaKebabs.Models;

namespace LitvaKebabs.Services
{
    public class MenuService
    {
        private ILiteCollection<MenuItem> _menuItemTable;

        public MenuService()
        {
            LiteDatabase database = new LiteDatabase(@"./mydatabase");

            _menuItemTable = database.GetCollection<MenuItem>("menuItems");
            var hasItems = _menuItemTable.Query().ToList().Count != 0;
            if (!hasItems)
            {
                _menuItemTable.InsertBulk(new List<MenuItem>()
                    {
                        new MenuItem()
                        {
                            Name = "\"CHICKEN DÖNER WRAP\"",
                            Price = 10.95M
                        },
                        new MenuItem()
                        {
                            Name = "CHICKEN SHISH WRAP",
                            Price = 11.95M
                        },
                        new MenuItem()
                        {
                            Name = "LAMB YAPRAK WRAP",
                            Price = 12.95M
                        },
                        new MenuItem()
                        {
                            Name = "LAMB DÖNER WRAP",
                            Price = 10.95M
                        },
                        new MenuItem()
                        {
                            Name = "LAMB SHISH WRAP",
                            Price = 12.95M
                        },
                        new MenuItem()
                        {
                            Name = "MIX SHISH WRAP",
                            Price = 12.95M
                        },
                        new MenuItem()
                        {
                            Name = "LAMB KÖFTE WRAP",
                            Price = 11.95M
                        },
                        new MenuItem()
                        {
                            Name = "MINT SAUCE",
                            Price = 0.49M
                        },
                        new MenuItem()
                        {
                            Name = "MAYO",
                            Price = 0.49M
                        },
                        new MenuItem()
                        {
                            Name = "HUMMUS",
                            Price = 0.99M
                        },
                        new MenuItem()
                        {
                            Name = "SALAD CREAM",
                            Price = 0.99M
                        },
                        new MenuItem()
                        {
                            Name = "TAHINI",
                            Price = 0.99M
                        },
                        new MenuItem()
                        {
                            Name = "LEMON AND LIME SAUCE",
                            Price = 0.99M
                        },
                        new MenuItem()
                        {
                            Name = "AJVAR",
                            Price = 1.99M
                        },
                        new MenuItem()
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
