
namespace Yulya
{
    partial class Addtovar
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
            this.components = new System.ComponentModel.Container();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.Catlabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.CattextBox = new System.Windows.Forms.TextBox();
            this.addbut = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.magazinstrDataSet = new Yulya.magazinstrDataSet();
            this.magazinstrDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazinstrDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.magazinstrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinstrDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinstrDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Namelabel.Location = new System.Drawing.Point(32, 57);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(141, 20);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Название товара";
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pricelabel.Location = new System.Drawing.Point(33, 103);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(48, 20);
            this.Pricelabel.TabIndex = 1;
            this.Pricelabel.Text = "Цена";
            // 
            // Catlabel
            // 
            this.Catlabel.AutoSize = true;
            this.Catlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Catlabel.Location = new System.Drawing.Point(33, 151);
            this.Catlabel.Name = "Catlabel";
            this.Catlabel.Size = new System.Drawing.Size(147, 20);
            this.Catlabel.TabIndex = 2;
            this.Catlabel.Text = "Категория товара";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(256, 57);
            this.NametextBox.Multiline = true;
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(161, 29);
            this.NametextBox.TabIndex = 3;
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(256, 103);
            this.PricetextBox.Multiline = true;
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(161, 32);
            this.PricetextBox.TabIndex = 4;
            // 
            // CattextBox
            // 
            this.CattextBox.Location = new System.Drawing.Point(256, 151);
            this.CattextBox.Multiline = true;
            this.CattextBox.Name = "CattextBox";
            this.CattextBox.Size = new System.Drawing.Size(161, 34);
            this.CattextBox.TabIndex = 5;
            // 
            // addbut
            // 
            this.addbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbut.Location = new System.Drawing.Point(276, 342);
            this.addbut.Name = "addbut";
            this.addbut.Size = new System.Drawing.Size(96, 41);
            this.addbut.TabIndex = 6;
            this.addbut.Text = "Добавить";
            this.addbut.UseVisualStyleBackColor = true;
            this.addbut.Click += new System.EventHandler(this.addbut_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Backbutton.Location = new System.Drawing.Point(51, 342);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(96, 41);
            this.Backbutton.TabIndex = 7;
            this.Backbutton.Text = "Назад";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // magazinstrDataSet
            // 
            this.magazinstrDataSet.DataSetName = "magazinstrDataSet";
            this.magazinstrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // magazinstrDataSetBindingSource
            // 
            this.magazinstrDataSetBindingSource.DataSource = this.magazinstrDataSet;
            this.magazinstrDataSetBindingSource.Position = 0;
            // 
            // magazinstrDataSetBindingSource1
            // 
            this.magazinstrDataSetBindingSource1.DataSource = this.magazinstrDataSet;
            this.magazinstrDataSetBindingSource1.Position = 0;
            // 
            // Addtovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 447);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.addbut);
            this.Controls.Add(this.CattextBox);
            this.Controls.Add(this.PricetextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.Catlabel);
            this.Controls.Add(this.Pricelabel);
            this.Controls.Add(this.Namelabel);
            this.Name = "Addtovar";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.magazinstrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinstrDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinstrDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Pricelabel;
        private System.Windows.Forms.Label Catlabel;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.TextBox CattextBox;
        private System.Windows.Forms.Button addbut;
        private System.Windows.Forms.Button Backbutton;
        private magazinstrDataSet magazinstrDataSet;
        private System.Windows.Forms.BindingSource magazinstrDataSetBindingSource;
        private System.Windows.Forms.BindingSource magazinstrDataSetBindingSource1;
    }
}