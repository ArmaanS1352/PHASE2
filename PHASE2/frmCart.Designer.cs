using System;

namespace PHASE2
{
    partial class frmCart
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblFoundItems = new System.Windows.Forms.Label();
            this.dgvFoundItems = new System.Windows.Forms.DataGridView();
            this.lblCart = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblSubtotalValue = new System.Windows.Forms.Label();
            this.lblTaxValue = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCommitOrdeer = new System.Windows.Forms.Button();
            this.txtTitleSearch = new System.Windows.Forms.TextBox();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.colCartTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboStore = new System.Windows.Forms.ComboBox();
            this.dtpOrdDate = new System.Windows.Forms.DateTimePicker();
            this.cboPayTerms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(22, 26);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(67, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Title Search:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(475, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 20);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(551, 105);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(64, 28);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "Add";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // lblFoundItems
            // 
            this.lblFoundItems.AutoSize = true;
            this.lblFoundItems.Location = new System.Drawing.Point(22, 50);
            this.lblFoundItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFoundItems.Name = "lblFoundItems";
            this.lblFoundItems.Size = new System.Drawing.Size(65, 13);
            this.lblFoundItems.TabIndex = 10;
            this.lblFoundItems.Text = "Found Items";
            // 
            // dgvFoundItems
            // 
            this.dgvFoundItems.AllowUserToAddRows = false;
            this.dgvFoundItems.AllowUserToDeleteRows = false;
            this.dgvFoundItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoundItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoundItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTitle,
            this.colPrice,
            this.colPub});
            this.dgvFoundItems.Location = new System.Drawing.Point(24, 66);
            this.dgvFoundItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFoundItems.MultiSelect = false;
            this.dgvFoundItems.Name = "dgvFoundItems";
            this.dgvFoundItems.ReadOnly = true;
            this.dgvFoundItems.RowHeadersVisible = false;
            this.dgvFoundItems.RowHeadersWidth = 51;
            this.dgvFoundItems.RowTemplate.Height = 24;
            this.dgvFoundItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoundItems.Size = new System.Drawing.Size(511, 109);
            this.dgvFoundItems.TabIndex = 11;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(22, 192);
            this.lblCart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(26, 13);
            this.lblCart.TabIndex = 12;
            this.lblCart.Text = "Cart";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCartTitle,
            this.colCartQty,
            this.colUnitPrice,
            this.colLineTotal});
            this.dgvCart.Location = new System.Drawing.Point(24, 207);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(511, 121);
            this.dgvCart.TabIndex = 13;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.AutoSize = true;
            this.lblSubtotalValue.Location = new System.Drawing.Point(22, 368);
            this.lblSubtotalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotalValue.TabIndex = 14;
            this.lblSubtotalValue.Text = "Subtotal:";
            // 
            // lblTaxValue
            // 
            this.lblTaxValue.AutoSize = true;
            this.lblTaxValue.Location = new System.Drawing.Point(42, 390);
            this.lblTaxValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaxValue.Name = "lblTaxValue";
            this.lblTaxValue.Size = new System.Drawing.Size(28, 13);
            this.lblTaxValue.TabIndex = 15;
            this.lblTaxValue.Text = "Tax:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(36, 413);
            this.lblTotalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(34, 13);
            this.lblTotalValue.TabIndex = 16;
            this.lblTotalValue.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(78, 366);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(76, 20);
            this.txtSubtotal.TabIndex = 17;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.Text = "$0.00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(78, 390);
            this.txtTax.Margin = new System.Windows.Forms.Padding(2);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(76, 20);
            this.txtTax.TabIndex = 18;
            this.txtTax.TabStop = false;
            this.txtTax.Text = "$0.00";
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(78, 416);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(76, 20);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "$0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCommitOrdeer
            // 
            this.btnCommitOrdeer.Location = new System.Drawing.Point(193, 399);
            this.btnCommitOrdeer.Margin = new System.Windows.Forms.Padding(2);
            this.btnCommitOrdeer.Name = "btnCommitOrdeer";
            this.btnCommitOrdeer.Size = new System.Drawing.Size(94, 37);
            this.btnCommitOrdeer.TabIndex = 21;
            this.btnCommitOrdeer.Text = "Commit Order";
            this.btnCommitOrdeer.UseVisualStyleBackColor = true;
            this.btnCommitOrdeer.Click += new System.EventHandler(this.btnCommitOrdeer_Click);
            // 
            // txtTitleSearch
            // 
            this.txtTitleSearch.Location = new System.Drawing.Point(94, 22);
            this.txtTitleSearch.MaxLength = 80;
            this.txtTitleSearch.Name = "txtTitleSearch";
            this.txtTitleSearch.Size = new System.Drawing.Size(362, 20);
            this.txtTitleSearch.TabIndex = 22;
            // 
            // colID
            // 
            this.colID.HeaderText = "Title ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colTitle
            // 
            this.colTitle.FillWeight = 119.5432F;
            this.colTitle.HeaderText = "Title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.FillWeight = 60.9137F;
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colPub
            // 
            this.colPub.FillWeight = 119.5432F;
            this.colPub.HeaderText = "Publisher";
            this.colPub.Name = "colPub";
            this.colPub.ReadOnly = true;
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(553, 66);
            this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(61, 20);
            this.numQty.TabIndex = 23;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // colCartTitle
            // 
            this.colCartTitle.FillWeight = 64.86485F;
            this.colCartTitle.HeaderText = "Title";
            this.colCartTitle.MinimumWidth = 6;
            this.colCartTitle.Name = "colCartTitle";
            this.colCartTitle.ReadOnly = true;
            // 
            // colCartQty
            // 
            this.colCartQty.FillWeight = 13.65663F;
            this.colCartQty.HeaderText = "Qty";
            this.colCartQty.MinimumWidth = 6;
            this.colCartQty.Name = "colCartQty";
            this.colCartQty.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FillWeight = 27.99814F;
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.MinimumWidth = 6;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colLineTotal
            // 
            this.colLineTotal.FillWeight = 27.99814F;
            this.colLineTotal.HeaderText = "Line Total";
            this.colLineTotal.Name = "colLineTotal";
            this.colLineTotal.ReadOnly = true;
            // 
            // cboStore
            // 
            this.cboStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStore.FormattingEnabled = true;
            this.cboStore.Location = new System.Drawing.Point(444, 384);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(92, 21);
            this.cboStore.TabIndex = 24;
            // 
            // dtpOrdDate
            // 
            this.dtpOrdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrdDate.Location = new System.Drawing.Point(444, 420);
            this.dtpOrdDate.Name = "dtpOrdDate";
            this.dtpOrdDate.Size = new System.Drawing.Size(92, 20);
            this.dtpOrdDate.TabIndex = 25;
            // 
            // cboPayTerms
            // 
            this.cboPayTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayTerms.FormattingEnabled = true;
            this.cboPayTerms.Location = new System.Drawing.Point(444, 349);
            this.cboPayTerms.Name = "cboPayTerms";
            this.cboPayTerms.Size = new System.Drawing.Size(92, 21);
            this.cboPayTerms.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Store:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 392);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Payment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 426);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Order Date:";
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPayTerms);
            this.Controls.Add(this.dtpOrdDate);
            this.Controls.Add(this.cboStore);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.txtTitleSearch);
            this.Controls.Add(this.btnCommitOrdeer);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTaxValue);
            this.Controls.Add(this.lblSubtotalValue);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.dgvFoundItems);
            this.Controls.Add(this.lblFoundItems);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Name = "frmCart";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblFoundItems;
        private System.Windows.Forms.DataGridView dgvFoundItems;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label lblTaxValue;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCommitOrdeer;
        private System.Windows.Forms.TextBox txtTitleSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPub;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineTotal;
        private System.Windows.Forms.ComboBox cboStore;
        private System.Windows.Forms.DateTimePicker dtpOrdDate;
        private System.Windows.Forms.ComboBox cboPayTerms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}