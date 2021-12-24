
namespace Yulya
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Info = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addbutton = new System.Windows.Forms.Button();
            this.changebutton = new System.Windows.Forms.Button();
            this.Delbutton = new System.Windows.Forms.Button();
            this.search_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.price,
            this.category});
            this.Info.HideSelection = false;
            this.Info.Location = new System.Drawing.Point(12, 97);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(500, 341);
            this.Info.TabIndex = 0;
            this.Info.UseCompatibleStateImageBehavior = false;
            this.Info.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            // 
            // name
            // 
            this.name.Text = "Название";
            this.name.Width = 100;
            // 
            // price
            // 
            this.price.Text = "Цена";
            // 
            // category
            // 
            this.category.Text = "Категория";
            this.category.Width = 120;
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbutton.Location = new System.Drawing.Point(568, 97);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(136, 45);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "Добавить товар";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // changebutton
            // 
            this.changebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changebutton.Location = new System.Drawing.Point(568, 148);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(136, 44);
            this.changebutton.TabIndex = 2;
            this.changebutton.Text = "Редактировать товар";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
            // 
            // Delbutton
            // 
            this.Delbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delbutton.Location = new System.Drawing.Point(568, 198);
            this.Delbutton.Name = "Delbutton";
            this.Delbutton.Size = new System.Drawing.Size(136, 42);
            this.Delbutton.TabIndex = 3;
            this.Delbutton.Text = "Удалить товар";
            this.Delbutton.UseVisualStyleBackColor = true;
            this.Delbutton.Click += new System.EventHandler(this.Delbutton_Click);
            // 
            // search_Box
            // 
            this.search_Box.Location = new System.Drawing.Point(13, 39);
            this.search_Box.Multiline = true;
            this.search_Box.Name = "search_Box";
            this.search_Box.Size = new System.Drawing.Size(328, 32);
            this.search_Box.TabIndex = 4;
            this.search_Box.TextChanged += new System.EventHandler(this.search_Box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_Box);
            this.Controls.Add(this.Delbutton);
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.Info);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Info;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button changebutton;
        private System.Windows.Forms.Button Delbutton;
        private System.Windows.Forms.TextBox search_Box;
        private System.Windows.Forms.Label label1;
    }
}

