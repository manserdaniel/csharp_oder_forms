namespace Supermarkt_Forms
{
    partial class OrderFormular
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbProduct = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lboxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(508, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.addClick);
            // 
            // tbProduct
            // 
            this.tbProduct.Location = new System.Drawing.Point(29, 69);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(229, 26);
            this.tbProduct.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Entfernen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.removeClick);
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Location = new System.Drawing.Point(29, 43);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(64, 20);
            this.lbProduct.TabIndex = 3;
            this.lbProduct.Text = "Produkt";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(288, 43);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(58, 20);
            this.lbAmount.TabIndex = 5;
            this.lbAmount.Text = "Anzahl";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(288, 69);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(76, 26);
            this.tbAmount.TabIndex = 4;
            // 
            // lboxOutput
            // 
            this.lboxOutput.FormattingEnabled = true;
            this.lboxOutput.ItemHeight = 20;
            this.lboxOutput.Location = new System.Drawing.Point(29, 134);
            this.lboxOutput.Name = "lboxOutput";
            this.lboxOutput.Size = new System.Drawing.Size(695, 284);
            this.lboxOutput.TabIndex = 6;
            // 
            // OrderFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 455);
            this.Controls.Add(this.lboxOutput);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbProduct);
            this.Controls.Add(this.btnAdd);
            this.Name = "OrderFormular";
            this.Text = "Bestellformular";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.ListBox lboxOutput;
    }
}

