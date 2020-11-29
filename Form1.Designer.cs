namespace file_organization
{
    partial class eisch_lich_algorithms
    {
      
        private System.ComponentModel.IContainer components = null;

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
            this.btn_generateNumber = new System.Windows.Forms.Button();
            this.txt_array_size = new System.Windows.Forms.TextBox();
            this.grid_LICHdata = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tbl_lich = new System.Windows.Forms.Label();
            this.lbl_eisch = new System.Windows.Forms.Label();
            this.LICH_textBox = new System.Windows.Forms.TextBox();
            this.grid_EISCHdata = new System.Windows.Forms.DataGridView();
            this.grid_probCom = new System.Windows.Forms.DataGridView();
            this.Values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search_result = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_number_range = new System.Windows.Forms.TextBox();
            this.lbl_range = new System.Windows.Forms.Label();
            this.txt_ProbsStatistics = new System.Windows.Forms.TextBox();
            this.txt_search_value = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_array_size = new System.Windows.Forms.Label();
            this.lbl_prob_num = new System.Windows.Forms.Label();
            this.lbl_baslik2 = new System.Windows.Forms.Label();
            this.lbl_baslik1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_LICHdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_EISCHdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_probCom)).BeginInit();
            this.SuspendLayout();
 
            // btn_generateNumber
            this.btn_generateNumber.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generateNumber.Location = new System.Drawing.Point(864, 110);
            this.btn_generateNumber.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generateNumber.Name = "btn_generateNumber";
            this.btn_generateNumber.Size = new System.Drawing.Size(217, 28);
            this.btn_generateNumber.TabIndex = 2;
            this.btn_generateNumber.Text = "Generate";
            this.btn_generateNumber.UseVisualStyleBackColor = true;
            this.btn_generateNumber.Click += new System.EventHandler(this.generateNumberButton_Click);
 
            // txt_array_size 
            this.txt_array_size.Location = new System.Drawing.Point(1025, 77);
            this.txt_array_size.Margin = new System.Windows.Forms.Padding(4);
            this.txt_array_size.Name = "txt_array_size";
            this.txt_array_size.Size = new System.Drawing.Size(56, 22);
            this.txt_array_size.TabIndex = 3;
            this.txt_array_size.Text = "20";
 
            // grid_LICHdata 
            this.grid_LICHdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_LICHdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewLinkColumn1});
            this.grid_LICHdata.Location = new System.Drawing.Point(564, 569);
            this.grid_LICHdata.Margin = new System.Windows.Forms.Padding(4);
            this.grid_LICHdata.Name = "grid_LICHdata";
            this.grid_LICHdata.RowHeadersWidth = 51;
            this.grid_LICHdata.Size = new System.Drawing.Size(330, 339);
            this.grid_LICHdata.TabIndex = 4;
            this.grid_LICHdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LICH_dataGrid_CellContentClick);
 
            // dataGridViewTextBoxColumn1 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Index";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 50;
 
            // dataGridViewTextBoxColumn2 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            
            // dataGridViewLinkColumn1 
            this.dataGridViewLinkColumn1.HeaderText = "Link";
            this.dataGridViewLinkColumn1.MinimumWidth = 6;
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn1.Width = 50;
             
            // dataGridViewTextBoxColumn3 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Index";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 50;

            // dataGridViewTextBoxColumn4
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
 
            // dataGridViewLinkColumn2 
            this.dataGridViewLinkColumn2.HeaderText = "Link";
            this.dataGridViewLinkColumn2.MinimumWidth = 6;
            this.dataGridViewLinkColumn2.Name = "dataGridViewLinkColumn2";
            this.dataGridViewLinkColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn2.Width = 50;
 
            // tbl_lich 
            this.tbl_lich.AutoSize = true;
            this.tbl_lich.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbl_lich.Location = new System.Drawing.Point(682, 530);
            this.tbl_lich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbl_lich.Name = "tbl_lich";
            this.tbl_lich.Size = new System.Drawing.Size(84, 35);
            this.tbl_lich.TabIndex = 7;
            this.tbl_lich.Text = "LICH";
            this.tbl_lich.TextAlign = System.Drawing.ContentAlignment.TopCenter;
 
            // lbl_eisch 
            this.lbl_eisch.AutoSize = true;
            this.lbl_eisch.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eisch.Location = new System.Drawing.Point(1155, 530);
            this.lbl_eisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_eisch.Name = "lbl_eisch";
            this.lbl_eisch.Size = new System.Drawing.Size(100, 35);
            this.lbl_eisch.TabIndex = 7;
            this.lbl_eisch.Text = "EISCH";
            this.lbl_eisch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_eisch.Click += new System.EventHandler(this.label3_Click);
 
            // LICH_textBox 
            this.LICH_textBox.Location = new System.Drawing.Point(564, 916);
            this.LICH_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.LICH_textBox.Multiline = true;
            this.LICH_textBox.Name = "LICH_textBox";
            this.LICH_textBox.Size = new System.Drawing.Size(330, 57);
            this.LICH_textBox.TabIndex = 6;
 
            // grid_EISCHdata 
            this.grid_EISCHdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_EISCHdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewLinkColumn2});
            this.grid_EISCHdata.Location = new System.Drawing.Point(1025, 569);
            this.grid_EISCHdata.Margin = new System.Windows.Forms.Padding(4);
            this.grid_EISCHdata.Name = "grid_EISCHdata";
            this.grid_EISCHdata.RowHeadersWidth = 51;
            this.grid_EISCHdata.Size = new System.Drawing.Size(330, 339);
            this.grid_EISCHdata.TabIndex = 4;
            this.grid_EISCHdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EISCH_dataGrid_CellContentClick);
 
            // grid_probCom 
            this.grid_probCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_probCom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Values,
            this.LI,
            this.EIS});
            this.grid_probCom.Location = new System.Drawing.Point(787, 272);
            this.grid_probCom.Margin = new System.Windows.Forms.Padding(4);
            this.grid_probCom.Name = "grid_probCom";
            this.grid_probCom.RowHeadersWidth = 51;
            this.grid_probCom.Size = new System.Drawing.Size(350, 247);
            this.grid_probCom.TabIndex = 4;
            this.grid_probCom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.probCom_dataGrid_CellContentClick);
 
            // Values 
            this.Values.HeaderText = "Value";
            this.Values.MinimumWidth = 6;
            this.Values.Name = "Values";
            this.Values.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Values.Width = 75;

            // LI 
            this.LI.HeaderText = "LICH";
            this.LI.MinimumWidth = 6;
            this.LI.Name = "LI";
            this.LI.Width = 75;
 
            // EIS 
            this.EIS.HeaderText = "EISCH";
            this.EIS.MinimumWidth = 6;
            this.EIS.Name = "EIS";
            this.EIS.Width = 75;
 
            // txt_search_result 
            this.txt_search_result.Location = new System.Drawing.Point(1509, 43);
            this.txt_search_result.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search_result.Multiline = true;
            this.txt_search_result.Name = "txt_search_result";
            this.txt_search_result.Size = new System.Drawing.Size(263, 92);
            this.txt_search_result.TabIndex = 8;
 
            // btn_search
            this.btn_search.Location = new System.Drawing.Point(1681, 143);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(91, 28);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.search_button_Click);
 
            // txt_number_range 
            this.txt_number_range.Location = new System.Drawing.Point(898, 80);
            this.txt_number_range.Margin = new System.Windows.Forms.Padding(4);
            this.txt_number_range.Name = "txt_number_range";
            this.txt_number_range.Size = new System.Drawing.Size(56, 22);
            this.txt_number_range.TabIndex = 3;
            this.txt_number_range.Text = "900";
            this.txt_number_range.TextChanged += new System.EventHandler(this.txt_number_range_TextChanged);
 
            // lbl_range 
            this.lbl_range.AutoSize = true;
            this.lbl_range.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_range.Location = new System.Drawing.Point(861, 53);
            this.lbl_range.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_range.Name = "lbl_range";
            this.lbl_range.Size = new System.Drawing.Size(100, 16);
            this.lbl_range.TabIndex = 10;
            this.lbl_range.Text = "Number Range";
            this.lbl_range.Click += new System.EventHandler(this.label8_Click);

            // txt_ProbsStatistics
            this.txt_ProbsStatistics.Location = new System.Drawing.Point(120, 569);
            this.txt_ProbsStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProbsStatistics.Multiline = true;
            this.txt_ProbsStatistics.Name = "txt_ProbsStatistics";
            this.txt_ProbsStatistics.Size = new System.Drawing.Size(372, 201);
            this.txt_ProbsStatistics.TabIndex = 6;

            // txt_search_value
            this.txt_search_value.Location = new System.Drawing.Point(1509, 13);
            this.txt_search_value.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search_value.Name = "txt_search_value";
            this.txt_search_value.Size = new System.Drawing.Size(106, 22);
            this.txt_search_value.TabIndex = 3;
             
            // label9 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(861, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "0 -";

            // lbl_array_size 
            this.lbl_array_size.AutoSize = true;
            this.lbl_array_size.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_array_size.Location = new System.Drawing.Point(1010, 50);
            this.lbl_array_size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_array_size.Name = "lbl_array_size";
            this.lbl_array_size.Size = new System.Drawing.Size(71, 16);
            this.lbl_array_size.TabIndex = 10;
            this.lbl_array_size.Text = "Array Size";
            this.lbl_array_size.Click += new System.EventHandler(this.lbl_array_size_Click);
           
            // lbl_prob_num 
            this.lbl_prob_num.AutoSize = true;
            this.lbl_prob_num.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prob_num.Location = new System.Drawing.Point(858, 233);
            this.lbl_prob_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prob_num.Name = "lbl_prob_num";
            this.lbl_prob_num.Size = new System.Drawing.Size(228, 35);
            this.lbl_prob_num.TabIndex = 7;
            this.lbl_prob_num.Text = "Prob Numbers";
            this.lbl_prob_num.TextAlign = System.Drawing.ContentAlignment.TopCenter;
             
            // lbl_baslik2
            this.lbl_baslik2.AutoSize = true;
            this.lbl_baslik2.BackColor = System.Drawing.Color.GhostWhite;
            this.lbl_baslik2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baslik2.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_baslik2.Location = new System.Drawing.Point(67, 99);
            this.lbl_baslik2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_baslik2.Name = "lbl_baslik2";
            this.lbl_baslik2.Size = new System.Drawing.Size(397, 37);
            this.lbl_baslik2.TabIndex = 10;
            this.lbl_baslik2.Text = "Coalesced Algorithms";
         
            // lbl_baslik1
            this.lbl_baslik1.AutoSize = true;
            this.lbl_baslik1.BackColor = System.Drawing.Color.Snow;
            this.lbl_baslik1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baslik1.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_baslik1.Location = new System.Drawing.Point(67, 27);
            this.lbl_baslik1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_baslik1.Name = "lbl_baslik1";
            this.lbl_baslik1.Size = new System.Drawing.Size(228, 42);
            this.lbl_baslik1.TabIndex = 10;
            this.lbl_baslik1.Text = "LICH - EISCH";
             
            // eisch_lich_algorithms
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1832, 1055);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_baslik1);
            this.Controls.Add(this.lbl_baslik2);
            this.Controls.Add(this.lbl_eisch);
            this.Controls.Add(this.tbl_lich);
            this.Controls.Add(this.lbl_prob_num);
            this.Controls.Add(this.txt_array_size);
            this.Controls.Add(this.btn_generateNumber);
            this.Controls.Add(this.txt_ProbsStatistics);
            this.Controls.Add(this.LICH_textBox);
            this.Controls.Add(this.grid_EISCHdata);
            this.Controls.Add(this.lbl_array_size);
            this.Controls.Add(this.lbl_range);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search_result);
            this.Controls.Add(this.grid_LICHdata);
            this.Controls.Add(this.grid_probCom);
            this.Controls.Add(this.txt_search_value);
            this.Controls.Add(this.txt_number_range);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "eisch_lich_algorithms";
            this.Text = "coaleshed_hashing_algorithms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_LICHdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_EISCHdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_probCom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_generateNumber;
        private System.Windows.Forms.TextBox txt_array_size; 
        private System.Windows.Forms.Label tbl_lich;
        private System.Windows.Forms.Label lbl_eisch;
        private System.Windows.Forms.DataGridView grid_probCom;
        private System.Windows.Forms.DataGridView grid_LICHdata;
        private System.Windows.Forms.TextBox LICH_textBox;
        private System.Windows.Forms.DataGridView grid_EISCHdata;
        private System.Windows.Forms.Label lbl_prob_num;
        private System.Windows.Forms.TextBox txt_ProbsStatistics;
        private System.Windows.Forms.TextBox txt_search_value;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Values;
        private System.Windows.Forms.DataGridViewTextBoxColumn LI;
        private System.Windows.Forms.DataGridViewTextBoxColumn EIS;
        private System.Windows.Forms.TextBox txt_search_result;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_number_range;
        private System.Windows.Forms.Label lbl_range;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_array_size;
        private System.Windows.Forms.Label lbl_baslik2;
        private System.Windows.Forms.Label lbl_baslik1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        
    }
}

