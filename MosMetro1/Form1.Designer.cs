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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.FindPathButton = new System.Windows.Forms.Button();
            this.PathListBox = new System.Windows.Forms.ListBox();
            this.TimeTravelLabel = new System.Windows.Forms.Label();
            this.ControlGroup = new System.Windows.Forms.GroupBox();
            this.undegroundMap = new System.Windows.Forms.PictureBox();
            this.DepartureGroup.SuspendLayout();
            this.DestinationGroup.SuspendLayout();
            this.ControlGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.undegroundMap)).BeginInit();
            this.SuspendLayout();
            // 
            // BranchDepartureComboBox
            // 
            this.BranchDepartureComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BranchDepartureComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BranchDepartureComboBox.FormattingEnabled = true;
            this.BranchDepartureComboBox.Location = new System.Drawing.Point(6, 45);
            this.BranchDepartureComboBox.Name = "BranchDepartureComboBox";
            this.BranchDepartureComboBox.Size = new System.Drawing.Size(211, 24);
            this.BranchDepartureComboBox.TabIndex = 0;
            this.BranchDepartureComboBox.SelectedIndexChanged += new System.EventHandler(this.BranchDepartureComboBox_SelectedIndexChanged);
            // 
            // StationDepartureComboBox
            // 
            this.StationDepartureComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StationDepartureComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StationDepartureComboBox.FormattingEnabled = true;
            this.StationDepartureComboBox.Location = new System.Drawing.Point(6, 91);
            this.StationDepartureComboBox.Name = "StationDepartureComboBox";
            this.StationDepartureComboBox.Size = new System.Drawing.Size(211, 24);
            this.StationDepartureComboBox.TabIndex = 1;
            this.StationDepartureComboBox.SelectedIndexChanged += new System.EventHandler(this.StationDepartureComboBox_SelectedIndexChanged);
            // 
            // BranchDepartureLabel
            // 
            this.BranchDepartureLabel.AutoSize = true;
            this.BranchDepartureLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BranchDepartureLabel.Location = new System.Drawing.Point(6, 26);
            this.BranchDepartureLabel.Name = "BranchDepartureLabel";
            this.BranchDepartureLabel.Size = new System.Drawing.Size(136, 16);
            this.BranchDepartureLabel.TabIndex = 2;
            this.BranchDepartureLabel.Text = "Ветка отправления";
            // 
            // StationDepartureLabel
            // 
            this.StationDepartureLabel.AutoSize = true;
            this.StationDepartureLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StationDepartureLabel.Location = new System.Drawing.Point(6, 72);
            this.StationDepartureLabel.Name = "StationDepartureLabel";
            this.StationDepartureLabel.Size = new System.Drawing.Size(152, 16);
            this.StationDepartureLabel.TabIndex = 3;
            this.StationDepartureLabel.Text = "Станция отправления";
            this.StationDepartureLabel.Click += new System.EventHandler(this.StationDestinationLabel_Click);
            // 
            // BranchDestinationComboBox
            // 
            this.BranchDestinationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BranchDestinationComboBox.FormattingEnabled = true;
            this.BranchDestinationComboBox.Location = new System.Drawing.Point(6, 45);
            this.BranchDestinationComboBox.Name = "BranchDestinationComboBox";
            this.BranchDestinationComboBox.Size = new System.Drawing.Size(211, 24);
            this.BranchDestinationComboBox.TabIndex = 4;
            this.BranchDestinationComboBox.SelectedIndexChanged += new System.EventHandler(this.BranchDestinationComboBox_SelectedIndexChanged);
            // 
            // StationDestinationComboBox
            // 
            this.StationDestinationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StationDestinationComboBox.FormattingEnabled = true;
            this.StationDestinationComboBox.Location = new System.Drawing.Point(6, 91);
            this.StationDestinationComboBox.Name = "StationDestinationComboBox";
            this.StationDestinationComboBox.Size = new System.Drawing.Size(211, 24);
            this.StationDestinationComboBox.TabIndex = 5;
            this.StationDestinationComboBox.SelectedIndexChanged += new System.EventHandler(this.StationDestinationComboBox_SelectedIndexChanged);
            // 
            // BranchDestinationLabel
            // 
            this.BranchDestinationLabel.AutoSize = true;
            this.BranchDestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BranchDestinationLabel.Location = new System.Drawing.Point(6, 26);
            this.BranchDestinationLabel.Name = "BranchDestinationLabel";
            this.BranchDestinationLabel.Size = new System.Drawing.Size(113, 16);
            this.BranchDestinationLabel.TabIndex = 6;
            this.BranchDestinationLabel.Text = "Ветка прибытия";
            // 
            // StationDestinationLabel
            // 
            this.StationDestinationLabel.AutoSize = true;
            this.StationDestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StationDestinationLabel.Location = new System.Drawing.Point(6, 72);
            this.StationDestinationLabel.Name = "StationDestinationLabel";
            this.StationDestinationLabel.Size = new System.Drawing.Size(129, 16);
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
            this.DepartureGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartureGroup.Location = new System.Drawing.Point(18, 21);
            this.DepartureGroup.Name = "DepartureGroup";
            this.DepartureGroup.Size = new System.Drawing.Size(223, 121);
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
            this.DestinationGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DestinationGroup.Location = new System.Drawing.Point(18, 148);
            this.DestinationGroup.Name = "DestinationGroup";
            this.DestinationGroup.Size = new System.Drawing.Size(223, 121);
            this.DestinationGroup.TabIndex = 9;
            this.DestinationGroup.TabStop = false;
            this.DestinationGroup.Text = "Прибытие";
            // 
            // FindPathButton
            // 
            this.FindPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindPathButton.Location = new System.Drawing.Point(24, 275);
            this.FindPathButton.Name = "FindPathButton";
            this.FindPathButton.Size = new System.Drawing.Size(211, 23);
            this.FindPathButton.TabIndex = 10;
            this.FindPathButton.Text = "Найти маршрут";
            this.FindPathButton.UseVisualStyleBackColor = true;
            this.FindPathButton.Click += new System.EventHandler(this.FindPathButton_Click);
            // 
            // PathListBox
            // 
            this.PathListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathListBox.FormattingEnabled = true;
            this.PathListBox.ItemHeight = 16;
            this.PathListBox.Location = new System.Drawing.Point(24, 332);
            this.PathListBox.Name = "PathListBox";
            this.PathListBox.Size = new System.Drawing.Size(211, 516);
            this.PathListBox.TabIndex = 11;
            // 
            // TimeTravelLabel
            // 
            this.TimeTravelLabel.AutoSize = true;
            this.TimeTravelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeTravelLabel.Location = new System.Drawing.Point(25, 313);
            this.TimeTravelLabel.Name = "TimeTravelLabel";
            this.TimeTravelLabel.Size = new System.Drawing.Size(0, 16);
            this.TimeTravelLabel.TabIndex = 12;
            this.TimeTravelLabel.Click += new System.EventHandler(this.TimeTravelLabel_Click);
            // 
            // ControlGroup
            // 
            this.ControlGroup.Controls.Add(this.PathListBox);
            this.ControlGroup.Controls.Add(this.FindPathButton);
            this.ControlGroup.Controls.Add(this.TimeTravelLabel);
            this.ControlGroup.Controls.Add(this.DestinationGroup);
            this.ControlGroup.Controls.Add(this.DepartureGroup);
            this.ControlGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlGroup.Location = new System.Drawing.Point(702, 12);
            this.ControlGroup.Name = "ControlGroup";
            this.ControlGroup.Size = new System.Drawing.Size(270, 867);
            this.ControlGroup.TabIndex = 13;
            this.ControlGroup.TabStop = false;
            this.ControlGroup.Text = "Управление";
            // 
            // undegroundMap
            // 
            this.undegroundMap.ErrorImage = null;
            this.undegroundMap.Image = ((System.Drawing.Image)(resources.GetObject("undegroundMap.Image")));
            this.undegroundMap.InitialImage = null;
            this.undegroundMap.Location = new System.Drawing.Point(12, 10);
            this.undegroundMap.Name = "undegroundMap";
            this.undegroundMap.Size = new System.Drawing.Size(684, 870);
            this.undegroundMap.TabIndex = 14;
            this.undegroundMap.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 891);
            this.Controls.Add(this.undegroundMap);
            this.Controls.Add(this.ControlGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.DepartureGroup.ResumeLayout(false);
            this.DepartureGroup.PerformLayout();
            this.DestinationGroup.ResumeLayout(false);
            this.DestinationGroup.PerformLayout();
            this.ControlGroup.ResumeLayout(false);
            this.ControlGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.undegroundMap)).EndInit();
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
        private System.Windows.Forms.Button FindPathButton;
        private System.Windows.Forms.ListBox PathListBox;
        private System.Windows.Forms.Label TimeTravelLabel;
        private System.Windows.Forms.GroupBox ControlGroup;
        private System.Windows.Forms.PictureBox undegroundMap;
    }
}

