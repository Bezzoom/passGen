﻿namespace passGen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_Main));
            this.cb_Capitalize = new System.Windows.Forms.CheckBox();
            this.cb_Small = new System.Windows.Forms.CheckBox();
            this.cb_Digits = new System.Windows.Forms.CheckBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_pass_count = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cm_Tray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_FastGen = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_symbols = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pass_count)).BeginInit();
            this.cm_Tray.SuspendLayout();
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
            this.cb_Small.Location = new System.Drawing.Point(67, 12);
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
            this.cb_Digits.Location = new System.Drawing.Point(119, 12);
            this.cb_Digits.Name = "cb_Digits";
            this.cb_Digits.Size = new System.Drawing.Size(47, 17);
            this.cb_Digits.TabIndex = 2;
            this.cb_Digits.Text = "0...9";
            this.cb_Digits.UseVisualStyleBackColor = true;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(228, 8);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(135, 52);
            this.btn_Generate.TabIndex = 4;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(55, 40);
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
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lenght";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Count";
            // 
            // num_pass_count
            // 
            this.num_pass_count.Location = new System.Drawing.Point(172, 40);
            this.num_pass_count.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.num_pass_count.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.num_pass_count.Name = "num_pass_count";
            this.num_pass_count.Size = new System.Drawing.Size(46, 20);
            this.num_pass_count.TabIndex = 9;
            this.num_pass_count.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cm_Tray;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "passGen";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // cm_Tray
            // 
            this.cm_Tray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_FastGen,
            this.mi_Show,
            this.mi_About,
            this.toolStripSeparator1,
            this.mi_Close});
            this.cm_Tray.Name = "cm_Tray";
            this.cm_Tray.Size = new System.Drawing.Size(168, 98);
            // 
            // mi_FastGen
            // 
            this.mi_FastGen.Name = "mi_FastGen";
            this.mi_FastGen.Size = new System.Drawing.Size(167, 22);
            this.mi_FastGen.Text = "Быстрый пароль";
            this.mi_FastGen.ToolTipText = "Генерировать пароль и скопироватье его в буфер обмена";
            this.mi_FastGen.Click += new System.EventHandler(this.mi_FastGen_Click);
            // 
            // mi_Show
            // 
            this.mi_Show.Name = "mi_Show";
            this.mi_Show.Size = new System.Drawing.Size(167, 22);
            this.mi_Show.Text = "Развернуть";
            this.mi_Show.Click += new System.EventHandler(this.mi_Show_Click);
            // 
            // mi_About
            // 
            this.mi_About.Name = "mi_About";
            this.mi_About.Size = new System.Drawing.Size(167, 22);
            this.mi_About.Text = "О Программе";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // mi_Close
            // 
            this.mi_Close.Name = "mi_Close";
            this.mi_Close.Size = new System.Drawing.Size(167, 22);
            this.mi_Close.Text = "Выход";
            this.mi_Close.Click += new System.EventHandler(this.выToolStripMenuItem_Click);
            // 
            // cb_symbols
            // 
            this.cb_symbols.AutoSize = true;
            this.cb_symbols.Checked = true;
            this.cb_symbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_symbols.Location = new System.Drawing.Point(172, 12);
            this.cb_symbols.Name = "cb_symbols";
            this.cb_symbols.Size = new System.Drawing.Size(50, 17);
            this.cb_symbols.TabIndex = 10;
            this.cb_symbols.Text = "@#$";
            this.cb_symbols.UseVisualStyleBackColor = true;
            // 
            // fm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 68);
            this.Controls.Add(this.cb_symbols);
            this.Controls.Add(this.num_pass_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.cb_Digits);
            this.Controls.Add(this.cb_Small);
            this.Controls.Add(this.cb_Capitalize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fm_Main";
            this.Text = "passGen 0.1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pass_count)).EndInit();
            this.cm_Tray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        // Checkboxes
        public System.Windows.Forms.CheckBox cb_Capitalize;
        public System.Windows.Forms.CheckBox cb_Small;
        public System.Windows.Forms.CheckBox cb_Digits;
        public System.Windows.Forms.CheckBox cb_symbols;

        // Buttons
        private System.Windows.Forms.Button btn_Generate;

        // Labels
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        // Others
        private System.Windows.Forms.NumericUpDown num_pass_count;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cm_Tray;
        private System.Windows.Forms.ToolStripMenuItem mi_Close;
        private System.Windows.Forms.ToolStripMenuItem mi_About;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mi_FastGen;
        private System.Windows.Forms.ToolStripMenuItem mi_Show;
    }
}

