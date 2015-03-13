namespace LODsample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEndpoint = new System.Windows.Forms.TextBox();
            this.classGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyGrid = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.classGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 244);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(852, 52);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "クラス検出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEndpoint
            // 
            this.txtEndpoint.Location = new System.Drawing.Point(212, 23);
            this.txtEndpoint.Name = "txtEndpoint";
            this.txtEndpoint.Size = new System.Drawing.Size(426, 22);
            this.txtEndpoint.TabIndex = 2;
            this.txtEndpoint.Text = "http://ja.dbpedia.org/sparql";
            // 
            // classGridView
            // 
            this.classGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.property,
            this.Column2});
            this.classGridView.Location = new System.Drawing.Point(27, 104);
            this.classGridView.Name = "classGridView";
            this.classGridView.RowTemplate.Height = 24;
            this.classGridView.Size = new System.Drawing.Size(395, 123);
            this.classGridView.TabIndex = 3;
            this.classGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "class";
            this.Column1.Name = "Column1";
            // 
            // property
            // 
            this.property.HeaderText = "property";
            this.property.Name = "property";
            this.property.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "エンドポイント指定";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(685, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 32);
            this.button4.TabIndex = 6;
            this.button4.Text = "検索結果出力";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // resultGridView
            // 
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5});
            this.resultGridView.Location = new System.Drawing.Point(27, 354);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.RowTemplate.Height = 24;
            this.resultGridView.Size = new System.Drawing.Size(852, 150);
            this.resultGridView.TabIndex = 7;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "s";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "p";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "o";
            this.Column5.Name = "Column5";
            // 
            // propertyGrid
            // 
            this.propertyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.label});
            this.propertyGrid.Location = new System.Drawing.Point(494, 104);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.RowTemplate.Height = 24;
            this.propertyGrid.Size = new System.Drawing.Size(385, 123);
            this.propertyGrid.TabIndex = 8;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "property";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // label
            // 
            this.label.HeaderText = "property";
            this.label.Name = "label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 533);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.resultGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.classGridView);
            this.Controls.Add(this.txtEndpoint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "LODsample";
            ((System.ComponentModel.ISupportInitialize)(this.classGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEndpoint;
        private System.Windows.Forms.DataGridView classGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView resultGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView propertyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn property;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn label;
    }
}

