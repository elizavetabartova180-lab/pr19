using FurnitureStore_Bartova.Classes;
using System.Collections.Generic;
using System.Windows.Controls;

namespace FurnitureStore_Bartova.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public List<Item> items = new List<Item>();
        public Main()
        {
            InitializeComponent();
            items.Add(new Item("Шкаф", 20000, "C:\\Users\\ADMIN\\Desktop\\ощепков практики\\FurnitureStore_Bartova\\Images\\6832637706.jpg"));
            LoadItems();
        }
        public void LoadItems()
        {
            parent.Children.Clear();
            foreach(Item item in items)
            {
                parent.Children.Add(new Elements.Item(item));
            }
        }
    }
}
