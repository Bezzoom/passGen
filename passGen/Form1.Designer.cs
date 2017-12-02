namespace pGen
{
    partial class fm_Main
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
            this.cb_Capitalize = new System.Windows.Forms.CheckBox();
            this.cb_Small = new System.Windows.Forms.CheckBox();
            this.cb_Digits = new System.Windows.Forms.CheckBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Capitalize
            // 
            this.cb_Capitalize.AutoSize = true;
            this.cb_Capitalize.Checked = true;
            this.cb_Capitalize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Capitalize.Location = new System.Drawing.Point(12, 12);
            this.cb_Capitalize.Name = "cb_Capitalize";
            this.cb_Capitalize.Size = new System.Drawing.Size(49, 17);
            this.cb_Capitalize.TabIndex = 0;
            this.cb_Capitalize.Text = "A...Z";
            this.cb_Capitalize.UseVisualStyleBackColor = true;
            // 
            // cb_Small
            // 
            this.cb_Small.AutoSize = true;
            this.cb_Small.Checked = true;
            this.cb_Small.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Small.Location = new System.Drawing.Point(12, 35);
            this.cb_Small.Name = "cb_Small";
            this.cb_Small.Size = new System.Drawing.Size(46, 17);
            this.cb_Small.TabIndex = 1;
            this.cb_Small.Text = "a...z";
            this.cb_Small.UseVisualStyleBackColor = true;
            // 
            // cb_Digits
            // 
            this.cb_Digits.AutoSize = true;
            this.cb_Digits.Checked = true;
            this.cb_Digits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Digits.Location = new System.Drawing.Point(12, 58);
            this.cb_Digits.Name = "cb_Digits";
            this.cb_Digits.Size = new System.Drawing.Size(47, 17);
            this.cb_Digits.TabIndex = 2;
            this.cb_Digits.Text = "0...9";
            this.cb_Digits.UseVisualStyleBackColor = true;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(81, 54);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(135, 23);
            this.btn_Generate.TabIndex = 4;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // tb_Result
            // 
            this.tb_Result.Location = new System.Drawing.Point(81, 33);
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.Size = new System.Drawing.Size(135, 20);
            this.tb_Result.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(170, 11);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lenght";
            // 
            // fm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 85);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.tb_Result);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.cb_Digits);
            this.Controls.Add(this.cb_Small);
            this.Controls.Add(this.cb_Capitalize);
            this.Name = "fm_Main";
            this.Text = "pGen 0.1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_Capitalize;
        private System.Windows.Forms.CheckBox cb_Small;
        private System.Windows.Forms.CheckBox cb_Digits;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox tb_Result;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

