namespace Burger_Display
{
    public partial class Form1 : Form
    {

        List<SaleItem>? currentMenu;
        InventoryManager inventory = new();
        MenuManager menu = new();

        Order currentOrder = new();
        public Form1()
        {
            InitializeComponent();

            LoadMenu();
        }
    
        public void UpdateMenuDisplay()
        {
            listBox1.Items.Clear();
            if (currentMenu == null)
            {
                listBox1.Items.Add("Menu Failed to Load");
                return;
            }
            //Grab Categories
            foreach (var item in currentMenu!)
            {
                listBox1.Items.Add(item.Name);
            }
        }

        public void LoadMenu()
        {
            inventory.LoadInventoryItems();
            currentMenu = menu.LoadMenu(inventory);
            

            UpdateMenuDisplay();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_Button.Enabled = listBox1.SelectedItem != null;
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            remove_Button.Enabled = listBox2.SelectedItem != null;
        }

        private void add_Button_Click(object sender, EventArgs e)
        {
            var selectedOption = (string)listBox1.SelectedItem;
            if (menu.CanMakeItem(selectedOption))
            {
                SaleItem? item = menu.MakeItem(selectedOption);
                if (item != null)
                {
                    currentOrder.AddToOrder(item);
                    listBox2.Items.Add(item!.Name);
                }
            }
        }

        private void remove_Button_Click(object sender, EventArgs e)
        {
            var selectedOption = (string)listBox2.SelectedItem;
            currentOrder.RemoveFromOrder(selectedOption);
            menu.UnMakeItem(selectedOption);
            listBox2.Items.Remove(selectedOption);
        }

    }
}