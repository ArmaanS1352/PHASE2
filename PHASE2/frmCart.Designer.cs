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
            this.txtSearchTitle = new System.Windows.Forms.MaskedTextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnUpdateQty = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnCommitOrder = new System.Windows.Forms.Button();
            this.lblFoundItems = new System.Windows.Forms.Label();
            this.dgvFoundItems = new System.Windows.Forms.DataGridView();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCart = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.colCartTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubtotalValue = new System.Windows.Forms.Label();
            this.lblTaxValue = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCommitOrdeer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(29, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(123, 16);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Partial Title Search:";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Location = new System.Drawing.Point(155, 21);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(193, 22);
            this.txtSearchTitle.TabIndex = 1;
            this.txtSearchTitle.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtSearchTitle_MaskInputRejected);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(370, 21);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(88, 23);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnUpdateQty
            // 
            this.btnUpdateQty.Location = new System.Drawing.Point(373, 206);
            this.btnUpdateQty.Name = "btnUpdateQty";
            this.btnUpdateQty.Size = new System.Drawing.Size(85, 34);
            this.btnUpdateQty.TabIndex = 7;
            this.btnUpdateQty.Text = "Update Qty";
            this.btnUpdateQty.UseVisualStyleBackColor = true;
            this.btnUpdateQty.Click += new System.EventHandler(this.btnUpdateQty_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(373, 265);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(88, 33);
            this.btnRemoveItem.TabIndex = 8;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnCommitOrder
            // 
            this.btnCommitOrder.Location = new System.Drawing.Point(0, 0);
            this.btnCommitOrder.Name = "btnCommitOrder";
            this.btnCommitOrder.Size = new System.Drawing.Size(75, 23);
            this.btnCommitOrder.TabIndex = 20;
            // 
            // lblFoundItems
            // 
            this.lblFoundItems.AutoSize = true;
            this.lblFoundItems.Location = new System.Drawing.Point(29, 62);
            this.lblFoundItems.Name = "lblFoundItems";
            this.lblFoundItems.Size = new System.Drawing.Size(80, 16);
            this.lblFoundItems.TabIndex = 10;
            this.lblFoundItems.Text = "Found Items";
            this.lblFoundItems.Click += new System.EventHandler(this.lblFoundItems_Click);
            // 
            // dgvFoundItems
            // 
            this.dgvFoundItems.AllowUserToAddRows = false;
            this.dgvFoundItems.AllowUserToDeleteRows = false;
            this.dgvFoundItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoundItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoundItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colPrice});
            this.dgvFoundItems.Location = new System.Drawing.Point(32, 81);
            this.dgvFoundItems.MultiSelect = false;
            this.dgvFoundItems.Name = "dgvFoundItems";
            this.dgvFoundItems.ReadOnly = true;
            this.dgvFoundItems.RowHeadersVisible = false;
            this.dgvFoundItems.RowHeadersWidth = 51;
            this.dgvFoundItems.RowTemplate.Height = 24;
            this.dgvFoundItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoundItems.Size = new System.Drawing.Size(403, 82);
            this.dgvFoundItems.TabIndex = 11;
            this.dgvFoundItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoundItems_CellContentClick_2);
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(32, 186);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(31, 16);
            this.lblCart.TabIndex = 12;
            this.lblCart.Text = "Cart";
            this.lblCart.Click += new System.EventHandler(this.lblCart_Click);
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
            this.colCartPrice});
            this.dgvCart.Location = new System.Drawing.Point(32, 206);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(316, 92);
            this.dgvCart.TabIndex = 13;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // colCartTitle
            // 
            this.colCartTitle.HeaderText = "Title";
            this.colCartTitle.MinimumWidth = 6;
            this.colCartTitle.Name = "colCartTitle";
            this.colCartTitle.ReadOnly = true;
            // 
            // colCartQty
            // 
            this.colCartQty.HeaderText = "Qty";
            this.colCartQty.MinimumWidth = 6;
            this.colCartQty.Name = "colCartQty";
            this.colCartQty.ReadOnly = true;
            // 
            // colCartPrice
            // 
            this.colCartPrice.HeaderText = "Price";
            this.colCartPrice.MinimumWidth = 6;
            this.colCartPrice.Name = "colCartPrice";
            this.colCartPrice.ReadOnly = true;
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.AutoSize = true;
            this.lblSubtotalValue.Location = new System.Drawing.Point(32, 323);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(59, 16);
            this.lblSubtotalValue.TabIndex = 14;
            this.lblSubtotalValue.Text = "Subtotal:";
            this.lblSubtotalValue.Click += new System.EventHandler(this.lblSubtotalValue_Click);
            // 
            // lblTaxValue
            // 
            this.lblTaxValue.AutoSize = true;
            this.lblTaxValue.Location = new System.Drawing.Point(58, 349);
            this.lblTaxValue.Name = "lblTaxValue";
            this.lblTaxValue.Size = new System.Drawing.Size(33, 16);
            this.lblTaxValue.TabIndex = 15;
            this.lblTaxValue.Text = "Tax:";
            this.lblTaxValue.Click += new System.EventHandler(this.lblTaxValue_Click);
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(50, 378);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(41, 16);
            this.lblTotalValue.TabIndex = 16;
            this.lblTotalValue.Text = "Total:";
            this.lblTotalValue.Click += new System.EventHandler(this.lblTotalValue_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(107, 320);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 17;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.Text = "$0.00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(107, 350);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 22);
            this.txtTax.TabIndex = 18;
            this.txtTax.TabStop = false;
            this.txtTax.Text = "$0.00";
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(107, 381);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "$0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // btnCommitOrdeer
            // 
            this.btnCommitOrdeer.Location = new System.Drawing.Point(309, 335);
            this.btnCommitOrdeer.Name = "btnCommitOrdeer";
            this.btnCommitOrdeer.Size = new System.Drawing.Size(126, 45);
            this.btnCommitOrdeer.TabIndex = 21;
            this.btnCommitOrdeer.Text = "Commit Order";
            this.btnCommitOrdeer.UseVisualStyleBackColor = true;
            this.btnCommitOrdeer.Click += new System.EventHandler(this.btnCommitOrdeer_Click);
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 415);
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
            this.Controls.Add(this.btnCommitOrder);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnUpdateQty);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.txtSearchTitle);
            this.Controls.Add(this.lblSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCart";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.MaskedTextBox txtSearchTitle;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnUpdateQty;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnCommitOrder;
        private System.Windows.Forms.Label lblFoundItems;
        private System.Windows.Forms.DataGridView dgvFoundItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartPrice;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label lblTaxValue;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCommitOrdeer;
    }
}