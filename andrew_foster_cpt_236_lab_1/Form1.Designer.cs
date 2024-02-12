
namespace andrew_foster_cpt_236_lab_1
{
    partial class Form1
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
            this.productDBDataSet = new andrew_foster_cpt_236_lab_1.ProductDBDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new andrew_foster_cpt_236_lab_1.ProductDBDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new andrew_foster_cpt_236_lab_1.ProductDBDataSetTableAdapters.TableAdapterManager();
            this.pNumText = new System.Windows.Forms.TextBox();
            this.productSearchBox = new System.Windows.Forms.GroupBox();
            this.pSearch = new System.Windows.Forms.Button();
            this.pClear = new System.Windows.Forms.Button();
            this.pDescText = new System.Windows.Forms.TextBox();
            this.pNumRadio = new System.Windows.Forms.RadioButton();
            this.pDescRadio = new System.Windows.Forms.RadioButton();
            this.amtSearchBox = new System.Windows.Forms.GroupBox();
            this.invSearch = new System.Windows.Forms.Button();
            this.invAmtText = new System.Windows.Forms.TextBox();
            this.invClear = new System.Windows.Forms.Button();
            this.invLabel = new System.Windows.Forms.Label();
            this.invGreatRadio = new System.Windows.Forms.RadioButton();
            this.invLessRadio = new System.Windows.Forms.RadioButton();
            this.priceSearch = new System.Windows.Forms.Button();
            this.priceClear = new System.Windows.Forms.Button();
            this.invAmtLabel = new System.Windows.Forms.Label();
            this.priceAmtText = new System.Windows.Forms.TextBox();
            this.priceGreatRadio = new System.Windows.Forms.RadioButton();
            this.priceLessRadio = new System.Windows.Forms.RadioButton();
            this.unitPriceBox = new System.Windows.Forms.GroupBox();
            this.exitButt = new System.Windows.Forms.Button();
            this.resultsList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.productSearchBox.SuspendLayout();
            this.amtSearchBox.SuspendLayout();
            this.unitPriceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // productDBDataSet
            // 
            this.productDBDataSet.DataSetName = "ProductDBDataSet";
            this.productDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productDBDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = andrew_foster_cpt_236_lab_1.ProductDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pNumText
            // 
            this.pNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNumText.Location = new System.Drawing.Point(200, 31);
            this.pNumText.Name = "pNumText";
            this.pNumText.Size = new System.Drawing.Size(162, 27);
            this.pNumText.TabIndex = 2;
            // 
            // productSearchBox
            // 
            this.productSearchBox.Controls.Add(this.pSearch);
            this.productSearchBox.Controls.Add(this.pClear);
            this.productSearchBox.Controls.Add(this.pDescText);
            this.productSearchBox.Controls.Add(this.pNumRadio);
            this.productSearchBox.Controls.Add(this.pNumText);
            this.productSearchBox.Controls.Add(this.pDescRadio);
            this.productSearchBox.Location = new System.Drawing.Point(13, 166);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(368, 152);
            this.productSearchBox.TabIndex = 3;
            this.productSearchBox.TabStop = false;
            this.productSearchBox.Text = "Product Search";
            // 
            // pSearch
            // 
            this.pSearch.Location = new System.Drawing.Point(189, 113);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(75, 25);
            this.pSearch.TabIndex = 7;
            this.pSearch.Text = "Search";
            this.toolTip1.SetToolTip(this.pSearch, "search for product by Number or Description");
            this.pSearch.UseVisualStyleBackColor = true;
            this.pSearch.Click += new System.EventHandler(this.pSearch_Click);
            // 
            // pClear
            // 
            this.pClear.Location = new System.Drawing.Point(69, 113);
            this.pClear.Name = "pClear";
            this.pClear.Size = new System.Drawing.Size(75, 25);
            this.pClear.TabIndex = 6;
            this.pClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.pClear, "clear Product Search text boxes");
            this.pClear.UseVisualStyleBackColor = true;
            this.pClear.Click += new System.EventHandler(this.pClear_Click);
            // 
            // pDescText
            // 
            this.pDescText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDescText.Location = new System.Drawing.Point(200, 70);
            this.pDescText.Name = "pDescText";
            this.pDescText.Size = new System.Drawing.Size(162, 27);
            this.pDescText.TabIndex = 5;
            // 
            // pNumRadio
            // 
            this.pNumRadio.AutoSize = true;
            this.pNumRadio.Checked = true;
            this.pNumRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNumRadio.Location = new System.Drawing.Point(6, 32);
            this.pNumRadio.Name = "pNumRadio";
            this.pNumRadio.Size = new System.Drawing.Size(177, 24);
            this.pNumRadio.TabIndex = 3;
            this.pNumRadio.TabStop = true;
            this.pNumRadio.Text = "By Product Number";
            this.pNumRadio.UseVisualStyleBackColor = true;
            this.pNumRadio.CheckedChanged += new System.EventHandler(this.pNumRadio_CheckedChanged);
            // 
            // pDescRadio
            // 
            this.pDescRadio.AutoSize = true;
            this.pDescRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDescRadio.Location = new System.Drawing.Point(6, 71);
            this.pDescRadio.Name = "pDescRadio";
            this.pDescRadio.Size = new System.Drawing.Size(135, 24);
            this.pDescRadio.TabIndex = 4;
            this.pDescRadio.Text = "By Desciption";
            this.pDescRadio.UseVisualStyleBackColor = true;
            this.pDescRadio.CheckedChanged += new System.EventHandler(this.pDescRadio_CheckedChanged);
            // 
            // amtSearchBox
            // 
            this.amtSearchBox.Controls.Add(this.invSearch);
            this.amtSearchBox.Controls.Add(this.invAmtText);
            this.amtSearchBox.Controls.Add(this.invClear);
            this.amtSearchBox.Controls.Add(this.invLabel);
            this.amtSearchBox.Controls.Add(this.invGreatRadio);
            this.amtSearchBox.Controls.Add(this.invLessRadio);
            this.amtSearchBox.Location = new System.Drawing.Point(387, 166);
            this.amtSearchBox.Name = "amtSearchBox";
            this.amtSearchBox.Size = new System.Drawing.Size(310, 152);
            this.amtSearchBox.TabIndex = 4;
            this.amtSearchBox.TabStop = false;
            this.amtSearchBox.Text = "Inventory Search";
            // 
            // invSearch
            // 
            this.invSearch.Location = new System.Drawing.Point(185, 113);
            this.invSearch.Name = "invSearch";
            this.invSearch.Size = new System.Drawing.Size(75, 25);
            this.invSearch.TabIndex = 9;
            this.invSearch.Text = "Search";
            this.toolTip1.SetToolTip(this.invSearch, "search inventory");
            this.invSearch.UseVisualStyleBackColor = true;
            this.invSearch.Click += new System.EventHandler(this.invSearch_Click);
            // 
            // invAmtText
            // 
            this.invAmtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invAmtText.Location = new System.Drawing.Point(114, 76);
            this.invAmtText.Name = "invAmtText";
            this.invAmtText.Size = new System.Drawing.Size(167, 27);
            this.invAmtText.TabIndex = 3;
            // 
            // invClear
            // 
            this.invClear.Location = new System.Drawing.Point(65, 113);
            this.invClear.Name = "invClear";
            this.invClear.Size = new System.Drawing.Size(75, 25);
            this.invClear.TabIndex = 8;
            this.invClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.invClear, "clear No. of Units text field");
            this.invClear.UseVisualStyleBackColor = true;
            // 
            // invLabel
            // 
            this.invLabel.AutoSize = true;
            this.invLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invLabel.Location = new System.Drawing.Point(6, 79);
            this.invLabel.Name = "invLabel";
            this.invLabel.Size = new System.Drawing.Size(102, 20);
            this.invLabel.TabIndex = 2;
            this.invLabel.Text = "No. of Units:";
            // 
            // invGreatRadio
            // 
            this.invGreatRadio.AutoSize = true;
            this.invGreatRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invGreatRadio.Location = new System.Drawing.Point(162, 37);
            this.invGreatRadio.Name = "invGreatRadio";
            this.invGreatRadio.Size = new System.Drawing.Size(129, 24);
            this.invGreatRadio.TabIndex = 1;
            this.invGreatRadio.Text = "Greater Than";
            this.invGreatRadio.UseVisualStyleBackColor = true;
            this.invGreatRadio.CheckedChanged += new System.EventHandler(this.invGreatRadio_CheckedChanged);
            // 
            // invLessRadio
            // 
            this.invLessRadio.AutoSize = true;
            this.invLessRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invLessRadio.Location = new System.Drawing.Point(30, 37);
            this.invLessRadio.Name = "invLessRadio";
            this.invLessRadio.Size = new System.Drawing.Size(109, 24);
            this.invLessRadio.TabIndex = 0;
            this.invLessRadio.Text = "Less Than";
            this.invLessRadio.UseVisualStyleBackColor = true;
            this.invLessRadio.CheckedChanged += new System.EventHandler(this.invLessRadio_CheckedChanged);
            // 
            // priceSearch
            // 
            this.priceSearch.Location = new System.Drawing.Point(174, 115);
            this.priceSearch.Name = "priceSearch";
            this.priceSearch.Size = new System.Drawing.Size(75, 25);
            this.priceSearch.TabIndex = 8;
            this.priceSearch.Text = "Search";
            this.toolTip1.SetToolTip(this.priceSearch, "search products by unit price");
            this.priceSearch.UseVisualStyleBackColor = true;
            this.priceSearch.Click += new System.EventHandler(this.priceSearch_Click);
            // 
            // priceClear
            // 
            this.priceClear.Location = new System.Drawing.Point(62, 115);
            this.priceClear.Name = "priceClear";
            this.priceClear.Size = new System.Drawing.Size(75, 25);
            this.priceClear.TabIndex = 7;
            this.priceClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.priceClear, "clear price search");
            this.priceClear.UseVisualStyleBackColor = true;
            // 
            // invAmtLabel
            // 
            this.invAmtLabel.AutoSize = true;
            this.invAmtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invAmtLabel.Location = new System.Drawing.Point(21, 72);
            this.invAmtLabel.Name = "invAmtLabel";
            this.invAmtLabel.Size = new System.Drawing.Size(71, 20);
            this.invAmtLabel.TabIndex = 3;
            this.invAmtLabel.Text = "Amount:";
            // 
            // priceAmtText
            // 
            this.priceAmtText.Location = new System.Drawing.Point(98, 72);
            this.priceAmtText.Name = "priceAmtText";
            this.priceAmtText.Size = new System.Drawing.Size(173, 22);
            this.priceAmtText.TabIndex = 2;
            // 
            // priceGreatRadio
            // 
            this.priceGreatRadio.AutoSize = true;
            this.priceGreatRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceGreatRadio.Location = new System.Drawing.Point(161, 31);
            this.priceGreatRadio.Name = "priceGreatRadio";
            this.priceGreatRadio.Size = new System.Drawing.Size(124, 24);
            this.priceGreatRadio.TabIndex = 1;
            this.priceGreatRadio.Text = "Greater than";
            this.priceGreatRadio.UseVisualStyleBackColor = true;
            this.priceGreatRadio.CheckedChanged += new System.EventHandler(this.priceGreatRadio_CheckedChanged);
            // 
            // priceLessRadio
            // 
            this.priceLessRadio.AutoSize = true;
            this.priceLessRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLessRadio.Location = new System.Drawing.Point(25, 31);
            this.priceLessRadio.Name = "priceLessRadio";
            this.priceLessRadio.Size = new System.Drawing.Size(104, 24);
            this.priceLessRadio.TabIndex = 0;
            this.priceLessRadio.Text = "Less than";
            this.priceLessRadio.UseVisualStyleBackColor = true;
            this.priceLessRadio.CheckedChanged += new System.EventHandler(this.priceLessRadio_CheckedChanged);
            // 
            // unitPriceBox
            // 
            this.unitPriceBox.Controls.Add(this.priceSearch);
            this.unitPriceBox.Controls.Add(this.priceLessRadio);
            this.unitPriceBox.Controls.Add(this.priceClear);
            this.unitPriceBox.Controls.Add(this.priceGreatRadio);
            this.unitPriceBox.Controls.Add(this.invAmtLabel);
            this.unitPriceBox.Controls.Add(this.priceAmtText);
            this.unitPriceBox.Location = new System.Drawing.Point(703, 166);
            this.unitPriceBox.Name = "unitPriceBox";
            this.unitPriceBox.Size = new System.Drawing.Size(315, 152);
            this.unitPriceBox.TabIndex = 5;
            this.unitPriceBox.TabStop = false;
            this.unitPriceBox.Text = "Unit Price Search";
            // 
            // exitButt
            // 
            this.exitButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButt.Location = new System.Drawing.Point(645, 357);
            this.exitButt.Name = "exitButt";
            this.exitButt.Size = new System.Drawing.Size(150, 45);
            this.exitButt.TabIndex = 6;
            this.exitButt.TabStop = false;
            this.exitButt.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitButt, "exit the program");
            this.exitButt.UseVisualStyleBackColor = true;
            this.exitButt.Click += new System.EventHandler(this.exitButt_Click);
            // 
            // resultsList
            // 
            this.resultsList.FormattingEnabled = true;
            this.resultsList.ItemHeight = 16;
            this.resultsList.Location = new System.Drawing.Point(12, 12);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(1006, 148);
            this.resultsList.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(231, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 45);
            this.button1.TabIndex = 8;
            this.button1.TabStop = false;
            this.button1.Text = "Clear &All";
            this.toolTip1.SetToolTip(this.button1, "clear all text fields");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultsList);
            this.Controls.Add(this.exitButt);
            this.Controls.Add(this.unitPriceBox);
            this.Controls.Add(this.amtSearchBox);
            this.Controls.Add(this.productSearchBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Andrew Foster Lab 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.productSearchBox.ResumeLayout(false);
            this.productSearchBox.PerformLayout();
            this.amtSearchBox.ResumeLayout(false);
            this.amtSearchBox.PerformLayout();
            this.unitPriceBox.ResumeLayout(false);
            this.unitPriceBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ProductDBDataSet productDBDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ProductDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private ProductDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox pNumText;
        private System.Windows.Forms.GroupBox productSearchBox;
        private System.Windows.Forms.Button pSearch;
        private System.Windows.Forms.Button pClear;
        private System.Windows.Forms.TextBox pDescText;
        private System.Windows.Forms.RadioButton pNumRadio;
        private System.Windows.Forms.RadioButton pDescRadio;
        private System.Windows.Forms.GroupBox amtSearchBox;
        private System.Windows.Forms.Button priceSearch;
        private System.Windows.Forms.Button priceClear;
        private System.Windows.Forms.Label invAmtLabel;
        private System.Windows.Forms.TextBox priceAmtText;
        private System.Windows.Forms.RadioButton priceGreatRadio;
        private System.Windows.Forms.RadioButton priceLessRadio;
        private System.Windows.Forms.GroupBox unitPriceBox;
        private System.Windows.Forms.Button exitButt;
        private System.Windows.Forms.ListBox resultsList;
        private System.Windows.Forms.Button invSearch;
        private System.Windows.Forms.TextBox invAmtText;
        private System.Windows.Forms.Button invClear;
        private System.Windows.Forms.Label invLabel;
        private System.Windows.Forms.RadioButton invGreatRadio;
        private System.Windows.Forms.RadioButton invLessRadio;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}

