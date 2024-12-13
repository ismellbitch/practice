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

namespace practice
{
    public partial class AddEditForm : Form
    {
        public AddEditForm()
        {
            InitializeComponent();
        }
        public AddEditForm(Material material)
        {
            InitializeComponent();
            textBoxName.Text = material.Name;
            if (material.Type == "Гранулы") comboBoxTypes.SelectedIndex = 0;
            else if (material.Type == "Нарезка") comboBoxTypes.SelectedIndex = 1;
            else if (material.Type == "Рулон") comboBoxTypes.SelectedIndex = 2;
            else if (material.Type == "Пресс") comboBoxTypes.SelectedIndex = 3;
            else comboBoxTypes.SelectedIndex = 0;
            numericUpDownPrice.Value = material.Price;
            numericUpDownCount.Value = material.Count;
            numericUpDownMinCount.Value = material.MinCount;
            numericUpDownItemsInPackage.Value = Convert.ToInt32(material.ItemsInPackage);
            if (material.Unit == "м") comboBoxUnits.SelectedIndex = 0;
            else if (material.Unit == "кг") comboBoxUnits.SelectedIndex = 1;
            else if (material.Unit == "м") comboBoxUnits.SelectedIndex = 2;
            else comboBoxUnits.SelectedIndex = 0;
        }
    }
}
