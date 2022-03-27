namespace EatMeUp.View.CustomControl
{
    partial class RecipeItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSadow = new System.Windows.Forms.Panel();
            this.pictureBoxCustommerImage = new System.Windows.Forms.PictureBox();
            this.labelTItle = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.Panel();
            this.labelShortDiscription = new System.Windows.Forms.Label();
            this.labelPreparationTime = new System.Windows.Forms.Label();
            this.labelCookingTime = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.labelPortions = new System.Windows.Forms.Label();
            this.iconPictureBoxCLock = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxInfo = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustommerImage)).BeginInit();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSadow
            // 
            this.panelSadow.BackColor = System.Drawing.Color.DimGray;
            this.panelSadow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSadow.Location = new System.Drawing.Point(0, 346);
            this.panelSadow.Name = "panelSadow";
            this.panelSadow.Size = new System.Drawing.Size(1281, 7);
            this.panelSadow.TabIndex = 0;
            // 
            // pictureBoxCustommerImage
            // 
            this.pictureBoxCustommerImage.Location = new System.Drawing.Point(26, 22);
            this.pictureBoxCustommerImage.Name = "pictureBoxCustommerImage";
            this.pictureBoxCustommerImage.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxCustommerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCustommerImage.TabIndex = 0;
            this.pictureBoxCustommerImage.TabStop = false;
            this.pictureBoxCustommerImage.MouseEnter += new System.EventHandler(this.pictureBoxCustommerImage_MouseEnter);
            this.pictureBoxCustommerImage.MouseLeave += new System.EventHandler(this.pictureBoxCustommerImage_MouseLeave);
            this.pictureBoxCustommerImage.MouseHover += new System.EventHandler(this.pictureBoxCustommerImage_MouseHover);
            // 
            // labelTItle
            // 
            this.labelTItle.AutoSize = true;
            this.labelTItle.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTItle.Location = new System.Drawing.Point(406, 49);
            this.labelTItle.Name = "labelTItle";
            this.labelTItle.Size = new System.Drawing.Size(137, 60);
            this.labelTItle.TabIndex = 1;
            this.labelTItle.Text = "Title";
            this.labelTItle.MouseEnter += new System.EventHandler(this.labelTItle_MouseEnter);
            this.labelTItle.MouseLeave += new System.EventHandler(this.labelTItle_MouseLeave);
            this.labelTItle.MouseHover += new System.EventHandler(this.labelTItle_MouseHover);
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.PeachPuff;
            this.panelImage.Controls.Add(this.pictureBoxCustommerImage);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(348, 346);
            this.panelImage.TabIndex = 2;
            this.panelImage.MouseEnter += new System.EventHandler(this.panelImage_MouseEnter);
            this.panelImage.MouseLeave += new System.EventHandler(this.panelImage_MouseLeave);
            this.panelImage.MouseHover += new System.EventHandler(this.panelImage_MouseHover);
            // 
            // labelShortDiscription
            // 
            this.labelShortDiscription.Font = new System.Drawing.Font("MS UI Gothic", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelShortDiscription.Location = new System.Drawing.Point(406, 133);
            this.labelShortDiscription.Name = "labelShortDiscription";
            this.labelShortDiscription.Size = new System.Drawing.Size(861, 77);
            this.labelShortDiscription.TabIndex = 3;
            this.labelShortDiscription.Text = "SHort Dis";
            this.labelShortDiscription.MouseEnter += new System.EventHandler(this.labelShortDiscription_MouseEnter);
            this.labelShortDiscription.MouseLeave += new System.EventHandler(this.labelShortDiscription_MouseLeave);
            this.labelShortDiscription.MouseHover += new System.EventHandler(this.labelShortDiscription_MouseHover);
            // 
            // labelPreparationTime
            // 
            this.labelPreparationTime.AutoSize = true;
            this.labelPreparationTime.Font = new System.Drawing.Font("MS UI Gothic", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPreparationTime.Location = new System.Drawing.Point(504, 230);
            this.labelPreparationTime.Name = "labelPreparationTime";
            this.labelPreparationTime.Size = new System.Drawing.Size(318, 34);
            this.labelPreparationTime.TabIndex = 4;
            this.labelPreparationTime.Text = "Preparation time: 340";
            this.labelPreparationTime.MouseEnter += new System.EventHandler(this.labelPreparationTime_MouseEnter);
            this.labelPreparationTime.MouseLeave += new System.EventHandler(this.labelPreparationTime_MouseLeave);
            this.labelPreparationTime.MouseHover += new System.EventHandler(this.labelPreparationTime_MouseHover);
            // 
            // labelCookingTime
            // 
            this.labelCookingTime.AutoSize = true;
            this.labelCookingTime.Font = new System.Drawing.Font("MS UI Gothic", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCookingTime.Location = new System.Drawing.Point(504, 288);
            this.labelCookingTime.Name = "labelCookingTime";
            this.labelCookingTime.Size = new System.Drawing.Size(267, 34);
            this.labelCookingTime.TabIndex = 5;
            this.labelCookingTime.Text = "Cooking time: 340";
            this.labelCookingTime.MouseEnter += new System.EventHandler(this.labelCookingTime_MouseEnter);
            this.labelCookingTime.MouseLeave += new System.EventHandler(this.labelCookingTime_MouseLeave);
            this.labelCookingTime.MouseHover += new System.EventHandler(this.labelCookingTime_MouseHover);
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Font = new System.Drawing.Font("MS UI Gothic", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDifficulty.Location = new System.Drawing.Point(977, 230);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(265, 34);
            this.labelDifficulty.TabIndex = 6;
            this.labelDifficulty.Text = "Difficulty: Medium";
            this.labelDifficulty.MouseEnter += new System.EventHandler(this.labelDifficulty_MouseEnter);
            this.labelDifficulty.MouseLeave += new System.EventHandler(this.labelDifficulty_MouseLeave);
            this.labelDifficulty.MouseHover += new System.EventHandler(this.labelDifficulty_MouseHover);
            // 
            // labelPortions
            // 
            this.labelPortions.AutoSize = true;
            this.labelPortions.Font = new System.Drawing.Font("MS UI Gothic", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPortions.Location = new System.Drawing.Point(977, 288);
            this.labelPortions.Name = "labelPortions";
            this.labelPortions.Size = new System.Drawing.Size(185, 34);
            this.labelPortions.TabIndex = 7;
            this.labelPortions.Text = "Portions: 20";
            this.labelPortions.MouseEnter += new System.EventHandler(this.labelPortions_MouseEnter);
            this.labelPortions.MouseLeave += new System.EventHandler(this.labelPortions_MouseLeave);
            this.labelPortions.MouseHover += new System.EventHandler(this.labelPortions_MouseHover);
            // 
            // iconPictureBoxCLock
            // 
            this.iconPictureBoxCLock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBoxCLock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxCLock.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconPictureBoxCLock.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxCLock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxCLock.IconSize = 104;
            this.iconPictureBoxCLock.Location = new System.Drawing.Point(406, 230);
            this.iconPictureBoxCLock.Name = "iconPictureBoxCLock";
            this.iconPictureBoxCLock.Size = new System.Drawing.Size(104, 106);
            this.iconPictureBoxCLock.TabIndex = 8;
            this.iconPictureBoxCLock.TabStop = false;
            this.iconPictureBoxCLock.MouseEnter += new System.EventHandler(this.iconPictureBoxCLock_MouseEnter);
            this.iconPictureBoxCLock.MouseLeave += new System.EventHandler(this.iconPictureBoxCLock_MouseLeave);
            this.iconPictureBoxCLock.MouseHover += new System.EventHandler(this.iconPictureBoxCLock_MouseHover);
            // 
            // iconPictureBoxInfo
            // 
            this.iconPictureBoxInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBoxInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconPictureBoxInfo.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxInfo.IconSize = 104;
            this.iconPictureBoxInfo.Location = new System.Drawing.Point(867, 230);
            this.iconPictureBoxInfo.Name = "iconPictureBoxInfo";
            this.iconPictureBoxInfo.Size = new System.Drawing.Size(104, 106);
            this.iconPictureBoxInfo.TabIndex = 9;
            this.iconPictureBoxInfo.TabStop = false;
            this.iconPictureBoxInfo.MouseEnter += new System.EventHandler(this.iconPictureBoxInfo_MouseEnter);
            this.iconPictureBoxInfo.MouseLeave += new System.EventHandler(this.iconPictureBoxInfo_MouseLeave);
            this.iconPictureBoxInfo.MouseHover += new System.EventHandler(this.iconPictureBoxInfo_MouseHover);
            // 
            // RecipeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.iconPictureBoxInfo);
            this.Controls.Add(this.iconPictureBoxCLock);
            this.Controls.Add(this.labelPortions);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.labelCookingTime);
            this.Controls.Add(this.labelPreparationTime);
            this.Controls.Add(this.labelShortDiscription);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.labelTItle);
            this.Controls.Add(this.panelSadow);
            this.Name = "RecipeItem";
            this.Size = new System.Drawing.Size(1281, 353);
            this.MouseEnter += new System.EventHandler(this.RecipeItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.RecipeItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.RecipeItem_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustommerImage)).EndInit();
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelSadow;
        private PictureBox pictureBoxCustommerImage;
        private Label labelTItle;
        private Panel panelImage;
        private Label labelShortDiscription;
        private Label labelPreparationTime;
        private Label labelCookingTime;
        private Label labelDifficulty;
        private Label labelPortions;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCLock;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxInfo;
    }
}
