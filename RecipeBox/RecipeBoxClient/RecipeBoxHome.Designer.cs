namespace RecipeBoxClient
{
    partial class RecipeBoxHome
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
            this.MyRecipesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddNewRecipeButton = new System.Windows.Forms.Button();
            this.DeleteRecipeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyRecipesListBox
            // 
            this.MyRecipesListBox.FormattingEnabled = true;
            this.MyRecipesListBox.ItemHeight = 16;
            this.MyRecipesListBox.Location = new System.Drawing.Point(12, 33);
            this.MyRecipesListBox.Name = "MyRecipesListBox";
            this.MyRecipesListBox.Size = new System.Drawing.Size(162, 164);
            this.MyRecipesListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Recipes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddNewRecipeButton
            // 
            this.AddNewRecipeButton.Location = new System.Drawing.Point(12, 203);
            this.AddNewRecipeButton.Name = "AddNewRecipeButton";
            this.AddNewRecipeButton.Size = new System.Drawing.Size(33, 23);
            this.AddNewRecipeButton.TabIndex = 2;
            this.AddNewRecipeButton.Text = "+";
            this.AddNewRecipeButton.UseVisualStyleBackColor = true;
            this.AddNewRecipeButton.Click += new System.EventHandler(this.AddNewRecipeButton_Click);
            // 
            // DeleteRecipeButton
            // 
            this.DeleteRecipeButton.Location = new System.Drawing.Point(61, 203);
            this.DeleteRecipeButton.Name = "DeleteRecipeButton";
            this.DeleteRecipeButton.Size = new System.Drawing.Size(33, 23);
            this.DeleteRecipeButton.TabIndex = 3;
            this.DeleteRecipeButton.Text = "-";
            this.DeleteRecipeButton.UseVisualStyleBackColor = true;
            // 
            // RecipeBoxHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 518);
            this.Controls.Add(this.DeleteRecipeButton);
            this.Controls.Add(this.AddNewRecipeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyRecipesListBox);
            this.Name = "RecipeBoxHome";
            this.Text = "RecipeBoxHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MyRecipesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewRecipeButton;
        private System.Windows.Forms.Button DeleteRecipeButton;
    }
}