using System.IO;
using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace FurnitureStore_Bartova.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(Classes.Item item)
        {
            InitializeComponent();
            if (item != null) {
                if (File.Exists(Directory.GetCurrentDirectory() + "/" + item.src))
                    image.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/" + item.src));
                
                price.Content = item.price;
                name.Content = item.name;
            }
        }
    }
}
