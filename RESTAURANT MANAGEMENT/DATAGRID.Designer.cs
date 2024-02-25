namespace RESTAURANT_MANAGEMENT
{
    partial class DATAGRID
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hamburgerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sandwichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mENUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataDataSet = new RESTAURANT_MANAGEMENT.restaurantDataDataSet();
            this.mENUTableAdapter = new RESTAURANT_MANAGEMENT.restaurantDataDataSetTableAdapters.MENUTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtCoffee = new System.Windows.Forms.ComboBox();
            this.txtCola = new System.Windows.Forms.ComboBox();
            this.txtTea = new System.Windows.Forms.ComboBox();
            this.txtFries = new System.Windows.Forms.ComboBox();
            this.txtSandwich = new System.Windows.Forms.ComboBox();
            this.txtHamburger = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.hamburgerDataGridViewTextBoxColumn,
            this.sandwichDataGridViewTextBoxColumn,
            this.friesDataGridViewTextBoxColumn,
            this.teaDataGridViewTextBoxColumn,
            this.colaDataGridViewTextBoxColumn,
            this.coffeeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mENUBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 609);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // hamburgerDataGridViewTextBoxColumn
            // 
            this.hamburgerDataGridViewTextBoxColumn.DataPropertyName = "hamburger";
            this.hamburgerDataGridViewTextBoxColumn.HeaderText = "hamburger";
            this.hamburgerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hamburgerDataGridViewTextBoxColumn.Name = "hamburgerDataGridViewTextBoxColumn";
            this.hamburgerDataGridViewTextBoxColumn.ReadOnly = true;
            this.hamburgerDataGridViewTextBoxColumn.Width = 125;
            // 
            // sandwichDataGridViewTextBoxColumn
            // 
            this.sandwichDataGridViewTextBoxColumn.DataPropertyName = "sandwich";
            this.sandwichDataGridViewTextBoxColumn.HeaderText = "sandwich";
            this.sandwichDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sandwichDataGridViewTextBoxColumn.Name = "sandwichDataGridViewTextBoxColumn";
            this.sandwichDataGridViewTextBoxColumn.ReadOnly = true;
            this.sandwichDataGridViewTextBoxColumn.Width = 125;
            // 
            // friesDataGridViewTextBoxColumn
            // 
            this.friesDataGridViewTextBoxColumn.DataPropertyName = "fries";
            this.friesDataGridViewTextBoxColumn.HeaderText = "fries";
            this.friesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.friesDataGridViewTextBoxColumn.Name = "friesDataGridViewTextBoxColumn";
            this.friesDataGridViewTextBoxColumn.ReadOnly = true;
            this.friesDataGridViewTextBoxColumn.Width = 125;
            // 
            // teaDataGridViewTextBoxColumn
            // 
            this.teaDataGridViewTextBoxColumn.DataPropertyName = "tea";
            this.teaDataGridViewTextBoxColumn.HeaderText = "tea";
            this.teaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teaDataGridViewTextBoxColumn.Name = "teaDataGridViewTextBoxColumn";
            this.teaDataGridViewTextBoxColumn.ReadOnly = true;
            this.teaDataGridViewTextBoxColumn.Width = 125;
            // 
            // colaDataGridViewTextBoxColumn
            // 
            this.colaDataGridViewTextBoxColumn.DataPropertyName = "cola";
            this.colaDataGridViewTextBoxColumn.HeaderText = "cola";
            this.colaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colaDataGridViewTextBoxColumn.Name = "colaDataGridViewTextBoxColumn";
            this.colaDataGridViewTextBoxColumn.ReadOnly = true;
            this.colaDataGridViewTextBoxColumn.Width = 125;
            // 
            // coffeeDataGridViewTextBoxColumn
            // 
            this.coffeeDataGridViewTextBoxColumn.DataPropertyName = "coffee";
            this.coffeeDataGridViewTextBoxColumn.HeaderText = "coffee";
            this.coffeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coffeeDataGridViewTextBoxColumn.Name = "coffeeDataGridViewTextBoxColumn";
            this.coffeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.coffeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // mENUBindingSource
            // 
            this.mENUBindingSource.DataMember = "MENU";
            this.mENUBindingSource.DataSource = this.restaurantDataDataSet;
            // 
            // restaurantDataDataSet
            // 
            this.restaurantDataDataSet.DataSetName = "restaurantDataDataSet";
            this.restaurantDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mENUTableAdapter
            // 
            this.mENUTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(786, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "REMOVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(786, 76);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "SEARCH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel1.Location = new System.Drawing.Point(786, 134);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 22);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ORDER AGAIN";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtCoffee
            // 
            this.txtCoffee.FormattingEnabled = true;
            this.txtCoffee.Items.AddRange(new object[] {
            "Americano : 3$",
            "Latte :3$",
            ""});
            this.txtCoffee.Location = new System.Drawing.Point(1263, 452);
            this.txtCoffee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCoffee.Name = "txtCoffee";
            this.txtCoffee.Size = new System.Drawing.Size(163, 28);
            this.txtCoffee.TabIndex = 37;
            // 
            // txtCola
            // 
            this.txtCola.FormattingEnabled = true;
            this.txtCola.Items.AddRange(new object[] {
            "0.5L Coca cola :2$",
            "1.0L Coca cola :3$",
            "1.5L Coca cola :3.5$",
            "",
            "0.5L Fanta :2$",
            "1.0L Fanta :3$",
            "1.5L Fanta :3.5$",
            "",
            "0.5L Sprite :2$",
            "1.0L Sprite :3$",
            "1.5L Sprite :3.5$"});
            this.txtCola.Location = new System.Drawing.Point(1263, 382);
            this.txtCola.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCola.Name = "txtCola";
            this.txtCola.Size = new System.Drawing.Size(163, 28);
            this.txtCola.TabIndex = 36;
            // 
            // txtTea
            // 
            this.txtTea.FormattingEnabled = true;
            this.txtTea.Items.AddRange(new object[] {
            "Black Tea : 1$",
            "Green Tea : 1$"});
            this.txtTea.Location = new System.Drawing.Point(1263, 321);
            this.txtTea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTea.Name = "txtTea";
            this.txtTea.Size = new System.Drawing.Size(163, 28);
            this.txtTea.TabIndex = 35;
            // 
            // txtFries
            // 
            this.txtFries.FormattingEnabled = true;
            this.txtFries.Items.AddRange(new object[] {
            "Small Fri : 2$",
            "Medium Fri  : 3$",
            "Big Fri : 4$"});
            this.txtFries.Location = new System.Drawing.Point(954, 459);
            this.txtFries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFries.Name = "txtFries";
            this.txtFries.Size = new System.Drawing.Size(163, 28);
            this.txtFries.TabIndex = 34;
            // 
            // txtSandwich
            // 
            this.txtSandwich.FormattingEnabled = true;
            this.txtSandwich.Items.AddRange(new object[] {
            "Beef Sandwich: 5$",
            "Chicken Sandwich: 4$"});
            this.txtSandwich.Location = new System.Drawing.Point(954, 389);
            this.txtSandwich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSandwich.Name = "txtSandwich";
            this.txtSandwich.Size = new System.Drawing.Size(163, 28);
            this.txtSandwich.TabIndex = 33;
            // 
            // txtHamburger
            // 
            this.txtHamburger.FormattingEnabled = true;
            this.txtHamburger.Items.AddRange(new object[] {
            "Mini Hamburger: 2$",
            "Big Hamburger: 3$",
            "Mini Cheese Hamburger: 4$",
            "Big Cheese Hamburger: 5$"});
            this.txtHamburger.Location = new System.Drawing.Point(954, 316);
            this.txtHamburger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHamburger.Name = "txtHamburger";
            this.txtHamburger.Size = new System.Drawing.Size(163, 28);
            this.txtHamburger.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1158, 461);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 26);
            this.label11.TabIndex = 31;
            this.label11.Text = "Coffee";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1158, 382);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 26);
            this.label10.TabIndex = 30;
            this.label10.Text = "Coca cola ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(782, 458);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "Fries";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(782, 389);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "Sandwiches";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1158, 320);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 26);
            this.label9.TabIndex = 27;
            this.label9.Text = "Tea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(782, 320);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 26);
            this.label4.TabIndex = 26;
            this.label4.Text = "Hamburgers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1275, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Drink";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(903, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fast Meal";
            // 
            // DATAGRID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1446, 639);
            this.Controls.Add(this.txtCoffee);
            this.Controls.Add(this.txtCola);
            this.Controls.Add(this.txtTea);
            this.Controls.Add(this.txtFries);
            this.Controls.Add(this.txtSandwich);
            this.Controls.Add(this.txtHamburger);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DATAGRID";
            this.Text = "DATAGRID";
            this.Load += new System.EventHandler(this.DATAGRID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private restaurantDataDataSet restaurantDataDataSet;
        private System.Windows.Forms.BindingSource mENUBindingSource;
        private restaurantDataDataSetTableAdapters.MENUTableAdapter mENUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hamburgerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sandwichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn friesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox txtCoffee;
        private System.Windows.Forms.ComboBox txtCola;
        private System.Windows.Forms.ComboBox txtTea;
        private System.Windows.Forms.ComboBox txtFries;
        private System.Windows.Forms.ComboBox txtSandwich;
        private System.Windows.Forms.ComboBox txtHamburger;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}