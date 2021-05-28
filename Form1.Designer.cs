namespace WindowsFormsApp11
{
    partial class NCparks_and_Rec
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
            this.OrderID2 = new System.Windows.Forms.Label();
            this.CustomerID2 = new System.Windows.Forms.Label();
            this.OrderDate = new System.Windows.Forms.Label();
            this.OrderQuantity = new System.Windows.Forms.Label();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxOrderDate = new System.Windows.Forms.TextBox();
            this.textBoxOrderQuantity = new System.Windows.Forms.TextBox();
            this.FileDialog2 = new System.Windows.Forms.Button();
            this.FileDialogText = new System.Windows.Forms.TextBox();
            this.InsertButton2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Insert2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderID2
            // 
            this.OrderID2.AutoSize = true;
            this.OrderID2.Location = new System.Drawing.Point(33, 26);
            this.OrderID2.Name = "OrderID2";
            this.OrderID2.Size = new System.Drawing.Size(47, 13);
            this.OrderID2.TabIndex = 0;
            this.OrderID2.Text = "Order ID";
            // 
            // CustomerID2
            // 
            this.CustomerID2.AutoSize = true;
            this.CustomerID2.Location = new System.Drawing.Point(18, 52);
            this.CustomerID2.Name = "CustomerID2";
            this.CustomerID2.Size = new System.Drawing.Size(62, 13);
            this.CustomerID2.TabIndex = 1;
            this.CustomerID2.Text = "CustomerID";
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSize = true;
            this.OrderDate.Location = new System.Drawing.Point(16, 92);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(64, 13);
            this.OrderDate.TabIndex = 2;
            this.OrderDate.Text = "Order Name";
            // 
            // OrderQuantity
            // 
            this.OrderQuantity.AutoSize = true;
            this.OrderQuantity.Location = new System.Drawing.Point(8, 124);
            this.OrderQuantity.Name = "OrderQuantity";
            this.OrderQuantity.Size = new System.Drawing.Size(75, 13);
            this.OrderQuantity.TabIndex = 3;
            this.OrderQuantity.Text = "Order Quantity";
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(86, 23);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderID.TabIndex = 4;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(86, 49);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerID.TabIndex = 5;
            // 
            // textBoxOrderDate
            // 
            this.textBoxOrderDate.Location = new System.Drawing.Point(86, 85);
            this.textBoxOrderDate.Name = "textBoxOrderDate";
            this.textBoxOrderDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderDate.TabIndex = 6;
            // 
            // textBoxOrderQuantity
            // 
            this.textBoxOrderQuantity.Location = new System.Drawing.Point(86, 117);
            this.textBoxOrderQuantity.Name = "textBoxOrderQuantity";
            this.textBoxOrderQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderQuantity.TabIndex = 7;
            // 
            // FileDialog2
            // 
            this.FileDialog2.Location = new System.Drawing.Point(86, 225);
            this.FileDialog2.Name = "FileDialog2";
            this.FileDialog2.Size = new System.Drawing.Size(100, 23);
            this.FileDialog2.TabIndex = 8;
            this.FileDialog2.Text = "File Explorer";
            this.FileDialog2.UseVisualStyleBackColor = true;
            this.FileDialog2.Click += new System.EventHandler(this.FileDialog2_Click);
            // 
            // FileDialogText
            // 
            this.FileDialogText.Location = new System.Drawing.Point(192, 225);
            this.FileDialogText.Name = "FileDialogText";
            this.FileDialogText.Size = new System.Drawing.Size(273, 20);
            this.FileDialogText.TabIndex = 9;
            // 
            // InsertButton2
            // 
            this.InsertButton2.Location = new System.Drawing.Point(86, 152);
            this.InsertButton2.Name = "InsertButton2";
            this.InsertButton2.Size = new System.Drawing.Size(100, 23);
            this.InsertButton2.TabIndex = 10;
            this.InsertButton2.Text = "INSERT";
            this.InsertButton2.UseVisualStyleBackColor = true;
            this.InsertButton2.Click += new System.EventHandler(this.InsertButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 240);
            this.dataGridView1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Click File Dialog Button to Upload Excel Spreadsheet to Database. ";
            // 
            // Insert2
            // 
            this.Insert2.Location = new System.Drawing.Point(471, 222);
            this.Insert2.Name = "Insert2";
            this.Insert2.Size = new System.Drawing.Size(75, 23);
            this.Insert2.TabIndex = 14;
            this.Insert2.Text = "Upload";
            this.Insert2.UseVisualStyleBackColor = true;
            this.Insert2.Click += new System.EventHandler(this.Insert2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NCparks_and_Rec
            // 
            this.ClientSize = new System.Drawing.Size(640, 506);
            this.Controls.Add(this.Insert2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InsertButton2);
            this.Controls.Add(this.FileDialogText);
            this.Controls.Add(this.FileDialog2);
            this.Controls.Add(this.textBoxOrderQuantity);
            this.Controls.Add(this.textBoxOrderDate);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.textBoxOrderID);
            this.Controls.Add(this.OrderQuantity);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.CustomerID2);
            this.Controls.Add(this.OrderID2);
            this.Name = "NCparks_and_Rec";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderID;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txtFileName;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label OrderID2;
        private System.Windows.Forms.Label CustomerID2;
        private System.Windows.Forms.Label OrderDate;
        private System.Windows.Forms.Label OrderQuantity;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.TextBox textBoxOrderDate;
        private System.Windows.Forms.TextBox textBoxOrderQuantity;
        private System.Windows.Forms.Button FileDialog2;
        private System.Windows.Forms.TextBox FileDialogText;
        private System.Windows.Forms.Button InsertButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Insert2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

