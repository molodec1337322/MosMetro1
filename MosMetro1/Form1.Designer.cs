namespace MosMetro1
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
            this.BranchDepartureComboBox = new System.Windows.Forms.ComboBox();
            this.StationDepartureComboBox = new System.Windows.Forms.ComboBox();
            this.BranchDepartureLabel = new System.Windows.Forms.Label();
            this.StationDepartureLabel = new System.Windows.Forms.Label();
            this.BranchDestinationComboBox = new System.Windows.Forms.ComboBox();
            this.StationDestinationComboBox = new System.Windows.Forms.ComboBox();
            this.BranchDestinationLabel = new System.Windows.Forms.Label();
            this.StationDestinationLabel = new System.Windows.Forms.Label();
            this.DepartureGroup = new System.Windows.Forms.GroupBox();
            this.DestinationGroup = new System.Windows.Forms.GroupBox();
            this.DepartureGroup.SuspendLayout();
            this.DestinationGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // BranchDepartureComboBox
            // 
            this.BranchDepartureComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BranchDepartureComboBox.FormattingEnabled = true;
            this.BranchDepartureComboBox.Location = new System.Drawing.Point(6, 32);
            this.BranchDepartureComboBox.Name = "BranchDepartureComboBox";
            this.BranchDepartureComboBox.Size = new System.Drawing.Size(171, 21);
            this.BranchDepartureComboBox.TabIndex = 0;
            this.BranchDepartureComboBox.SelectedIndexChanged += new System.EventHandler(this.BranchDepartureComboBox_SelectedIndexChanged);
            // 
            // StationDepartureComboBox
            // 
            this.StationDepartureComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StationDepartureComboBox.FormattingEnabled = true;
            this.StationDepartureComboBox.Location = new System.Drawing.Point(6, 72);
            this.StationDepartureComboBox.Name = "StationDepartureComboBox";
            this.StationDepartureComboBox.Size = new System.Drawing.Size(171, 21);
            this.StationDepartureComboBox.TabIndex = 1;
            this.StationDepartureComboBox.SelectedIndexChanged += new System.EventHandler(this.StationDepartureComboBox_SelectedIndexChanged);
            // 
            // BranchDepartureLabel
            // 
            this.BranchDepartureLabel.AutoSize = true;
            this.BranchDepartureLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BranchDepartureLabel.Location = new System.Drawing.Point(6, 16);
            this.BranchDepartureLabel.Name = "BranchDepartureLabel";
            this.BranchDepartureLabel.Size = new System.Drawing.Size(105, 13);
            this.BranchDepartureLabel.TabIndex = 2;
            this.BranchDepartureLabel.Text = "Ветка отправления";
            // 
            // StationDepartureLabel
            // 
            this.StationDepartureLabel.AutoSize = true;
            this.StationDepartureLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StationDepartureLabel.Location = new System.Drawing.Point(6, 56);
            this.StationDepartureLabel.Name = "StationDepartureLabel";
            this.StationDepartureLabel.Size = new System.Drawing.Size(117, 13);
            this.StationDepartureLabel.TabIndex = 3;
            this.StationDepartureLabel.Text = "Станция отправления";
            this.StationDepartureLabel.Click += new System.EventHandler(this.StationDestinationLabel_Click);
            // 
            // BranchDestinationComboBox
            // 
            this.BranchDestinationComboBox.FormattingEnabled = true;
            this.BranchDestinationComboBox.Location = new System.Drawing.Point(6, 35);
            this.BranchDestinationComboBox.Name = "BranchDestinationComboBox";
            this.BranchDestinationComboBox.Size = new System.Drawing.Size(171, 21);
            this.BranchDestinationComboBox.TabIndex = 4;
            this.BranchDestinationComboBox.SelectedIndexChanged += new System.EventHandler(this.BranchDestinationComboBox_SelectedIndexChanged);
            // 
            // StationDestinationComboBox
            // 
            this.StationDestinationComboBox.FormattingEnabled = true;
            this.StationDestinationComboBox.Location = new System.Drawing.Point(6, 73);
            this.StationDestinationComboBox.Name = "StationDestinationComboBox";
            this.StationDestinationComboBox.Size = new System.Drawing.Size(171, 21);
            this.StationDestinationComboBox.TabIndex = 5;
            this.StationDestinationComboBox.SelectedIndexChanged += new System.EventHandler(this.StationDestinationComboBox_SelectedIndexChanged);
            // 
            // BranchDestinationLabel
            // 
            this.BranchDestinationLabel.AutoSize = true;
            this.BranchDestinationLabel.Location = new System.Drawing.Point(6, 16);
            this.BranchDestinationLabel.Name = "BranchDestinationLabel";
            this.BranchDestinationLabel.Size = new System.Drawing.Size(89, 13);
            this.BranchDestinationLabel.TabIndex = 6;
            this.BranchDestinationLabel.Text = "Ветка прибытия";
            // 
            // StationDestinationLabel
            // 
            this.StationDestinationLabel.AutoSize = true;
            this.StationDestinationLabel.Location = new System.Drawing.Point(6, 59);
            this.StationDestinationLabel.Name = "StationDestinationLabel";
            this.StationDestinationLabel.Size = new System.Drawing.Size(101, 13);
            this.StationDestinationLabel.TabIndex = 7;
            this.StationDestinationLabel.Text = "Станция прибытия";
            this.StationDestinationLabel.Click += new System.EventHandler(this.StationDestinationLabel_Click_1);
            // 
            // DepartureGroup
            // 
            this.DepartureGroup.Controls.Add(this.BranchDepartureLabel);
            this.DepartureGroup.Controls.Add(this.StationDepartureLabel);
            this.DepartureGroup.Controls.Add(this.BranchDepartureComboBox);
            this.DepartureGroup.Controls.Add(this.StationDepartureComboBox);
            this.DepartureGroup.Location = new System.Drawing.Point(789, 12);
            this.DepartureGroup.Name = "DepartureGroup";
            this.DepartureGroup.Size = new System.Drawing.Size(183, 103);
            this.DepartureGroup.TabIndex = 8;
            this.DepartureGroup.TabStop = false;
            this.DepartureGroup.Text = "Отправление";
            this.DepartureGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DestinationGroup
            // 
            this.DestinationGroup.Controls.Add(this.BranchDestinationLabel);
            this.DestinationGroup.Controls.Add(this.BranchDestinationComboBox);
            this.DestinationGroup.Controls.Add(this.StationDestinationLabel);
            this.DestinationGroup.Controls.Add(this.StationDestinationComboBox);
            this.DestinationGroup.Location = new System.Drawing.Point(789, 121);
            this.DestinationGroup.Name = "DestinationGroup";
            this.DestinationGroup.Size = new System.Drawing.Size(183, 103);
            this.DestinationGroup.TabIndex = 9;
            this.DestinationGroup.TabStop = false;
            this.DestinationGroup.Text = "Прибытие";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.DestinationGroup);
            this.Controls.Add(this.DepartureGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.DepartureGroup.ResumeLayout(false);
            this.DepartureGroup.PerformLayout();
            this.DestinationGroup.ResumeLayout(false);
            this.DestinationGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox BranchDepartureComboBox;
        private System.Windows.Forms.ComboBox StationDepartureComboBox;
        private System.Windows.Forms.Label BranchDepartureLabel;
        private System.Windows.Forms.Label StationDepartureLabel;
        private System.Windows.Forms.ComboBox BranchDestinationComboBox;
        private System.Windows.Forms.ComboBox StationDestinationComboBox;
        private System.Windows.Forms.Label BranchDestinationLabel;
        private System.Windows.Forms.Label StationDestinationLabel;
        private System.Windows.Forms.GroupBox DepartureGroup;
        private System.Windows.Forms.GroupBox DestinationGroup;
    }
}

