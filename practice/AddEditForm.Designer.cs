namespace practice
{
    partial class AddEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxName = new TextBox();
            comboBoxTypes = new ComboBox();
            materialBindingSource = new BindingSource(components);
            comboBoxSupplier = new ComboBox();
            supplierBindingSource = new BindingSource(components);
            comboBoxUnits = new ComboBox();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownCount = new NumericUpDown();
            numericUpDownMinCount = new NumericUpDown();
            numericUpDownItemsInPackage = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownItemsInPackage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 76);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "Тип";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 120);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Цена";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 164);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 3;
            label4.Text = "Количество на складе";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 208);
            label5.Name = "label5";
            label5.Size = new Size(154, 15);
            label5.TabIndex = 4;
            label5.Text = "Минимальное количество";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 252);
            label6.Name = "label6";
            label6.Size = new Size(134, 15);
            label6.TabIndex = 5;
            label6.Text = "Количество в упаковке";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 296);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 6;
            label7.Text = "Единица измерения";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 340);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 7;
            label8.Text = "Поставщик";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(32, 50);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(215, 23);
            textBoxName.TabIndex = 8;
            // 
            // comboBoxTypes
            // 
            comboBoxTypes.FormattingEnabled = true;
            comboBoxTypes.Items.AddRange(new object[] { "Гранулы", "Нарезка", "Рулон", "Пресс" });
            comboBoxTypes.Location = new Point(32, 94);
            comboBoxTypes.Name = "comboBoxTypes";
            comboBoxTypes.Size = new Size(121, 23);
            comboBoxTypes.TabIndex = 9;
            // 
            // materialBindingSource
            // 
            materialBindingSource.DataSource = typeof(Models.Material);
            // 
            // comboBoxSupplier
            // 
            comboBoxSupplier.FormattingEnabled = true;
            comboBoxSupplier.Items.AddRange(new object[] { "АлмазМикроМобайлПром", "БухИнфо", "Вектор", "Вод", "ВодОбл", "Глав", "ГлавСерви", "ГлавСтрой", "ГорТверьЛифт", "ДизайнТекстил", "ЖелДорСтройВекторКомплекс", "ЖелДорХ", "ИнжСофт", "Инфо", "Компания МорКаза", "Компания Нефть", "Компания ТелекомРосКрепПром", "Компания ТомскТверьТ", "КрепМетизВектор", "Лифт", "МонтажНефтьОрион", "МонтажОр", "ОблВектор", "Омск", "ОрионБухМетал", "Радио", "РечСофтРе", "РечТранс", "РосЮпитер", "РыбВостокХоз", "РыбИнфо", "РыбОбл", "СервисБашкирКазТраст", "Строй", "Тверь", "ТверьЛайт", "ТверьМор", "ТелекомМетизХмель", "ТелекомТра", "Тех", "ТрансМясМясКомплекс", "Урал", "УралТексти", "ФинансСервис", "ХозБашкирГла", "ХозСервис", "ЦементИнфоМонтаж", "ЦементОрион", "Электро", "ЭлектроВод" });
            comboBoxSupplier.Location = new Point(32, 358);
            comboBoxSupplier.Name = "comboBoxSupplier";
            comboBoxSupplier.Size = new Size(215, 23);
            comboBoxSupplier.TabIndex = 10;
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(Models.Supplier);
            // 
            // comboBoxUnits
            // 
            comboBoxUnits.FormattingEnabled = true;
            comboBoxUnits.Items.AddRange(new object[] { "л", "кг", "м" });
            comboBoxUnits.Location = new Point(32, 314);
            comboBoxUnits.Name = "comboBoxUnits";
            comboBoxUnits.Size = new Size(59, 23);
            comboBoxUnits.TabIndex = 11;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(33, 138);
            numericUpDownPrice.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(120, 23);
            numericUpDownPrice.TabIndex = 12;
            // 
            // numericUpDownCount
            // 
            numericUpDownCount.Location = new Point(34, 182);
            numericUpDownCount.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.Size = new Size(120, 23);
            numericUpDownCount.TabIndex = 13;
            // 
            // numericUpDownMinCount
            // 
            numericUpDownMinCount.Location = new Point(34, 226);
            numericUpDownMinCount.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDownMinCount.Name = "numericUpDownMinCount";
            numericUpDownMinCount.Size = new Size(120, 23);
            numericUpDownMinCount.TabIndex = 14;
            // 
            // numericUpDownItemsInPackage
            // 
            numericUpDownItemsInPackage.Location = new Point(34, 270);
            numericUpDownItemsInPackage.Name = "numericUpDownItemsInPackage";
            numericUpDownItemsInPackage.Size = new Size(120, 23);
            numericUpDownItemsInPackage.TabIndex = 15;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(27, 400);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 16;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(147, 400);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 17;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // AddEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 465);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDownItemsInPackage);
            Controls.Add(numericUpDownMinCount);
            Controls.Add(numericUpDownCount);
            Controls.Add(numericUpDownPrice);
            Controls.Add(comboBoxUnits);
            Controls.Add(comboBoxSupplier);
            Controls.Add(comboBoxTypes);
            Controls.Add(textBoxName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddEditForm";
            Text = "AddEditForm";
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownItemsInPackage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private BindingSource supplierBindingSource;
        public TextBox textBoxName;
        public ComboBox comboBoxTypes;
        public ComboBox comboBoxSupplier;
        public ComboBox comboBoxUnits;
        public NumericUpDown numericUpDownPrice;
        public NumericUpDown numericUpDownCount;
        public NumericUpDown numericUpDownMinCount;
        public NumericUpDown numericUpDownItemsInPackage;
        private BindingSource materialBindingSource;
        private Button button1;
        private Button button2;
    }
}