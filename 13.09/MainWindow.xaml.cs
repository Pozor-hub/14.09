using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace _13._09
{
    public partial class MainWindow : Window
    { 
         public ObservableCollection<Ingredient> ingredients { get; set; }
         public ObservableCollection<Ingredient> setIngredients { get; set; }
         public Ingredient selectedIngredient { get; set; }
         public float totalSum { get; set; } 
      
        
        public MainWindow()
         {
          List<Ingredient> producs = new List<Ingredient>();

           InitializeComponent();

           DataContext = this;

            ingredients = new ObservableCollection<Ingredient>();
            setIngredients = new ObservableCollection<Ingredient>();
            
            ingredients.Add(new Ingredient("Сыр", 70));
            ingredients.Add(new Ingredient("Огурец", 50));
            ingredients.Add(new Ingredient("Помидор", 60));
         }

        private void LBIngeddients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (selectedIngredient == null) return;

            if(!listBox.Items.Contains(selectedIngredient))
            {
                setIngredients.Add(selectedIngredient);
            }

            selectedIngredient.Count++;  //=0 попробовать
            totalSum += selectedIngredient.Price;

            sum.GetBindingExpression(Label.ContentProperty).UpdateTarget();
            LBIngeddients.SelectedIndex = -1;
            listBox.GetBindingExpression(ListBox.ItemsSourceProperty).UpdateSource();
            listBox.GetBindingExpression(ListBox.ItemsSourceProperty).UpdateTarget();
        }
    }
}
