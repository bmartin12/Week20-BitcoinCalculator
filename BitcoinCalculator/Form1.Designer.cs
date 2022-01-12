namespace BitcoinCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyMenu = new System.Windows.Forms.ComboBox();
            this.getRatesBtcn = new System.Windows.Forms.Button();
            this.AmountOfBtcn = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.resultbi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyMenu
            // 
            this.currencyMenu.FormattingEnabled = true;
            this.currencyMenu.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.currencyMenu.Location = new System.Drawing.Point(57, 73);
            this.currencyMenu.Name = "currencyMenu";
            this.currencyMenu.Size = new System.Drawing.Size(121, 23);
            this.currencyMenu.TabIndex = 0;
            this.currencyMenu.Text = "Select currency";
            // 
            // getRatesBtcn
            // 
            this.getRatesBtcn.Location = new System.Drawing.Point(269, 139);
            this.getRatesBtcn.Name = "getRatesBtcn";
            this.getRatesBtcn.Size = new System.Drawing.Size(75, 23);
            this.getRatesBtcn.TabIndex = 1;
            this.getRatesBtcn.Text = "Get Rates";
            this.getRatesBtcn.UseVisualStyleBackColor = true;
            this.getRatesBtcn.Click += new System.EventHandler(this.getRatesBtcn_Click);
            // 
            // AmountOfBtcn
            // 
            this.AmountOfBtcn.Location = new System.Drawing.Point(57, 139);
            this.AmountOfBtcn.Name = "AmountOfBtcn";
            this.AmountOfBtcn.PlaceholderText = "Amount Of Bitcoins";
            this.AmountOfBtcn.Size = new System.Drawing.Size(197, 23);
            this.AmountOfBtcn.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(57, 280);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 23);
            this.result.TabIndex = 3;
            this.result.Visible = false;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // resultbi
            // 
            this.resultbi.AutoSize = true;
            this.resultbi.Location = new System.Drawing.Point(57, 251);
            this.resultbi.Name = "resultbi";
            this.resultbi.Size = new System.Drawing.Size(39, 15);
            this.resultbi.TabIndex = 4;
            this.resultbi.Text = "Result";
            this.resultbi.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(738, 499);
            this.Controls.Add(this.resultbi);
            this.Controls.Add(this.result);
            this.Controls.Add(this.AmountOfBtcn);
            this.Controls.Add(this.getRatesBtcn);
            this.Controls.Add(this.currencyMenu);
            this.Name = "Form1";
            this.Text = "Bitcoin Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyMenu;
        private System.Windows.Forms.Button getRatesBtcn;
        private System.Windows.Forms.TextBox AmountOfBtcn;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label resultbi;
    }
}

