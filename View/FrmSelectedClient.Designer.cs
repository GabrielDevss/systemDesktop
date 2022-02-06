
namespace View
{
    partial class FrmSelectedClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tbnSearch = new System.Windows.Forms.Button();
            this.gropClientData = new System.Windows.Forms.GroupBox();
            this.dgvPricipal = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LimitPurchases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConsult = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gropClientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPricipal)).BeginInit();
            this.groupSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(653, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // tbnSearch
            // 
            this.tbnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnSearch.Location = new System.Drawing.Point(665, 44);
            this.tbnSearch.Name = "tbnSearch";
            this.tbnSearch.Size = new System.Drawing.Size(121, 26);
            this.tbnSearch.TabIndex = 2;
            this.tbnSearch.Text = "&Pesquisar";
            this.tbnSearch.UseVisualStyleBackColor = true;
            this.tbnSearch.Click += new System.EventHandler(this.tbnSearch_Click);
            // 
            // gropClientData
            // 
            this.gropClientData.Controls.Add(this.dgvPricipal);
            this.gropClientData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gropClientData.Location = new System.Drawing.Point(2, 79);
            this.gropClientData.Name = "gropClientData";
            this.gropClientData.Size = new System.Drawing.Size(796, 340);
            this.gropClientData.TabIndex = 4;
            this.gropClientData.TabStop = false;
            this.gropClientData.Text = "Dados do Cliente";
            // 
            // dgvPricipal
            // 
            this.dgvPricipal.AllowUserToAddRows = false;
            this.dgvPricipal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            this.dgvPricipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPricipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPricipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.ClientName,
            this.DateBirth,
            this.Sex,
            this.LimitPurchases});
            this.dgvPricipal.Location = new System.Drawing.Point(6, 25);
            this.dgvPricipal.MultiSelect = false;
            this.dgvPricipal.Name = "dgvPricipal";
            this.dgvPricipal.ReadOnly = true;
            this.dgvPricipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPricipal.Size = new System.Drawing.Size(784, 315);
            this.dgvPricipal.TabIndex = 3;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "IdClient";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.Format = "#,##0";
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Red;
            this.codigo.DefaultCellStyle = dataGridViewCellStyle7;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 70;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ClientName.DefaultCellStyle = dataGridViewCellStyle8;
            this.ClientName.HeaderText = "Nome";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            this.ClientName.Width = 200;
            // 
            // DateBirth
            // 
            this.DateBirth.DataPropertyName = "DateBirth";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "dd/MM/yyyy";
            this.DateBirth.DefaultCellStyle = dataGridViewCellStyle9;
            this.DateBirth.HeaderText = "Nascimento";
            this.DateBirth.Name = "DateBirth";
            this.DateBirth.ReadOnly = true;
            this.DateBirth.Width = 200;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "Sexo";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sex.Width = 60;
            // 
            // LimitPurchases
            // 
            this.LimitPurchases.DataPropertyName = "LimitPurchases";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "#,##0.00";
            this.LimitPurchases.DefaultCellStyle = dataGridViewCellStyle10;
            this.LimitPurchases.HeaderText = "Limite Compras";
            this.LimitPurchases.Name = "LimitPurchases";
            this.LimitPurchases.ReadOnly = true;
            this.LimitPurchases.Width = 160;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(333, 425);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 31);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Inserir";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(426, 425);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 31);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Alterar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(519, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 31);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConsult
            // 
            this.btnConsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsult.Location = new System.Drawing.Point(612, 425);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(87, 31);
            this.btnConsult.TabIndex = 7;
            this.btnConsult.Text = "Consultar";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(705, 425);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 31);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupSearch
            // 
            this.groupSearch.Controls.Add(this.label1);
            this.groupSearch.Controls.Add(this.txtSearch);
            this.groupSearch.Controls.Add(this.tbnSearch);
            this.groupSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSearch.Location = new System.Drawing.Point(2, 3);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(790, 77);
            this.groupSearch.TabIndex = 0;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "Pesquisar Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código/Nome";
            // 
            // FrmSelectedClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.groupSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gropClientData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectedClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ERP System - Selecionar Cliente";
            this.gropClientData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPricipal)).EndInit();
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button tbnSearch;
        private System.Windows.Forms.GroupBox gropClientData;
        private System.Windows.Forms.DataGridView dgvPricipal;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBirth;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimitPurchases;
    }
}