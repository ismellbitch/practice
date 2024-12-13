//using practice.Models;


using practice.Models;

namespace practice
{
    public partial class MainForm : Form
    {
        private List<Material> list;
        private WarehouseContext db;

        public MainForm()
        {
            InitializeComponent();

            db = new WarehouseContext();
            list = db.Materials.ToList();

            UpdateForm();
        }

        public void UpdateForm()
        {
            panelMaterials.Controls.Clear();
            list = db.Materials.ToList();
            int x = 0;
            for (int i = 0; i < list.Count; i++)
            {
                Panel pc = new Panel(list[i], this);
                pc.Top = x;
                panelMaterials.Controls.Add(pc);
                x += pc.Height;
            }
        }

        public void UpdateForm(List<Material> sortingList)
        {
            panelMaterials.Controls.Clear();
            int x = 0;
            for (int i = 0; i < sortingList.Count; i++)
            {
                Panel pc = new Panel(sortingList[i], this);
                pc.Top = x;
                panelMaterials.Controls.Add(pc);
                x += pc.Height;
            }
        }


        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortForm();
        }
        public void SortForm()
        {
            if (comboBoxSort.SelectedIndex == 0)
            {
                panelMaterials.Controls.Clear();
                list = db.Materials.ToList();
                list = list.OrderBy(i => i.Count).ToList();
                int Y = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    Panel pc = new Panel(list[i], this);
                    pc.Top = Y;
                    panelMaterials.Controls.Add(pc);
                    Y += pc.Height + 10;
                }
            }
            else
            {
                panelMaterials.Controls.Clear();

                list = db.Materials.ToList();
                list = list.OrderBy(i => i.Count).ToList();
                list.Reverse();
                int Y = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    Panel pc = new Panel(list[i],this);
                    pc.Top = Y;
                    panelMaterials.Controls.Add(pc);
                    Y += pc.Height + 10;
                }
            }
        }

        private void textBoxNameSearch_TextChanged(object sender, EventArgs e)
        {
            panelMaterials.Controls.Clear();

            list = db.Materials.Where(i => i.Name.Contains(textBoxNameSearch.Text)).ToList();
            int Y = 0;
            for (int i = 0; i < list.Count; i++)
            {
                Panel pc = new Panel(list[i], this);
                pc.Top = Y;
                panelMaterials.Controls.Add(pc);
                Y += pc.Height + 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditForm window = new AddEditForm();
            if (window.ShowDialog() == DialogResult.OK)
            {
                Material material = new Material();
                material.Name = window.textBoxName.Text;
                material.Type = window.comboBoxTypes.Text;
                material.Price = Convert.ToInt32(window.numericUpDownPrice.Value);
                material.Count = Convert.ToInt32(window.numericUpDownCount.Value);
                material.MinCount = Convert.ToInt32(window.numericUpDownMinCount.Value);
                material.ItemsInPackage = Convert.ToInt32(window.numericUpDownItemsInPackage.Value);
                material.Unit = window.comboBoxUnits.Text;
                using (db = new WarehouseContext())
                {
                    db.Materials.Add(material);
                    db.SaveChanges();
                    UpdateForm();
                }
            }
        }
    }
}
