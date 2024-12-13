namespace practice
{
    partial class Panel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            pictureBox1 = new PictureBox();
            labelType = new Label();
            labelName = new Label();
            labelMinCount = new Label();
            labelItemsLeft = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(109, 3);
            labelType.Name = "labelType";
            labelType.Size = new Size(27, 15);
            labelType.TabIndex = 1;
            labelType.Text = "Тип";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(256, 3);
            labelName.Name = "labelName";
            labelName.Size = new Size(90, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Наименование";
            // 
            // labelMinCount
            // 
            labelMinCount.AutoSize = true;
            labelMinCount.Location = new Point(109, 31);
            labelMinCount.Name = "labelMinCount";
            labelMinCount.Size = new Size(154, 15);
            labelMinCount.TabIndex = 3;
            labelMinCount.Text = "Минимальное количество";
            // 
            // labelItemsLeft
            // 
            labelItemsLeft.AutoSize = true;
            labelItemsLeft.Location = new Point(533, 3);
            labelItemsLeft.Name = "labelItemsLeft";
            labelItemsLeft.Size = new Size(51, 15);
            labelItemsLeft.TabIndex = 5;
            labelItemsLeft.Text = "Остаток";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(652, 3);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 7;
            label1.Text = "x";
            label1.Click += label1_Click;
            // 
            // Panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label1);
            Controls.Add(labelItemsLeft);
            Controls.Add(labelMinCount);
            Controls.Add(labelName);
            Controls.Add(labelType);
            Controls.Add(pictureBox1);
            Name = "Panel";
            Size = new Size(668, 79);
            DoubleClick += Panel_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelType;
        private Label labelName;
        private Label labelMinCount;
        private Label labelItemsLeft;
        private Label label1;
    }
}
