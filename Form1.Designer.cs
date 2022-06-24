namespace Patterns
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AnimalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalRunMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveToTxt = new System.Windows.Forms.RadioButton();
            this.SaveToXml = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load animal list";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnimalType,
            this.AnimalName,
            this.AnimalRunMethod});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 278);
            this.dataGridView1.TabIndex = 1;
            // 
            // AnimalType
            // 
            this.AnimalType.HeaderText = "Animal Type";
            this.AnimalType.Name = "AnimalType";
            // 
            // AnimalName
            // 
            this.AnimalName.HeaderText = "Animal name";
            this.AnimalName.Name = "AnimalName";
            // 
            // AnimalRunMethod
            // 
            this.AnimalRunMethod.HeaderText = "Run method";
            this.AnimalRunMethod.Name = "AnimalRunMethod";
            // 
            // SaveList
            // 
            this.SaveList.Location = new System.Drawing.Point(440, 228);
            this.SaveList.Name = "SaveList";
            this.SaveList.Size = new System.Drawing.Size(131, 43);
            this.SaveList.TabIndex = 2;
            this.SaveList.Text = "Save list";
            this.SaveList.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveToXml);
            this.groupBox1.Controls.Add(this.SaveToTxt);
            this.groupBox1.Location = new System.Drawing.Point(440, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(80, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save file to:";
            // 
            // SaveToTxt
            // 
            this.SaveToTxt.AutoSize = true;
            this.SaveToTxt.Checked = true;
            this.SaveToTxt.Location = new System.Drawing.Point(17, 35);
            this.SaveToTxt.Name = "SaveToTxt";
            this.SaveToTxt.Size = new System.Drawing.Size(40, 17);
            this.SaveToTxt.TabIndex = 0;
            this.SaveToTxt.TabStop = true;
            this.SaveToTxt.Text = "Txt";
            this.SaveToTxt.UseVisualStyleBackColor = true;
            // 
            // SaveToXml
            // 
            this.SaveToXml.AutoSize = true;
            this.SaveToXml.Location = new System.Drawing.Point(17, 58);
            this.SaveToXml.Name = "SaveToXml";
            this.SaveToXml.Size = new System.Drawing.Size(42, 17);
            this.SaveToXml.TabIndex = 1;
            this.SaveToXml.Text = "Xml";
            this.SaveToXml.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 302);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalRunMethod;
        private System.Windows.Forms.Button SaveList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SaveToXml;
        private System.Windows.Forms.RadioButton SaveToTxt;
    }
}

