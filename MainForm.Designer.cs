
namespace DocumentSearch
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.search_panel = new System.Windows.Forms.Panel();
            this.insuredNum_textBox = new System.Windows.Forms.TextBox();
            this.fullName_textBox = new System.Windows.Forms.TextBox();
            this.empNum_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.other_checkBox = new System.Windows.Forms.CheckBox();
            this.medicalInformation_checkBox = new System.Windows.Forms.CheckBox();
            this.informant_checkBox = new System.Windows.Forms.CheckBox();
            this.medical_checkBox = new System.Windows.Forms.CheckBox();
            this.tessikai_checkBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reset_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.humanDog_checkBox = new System.Windows.Forms.CheckBox();
            this.storeNum_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employee_dgv = new System.Windows.Forms.DataGridView();
            this.noData_panel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dgv)).BeginInit();
            this.noData_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_panel
            // 
            this.search_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.search_panel.Controls.Add(this.insuredNum_textBox);
            this.search_panel.Controls.Add(this.fullName_textBox);
            this.search_panel.Controls.Add(this.empNum_textBox);
            this.search_panel.Controls.Add(this.label6);
            this.search_panel.Controls.Add(this.label5);
            this.search_panel.Controls.Add(this.label4);
            this.search_panel.Controls.Add(this.other_checkBox);
            this.search_panel.Controls.Add(this.medicalInformation_checkBox);
            this.search_panel.Controls.Add(this.informant_checkBox);
            this.search_panel.Controls.Add(this.medical_checkBox);
            this.search_panel.Controls.Add(this.tessikai_checkBox);
            this.search_panel.Controls.Add(this.label3);
            this.search_panel.Controls.Add(this.label1);
            this.search_panel.Controls.Add(this.reset_label);
            this.search_panel.Controls.Add(this.search_button);
            this.search_panel.Controls.Add(this.humanDog_checkBox);
            this.search_panel.Controls.Add(this.storeNum_textBox);
            this.search_panel.Controls.Add(this.label2);
            this.search_panel.Location = new System.Drawing.Point(13, 25);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(689, 385);
            this.search_panel.TabIndex = 0;
            // 
            // insuredNum_textBox
            // 
            this.insuredNum_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.insuredNum_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insuredNum_textBox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.insuredNum_textBox.Location = new System.Drawing.Point(403, 225);
            this.insuredNum_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.insuredNum_textBox.MaxLength = 8;
            this.insuredNum_textBox.Name = "insuredNum_textBox";
            this.insuredNum_textBox.Size = new System.Drawing.Size(143, 26);
            this.insuredNum_textBox.TabIndex = 70;
            this.insuredNum_textBox.WordWrap = false;
            this.insuredNum_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnly_KeyPress);
            // 
            // fullName_textBox
            // 
            this.fullName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fullName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fullName_textBox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fullName_textBox.Location = new System.Drawing.Point(105, 271);
            this.fullName_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.fullName_textBox.Name = "fullName_textBox";
            this.fullName_textBox.Size = new System.Drawing.Size(143, 26);
            this.fullName_textBox.TabIndex = 69;
            this.fullName_textBox.WordWrap = false;
            // 
            // empNum_textBox
            // 
            this.empNum_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.empNum_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empNum_textBox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empNum_textBox.Location = new System.Drawing.Point(105, 225);
            this.empNum_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.empNum_textBox.MaxLength = 6;
            this.empNum_textBox.Name = "empNum_textBox";
            this.empNum_textBox.Size = new System.Drawing.Size(143, 26);
            this.empNum_textBox.TabIndex = 68;
            this.empNum_textBox.WordWrap = false;
            this.empNum_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnly_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(278, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 67;
            this.label6.Text = "被保険者番号：";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(12, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 66;
            this.label5.Text = "氏名：";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 65;
            this.label4.Text = "社員番号：";
            // 
            // other_checkBox
            // 
            this.other_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.other_checkBox.AutoSize = true;
            this.other_checkBox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.other_checkBox.Location = new System.Drawing.Point(461, 165);
            this.other_checkBox.Name = "other_checkBox";
            this.other_checkBox.Size = new System.Drawing.Size(205, 25);
            this.other_checkBox.TabIndex = 62;
            this.other_checkBox.Text = "その他の病院・個別受診";
            this.other_checkBox.UseVisualStyleBackColor = true;
            this.other_checkBox.CheckedChanged += new System.EventHandler(this.form_checkBox_CheckedChanged);
            // 
            // medicalInformation_checkBox
            // 
            this.medicalInformation_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.medicalInformation_checkBox.AutoSize = true;
            this.medicalInformation_checkBox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalInformation_checkBox.Location = new System.Drawing.Point(16, 165);
            this.medicalInformation_checkBox.Name = "medicalInformation_checkBox";
            this.medicalInformation_checkBox.Size = new System.Drawing.Size(281, 25);
            this.medicalInformation_checkBox.TabIndex = 61;
            this.medicalInformation_checkBox.Text = "医療情報健康財団(那須クリニック)";
            this.medicalInformation_checkBox.UseVisualStyleBackColor = true;
            this.medicalInformation_checkBox.CheckedChanged += new System.EventHandler(this.form_checkBox_CheckedChanged);
            // 
            // informant_checkBox
            // 
            this.informant_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.informant_checkBox.AutoSize = true;
            this.informant_checkBox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informant_checkBox.Location = new System.Drawing.Point(325, 125);
            this.informant_checkBox.Name = "informant_checkBox";
            this.informant_checkBox.Size = new System.Drawing.Size(157, 25);
            this.informant_checkBox.TabIndex = 60;
            this.informant_checkBox.Text = "医療情報健康財団";
            this.informant_checkBox.UseVisualStyleBackColor = true;
            this.informant_checkBox.CheckedChanged += new System.EventHandler(this.form_checkBox_CheckedChanged);
            // 
            // medical_checkBox
            // 
            this.medical_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.medical_checkBox.AutoSize = true;
            this.medical_checkBox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medical_checkBox.Location = new System.Drawing.Point(162, 125);
            this.medical_checkBox.Name = "medical_checkBox";
            this.medical_checkBox.Size = new System.Drawing.Size(109, 25);
            this.medical_checkBox.TabIndex = 59;
            this.medical_checkBox.Text = "メディカル";
            this.medical_checkBox.UseVisualStyleBackColor = true;
            this.medical_checkBox.CheckedChanged += new System.EventHandler(this.form_checkBox_CheckedChanged);
            // 
            // tessikai_checkBox
            // 
            this.tessikai_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tessikai_checkBox.AutoSize = true;
            this.tessikai_checkBox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tessikai_checkBox.Location = new System.Drawing.Point(16, 125);
            this.tessikai_checkBox.Name = "tessikai_checkBox";
            this.tessikai_checkBox.Size = new System.Drawing.Size(77, 25);
            this.tessikai_checkBox.TabIndex = 58;
            this.tessikai_checkBox.Text = "畷生会";
            this.tessikai_checkBox.UseVisualStyleBackColor = true;
            this.tessikai_checkBox.CheckedChanged += new System.EventHandler(this.form_checkBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 57;
            this.label3.Text = "帳票名：";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "作成年：";
            // 
            // reset_label
            // 
            this.reset_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reset_label.AutoSize = true;
            this.reset_label.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_label.Location = new System.Drawing.Point(471, 337);
            this.reset_label.Name = "reset_label";
            this.reset_label.Size = new System.Drawing.Size(186, 21);
            this.reset_label.TabIndex = 54;
            this.reset_label.Text = "検索条件をリセットする\r\n";
            this.reset_label.Click += new System.EventHandler(this.reset_label_Click);
            this.reset_label.MouseHover += new System.EventHandler(this.reset_label_MouseHover);
            // 
            // search_button
            // 
            this.search_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.search_button.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(254, 324);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(140, 36);
            this.search_button.TabIndex = 53;
            this.search_button.Text = "検索";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // humanDog_checkBox
            // 
            this.humanDog_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.humanDog_checkBox.AutoSize = true;
            this.humanDog_checkBox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanDog_checkBox.Location = new System.Drawing.Point(325, 165);
            this.humanDog_checkBox.Name = "humanDog_checkBox";
            this.humanDog_checkBox.Size = new System.Drawing.Size(109, 25);
            this.humanDog_checkBox.TabIndex = 35;
            this.humanDog_checkBox.Text = "人間ドッグ";
            this.humanDog_checkBox.UseVisualStyleBackColor = true;
            this.humanDog_checkBox.CheckedChanged += new System.EventHandler(this.form_checkBox_CheckedChanged);
            // 
            // storeNum_textBox
            // 
            this.storeNum_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.storeNum_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.storeNum_textBox.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.storeNum_textBox.Location = new System.Drawing.Point(110, 46);
            this.storeNum_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.storeNum_textBox.MaxLength = 4;
            this.storeNum_textBox.Name = "storeNum_textBox";
            this.storeNum_textBox.Size = new System.Drawing.Size(143, 26);
            this.storeNum_textBox.TabIndex = 34;
            this.storeNum_textBox.WordWrap = false;
            this.storeNum_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnly_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "店舗番号：";
            // 
            // employee_dgv
            // 
            this.employee_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employee_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_dgv.Location = new System.Drawing.Point(12, 424);
            this.employee_dgv.Name = "employee_dgv";
            this.employee_dgv.Size = new System.Drawing.Size(690, 240);
            this.employee_dgv.TabIndex = 6;
            this.employee_dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.employee_dgv_CellMouseDoubleClick);
            this.employee_dgv.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.employee_dgv_CellMouseMove);
            this.employee_dgv.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.employee_dgv_SortCompare);
            // 
            // noData_panel
            // 
            this.noData_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noData_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.noData_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.noData_panel.Controls.Add(this.label12);
            this.noData_panel.Location = new System.Drawing.Point(13, 475);
            this.noData_panel.Name = "noData_panel";
            this.noData_panel.Size = new System.Drawing.Size(687, 189);
            this.noData_panel.TabIndex = 17;
            this.noData_panel.Visible = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(122, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(430, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "「検索条件に一致するものはありませんでした」";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 688);
            this.Controls.Add(this.noData_panel);
            this.Controls.Add(this.employee_dgv);
            this.Controls.Add(this.search_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(730, 727);
            this.Name = "MainForm";
            this.Text = "Document Search System v. 1.0";
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dgv)).EndInit();
            this.noData_panel.ResumeLayout(false);
            this.noData_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox insuredNum_textBox;
        private System.Windows.Forms.TextBox fullName_textBox;
        private System.Windows.Forms.TextBox empNum_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox other_checkBox;
        private System.Windows.Forms.CheckBox medicalInformation_checkBox;
        private System.Windows.Forms.CheckBox informant_checkBox;
        private System.Windows.Forms.CheckBox medical_checkBox;
        private System.Windows.Forms.CheckBox tessikai_checkBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reset_label;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.CheckBox humanDog_checkBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel search_panel;
        public System.Windows.Forms.DataGridView employee_dgv;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Panel noData_panel;
        public System.Windows.Forms.TextBox storeNum_textBox;
    }
}

