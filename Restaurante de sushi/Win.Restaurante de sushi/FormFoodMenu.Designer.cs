namespace Win.Restaurante_de_sushi
{
    partial class FormFoodMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFoodMenu));
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label calificacionLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label menuLabel;
            System.Windows.Forms.Label precioLabel;
            this.listaFoodMenuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaFoodMenuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listaFoodMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.calificacionTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.menuTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            activoLabel = new System.Windows.Forms.Label();
            calificacionLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            menuLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaFoodMenuBindingNavigator)).BeginInit();
            this.listaFoodMenuBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaFoodMenuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listaFoodMenuBindingNavigator
            // 
            this.listaFoodMenuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaFoodMenuBindingNavigator.BindingSource = this.listaFoodMenuBindingSource;
            this.listaFoodMenuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaFoodMenuBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaFoodMenuBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaFoodMenuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaFoodMenuBindingNavigatorSaveItem});
            this.listaFoodMenuBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaFoodMenuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaFoodMenuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaFoodMenuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaFoodMenuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaFoodMenuBindingNavigator.Name = "listaFoodMenuBindingNavigator";
            this.listaFoodMenuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaFoodMenuBindingNavigator.Size = new System.Drawing.Size(711, 27);
            this.listaFoodMenuBindingNavigator.TabIndex = 0;
            this.listaFoodMenuBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // listaFoodMenuBindingNavigatorSaveItem
            // 
            this.listaFoodMenuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaFoodMenuBindingNavigatorSaveItem.Enabled = false;
            this.listaFoodMenuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaFoodMenuBindingNavigatorSaveItem.Image")));
            this.listaFoodMenuBindingNavigatorSaveItem.Name = "listaFoodMenuBindingNavigatorSaveItem";
            this.listaFoodMenuBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.listaFoodMenuBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // listaFoodMenuBindingSource
            // 
            this.listaFoodMenuBindingSource.DataSource = typeof(BL.Sushi.FoodMenu);
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(28, 190);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(50, 17);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaFoodMenuBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(118, 188);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(441, 19);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // calificacionLabel
            // 
            calificacionLabel.AutoSize = true;
            calificacionLabel.Location = new System.Drawing.Point(26, 163);
            calificacionLabel.Name = "calificacionLabel";
            calificacionLabel.Size = new System.Drawing.Size(83, 17);
            calificacionLabel.TabIndex = 3;
            calificacionLabel.Text = "Calificacion:";
            // 
            // calificacionTextBox
            // 
            this.calificacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFoodMenuBindingSource, "Calificacion", true));
            this.calificacionTextBox.Location = new System.Drawing.Point(118, 160);
            this.calificacionTextBox.Name = "calificacionTextBox";
            this.calificacionTextBox.Size = new System.Drawing.Size(513, 22);
            this.calificacionTextBox.TabIndex = 4;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(26, 105);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFoodMenuBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(118, 102);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(513, 22);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Location = new System.Drawing.Point(26, 72);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new System.Drawing.Size(47, 17);
            menuLabel.TabIndex = 7;
            menuLabel.Text = "Menu:";
            // 
            // menuTextBox
            // 
            this.menuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFoodMenuBindingSource, "Menu", true));
            this.menuTextBox.Location = new System.Drawing.Point(118, 69);
            this.menuTextBox.Name = "menuTextBox";
            this.menuTextBox.Size = new System.Drawing.Size(513, 22);
            this.menuTextBox.TabIndex = 8;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(26, 133);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(52, 17);
            precioLabel.TabIndex = 9;
            precioLabel.Text = "Precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFoodMenuBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(118, 130);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(513, 22);
            this.precioTextBox.TabIndex = 10;
            // 
            // FormFoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 314);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(calificacionLabel);
            this.Controls.Add(this.calificacionTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(menuLabel);
            this.Controls.Add(this.menuTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.listaFoodMenuBindingNavigator);
            this.Name = "FormFoodMenu";
            this.Text = "FoodMenu";
            ((System.ComponentModel.ISupportInitialize)(this.listaFoodMenuBindingNavigator)).EndInit();
            this.listaFoodMenuBindingNavigator.ResumeLayout(false);
            this.listaFoodMenuBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaFoodMenuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaFoodMenuBindingSource;
        private System.Windows.Forms.BindingNavigator listaFoodMenuBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaFoodMenuBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox calificacionTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox menuTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
    }
}