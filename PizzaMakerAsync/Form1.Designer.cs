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
            WorkButton = new Button();
            PizzaCountLabel = new Label();
            SpawnPizzaMakerButton = new Button();
            OvenGridView = new DataGridView();
            RackDataGridView = new DataGridView();
            OvenTenderGridView = new DataGridView();
            SpawnOvenTenderButton = new Button();
            OrderDataGridView = new DataGridView();
            FirePizzaMakerButton = new Button();
            FireOvenTenderButton = new Button();
            InventoryDataGridView = new DataGridView();
            OpenButton = new Button();
            MoneyLabel = new Label();
            MultiCheckbox = new CheckBox();
            InventoryQuantityColumn = new DataGridViewTextBoxColumn();
            InventoryDescriptionColumn = new DataGridViewTextBoxColumn();
            InventoryBuyColumn = new DataGridViewTextBoxColumn();
            RackPositionColumn = new DataGridViewTextBoxColumn();
            RackDescriptionColumn = new DataGridViewTextBoxColumn();
            RackBakeColumn = new DataGridViewTextBoxColumn();
            OvenTenderPositionColumn = new DataGridViewTextBoxColumn();
            OvenTenderNameColumn = new DataGridViewTextBoxColumn();
            OvenTenderTaskColumn = new DataGridViewTextBoxColumn();
            OvenPositionColumn = new DataGridViewTextBoxColumn();
            OvenDescriptionColumn = new DataGridViewTextBoxColumn();
            OvenBakeColumn = new DataGridViewTextBoxColumn();
            PizzaMakerPositionColumn = new DataGridViewTextBoxColumn();
            PizzaMakerNameColumn = new DataGridViewTextBoxColumn();
            PizzaMakerTaskColumn = new DataGridViewTextBoxColumn();
            OrderPositionColumn = new DataGridViewTextBoxColumn();
            OrderDescriptionColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)PizzaMakerGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OvenGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RackDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OvenTenderGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InventoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // PizzaMakerGridView
            // 
            PizzaMakerGridView.AllowUserToAddRows = false;
            PizzaMakerGridView.AllowUserToDeleteRows = false;
            PizzaMakerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PizzaMakerGridView.Columns.AddRange(new DataGridViewColumn[] { PizzaMakerPositionColumn, PizzaMakerNameColumn, PizzaMakerTaskColumn });
            PizzaMakerGridView.Location = new Point(148, 43);
            PizzaMakerGridView.Name = "PizzaMakerGridView";
            PizzaMakerGridView.ReadOnly = true;
            PizzaMakerGridView.RowHeadersVisible = false;
            PizzaMakerGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            PizzaMakerGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PizzaMakerGridView.Size = new Size(230, 600);
            PizzaMakerGridView.TabIndex = 0;
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
            PizzaCountLabel.Location = new Point(1067, 14);
            PizzaCountLabel.Name = "PizzaCountLabel";
            PizzaCountLabel.Size = new Size(19, 21);
            PizzaCountLabel.TabIndex = 2;
            PizzaCountLabel.Text = "0";
            // 
            // SpawnPizzaMakerButton
            // 
            SpawnPizzaMakerButton.Location = new Point(148, 14);
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
            OvenGridView.Location = new Point(384, 43);
            OvenGridView.Name = "OvenGridView";
            OvenGridView.ReadOnly = true;
            OvenGridView.RowHeadersVisible = false;
            OvenGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            OvenGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OvenGridView.Size = new Size(230, 600);
            OvenGridView.TabIndex = 4;
            // 
            // RackDataGridView
            // 
            RackDataGridView.AllowUserToAddRows = false;
            RackDataGridView.AllowUserToDeleteRows = false;
            RackDataGridView.AllowUserToResizeColumns = false;
            RackDataGridView.AllowUserToResizeRows = false;
            RackDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RackDataGridView.Columns.AddRange(new DataGridViewColumn[] { RackPositionColumn, RackDescriptionColumn, RackBakeColumn });
            RackDataGridView.Location = new Point(856, 43);
            RackDataGridView.Name = "RackDataGridView";
            RackDataGridView.ReadOnly = true;
            RackDataGridView.RowHeadersVisible = false;
            RackDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            RackDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RackDataGridView.Size = new Size(230, 300);
            RackDataGridView.TabIndex = 5;
            // 
            // OvenTenderGridView
            // 
            OvenTenderGridView.AllowUserToAddRows = false;
            OvenTenderGridView.AllowUserToDeleteRows = false;
            OvenTenderGridView.AllowUserToResizeColumns = false;
            OvenTenderGridView.AllowUserToResizeRows = false;
            OvenTenderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OvenTenderGridView.Columns.AddRange(new DataGridViewColumn[] { OvenTenderPositionColumn, OvenTenderNameColumn, OvenTenderTaskColumn });
            OvenTenderGridView.Location = new Point(620, 43);
            OvenTenderGridView.Name = "OvenTenderGridView";
            OvenTenderGridView.ReadOnly = true;
            OvenTenderGridView.RowHeadersVisible = false;
            OvenTenderGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            OvenTenderGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OvenTenderGridView.Size = new Size(230, 600);
            OvenTenderGridView.TabIndex = 6;
            // 
            // SpawnOvenTenderButton
            // 
            SpawnOvenTenderButton.Location = new Point(620, 12);
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
            OrderDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            OrderDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderDataGridView.Size = new Size(130, 600);
            OrderDataGridView.TabIndex = 8;
            // 
            // FirePizzaMakerButton
            // 
            FirePizzaMakerButton.Location = new Point(270, 14);
            FirePizzaMakerButton.Name = "FirePizzaMakerButton";
            FirePizzaMakerButton.Size = new Size(75, 23);
            FirePizzaMakerButton.TabIndex = 9;
            FirePizzaMakerButton.Text = "Fire";
            FirePizzaMakerButton.UseVisualStyleBackColor = true;
            FirePizzaMakerButton.Click += FirePizzaMakerButton_Click;
            // 
            // FireOvenTenderButton
            // 
            FireOvenTenderButton.Location = new Point(749, 12);
            FireOvenTenderButton.Name = "FireOvenTenderButton";
            FireOvenTenderButton.Size = new Size(75, 23);
            FireOvenTenderButton.TabIndex = 10;
            FireOvenTenderButton.Text = "Fire";
            FireOvenTenderButton.UseVisualStyleBackColor = true;
            FireOvenTenderButton.Click += FireOvenTenderButton_Click;
            // 
            // InventoryDataGridView
            // 
            InventoryDataGridView.AllowUserToAddRows = false;
            InventoryDataGridView.AllowUserToDeleteRows = false;
            InventoryDataGridView.AllowUserToResizeColumns = false;
            InventoryDataGridView.AllowUserToResizeRows = false;
            InventoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { InventoryQuantityColumn, InventoryDescriptionColumn, InventoryBuyColumn });
            InventoryDataGridView.Location = new Point(856, 343);
            InventoryDataGridView.Name = "InventoryDataGridView";
            InventoryDataGridView.ReadOnly = true;
            InventoryDataGridView.RowHeadersVisible = false;
            InventoryDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            InventoryDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InventoryDataGridView.Size = new Size(230, 300);
            InventoryDataGridView.TabIndex = 11;
            InventoryDataGridView.CellClick += InventoryDataGridView_CellClick;
            // 
            // OpenButton
            // 
            OpenButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OpenButton.Location = new Point(12, 649);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(142, 49);
            OpenButton.TabIndex = 12;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // MoneyLabel
            // 
            MoneyLabel.AutoSize = true;
            MoneyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MoneyLabel.Location = new Point(160, 677);
            MoneyLabel.Name = "MoneyLabel";
            MoneyLabel.Size = new Size(28, 21);
            MoneyLabel.TabIndex = 13;
            MoneyLabel.Text = "$0";
            // 
            // MultiCheckbox
            // 
            MultiCheckbox.AutoSize = true;
            MultiCheckbox.Location = new Point(108, 17);
            MultiCheckbox.Name = "MultiCheckbox";
            MultiCheckbox.Size = new Size(15, 14);
            MultiCheckbox.TabIndex = 14;
            MultiCheckbox.UseVisualStyleBackColor = true;
            // 
            // InventoryQuantityColumn
            // 
            InventoryQuantityColumn.HeaderText = "#";
            InventoryQuantityColumn.Name = "InventoryQuantityColumn";
            InventoryQuantityColumn.ReadOnly = true;
            InventoryQuantityColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            InventoryQuantityColumn.Width = 50;
            // 
            // InventoryDescriptionColumn
            // 
            InventoryDescriptionColumn.HeaderText = "Topping";
            InventoryDescriptionColumn.Name = "InventoryDescriptionColumn";
            InventoryDescriptionColumn.ReadOnly = true;
            InventoryDescriptionColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // InventoryBuyColumn
            // 
            InventoryBuyColumn.HeaderText = "";
            InventoryBuyColumn.Name = "InventoryBuyColumn";
            InventoryBuyColumn.ReadOnly = true;
            InventoryBuyColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            InventoryBuyColumn.Width = 50;
            // 
            // RackPositionColumn
            // 
            RackPositionColumn.HeaderText = "#";
            RackPositionColumn.Name = "RackPositionColumn";
            RackPositionColumn.ReadOnly = true;
            RackPositionColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            RackPositionColumn.Width = 35;
            // 
            // RackDescriptionColumn
            // 
            RackDescriptionColumn.HeaderText = "Desc.";
            RackDescriptionColumn.Name = "RackDescriptionColumn";
            RackDescriptionColumn.ReadOnly = true;
            RackDescriptionColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // RackBakeColumn
            // 
            RackBakeColumn.HeaderText = "Bake Percent";
            RackBakeColumn.Name = "RackBakeColumn";
            RackBakeColumn.ReadOnly = true;
            RackBakeColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OvenTenderPositionColumn
            // 
            OvenTenderPositionColumn.HeaderText = "#";
            OvenTenderPositionColumn.Name = "OvenTenderPositionColumn";
            OvenTenderPositionColumn.ReadOnly = true;
            OvenTenderPositionColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            OvenTenderPositionColumn.Width = 35;
            // 
            // OvenTenderNameColumn
            // 
            OvenTenderNameColumn.HeaderText = "Name";
            OvenTenderNameColumn.Name = "OvenTenderNameColumn";
            OvenTenderNameColumn.ReadOnly = true;
            OvenTenderNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OvenTenderTaskColumn
            // 
            OvenTenderTaskColumn.HeaderText = "Current task";
            OvenTenderTaskColumn.Name = "OvenTenderTaskColumn";
            OvenTenderTaskColumn.ReadOnly = true;
            OvenTenderTaskColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OvenPositionColumn
            // 
            OvenPositionColumn.HeaderText = "#";
            OvenPositionColumn.Name = "OvenPositionColumn";
            OvenPositionColumn.ReadOnly = true;
            OvenPositionColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            OvenPositionColumn.Width = 30;
            // 
            // OvenDescriptionColumn
            // 
            OvenDescriptionColumn.HeaderText = "Desc.";
            OvenDescriptionColumn.Name = "OvenDescriptionColumn";
            OvenDescriptionColumn.ReadOnly = true;
            OvenDescriptionColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OvenBakeColumn
            // 
            OvenBakeColumn.HeaderText = "Bake time";
            OvenBakeColumn.Name = "OvenBakeColumn";
            OvenBakeColumn.ReadOnly = true;
            OvenBakeColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PizzaMakerPositionColumn
            // 
            PizzaMakerPositionColumn.HeaderText = "#";
            PizzaMakerPositionColumn.Name = "PizzaMakerPositionColumn";
            PizzaMakerPositionColumn.ReadOnly = true;
            PizzaMakerPositionColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            PizzaMakerPositionColumn.Width = 25;
            // 
            // PizzaMakerNameColumn
            // 
            PizzaMakerNameColumn.HeaderText = "Name";
            PizzaMakerNameColumn.Name = "PizzaMakerNameColumn";
            PizzaMakerNameColumn.ReadOnly = true;
            PizzaMakerNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PizzaMakerTaskColumn
            // 
            PizzaMakerTaskColumn.HeaderText = "Current task";
            PizzaMakerTaskColumn.Name = "PizzaMakerTaskColumn";
            PizzaMakerTaskColumn.ReadOnly = true;
            PizzaMakerTaskColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderPositionColumn
            // 
            OrderPositionColumn.HeaderText = "#";
            OrderPositionColumn.Name = "OrderPositionColumn";
            OrderPositionColumn.ReadOnly = true;
            OrderPositionColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            OrderPositionColumn.Width = 35;
            // 
            // OrderDescriptionColumn
            // 
            OrderDescriptionColumn.HeaderText = "Desc.";
            OrderDescriptionColumn.Name = "OrderDescriptionColumn";
            OrderDescriptionColumn.ReadOnly = true;
            OrderDescriptionColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1240, 838);
            Controls.Add(MultiCheckbox);
            Controls.Add(MoneyLabel);
            Controls.Add(OpenButton);
            Controls.Add(InventoryDataGridView);
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
            ((System.ComponentModel.ISupportInitialize)InventoryDataGridView).EndInit();
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
        private DataGridView OrderDataGridView;
        private Button FirePizzaMakerButton;
        private Button FireOvenTenderButton;
        private DataGridView InventoryDataGridView;
        private Button OpenButton;
        private Label MoneyLabel;
        private CheckBox MultiCheckbox;
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
        private DataGridViewTextBoxColumn OrderPositionColumn;
        private DataGridViewTextBoxColumn OrderDescriptionColumn;
        private DataGridViewTextBoxColumn InventoryQuantityColumn;
        private DataGridViewTextBoxColumn InventoryDescriptionColumn;
        private DataGridViewTextBoxColumn InventoryBuyColumn;
    }
}
