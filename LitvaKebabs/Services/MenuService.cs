using LiteDB;
using LitvaKebabs.Models;

namespace LitvaKebabs.Services
{
    public class MenuService : IMenuService
    {
        private ILiteCollection<MenuItem> _menuItemTable;

        public MenuService()
        {
            LiteDatabase database = new(@"Filename=./mydatabase; Connection=shared");

            _menuItemTable = database.GetCollection<MenuItem>("menuItems");

            bool hasItems = _menuItemTable.Query().ToList().Count != 0;

            if (!hasItems)
            {
                _menuItemTable.InsertBulk(new List<MenuItem>()
                    {
                        new()
                        {
                            Id = ObjectId.NewObjectId(),
                            Name = "\"CHICKEN DÖNER WRAP\"",
                            Price = 10.95M
                        },
                        new()
                        {
                            Id = ObjectId.NewObjectId(),
                            Name = "CHICKEN SHISH WRAP",
                            Price = 11.95M
                        },
                        new()
                        {Id = ObjectId.NewObjectId(),

                            Name = "LAMB YAPRAK WRAP",
                            Price = 12.95M
                        },
                        new()
                        {Id = ObjectId.NewObjectId(),
                            Name = "LAMB DÖNER WRAP",
                            Price = 10.95M
                        },
                        new()
                        {Id = ObjectId.NewObjectId(),
                            Name = "LAMB SHISH WRAP",
                            Price = 12.95M
                        },
                        new()
                        {Id = ObjectId.NewObjectId(),
                            Name = "MIX SHISH WRAP",
                            Price = 12.95M
                        },
                        new()
                        {Id = ObjectId.NewObjectId(),
                            Name = "LAMB KÖFTE WRAP",
                            Price = 11.95M
                        },
                        new()
                        {   Id = ObjectId.NewObjectId(),
                            Name = "MINT SAUCE",
                            Price = 0.49M
                        },
                        new()
                        {Id = ObjectId.NewObjectId(),
                            Name = "MAYO",
                            Price = 0.49M
                        },
                        new()
                        {Id = ObjectId.NewObjectId(),
                            Name = "HUMMUS",
                            Price = 0.99M
                        },
                        new()
                        {Id = ObjectId.NewObjectId(),
                            Name = "SALAD CREAM",
                            Price = 0.99M
                        },
                        new()
                        {Id = ObjectId.NewObjectId(),
                            Name = "TAHINI",
                            Price = 0.99M
                        },
                        new()
                        {Id = ObjectId.NewObjectId(),
                            Name = "LEMON AND LIME SAUCE",
                            Price = 0.99M
                        },
                        new()
                        {Id = ObjectId.NewObjectId(),
                            Name = "AJVAR",
                            Price = 1.99M
                        },
                        new()
                        {Id = ObjectId.NewObjectId(),
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

        public void DeleteMenuItem(ObjectId id)
        {
            _menuItemTable.Delete(id);
        }
    }
}
