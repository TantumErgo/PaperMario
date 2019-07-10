namespace Paper_Mario
{
    partial class TattleLogForm
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
            System.Windows.Forms.Label maxHPLabel;
            System.Windows.Forms.Label attackLabel;
            System.Windows.Forms.Label defenseLabel;
            System.Windows.Forms.Label tattleLabel;
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.enemyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enemyDatabaseDataSet = new Paper_Mario.EnemyDatabaseDataSet();
            this.enemyTableAdapter = new Paper_Mario.EnemyDatabaseDataSetTableAdapters.EnemyTableAdapter();
            this.tableAdapterManager = new Paper_Mario.EnemyDatabaseDataSetTableAdapters.TableAdapterManager();
            this.maxHPTextBox = new System.Windows.Forms.TextBox();
            this.attackTextBox = new System.Windows.Forms.TextBox();
            this.defenseTextBox = new System.Windows.Forms.TextBox();
            this.enemyImagePictureBox = new System.Windows.Forms.PictureBox();
            this.tattleTextBox = new System.Windows.Forms.TextBox();
            this.sortByEnemyIdButton = new System.Windows.Forms.Button();
            this.sortAlphabeticallyButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            maxHPLabel = new System.Windows.Forms.Label();
            attackLabel = new System.Windows.Forms.Label();
            defenseLabel = new System.Windows.Forms.Label();
            tattleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // maxHPLabel
            // 
            maxHPLabel.AutoSize = true;
            maxHPLabel.Location = new System.Drawing.Point(9, 33);
            maxHPLabel.Name = "maxHPLabel";
            maxHPLabel.Size = new System.Drawing.Size(48, 13);
            maxHPLabel.TabIndex = 1;
            maxHPLabel.Text = "Max HP:";
            // 
            // attackLabel
            // 
            attackLabel.AutoSize = true;
            attackLabel.Location = new System.Drawing.Point(9, 67);
            attackLabel.Name = "attackLabel";
            attackLabel.Size = new System.Drawing.Size(41, 13);
            attackLabel.TabIndex = 3;
            attackLabel.Text = "Attack:";
            // 
            // defenseLabel
            // 
            defenseLabel.AutoSize = true;
            defenseLabel.Location = new System.Drawing.Point(9, 102);
            defenseLabel.Name = "defenseLabel";
            defenseLabel.Size = new System.Drawing.Size(50, 13);
            defenseLabel.TabIndex = 5;
            defenseLabel.Text = "Defense:";
            // 
            // tattleLabel
            // 
            tattleLabel.AutoSize = true;
            tattleLabel.Location = new System.Drawing.Point(9, 145);
            tattleLabel.Name = "tattleLabel";
            tattleLabel.Size = new System.Drawing.Size(37, 13);
            tattleLabel.TabIndex = 10;
            tattleLabel.Text = "Tattle:";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.enemyBindingSource;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(180, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // enemyBindingSource
            // 
            this.enemyBindingSource.DataMember = "Enemy";
            this.enemyBindingSource.DataSource = this.enemyDatabaseDataSet;
            // 
            // enemyDatabaseDataSet
            // 
            this.enemyDatabaseDataSet.DataSetName = "EnemyDatabaseDataSet";
            this.enemyDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enemyTableAdapter
            // 
            this.enemyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EnemyTableAdapter = this.enemyTableAdapter;
            this.tableAdapterManager.UpdateOrder = Paper_Mario.EnemyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maxHPTextBox
            // 
            this.maxHPTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.maxHPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enemyBindingSource, "MaxHP", true));
            this.maxHPTextBox.Location = new System.Drawing.Point(63, 30);
            this.maxHPTextBox.Name = "maxHPTextBox";
            this.maxHPTextBox.ReadOnly = true;
            this.maxHPTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxHPTextBox.TabIndex = 2;
            // 
            // attackTextBox
            // 
            this.attackTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.attackTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enemyBindingSource, "Attack", true));
            this.attackTextBox.Location = new System.Drawing.Point(63, 64);
            this.attackTextBox.Name = "attackTextBox";
            this.attackTextBox.ReadOnly = true;
            this.attackTextBox.Size = new System.Drawing.Size(100, 20);
            this.attackTextBox.TabIndex = 4;
            // 
            // defenseTextBox
            // 
            this.defenseTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.defenseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enemyBindingSource, "Defense", true));
            this.defenseTextBox.Location = new System.Drawing.Point(63, 99);
            this.defenseTextBox.Name = "defenseTextBox";
            this.defenseTextBox.ReadOnly = true;
            this.defenseTextBox.Size = new System.Drawing.Size(100, 20);
            this.defenseTextBox.TabIndex = 6;
            // 
            // enemyImagePictureBox
            // 
            this.enemyImagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.enemyBindingSource, "EnemyImage", true));
            this.enemyImagePictureBox.Location = new System.Drawing.Point(189, 21);
            this.enemyImagePictureBox.Name = "enemyImagePictureBox";
            this.enemyImagePictureBox.Size = new System.Drawing.Size(100, 50);
            this.enemyImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyImagePictureBox.TabIndex = 10;
            this.enemyImagePictureBox.TabStop = false;
            // 
            // tattleTextBox
            // 
            this.tattleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.tattleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enemyBindingSource, "Tattle", true));
            this.tattleTextBox.Location = new System.Drawing.Point(63, 142);
            this.tattleTextBox.Multiline = true;
            this.tattleTextBox.Name = "tattleTextBox";
            this.tattleTextBox.ReadOnly = true;
            this.tattleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tattleTextBox.Size = new System.Drawing.Size(100, 121);
            this.tattleTextBox.TabIndex = 11;
            // 
            // sortByEnemyIdButton
            // 
            this.sortByEnemyIdButton.Location = new System.Drawing.Point(22, 272);
            this.sortByEnemyIdButton.Name = "sortByEnemyIdButton";
            this.sortByEnemyIdButton.Size = new System.Drawing.Size(100, 35);
            this.sortByEnemyIdButton.TabIndex = 12;
            this.sortByEnemyIdButton.Text = "Sort By Number";
            this.sortByEnemyIdButton.UseVisualStyleBackColor = true;
            this.sortByEnemyIdButton.Click += new System.EventHandler(this.sortByEnemyIdButton_Click);
            // 
            // sortAlphabeticallyButton
            // 
            this.sortAlphabeticallyButton.Location = new System.Drawing.Point(156, 272);
            this.sortAlphabeticallyButton.Name = "sortAlphabeticallyButton";
            this.sortAlphabeticallyButton.Size = new System.Drawing.Size(75, 35);
            this.sortAlphabeticallyButton.TabIndex = 13;
            this.sortAlphabeticallyButton.Text = "Sort A-Z";
            this.sortAlphabeticallyButton.UseVisualStyleBackColor = true;
            this.sortAlphabeticallyButton.Click += new System.EventHandler(this.sortAlphabeticallyButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(259, 243);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 14;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(271, 272);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 35);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // TattleLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 319);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.sortAlphabeticallyButton);
            this.Controls.Add(this.sortByEnemyIdButton);
            this.Controls.Add(tattleLabel);
            this.Controls.Add(this.tattleTextBox);
            this.Controls.Add(this.enemyImagePictureBox);
            this.Controls.Add(defenseLabel);
            this.Controls.Add(this.defenseTextBox);
            this.Controls.Add(attackLabel);
            this.Controls.Add(this.attackTextBox);
            this.Controls.Add(maxHPLabel);
            this.Controls.Add(this.maxHPTextBox);
            this.Controls.Add(this.listBox1);
            this.Name = "TattleLogForm";
            this.Text = "TattleLogForm";
            this.Load += new System.EventHandler(this.TattleLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private EnemyDatabaseDataSet enemyDatabaseDataSet;
        private System.Windows.Forms.BindingSource enemyBindingSource;
        private EnemyDatabaseDataSetTableAdapters.EnemyTableAdapter enemyTableAdapter;
        private EnemyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maxHPTextBox;
        private System.Windows.Forms.TextBox attackTextBox;
        private System.Windows.Forms.TextBox defenseTextBox;
        private System.Windows.Forms.PictureBox enemyImagePictureBox;
        private System.Windows.Forms.TextBox tattleTextBox;
        private System.Windows.Forms.Button sortByEnemyIdButton;
        private System.Windows.Forms.Button sortAlphabeticallyButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}