
namespace Projeto3Camadas
{
    partial class frm_Formatura
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(37, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(37, 120);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(74, 20);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Descrição";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(37, 183);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 20);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(37, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 27);
            this.txtID.TabIndex = 3;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(37, 144);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(253, 27);
            this.txtDesc.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(37, 206);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(125, 27);
            this.txtValor.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(455, 417);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(37, 256);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(253, 34);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "INSERIR";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(37, 296);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(253, 32);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "EDITAR";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(37, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(253, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "EXCLUIR";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(37, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(125, 27);
            this.txtNome.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome";
            // 
            // frm_Formatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblID);
            this.Name = "frm_Formatura";
            this.Text = "frm_Pacote";
            this.Load += new System.EventHandler(this.frm_Formatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
    }
}

