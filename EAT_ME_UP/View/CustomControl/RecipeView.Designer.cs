namespace EatMeUp.View.CustomList
{
    partial class RecipeView
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.labelInfoProducts = new System.Windows.Forms.Label();
            this.panelMethod = new System.Windows.Forms.Panel();
            this.labelInfoMethod = new System.Windows.Forms.Label();
            this.richTextBoxProducts = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMethod = new System.Windows.Forms.RichTextBox();
            this.panelTitleBar.SuspendLayout();
            this.tableLayoutPanelInfo.SuspendLayout();
            this.panelProducts.SuspendLayout();
            this.panelMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkCyan;
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(2281, 220);
            this.panelTitleBar.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("MS UI Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitle.Location = new System.Drawing.Point(26, 65);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(2243, 80);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "recipe Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelInfo
            // 
            this.tableLayoutPanelInfo.AutoScroll = true;
            this.tableLayoutPanelInfo.ColumnCount = 2;
            this.tableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelInfo.Controls.Add(this.panelProducts, 0, 0);
            this.tableLayoutPanelInfo.Controls.Add(this.panelMethod, 1, 0);
            this.tableLayoutPanelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInfo.Location = new System.Drawing.Point(0, 220);
            this.tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
            this.tableLayoutPanelInfo.RowCount = 1;
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInfo.Size = new System.Drawing.Size(2281, 1163);
            this.tableLayoutPanelInfo.TabIndex = 1;
            // 
            // panelProducts
            // 
            this.panelProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelProducts.Controls.Add(this.richTextBoxProducts);
            this.panelProducts.Controls.Add(this.labelInfoProducts);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProducts.Location = new System.Drawing.Point(3, 3);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Padding = new System.Windows.Forms.Padding(20);
            this.panelProducts.Size = new System.Drawing.Size(906, 1157);
            this.panelProducts.TabIndex = 1;
            // 
            // labelInfoProducts
            // 
            this.labelInfoProducts.AutoSize = true;
            this.labelInfoProducts.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfoProducts.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelInfoProducts.Location = new System.Drawing.Point(23, 20);
            this.labelInfoProducts.Name = "labelInfoProducts";
            this.labelInfoProducts.Size = new System.Drawing.Size(362, 40);
            this.labelInfoProducts.TabIndex = 1;
            this.labelInfoProducts.Text = "Necessary Products:";
            // 
            // panelMethod
            // 
            this.panelMethod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMethod.Controls.Add(this.richTextBoxMethod);
            this.panelMethod.Controls.Add(this.labelInfoMethod);
            this.panelMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod.Location = new System.Drawing.Point(915, 3);
            this.panelMethod.Name = "panelMethod";
            this.panelMethod.Padding = new System.Windows.Forms.Padding(20);
            this.panelMethod.Size = new System.Drawing.Size(1363, 1157);
            this.panelMethod.TabIndex = 2;
            // 
            // labelInfoMethod
            // 
            this.labelInfoMethod.AutoSize = true;
            this.labelInfoMethod.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfoMethod.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelInfoMethod.Location = new System.Drawing.Point(23, 20);
            this.labelInfoMethod.Name = "labelInfoMethod";
            this.labelInfoMethod.Size = new System.Drawing.Size(393, 40);
            this.labelInfoMethod.TabIndex = 2;
            this.labelInfoMethod.Text = "Method of preparation:";
            // 
            // richTextBoxProducts
            // 
            this.richTextBoxProducts.Font = new System.Drawing.Font("MS UI Gothic", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxProducts.Location = new System.Drawing.Point(23, 82);
            this.richTextBoxProducts.Name = "richTextBoxProducts";
            this.richTextBoxProducts.ReadOnly = true;
            this.richTextBoxProducts.Size = new System.Drawing.Size(860, 1052);
            this.richTextBoxProducts.TabIndex = 2;
            this.richTextBoxProducts.Text = "";
            // 
            // richTextBoxMethod
            // 
            this.richTextBoxMethod.Font = new System.Drawing.Font("MS UI Gothic", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxMethod.Location = new System.Drawing.Point(23, 82);
            this.richTextBoxMethod.Name = "richTextBoxMethod";
            this.richTextBoxMethod.ReadOnly = true;
            this.richTextBoxMethod.Size = new System.Drawing.Size(1317, 1052);
            this.richTextBoxMethod.TabIndex = 3;
            this.richTextBoxMethod.Text = "";
            // 
            // RecipeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2281, 1383);
            this.Controls.Add(this.tableLayoutPanelInfo);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "RecipeView";
            this.Text = "RecipeView";
            this.panelTitleBar.ResumeLayout(false);
            this.tableLayoutPanelInfo.ResumeLayout(false);
            this.panelProducts.ResumeLayout(false);
            this.panelProducts.PerformLayout();
            this.panelMethod.ResumeLayout(false);
            this.panelMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTitleBar;
        private Label labelTitle;
        private TableLayoutPanel tableLayoutPanelInfo;
        private Panel panelProducts;
        private Label labelInfoProducts;
        private Panel panelMethod;
        private Label labelInfoMethod;
        private RichTextBox richTextBoxProducts;
        private RichTextBox richTextBoxMethod;
    }
}