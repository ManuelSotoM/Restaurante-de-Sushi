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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label calificacionLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label menuLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFoodMenu));
            System.Windows.Forms.Label tipoIdLabel;
            this.listaFoodMenuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaFoodMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaFoodMenuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.calificacionTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.menuTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.listaFoodMenuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listaFoodMenuBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaIdComboBox = new System.Windows.Forms.ComboBox();
            this.categoriasBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoIdComboBox = new System.Windows.Forms.ComboBox();
            this.tiposBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listaTiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            activoLabel = new System.Windows.Forms.Label();
            calificacionLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            menuLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            tipoIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaFoodMenuBindingNavigator)).BeginInit();
            this.listaFoodMenuBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaFoodMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFoodMenuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFoodMenuBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTiposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(28, 257);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(50, 17);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // calificacionLabel
            // 
            calificacionLabel.AutoSize = true;
            calificacionLabel.Location = new System.Drawing.Point(26, 227);
            calificacionLabel.Name = "calificacionLabel";
            calificacionLabel.Size = new System.Drawing.Size(83, 17);
            calificacionLabel.TabIndex = 3;
            calificacionLabel.Text = "Calificacion:";
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
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Location = new System.Drawing.Point(26, 72);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new System.Drawing.Size(47, 17);
            menuLabel.TabIndex = 7;
            menuLabel.Text = "Menu:";
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
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(711, 69);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(0, 17);
            fotoLabel.TabIndex = 11;
            fotoLabel.Click += new System.EventHandler(this.fotoLabel_Click);
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(28, 187);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(77, 17);
            categoriaIdLabel.TabIndex = 17;
            categoriaIdLabel.Text = "Categoria :";
            // 
            // listaFoodMenuBindingNavigator
            // 
            this.listaFoodMenuBindingNavigator.AddNewItem = null;
            this.listaFoodMenuBindingNavigator.BindingSource = this.listaFoodMenuBindingSource;
            this.listaFoodMenuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaFoodMenuBindingNavigator.DeleteItem = null;
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
            this.listaFoodMenuBindingNavigatorSaveItem,
            this.toolStripButtonCancelar,
            this.toolStripButton1});
            this.listaFoodMenuBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaFoodMenuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaFoodMenuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaFoodMenuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaFoodMenuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaFoodMenuBindingNavigator.Name = "listaFoodMenuBindingNavigator";
            this.listaFoodMenuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaFoodMenuBindingNavigator.Size = new System.Drawing.Size(1064, 27);
            this.listaFoodMenuBindingNavigator.TabIndex = 0;
            this.listaFoodMenuBindingNavigator.Text = "bindingNavigator1";
            // 
            // listaFoodMenuBindingSource
            // 
            this.listaFoodMenuBindingSource.DataSource = typeof(BL.Sushi.FoodMenuBL.FoodMenu);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
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
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaFoodMenuBindingNavigatorSaveItem
            // 
            this.listaFoodMenuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaFoodMenuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaFoodMenuBindingNavigatorSaveItem.Image")));
            this.listaFoodMenuBindingNavigatorSaveItem.Name = "listaFoodMenuBindingNavigatorSaveItem";
            this.listaFoodMenuBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.listaFoodMenuBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaFoodMenuBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaFoodMenuBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(70, 24);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaFoodMenuBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(118, 255);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(441, 19);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // calificacionTextBox
            // 
            this.calificacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFoodMenuBindingSource, "Calificacion", true));
            this.calificacionTextBox.Location = new System.Drawing.Point(118, 227);
            this.calificacionTextBox.Name = "calificacionTextBox";
            this.calificacionTextBox.Size = new System.Drawing.Size(513, 22);
            this.calificacionTextBox.TabIndex = 4;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFoodMenuBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(118, 102);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(513, 22);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // menuTextBox
            // 
            this.menuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFoodMenuBindingSource, "Menu", true));
            this.menuTextBox.Location = new System.Drawing.Point(118, 69);
            this.menuTextBox.Name = "menuTextBox";
            this.menuTextBox.Size = new System.Drawing.Size(513, 22);
            this.menuTextBox.TabIndex = 8;
            this.menuTextBox.TextChanged += new System.EventHandler(this.menuTextBox_TextChanged);
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFoodMenuBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(118, 133);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(513, 22);
            this.precioTextBox.TabIndex = 10;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaFoodMenuBindingSource, "Foto", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.fotoPictureBox.Location = new System.Drawing.Point(659, 69);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(385, 233);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 12;
            this.fotoPictureBox.TabStop = false;
            this.fotoPictureBox.Click += new System.EventHandler(this.fotoPictureBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(728, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(895, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Remover foto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "jpg, png | *.jpg; *.png";
            // 
            // categoriaIdComboBox
            // 
            this.categoriaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaFoodMenuBindingSource, "CategoriaId", true));
            this.categoriaIdComboBox.DataSource = this.listaCategoriasBindingSource;
            this.categoriaIdComboBox.DisplayMember = "Descripcion";
            this.categoriaIdComboBox.FormattingEnabled = true;
            this.categoriaIdComboBox.Location = new System.Drawing.Point(118, 191);
            this.categoriaIdComboBox.Name = "categoriaIdComboBox";
            this.categoriaIdComboBox.Size = new System.Drawing.Size(513, 24);
            this.categoriaIdComboBox.TabIndex = 18;
            this.categoriaIdComboBox.ValueMember = "Id";
            // 
            // categoriasBLBindingSource
            // 
            this.categoriasBLBindingSource.DataSource = typeof(BL.Sushi.CategoriasBL);
            // 
            // listaCategoriasBindingSource
            // 
            this.listaCategoriasBindingSource.DataMember = "ListaCategorias";
            this.listaCategoriasBindingSource.DataSource = this.categoriasBLBindingSource;
            // 
            // tiposBLBindingSource
            // 
            this.tiposBLBindingSource.DataSource = typeof(BL.Sushi.TiposBL);
            // 
            // tipoIdLabel
            // 
            tipoIdLabel.AutoSize = true;
            tipoIdLabel.Location = new System.Drawing.Point(28, 161);
            tipoIdLabel.Name = "tipoIdLabel";
            tipoIdLabel.Size = new System.Drawing.Size(44, 17);
            tipoIdLabel.TabIndex = 18;
            tipoIdLabel.Text = "Tipo :";
            // 
            // tipoIdComboBox
            // 
            this.tipoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaFoodMenuBindingSource, "TipoId", true));
            this.tipoIdComboBox.DataSource = this.listaTiposBindingSource;
            this.tipoIdComboBox.DisplayMember = "Descripcion";
            this.tipoIdComboBox.FormattingEnabled = true;
            this.tipoIdComboBox.Location = new System.Drawing.Point(118, 161);
            this.tipoIdComboBox.Name = "tipoIdComboBox";
            this.tipoIdComboBox.Size = new System.Drawing.Size(513, 24);
            this.tipoIdComboBox.TabIndex = 19;
            this.tipoIdComboBox.ValueMember = "Id";
            // 
            // tiposBLBindingSource1
            // 
            this.tiposBLBindingSource1.DataSource = typeof(BL.Sushi.TiposBL);
            this.tiposBLBindingSource1.CurrentChanged += new System.EventHandler(this.tiposBLBindingSource1_CurrentChanged);
            // 
            // listaTiposBindingSource
            // 
            this.listaTiposBindingSource.DataMember = "ListaTipos";
            this.listaTiposBindingSource.DataSource = this.tiposBLBindingSource;
            // 
            // FormFoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 595);
            this.Controls.Add(tipoIdLabel);
            this.Controls.Add(this.tipoIdComboBox);
            this.Controls.Add(categoriaIdLabel);
            this.Controls.Add(this.categoriaIdComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
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
            this.Load += new System.EventHandler(this.FormFoodMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaFoodMenuBindingNavigator)).EndInit();
            this.listaFoodMenuBindingNavigator.ResumeLayout(false);
            this.listaFoodMenuBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaFoodMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFoodMenuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFoodMenuBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTiposBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource listaFoodMenuBindingSource1;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource listaFoodMenuBindingSource2;
        private System.Windows.Forms.ComboBox categoriaIdComboBox;
        private System.Windows.Forms.BindingSource categoriasBLBindingSource;
        private System.Windows.Forms.BindingSource listaCategoriasBindingSource;
        private System.Windows.Forms.BindingSource tiposBLBindingSource;
        private System.Windows.Forms.ComboBox tipoIdComboBox;
        private System.Windows.Forms.BindingSource tiposBLBindingSource1;
        private System.Windows.Forms.BindingSource listaTiposBindingSource;
    }
}