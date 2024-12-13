//using practice.Models;
using practice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practice
{
    public partial class Panel : UserControl
    {
        private Material material;
        private WarehouseContext db;
        private MainForm form;

        public Panel(Material _material, MainForm _form)
        {
            InitializeComponent();

            material = _material;
            form = _form;

            labelType.Text = material.Type;
            labelName.Text = material.Name;
            labelMinCount.Text = material.MinCount.ToString();
            labelItemsLeft.Text = material.Count.ToString();
        }

        private void Panel_DoubleClick(object sender, EventArgs e)
        {
            AddEditForm window = new AddEditForm(material);
            if (window.ShowDialog() == DialogResult.OK)
            {
                material.Name = window.textBoxName.Text;
                material.Type = window.comboBoxTypes.Text;
                material.Price = Convert.ToInt32(window.numericUpDownPrice.Value);
                material.Count = Convert.ToInt32(window.numericUpDownCount.Value);
                material.MinCount = Convert.ToInt32(window.numericUpDownMinCount.Value);
                material.ItemsInPackage = Convert.ToInt32(window.numericUpDownItemsInPackage.Value);
                material.Unit = window.comboBoxUnits.Text;
                db.Materials.Update(material);
                db.SaveChanges();
                form.UpdateForm();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить элемент {material.Name}?", "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    db = new WarehouseContext();
                    db.Remove(material);
                    db.SaveChanges();
                    form.UpdateForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Невозможно удалить элемент {ex.Message}");
                }
            }
        }
    }
}
