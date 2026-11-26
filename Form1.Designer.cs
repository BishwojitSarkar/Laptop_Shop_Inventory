namespace CRUDproject
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
            groupBox1 = new GroupBox();
            clearbtn = new Button();
            deletebtn = new Button();
            updatebtn = new Button();
            addbtn = new Button();
            modeltxtbox = new TextBox();
            processortxtbox = new TextBox();
            ramtxtbox = new TextBox();
            storagetxtbox = new TextBox();
            pricetxtbox = new TextBox();
            quantitytxtbox = new TextBox();
            warrantytxtbox = new TextBox();
            companytxtbox = new TextBox();
            warrantylbl = new Label();
            pricelbl = new Label();
            quantitylbl = new Label();
            storagelbl = new Label();
            ramlbl = new Label();
            processorlbl = new Label();
            modellbl = new Label();
            companylbl = new Label();
            dataGridView1 = new DataGridView();
            searchtxtbox = new TextBox();
            searchbtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clearbtn);
            groupBox1.Controls.Add(deletebtn);
            groupBox1.Controls.Add(updatebtn);
            groupBox1.Controls.Add(addbtn);
            groupBox1.Controls.Add(modeltxtbox);
            groupBox1.Controls.Add(processortxtbox);
            groupBox1.Controls.Add(ramtxtbox);
            groupBox1.Controls.Add(storagetxtbox);
            groupBox1.Controls.Add(pricetxtbox);
            groupBox1.Controls.Add(quantitytxtbox);
            groupBox1.Controls.Add(warrantytxtbox);
            groupBox1.Controls.Add(companytxtbox);
            groupBox1.Controls.Add(warrantylbl);
            groupBox1.Controls.Add(pricelbl);
            groupBox1.Controls.Add(quantitylbl);
            groupBox1.Controls.Add(storagelbl);
            groupBox1.Controls.Add(ramlbl);
            groupBox1.Controls.Add(processorlbl);
            groupBox1.Controls.Add(modellbl);
            groupBox1.Controls.Add(companylbl);
            groupBox1.Location = new Point(28, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 543);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Laptop Details";
            // 
            // clearbtn
            // 
            clearbtn.BackColor = SystemColors.ControlLight;
            clearbtn.Location = new Point(100, 499);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(184, 34);
            clearbtn.TabIndex = 18;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            clearbtn.Click += clearbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = SystemColors.ControlLight;
            deletebtn.Location = new Point(100, 459);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(184, 34);
            deletebtn.TabIndex = 17;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = SystemColors.ControlLight;
            updatebtn.Location = new Point(100, 419);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(184, 34);
            updatebtn.TabIndex = 16;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = SystemColors.ControlLight;
            addbtn.Location = new Point(100, 379);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(184, 34);
            addbtn.TabIndex = 1;
            addbtn.Text = "Add Laptop";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // modeltxtbox
            // 
            modeltxtbox.Location = new Point(119, 79);
            modeltxtbox.Name = "modeltxtbox";
            modeltxtbox.Size = new Size(292, 31);
            modeltxtbox.TabIndex = 15;
            // 
            // processortxtbox
            // 
            processortxtbox.Location = new Point(119, 116);
            processortxtbox.Name = "processortxtbox";
            processortxtbox.Size = new Size(292, 31);
            processortxtbox.TabIndex = 14;
            // 
            // ramtxtbox
            // 
            ramtxtbox.Location = new Point(119, 153);
            ramtxtbox.Name = "ramtxtbox";
            ramtxtbox.Size = new Size(292, 31);
            ramtxtbox.TabIndex = 13;
            // 
            // storagetxtbox
            // 
            storagetxtbox.Location = new Point(119, 190);
            storagetxtbox.Name = "storagetxtbox";
            storagetxtbox.Size = new Size(292, 31);
            storagetxtbox.TabIndex = 12;
            // 
            // pricetxtbox
            // 
            pricetxtbox.Location = new Point(119, 264);
            pricetxtbox.Name = "pricetxtbox";
            pricetxtbox.Size = new Size(292, 31);
            pricetxtbox.TabIndex = 11;
            // 
            // quantitytxtbox
            // 
            quantitytxtbox.Location = new Point(178, 227);
            quantitytxtbox.Name = "quantitytxtbox";
            quantitytxtbox.Size = new Size(233, 31);
            quantitytxtbox.TabIndex = 10;
            // 
            // warrantytxtbox
            // 
            warrantytxtbox.Location = new Point(119, 303);
            warrantytxtbox.Name = "warrantytxtbox";
            warrantytxtbox.Size = new Size(292, 31);
            warrantytxtbox.TabIndex = 9;
            // 
            // companytxtbox
            // 
            companytxtbox.Location = new Point(119, 44);
            companytxtbox.Name = "companytxtbox";
            companytxtbox.Size = new Size(292, 31);
            companytxtbox.TabIndex = 7;
            // 
            // warrantylbl
            // 
            warrantylbl.AutoSize = true;
            warrantylbl.Location = new Point(15, 306);
            warrantylbl.Name = "warrantylbl";
            warrantylbl.Size = new Size(92, 25);
            warrantylbl.TabIndex = 6;
            warrantylbl.Text = "Warranty :";
            // 
            // pricelbl
            // 
            pricelbl.AutoSize = true;
            pricelbl.Location = new Point(15, 267);
            pricelbl.Name = "pricelbl";
            pricelbl.Size = new Size(58, 25);
            pricelbl.TabIndex = 5;
            pricelbl.Text = "Price :";
            // 
            // quantitylbl
            // 
            quantitylbl.AutoSize = true;
            quantitylbl.Location = new Point(15, 230);
            quantitylbl.Name = "quantitylbl";
            quantitylbl.Size = new Size(157, 25);
            quantitylbl.TabIndex = 4;
            quantitylbl.Text = "Quantity In Stock :";
            // 
            // storagelbl
            // 
            storagelbl.AutoSize = true;
            storagelbl.Location = new Point(15, 196);
            storagelbl.Name = "storagelbl";
            storagelbl.Size = new Size(82, 25);
            storagelbl.TabIndex = 3;
            storagelbl.Text = "Storage :";
            // 
            // ramlbl
            // 
            ramlbl.AutoSize = true;
            ramlbl.Location = new Point(15, 156);
            ramlbl.Name = "ramlbl";
            ramlbl.Size = new Size(60, 25);
            ramlbl.TabIndex = 2;
            ramlbl.Text = "RAM :";
            // 
            // processorlbl
            // 
            processorlbl.AutoSize = true;
            processorlbl.Location = new Point(15, 119);
            processorlbl.Name = "processorlbl";
            processorlbl.Size = new Size(98, 25);
            processorlbl.TabIndex = 1;
            processorlbl.Text = "Processor :";
            // 
            // modellbl
            // 
            modellbl.AutoSize = true;
            modellbl.Location = new Point(15, 85);
            modellbl.Name = "modellbl";
            modellbl.Size = new Size(72, 25);
            modellbl.TabIndex = 1;
            modellbl.Text = "Model :";
            // 
            // companylbl
            // 
            companylbl.AutoSize = true;
            companylbl.Location = new Point(15, 47);
            companylbl.Name = "companylbl";
            companylbl.Size = new Size(98, 25);
            companylbl.TabIndex = 0;
            companylbl.Text = "Company :";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(480, 93);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(767, 480);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // searchtxtbox
            // 
            searchtxtbox.Location = new Point(480, 56);
            searchtxtbox.Name = "searchtxtbox";
            searchtxtbox.Size = new Size(526, 31);
            searchtxtbox.TabIndex = 19;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = SystemColors.ControlLight;
            searchbtn.Location = new Point(1012, 53);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(99, 34);
            searchbtn.TabIndex = 19;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += searchbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1259, 588);
            Controls.Add(searchbtn);
            Controls.Add(searchtxtbox);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label ramlbl;
        private Label processorlbl;
        private Label modellbl;
        private Label companylbl;
        private TextBox modeltxtbox;
        private TextBox processortxtbox;
        private TextBox ramtxtbox;
        private TextBox storagetxtbox;
        private TextBox pricetxtbox;
        private TextBox quantitytxtbox;
        private TextBox warrantytxtbox;
        private TextBox companytxtbox;
        private Label warrantylbl;
        private Label pricelbl;
        private Label quantitylbl;
        private Label storagelbl;
        private Button deletebtn;
        private Button updatebtn;
        private Button addbtn;
        private Button clearbtn;
        private DataGridView dataGridView1;
        private TextBox searchtxtbox;
        private Button searchbtn;
    }
}
