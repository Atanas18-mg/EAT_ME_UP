namespace EatMeUp.View.ChildForms
{
    partial class ProfileForm
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelInfoForRecipes = new System.Windows.Forms.Label();
            this.tableLayoutPanelRecipeInfo = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelList = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRecipeInfo = new System.Windows.Forms.Panel();
            this.buttonOK = new RJCodeAdvance.RJControls.RJButton();
            this.buttonDeleteRecipe = new RJCodeAdvance.RJControls.RJButton();
            this.richTextBoxMethodPreparation = new System.Windows.Forms.RichTextBox();
            this.richTextBoxProducts = new System.Windows.Forms.RichTextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBoxCustommerImage = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.tableLayoutPanelRecipeInfo.SuspendLayout();
            this.panelRecipeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustommerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("MS UI Gothic", 26.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelWelcome.Location = new System.Drawing.Point(102, 42);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(793, 87);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome, username!";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("MS UI Gothic", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelInfo.Location = new System.Drawing.Point(102, 182);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(1617, 53);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Here you will find all the information about your profile and your recipes.";
            // 
            // labelInfoForRecipes
            // 
            this.labelInfoForRecipes.AutoSize = true;
            this.labelInfoForRecipes.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfoForRecipes.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelInfoForRecipes.Location = new System.Drawing.Point(61, 335);
            this.labelInfoForRecipes.Name = "labelInfoForRecipes";
            this.labelInfoForRecipes.Size = new System.Drawing.Size(1797, 40);
            this.labelInfoForRecipes.TabIndex = 3;
            this.labelInfoForRecipes.Text = "You haven\'t added a recipe to our platform yet. You can do this by clicking on \"A" +
    "DD RECIPE\" in the menu.";
            // 
            // tableLayoutPanelRecipeInfo
            // 
            this.tableLayoutPanelRecipeInfo.BackColor = System.Drawing.Color.DarkCyan;
            this.tableLayoutPanelRecipeInfo.ColumnCount = 2;
            this.tableLayoutPanelRecipeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.7512F));
            this.tableLayoutPanelRecipeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.2488F));
            this.tableLayoutPanelRecipeInfo.Controls.Add(this.flowLayoutPanelList, 0, 0);
            this.tableLayoutPanelRecipeInfo.Controls.Add(this.panelRecipeInfo, 1, 0);
            this.tableLayoutPanelRecipeInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelRecipeInfo.Location = new System.Drawing.Point(0, 257);
            this.tableLayoutPanelRecipeInfo.Name = "tableLayoutPanelRecipeInfo";
            this.tableLayoutPanelRecipeInfo.Padding = new System.Windows.Forms.Padding(30);
            this.tableLayoutPanelRecipeInfo.RowCount = 1;
            this.tableLayoutPanelRecipeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRecipeInfo.Size = new System.Drawing.Size(3215, 1352);
            this.tableLayoutPanelRecipeInfo.TabIndex = 4;
            // 
            // flowLayoutPanelList
            // 
            this.flowLayoutPanelList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelList.AutoScroll = true;
            this.flowLayoutPanelList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelList.Location = new System.Drawing.Point(61, 128);
            this.flowLayoutPanelList.Name = "flowLayoutPanelList";
            this.flowLayoutPanelList.Padding = new System.Windows.Forms.Padding(80, 10, 80, 10);
            this.flowLayoutPanelList.Size = new System.Drawing.Size(1443, 1095);
            this.flowLayoutPanelList.TabIndex = 1;
            // 
            // panelRecipeInfo
            // 
            this.panelRecipeInfo.Controls.Add(this.buttonOK);
            this.panelRecipeInfo.Controls.Add(this.buttonDeleteRecipe);
            this.panelRecipeInfo.Controls.Add(this.richTextBoxMethodPreparation);
            this.panelRecipeInfo.Controls.Add(this.richTextBoxProducts);
            this.panelRecipeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRecipeInfo.Location = new System.Drawing.Point(1539, 33);
            this.panelRecipeInfo.Name = "panelRecipeInfo";
            this.panelRecipeInfo.Padding = new System.Windows.Forms.Padding(30);
            this.panelRecipeInfo.Size = new System.Drawing.Size(1643, 1286);
            this.panelRecipeInfo.TabIndex = 2;
            this.panelRecipeInfo.Visible = false;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonOK.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.buttonOK.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOK.BorderRadius = 20;
            this.buttonOK.BorderSize = 5;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(870, 1021);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(375, 100);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.TextColor = System.Drawing.Color.White;
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonDeleteRecipe
            // 
            this.buttonDeleteRecipe.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonDeleteRecipe.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.buttonDeleteRecipe.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDeleteRecipe.BorderRadius = 20;
            this.buttonDeleteRecipe.BorderSize = 5;
            this.buttonDeleteRecipe.FlatAppearance.BorderSize = 0;
            this.buttonDeleteRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteRecipe.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteRecipe.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteRecipe.Location = new System.Drawing.Point(1268, 1021);
            this.buttonDeleteRecipe.Name = "buttonDeleteRecipe";
            this.buttonDeleteRecipe.Size = new System.Drawing.Size(375, 100);
            this.buttonDeleteRecipe.TabIndex = 2;
            this.buttonDeleteRecipe.Text = "Delete Recipe";
            this.buttonDeleteRecipe.TextColor = System.Drawing.Color.White;
            this.buttonDeleteRecipe.UseVisualStyleBackColor = false;
            this.buttonDeleteRecipe.Click += new System.EventHandler(this.buttonDeleteRecipe_Click);
            // 
            // richTextBoxMethodPreparation
            // 
            this.richTextBoxMethodPreparation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBoxMethodPreparation.Location = new System.Drawing.Point(647, 19);
            this.richTextBoxMethodPreparation.Name = "richTextBoxMethodPreparation";
            this.richTextBoxMethodPreparation.ReadOnly = true;
            this.richTextBoxMethodPreparation.Size = new System.Drawing.Size(996, 968);
            this.richTextBoxMethodPreparation.TabIndex = 1;
            this.richTextBoxMethodPreparation.Text = "";
            // 
            // richTextBoxProducts
            // 
            this.richTextBoxProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBoxProducts.Location = new System.Drawing.Point(45, 26);
            this.richTextBoxProducts.Name = "richTextBoxProducts";
            this.richTextBoxProducts.ReadOnly = true;
            this.richTextBoxProducts.Size = new System.Drawing.Size(565, 1095);
            this.richTextBoxProducts.TabIndex = 0;
            this.richTextBoxProducts.Text = "";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelLastName.Location = new System.Drawing.Point(2335, 286);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(276, 60);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "LastName";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelFirstName.Location = new System.Drawing.Point(2335, 175);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(282, 60);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "FirstName";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelUsername.Location = new System.Drawing.Point(2335, 42);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(390, 60);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "labelUsername";
            // 
            // pictureBoxCustommerImage
            // 
            this.pictureBoxCustommerImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBoxCustommerImage.BorderColor = System.Drawing.Color.DarkCyan;
            this.pictureBoxCustommerImage.BorderColor2 = System.Drawing.Color.DarkCyan;
            this.pictureBoxCustommerImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.pictureBoxCustommerImage.BorderSize = 6;
            this.pictureBoxCustommerImage.GradientAngle = 50F;
            this.pictureBoxCustommerImage.Location = new System.Drawing.Point(1932, 20);
            this.pictureBoxCustommerImage.Name = "pictureBoxCustommerImage";
            this.pictureBoxCustommerImage.Size = new System.Drawing.Size(355, 355);
            this.pictureBoxCustommerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCustommerImage.TabIndex = 0;
            this.pictureBoxCustommerImage.TabStop = false;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(3215, 1609);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.tableLayoutPanelRecipeInfo);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.pictureBoxCustommerImage);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelInfoForRecipes);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.tableLayoutPanelRecipeInfo.ResumeLayout(false);
            this.panelRecipeInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustommerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label labelWelcome;
        public Label labelInfo;
        public Label labelInfoForRecipes;
        public TableLayoutPanel tableLayoutPanelRecipeInfo;
        public FlowLayoutPanel flowLayoutPanelList;
        public Panel panelRecipeInfo;
        public RichTextBox richTextBoxMethodPreparation;
        public RichTextBox richTextBoxProducts;
        public Label labelLastName;
        public Label labelFirstName;
        public Label labelUsername;
        public RJCodeAdvance.RJControls.RJCircularPictureBox pictureBoxCustommerImage;
        public RJCodeAdvance.RJControls.RJButton buttonOK;
        public RJCodeAdvance.RJControls.RJButton buttonDeleteRecipe;
    }
}