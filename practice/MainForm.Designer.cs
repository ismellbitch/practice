namespace practice
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMaterials = new System.Windows.Forms.Panel();
            comboBoxSort = new ComboBox();
            label1 = new Label();
            textBoxNameSearch = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // panelMaterials
            // 
            panelMaterials.AutoScroll = true;
            panelMaterials.Location = new Point(12, 82);
            panelMaterials.Name = "panelMaterials";
            panelMaterials.Size = new Size(697, 363);
            panelMaterials.TabIndex = 0;
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "По возрастанию", "По убыванию" });
            comboBoxSort.Location = new Point(221, 32);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(121, 23);
            comboBoxSort.TabIndex = 1;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 14);
            label1.Name = "label1";
            label1.Size = new Size(212, 15);
            label1.TabIndex = 2;
            label1.Text = "Сортировка по количеству на складе";
            // 
            // textBoxNameSearch
            // 
            textBoxNameSearch.BorderStyle = BorderStyle.None;
            textBoxNameSearch.Location = new Point(12, 35);
            textBoxNameSearch.Name = "textBoxNameSearch";
            textBoxNameSearch.PlaceholderText = "Поиск по наименованию";
            textBoxNameSearch.Size = new Size(186, 16);
            textBoxNameSearch.TabIndex = 3;
            textBoxNameSearch.TextChanged += textBoxNameSearch_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(490, 26);
            button1.Name = "button1";
            button1.Size = new Size(131, 33);
            button1.TabIndex = 4;
            button1.Text = "Добавить материал";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 457);
            Controls.Add(button1);
            Controls.Add(textBoxNameSearch);
            Controls.Add(label1);
            Controls.Add(comboBoxSort);
            Controls.Add(panelMaterials);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelMaterials;
        private ComboBox comboBoxSort;
        private Label label1;
        private TextBox textBoxNameSearch;
        private Button button1;
    }
}
