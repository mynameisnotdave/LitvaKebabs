namespace LitvaKebabs.Util
{
    public static class Menu
    {
        public static Dictionary<string, decimal> MenuItems = new Dictionary<string, decimal>()
        {
            { "CHICKEN DÖNER WRAP", 10.95M },
            { "CHICKEN SHISH WRAP", 11.95M },
            { "LAMB YAPRAK WRAP", 12.95M },
            { "LAMB DÖNER WRAP", 10.95M },
            { "LAMB SHISH WRAP",12.95M },
            { "MIX SHISH WRAP",12.95M },
            { "LAMB KÖFTE WRAP",11.95M },
            { "FALAFEL, RED PEPPER, RED ONION & HUMMUS WRAP", 10.95M }
        };

        public static Dictionary<string, decimal> SauceItems = new Dictionary<string, decimal>()
        {
            { "MINT SAUCE", 0.49M },
            { "MAYO", 0.49M },
            { "HUMMUS", 0.99M },
            { "SALAD CREAM", 0.49M },
            { "TAHINI", 0.99M },
            { "LEMON AND LIME SAUCE", 0.99M },
            { "AJVAR", 1.99M },
            { "KAJMAK", 2.49M }
        };
    }
}
