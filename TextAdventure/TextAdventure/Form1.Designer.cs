namespace TextAdventure
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
            this.descriptionBox = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.GroupBox();
            this.bedroomPicBox = new System.Windows.Forms.PictureBox();
            this.livingPicBox = new System.Windows.Forms.PictureBox();
            this.kitchenPicBox = new System.Windows.Forms.PictureBox();
            this.diningPicBox = new System.Windows.Forms.PictureBox();
            this.bathroomPicBox = new System.Windows.Forms.PictureBox();
            this.entrancePicBox = new System.Windows.Forms.PictureBox();
            this.examineButton = new System.Windows.Forms.Button();
            this.eastButton = new System.Windows.Forms.Button();
            this.westButton = new System.Windows.Forms.Button();
            this.northButton = new System.Windows.Forms.Button();
            this.southButton = new System.Windows.Forms.Button();
            this.doSomethingButton = new System.Windows.Forms.Button();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.blueKey = new System.Windows.Forms.Label();
            this.redKey = new System.Windows.Forms.Label();
            this.greenKey = new System.Windows.Forms.Label();
            this.descriptionBox.SuspendLayout();
            this.imageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bedroomPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livingPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathroomPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrancePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionBox
            // 
            this.descriptionBox.Controls.Add(this.descriptionLabel);
            this.descriptionBox.Location = new System.Drawing.Point(13, 13);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(381, 286);
            this.descriptionBox.TabIndex = 0;
            this.descriptionBox.TabStop = false;
            this.descriptionBox.Text = "Description";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(24, 39);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(335, 224);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "The door is shut tight. It appears to have three different locks to open.";
            // 
            // imageBox
            // 
            this.imageBox.Controls.Add(this.bedroomPicBox);
            this.imageBox.Controls.Add(this.livingPicBox);
            this.imageBox.Controls.Add(this.kitchenPicBox);
            this.imageBox.Controls.Add(this.diningPicBox);
            this.imageBox.Controls.Add(this.bathroomPicBox);
            this.imageBox.Controls.Add(this.entrancePicBox);
            this.imageBox.Location = new System.Drawing.Point(414, 13);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(381, 286);
            this.imageBox.TabIndex = 1;
            this.imageBox.TabStop = false;
            this.imageBox.Text = "Image";
            // 
            // bedroomPicBox
            // 
            this.bedroomPicBox.Image = global::TextAdventure.Properties.Resources.hauntedBedroom;
            this.bedroomPicBox.Location = new System.Drawing.Point(31, 31);
            this.bedroomPicBox.Name = "bedroomPicBox";
            this.bedroomPicBox.Size = new System.Drawing.Size(319, 224);
            this.bedroomPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bedroomPicBox.TabIndex = 10;
            this.bedroomPicBox.TabStop = false;
            this.bedroomPicBox.Visible = false;
            // 
            // livingPicBox
            // 
            this.livingPicBox.Image = global::TextAdventure.Properties.Resources.hauntedLivingRoom;
            this.livingPicBox.Location = new System.Drawing.Point(31, 31);
            this.livingPicBox.Name = "livingPicBox";
            this.livingPicBox.Size = new System.Drawing.Size(319, 224);
            this.livingPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.livingPicBox.TabIndex = 9;
            this.livingPicBox.TabStop = false;
            this.livingPicBox.Visible = false;
            // 
            // kitchenPicBox
            // 
            this.kitchenPicBox.Image = global::TextAdventure.Properties.Resources.hauntedKitchen;
            this.kitchenPicBox.Location = new System.Drawing.Point(31, 31);
            this.kitchenPicBox.Name = "kitchenPicBox";
            this.kitchenPicBox.Size = new System.Drawing.Size(319, 224);
            this.kitchenPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kitchenPicBox.TabIndex = 8;
            this.kitchenPicBox.TabStop = false;
            this.kitchenPicBox.Visible = false;
            // 
            // diningPicBox
            // 
            this.diningPicBox.Image = global::TextAdventure.Properties.Resources.hauntedDiningRoom;
            this.diningPicBox.Location = new System.Drawing.Point(31, 31);
            this.diningPicBox.Name = "diningPicBox";
            this.diningPicBox.Size = new System.Drawing.Size(319, 224);
            this.diningPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diningPicBox.TabIndex = 7;
            this.diningPicBox.TabStop = false;
            this.diningPicBox.Visible = false;
            // 
            // bathroomPicBox
            // 
            this.bathroomPicBox.Image = global::TextAdventure.Properties.Resources.hauntedBathroom;
            this.bathroomPicBox.Location = new System.Drawing.Point(31, 31);
            this.bathroomPicBox.Name = "bathroomPicBox";
            this.bathroomPicBox.Size = new System.Drawing.Size(319, 224);
            this.bathroomPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bathroomPicBox.TabIndex = 11;
            this.bathroomPicBox.TabStop = false;
            this.bathroomPicBox.Visible = false;
            // 
            // entrancePicBox
            // 
            this.entrancePicBox.Image = global::TextAdventure.Properties.Resources.hauntedEntryway;
            this.entrancePicBox.Location = new System.Drawing.Point(31, 31);
            this.entrancePicBox.Name = "entrancePicBox";
            this.entrancePicBox.Size = new System.Drawing.Size(319, 224);
            this.entrancePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.entrancePicBox.TabIndex = 6;
            this.entrancePicBox.TabStop = false;
            // 
            // examineButton
            // 
            this.examineButton.Location = new System.Drawing.Point(141, 316);
            this.examineButton.Name = "examineButton";
            this.examineButton.Size = new System.Drawing.Size(108, 23);
            this.examineButton.TabIndex = 2;
            this.examineButton.Text = "Examine";
            this.examineButton.UseVisualStyleBackColor = true;
            this.examineButton.Click += new System.EventHandler(this.ExamineButton_Click);
            // 
            // eastButton
            // 
            this.eastButton.Location = new System.Drawing.Point(658, 345);
            this.eastButton.Name = "eastButton";
            this.eastButton.Size = new System.Drawing.Size(75, 23);
            this.eastButton.TabIndex = 3;
            this.eastButton.Text = "East";
            this.eastButton.UseVisualStyleBackColor = true;
            this.eastButton.Click += new System.EventHandler(this.EastButton_Click);
            // 
            // westButton
            // 
            this.westButton.Location = new System.Drawing.Point(513, 345);
            this.westButton.Name = "westButton";
            this.westButton.Size = new System.Drawing.Size(75, 23);
            this.westButton.TabIndex = 4;
            this.westButton.Text = "West";
            this.westButton.UseVisualStyleBackColor = true;
            this.westButton.Click += new System.EventHandler(this.WestButton_Click);
            // 
            // northButton
            // 
            this.northButton.Location = new System.Drawing.Point(585, 316);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(75, 23);
            this.northButton.TabIndex = 5;
            this.northButton.Text = "North";
            this.northButton.UseVisualStyleBackColor = true;
            this.northButton.Click += new System.EventHandler(this.NorthButton_Click);
            // 
            // southButton
            // 
            this.southButton.Enabled = false;
            this.southButton.Location = new System.Drawing.Point(585, 375);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(75, 23);
            this.southButton.TabIndex = 6;
            this.southButton.Text = "South";
            this.southButton.UseVisualStyleBackColor = true;
            this.southButton.Click += new System.EventHandler(this.SouthButton_Click);
            // 
            // doSomethingButton
            // 
            this.doSomethingButton.Location = new System.Drawing.Point(141, 357);
            this.doSomethingButton.Name = "doSomethingButton";
            this.doSomethingButton.Size = new System.Drawing.Size(108, 23);
            this.doSomethingButton.TabIndex = 7;
            this.doSomethingButton.Text = "Do Something";
            this.doSomethingButton.UseVisualStyleBackColor = true;
            this.doSomethingButton.Click += new System.EventHandler(this.DoSomethingButton_Click);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(211, 420);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(54, 13);
            this.inventoryLabel.TabIndex = 8;
            this.inventoryLabel.Text = "Inventory:";
            // 
            // blueKey
            // 
            this.blueKey.AutoSize = true;
            this.blueKey.Location = new System.Drawing.Point(271, 421);
            this.blueKey.Name = "blueKey";
            this.blueKey.Size = new System.Drawing.Size(49, 13);
            this.blueKey.TabIndex = 9;
            this.blueKey.Text = "Blue Key";
            this.blueKey.Visible = false;
            // 
            // redKey
            // 
            this.redKey.AutoSize = true;
            this.redKey.Location = new System.Drawing.Point(271, 408);
            this.redKey.Name = "redKey";
            this.redKey.Size = new System.Drawing.Size(48, 13);
            this.redKey.TabIndex = 10;
            this.redKey.Text = "Red Key";
            this.redKey.Visible = false;
            // 
            // greenKey
            // 
            this.greenKey.AutoSize = true;
            this.greenKey.Location = new System.Drawing.Point(271, 434);
            this.greenKey.Name = "greenKey";
            this.greenKey.Size = new System.Drawing.Size(57, 13);
            this.greenKey.TabIndex = 11;
            this.greenKey.Text = "Green Key";
            this.greenKey.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 475);
            this.Controls.Add(this.greenKey);
            this.Controls.Add(this.redKey);
            this.Controls.Add(this.blueKey);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.doSomethingButton);
            this.Controls.Add(this.southButton);
            this.Controls.Add(this.northButton);
            this.Controls.Add(this.westButton);
            this.Controls.Add(this.eastButton);
            this.Controls.Add(this.examineButton);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.descriptionBox);
            this.Name = "Form1";
            this.Text = "Escape the Haunted House";
            this.descriptionBox.ResumeLayout(false);
            this.imageBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bedroomPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livingPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathroomPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrancePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox descriptionBox;
        private System.Windows.Forms.GroupBox imageBox;
        private System.Windows.Forms.Button examineButton;
        private System.Windows.Forms.Button eastButton;
        private System.Windows.Forms.Button westButton;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Button doSomethingButton;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label blueKey;
        private System.Windows.Forms.Label redKey;
        private System.Windows.Forms.Label greenKey;
        private System.Windows.Forms.PictureBox bedroomPicBox;
        private System.Windows.Forms.PictureBox livingPicBox;
        private System.Windows.Forms.PictureBox kitchenPicBox;
        private System.Windows.Forms.PictureBox diningPicBox;
        private System.Windows.Forms.PictureBox bathroomPicBox;
        private System.Windows.Forms.PictureBox entrancePicBox;
    }
}

