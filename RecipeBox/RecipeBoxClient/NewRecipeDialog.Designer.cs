namespace RecipeBoxClient
{
    partial class NewRecipeDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.NewRecipeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewRecipePrepTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewRecipeDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NewRecipeCookTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IngredientsList = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NewIngredientName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NewIngredientQnty = new System.Windows.Forms.TextBox();
            this.NewIngredientType = new System.Windows.Forms.ComboBox();
            this.NewIngredientAdd = new System.Windows.Forms.Button();
            this.NewStepAdd = new System.Windows.Forms.Button();
            this.NewStepText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.RecipeStepsList = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.NewRecipeAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe Name";
            // 
            // NewRecipeName
            // 
            this.NewRecipeName.Location = new System.Drawing.Point(13, 30);
            this.NewRecipeName.Name = "NewRecipeName";
            this.NewRecipeName.Size = new System.Drawing.Size(242, 22);
            this.NewRecipeName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prep Time";
            // 
            // NewRecipePrepTime
            // 
            this.NewRecipePrepTime.Location = new System.Drawing.Point(12, 236);
            this.NewRecipePrepTime.Name = "NewRecipePrepTime";
            this.NewRecipePrepTime.Size = new System.Drawing.Size(71, 22);
            this.NewRecipePrepTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(564, 2);
            this.label3.TabIndex = 4;
            // 
            // NewRecipeDescription
            // 
            this.NewRecipeDescription.Location = new System.Drawing.Point(13, 76);
            this.NewRecipeDescription.Multiline = true;
            this.NewRecipeDescription.Name = "NewRecipeDescription";
            this.NewRecipeDescription.Size = new System.Drawing.Size(563, 101);
            this.NewRecipeDescription.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description";
            // 
            // NewRecipeCookTime
            // 
            this.NewRecipeCookTime.Location = new System.Drawing.Point(109, 236);
            this.NewRecipeCookTime.Name = "NewRecipeCookTime";
            this.NewRecipeCookTime.Size = new System.Drawing.Size(71, 22);
            this.NewRecipeCookTime.TabIndex = 8;
            this.NewRecipeCookTime.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cook Time";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(564, 2);
            this.label6.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ingredients List:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // IngredientsList
            // 
            this.IngredientsList.FormattingEnabled = true;
            this.IngredientsList.ItemHeight = 16;
            this.IngredientsList.Location = new System.Drawing.Point(12, 310);
            this.IngredientsList.Name = "IngredientsList";
            this.IngredientsList.Size = new System.Drawing.Size(220, 196);
            this.IngredientsList.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Add New Ingredient:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 566);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Name";
            // 
            // NewIngredientName
            // 
            this.NewIngredientName.Location = new System.Drawing.Point(63, 563);
            this.NewIngredientName.Name = "NewIngredientName";
            this.NewIngredientName.Size = new System.Drawing.Size(169, 22);
            this.NewIngredientName.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 600);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Qnty";
            // 
            // NewIngredientQnty
            // 
            this.NewIngredientQnty.Location = new System.Drawing.Point(63, 597);
            this.NewIngredientQnty.Name = "NewIngredientQnty";
            this.NewIngredientQnty.Size = new System.Drawing.Size(42, 22);
            this.NewIngredientQnty.TabIndex = 16;
            // 
            // NewIngredientType
            // 
            this.NewIngredientType.FormattingEnabled = true;
            this.NewIngredientType.Location = new System.Drawing.Point(111, 595);
            this.NewIngredientType.Name = "NewIngredientType";
            this.NewIngredientType.Size = new System.Drawing.Size(121, 24);
            this.NewIngredientType.TabIndex = 17;
            // 
            // NewIngredientAdd
            // 
            this.NewIngredientAdd.Location = new System.Drawing.Point(157, 625);
            this.NewIngredientAdd.Name = "NewIngredientAdd";
            this.NewIngredientAdd.Size = new System.Drawing.Size(75, 23);
            this.NewIngredientAdd.TabIndex = 18;
            this.NewIngredientAdd.Text = "Add";
            this.NewIngredientAdd.UseVisualStyleBackColor = true;
            this.NewIngredientAdd.Click += new System.EventHandler(this.NewIngredientAdd_Click);
            // 
            // NewStepAdd
            // 
            this.NewStepAdd.Location = new System.Drawing.Point(418, 625);
            this.NewStepAdd.Name = "NewStepAdd";
            this.NewStepAdd.Size = new System.Drawing.Size(75, 23);
            this.NewStepAdd.TabIndex = 26;
            this.NewStepAdd.Text = "Add";
            this.NewStepAdd.UseVisualStyleBackColor = true;
            this.NewStepAdd.Click += new System.EventHandler(this.NewStepAdd_Click);
            // 
            // NewStepText
            // 
            this.NewStepText.Location = new System.Drawing.Point(276, 563);
            this.NewStepText.Multiline = true;
            this.NewStepText.Name = "NewStepText";
            this.NewStepText.Size = new System.Drawing.Size(217, 56);
            this.NewStepText.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(273, 540);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Add New Step:";
            // 
            // RecipeStepsList
            // 
            this.RecipeStepsList.FormattingEnabled = true;
            this.RecipeStepsList.ItemHeight = 16;
            this.RecipeStepsList.Location = new System.Drawing.Point(273, 310);
            this.RecipeStepsList.Name = "RecipeStepsList";
            this.RecipeStepsList.Size = new System.Drawing.Size(220, 196);
            this.RecipeStepsList.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(271, 289);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "Recipe Steps:";
            // 
            // NewRecipeAdd
            // 
            this.NewRecipeAdd.Location = new System.Drawing.Point(418, 710);
            this.NewRecipeAdd.Name = "NewRecipeAdd";
            this.NewRecipeAdd.Size = new System.Drawing.Size(75, 23);
            this.NewRecipeAdd.TabIndex = 27;
            this.NewRecipeAdd.Text = "Submit";
            this.NewRecipeAdd.UseVisualStyleBackColor = true;
            this.NewRecipeAdd.Click += new System.EventHandler(this.NewRecipeAdd_Click);
            // 
            // NewRecipeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 745);
            this.Controls.Add(this.NewRecipeAdd);
            this.Controls.Add(this.NewStepAdd);
            this.Controls.Add(this.NewStepText);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.RecipeStepsList);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.NewIngredientAdd);
            this.Controls.Add(this.NewIngredientType);
            this.Controls.Add(this.NewIngredientQnty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NewIngredientName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IngredientsList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NewRecipeCookTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NewRecipeDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewRecipePrepTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewRecipeName);
            this.Controls.Add(this.label1);
            this.Name = "NewRecipeDialog";
            this.Text = "NewRecipeDialog";
            this.Load += new System.EventHandler(this.NewRecipeDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewRecipeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewRecipePrepTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewRecipeDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewRecipeCookTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox IngredientsList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NewIngredientName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NewIngredientQnty;
        private System.Windows.Forms.ComboBox NewIngredientType;
        private System.Windows.Forms.Button NewIngredientAdd;
        private System.Windows.Forms.Button NewStepAdd;
        private System.Windows.Forms.TextBox NewStepText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox RecipeStepsList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button NewRecipeAdd;
    }
}