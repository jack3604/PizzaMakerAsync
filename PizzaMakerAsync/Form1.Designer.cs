namespace PizzaMakerAsync
{
    partial class Form1
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
            PizzaMakerGridView = new DataGridView();
            PizzaMakerPositionColumn = new DataGridViewTextBoxColumn();
            PizzaMakerNameColumn = new DataGridViewTextBoxColumn();
            PizzaMakerTaskColumn = new DataGridViewTextBoxColumn();
            WorkButton = new Button();
            PizzaCountLabel = new Label();
            SpawnPizzaMakerButton = new Button();
            OvenGridView = new DataGridView();
            OvenPositionColumn = new DataGridViewTextBoxColumn();
            OvenDescriptionColumn = new DataGridViewTextBoxColumn();
            OvenBakeColumn = new DataGridViewTextBoxColumn();
            RackDataGridView = new DataGridView();
            RackPositionColumn = new DataGridViewTextBoxColumn();
            RackDescriptionColumn = new DataGridViewTextBoxColumn();
            RackBakeColumn = new DataGridViewTextBoxColumn();
            OvenTenderGridView = new DataGridView();
            OvenTenderPositionColumn = new DataGridViewTextBoxColumn();
            OvenTenderNameColumn = new DataGridViewTextBoxColumn();
            OvenTenderTaskColumn = new DataGridViewTextBoxColumn();
            SpawnOvenTenderButton = new Button();
            OrderDataGridView = new DataGridView();
            OrderPositionColumn = new DataGridViewTextBoxColumn();
            OrderDescriptionColumn = new DataGridViewTextBoxColumn();
            FirePizzaMakerButton = new Button();
            FireOvenTenderButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PizzaMakerGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OvenGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RackDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OvenTenderGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).BeginInit();
            SuspendLayout();
            // 
            // PizzaMakerGridView
            // 
            PizzaMakerGridView.AllowUserToAddRows = false;
            PizzaMakerGridView.AllowUserToDeleteRows = false;
            PizzaMakerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PizzaMakerGridView.Columns.AddRange(new DataGridViewColumn[] { PizzaMakerPositionColumn, PizzaMakerNameColumn, PizzaMakerTaskColumn });
            PizzaMakerGridView.Location = new Point(248, 43);
            PizzaMakerGridView.Name = "PizzaMakerGridView";
            PizzaMakerGridView.ReadOnly = true;
            PizzaMakerGridView.RowHeadersVisible = false;
            PizzaMakerGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PizzaMakerGridView.Size = new Size(230, 600);
            PizzaMakerGridView.TabIndex = 0;
            // 
            // PizzaMakerPositionColumn
            // 
            PizzaMakerPositionColumn.HeaderText = "#";
            PizzaMakerPositionColumn.Name = "PizzaMakerPositionColumn";
            PizzaMakerPositionColumn.ReadOnly = true;
            PizzaMakerPositionColumn.Width = 25;
            // 
            // PizzaMakerNameColumn
            // 
            PizzaMakerNameColumn.HeaderText = "Name";
            PizzaMakerNameColumn.Name = "PizzaMakerNameColumn";
            PizzaMakerNameColumn.ReadOnly = true;
            // 
            // PizzaMakerTaskColumn
            // 
            PizzaMakerTaskColumn.HeaderText = "Current task";
            PizzaMakerTaskColumn.Name = "PizzaMakerTaskColumn";
            PizzaMakerTaskColumn.ReadOnly = true;
            // 
            // WorkButton
            // 
            WorkButton.Location = new Point(12, 12);
            WorkButton.Name = "WorkButton";
            WorkButton.Size = new Size(90, 23);
            WorkButton.TabIndex = 1;
            WorkButton.Text = "Spawn order";
            WorkButton.UseVisualStyleBackColor = true;
            WorkButton.Click += WorkButton_Click;
            // 
            // PizzaCountLabel
            // 
            PizzaCountLabel.AutoSize = true;
            PizzaCountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PizzaCountLabel.Location = new Point(1167, 14);
            PizzaCountLabel.Name = "PizzaCountLabel";
            PizzaCountLabel.Size = new Size(19, 21);
            PizzaCountLabel.TabIndex = 2;
            PizzaCountLabel.Text = "0";
            // 
            // SpawnPizzaMakerButton
            // 
            SpawnPizzaMakerButton.Location = new Point(248, 14);
            SpawnPizzaMakerButton.Name = "SpawnPizzaMakerButton";
            SpawnPizzaMakerButton.Size = new Size(116, 23);
            SpawnPizzaMakerButton.TabIndex = 3;
            SpawnPizzaMakerButton.Text = "Spawn Pizza Maker";
            SpawnPizzaMakerButton.UseVisualStyleBackColor = true;
            SpawnPizzaMakerButton.Click += SpawnPizzaMakerButton_Click;
            // 
            // OvenGridView
            // 
            OvenGridView.AllowUserToAddRows = false;
            OvenGridView.AllowUserToDeleteRows = false;
            OvenGridView.AllowUserToResizeColumns = false;
            OvenGridView.AllowUserToResizeRows = false;
            OvenGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OvenGridView.Columns.AddRange(new DataGridViewColumn[] { OvenPositionColumn, OvenDescriptionColumn, OvenBakeColumn });
            OvenGridView.Location = new Point(484, 43);
            OvenGridView.Name = "OvenGridView";
            OvenGridView.ReadOnly = true;
            OvenGridView.RowHeadersVisible = false;
            OvenGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OvenGridView.Size = new Size(230, 600);
            OvenGridView.TabIndex = 4;
            // 
            // OvenPositionColumn
            // 
            OvenPositionColumn.HeaderText = "#";
            OvenPositionColumn.Name = "OvenPositionColumn";
            OvenPositionColumn.ReadOnly = true;
            OvenPositionColumn.Width = 25;
            // 
            // OvenDescriptionColumn
            // 
            OvenDescriptionColumn.HeaderText = "Desc.";
            OvenDescriptionColumn.Name = "OvenDescriptionColumn";
            OvenDescriptionColumn.ReadOnly = true;
            // 
            // OvenBakeColumn
            // 
            OvenBakeColumn.HeaderText = "Bake time";
            OvenBakeColumn.Name = "OvenBakeColumn";
            OvenBakeColumn.ReadOnly = true;
            // 
            // RackDataGridView
            // 
            RackDataGridView.AllowUserToAddRows = false;
            RackDataGridView.AllowUserToDeleteRows = false;
            RackDataGridView.AllowUserToResizeColumns = false;
            RackDataGridView.AllowUserToResizeRows = false;
            RackDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RackDataGridView.Columns.AddRange(new DataGridViewColumn[] { RackPositionColumn, RackDescriptionColumn, RackBakeColumn });
            RackDataGridView.Location = new Point(956, 43);
            RackDataGridView.Name = "RackDataGridView";
            RackDataGridView.ReadOnly = true;
            RackDataGridView.RowHeadersVisible = false;
            RackDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RackDataGridView.Size = new Size(230, 300);
            RackDataGridView.TabIndex = 5;
            // 
            // RackPositionColumn
            // 
            RackPositionColumn.HeaderText = "#";
            RackPositionColumn.Name = "RackPositionColumn";
            RackPositionColumn.ReadOnly = true;
            RackPositionColumn.Width = 25;
            // 
            // RackDescriptionColumn
            // 
            RackDescriptionColumn.HeaderText = "Desc.";
            RackDescriptionColumn.Name = "RackDescriptionColumn";
            RackDescriptionColumn.ReadOnly = true;
            // 
            // RackBakeColumn
            // 
            RackBakeColumn.HeaderText = "Bake Percent";
            RackBakeColumn.Name = "RackBakeColumn";
            RackBakeColumn.ReadOnly = true;
            // 
            // OvenTenderGridView
            // 
            OvenTenderGridView.AllowUserToAddRows = false;
            OvenTenderGridView.AllowUserToDeleteRows = false;
            OvenTenderGridView.AllowUserToResizeColumns = false;
            OvenTenderGridView.AllowUserToResizeRows = false;
            OvenTenderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OvenTenderGridView.Columns.AddRange(new DataGridViewColumn[] { OvenTenderPositionColumn, OvenTenderNameColumn, OvenTenderTaskColumn });
            OvenTenderGridView.Location = new Point(720, 43);
            OvenTenderGridView.Name = "OvenTenderGridView";
            OvenTenderGridView.ReadOnly = true;
            OvenTenderGridView.RowHeadersVisible = false;
            OvenTenderGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OvenTenderGridView.Size = new Size(230, 600);
            OvenTenderGridView.TabIndex = 6;
            // 
            // OvenTenderPositionColumn
            // 
            OvenTenderPositionColumn.HeaderText = "#";
            OvenTenderPositionColumn.Name = "OvenTenderPositionColumn";
            OvenTenderPositionColumn.ReadOnly = true;
            OvenTenderPositionColumn.Width = 25;
            // 
            // OvenTenderNameColumn
            // 
            OvenTenderNameColumn.HeaderText = "Name";
            OvenTenderNameColumn.Name = "OvenTenderNameColumn";
            OvenTenderNameColumn.ReadOnly = true;
            // 
            // OvenTenderTaskColumn
            // 
            OvenTenderTaskColumn.HeaderText = "Current task";
            OvenTenderTaskColumn.Name = "OvenTenderTaskColumn";
            OvenTenderTaskColumn.ReadOnly = true;
            // 
            // SpawnOvenTenderButton
            // 
            SpawnOvenTenderButton.Location = new Point(720, 12);
            SpawnOvenTenderButton.Name = "SpawnOvenTenderButton";
            SpawnOvenTenderButton.Size = new Size(123, 23);
            SpawnOvenTenderButton.TabIndex = 7;
            SpawnOvenTenderButton.Text = "Spawn oven tender";
            SpawnOvenTenderButton.UseVisualStyleBackColor = true;
            SpawnOvenTenderButton.Click += SpawnOvenTenderButton_Click;
            // 
            // OrderDataGridView
            // 
            OrderDataGridView.AllowUserToAddRows = false;
            OrderDataGridView.AllowUserToDeleteRows = false;
            OrderDataGridView.AllowUserToResizeColumns = false;
            OrderDataGridView.AllowUserToResizeRows = false;
            OrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDataGridView.Columns.AddRange(new DataGridViewColumn[] { OrderPositionColumn, OrderDescriptionColumn });
            OrderDataGridView.Location = new Point(12, 43);
            OrderDataGridView.Name = "OrderDataGridView";
            OrderDataGridView.ReadOnly = true;
            OrderDataGridView.RowHeadersVisible = false;
            OrderDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderDataGridView.Size = new Size(230, 600);
            OrderDataGridView.TabIndex = 8;
            // 
            // OrderPositionColumn
            // 
            OrderPositionColumn.HeaderText = "#";
            OrderPositionColumn.Name = "OrderPositionColumn";
            OrderPositionColumn.ReadOnly = true;
            OrderPositionColumn.Width = 25;
            // 
            // OrderDescriptionColumn
            // 
            OrderDescriptionColumn.HeaderText = "Desc.";
            OrderDescriptionColumn.Name = "OrderDescriptionColumn";
            OrderDescriptionColumn.ReadOnly = true;
            // 
            // FirePizzaMakerButton
            // 
            FirePizzaMakerButton.Location = new Point(370, 14);
            FirePizzaMakerButton.Name = "FirePizzaMakerButton";
            FirePizzaMakerButton.Size = new Size(75, 23);
            FirePizzaMakerButton.TabIndex = 9;
            FirePizzaMakerButton.Text = "Fire";
            FirePizzaMakerButton.UseVisualStyleBackColor = true;
            FirePizzaMakerButton.Click += FirePizzaMakerButton_Click;
            // 
            // FireOvenTenderButton
            // 
            FireOvenTenderButton.Location = new Point(849, 12);
            FireOvenTenderButton.Name = "FireOvenTenderButton";
            FireOvenTenderButton.Size = new Size(75, 23);
            FireOvenTenderButton.TabIndex = 10;
            FireOvenTenderButton.Text = "Fire";
            FireOvenTenderButton.UseVisualStyleBackColor = true;
            FireOvenTenderButton.Click += FireOvenTenderButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1240, 838);
            Controls.Add(FireOvenTenderButton);
            Controls.Add(FirePizzaMakerButton);
            Controls.Add(OrderDataGridView);
            Controls.Add(SpawnOvenTenderButton);
            Controls.Add(OvenTenderGridView);
            Controls.Add(RackDataGridView);
            Controls.Add(OvenGridView);
            Controls.Add(SpawnPizzaMakerButton);
            Controls.Add(PizzaCountLabel);
            Controls.Add(WorkButton);
            Controls.Add(PizzaMakerGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PizzaMakerGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OvenGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)RackDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OvenTenderGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PizzaMakerGridView;
        private Button WorkButton;
        private Label PizzaCountLabel;
        private Button SpawnPizzaMakerButton;
        private DataGridView OvenGridView;
        private DataGridView RackDataGridView;
        private DataGridView OvenTenderGridView;
        private Button SpawnOvenTenderButton;
        private DataGridViewTextBoxColumn PizzaMakerPositionColumn;
        private DataGridViewTextBoxColumn PizzaMakerNameColumn;
        private DataGridViewTextBoxColumn PizzaMakerTaskColumn;
        private DataGridViewTextBoxColumn OvenPositionColumn;
        private DataGridViewTextBoxColumn OvenDescriptionColumn;
        private DataGridViewTextBoxColumn OvenBakeColumn;
        private DataGridViewTextBoxColumn RackPositionColumn;
        private DataGridViewTextBoxColumn RackDescriptionColumn;
        private DataGridViewTextBoxColumn RackBakeColumn;
        private DataGridViewTextBoxColumn OvenTenderPositionColumn;
        private DataGridViewTextBoxColumn OvenTenderNameColumn;
        private DataGridViewTextBoxColumn OvenTenderTaskColumn;
        private DataGridView OrderDataGridView;
        private DataGridViewTextBoxColumn OrderPositionColumn;
        private DataGridViewTextBoxColumn OrderDescriptionColumn;
        private Button FirePizzaMakerButton;
        private Button FireOvenTenderButton;
    }
}
