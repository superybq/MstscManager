using System;

namespace MstscManager
{
    partial class FormConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView1.AutoGenerateColumns = false;
            this.btnSave = new System.Windows.Forms.Button();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Group,
            this.ServerName,
            this.ServerIp,
            this.ServerUserName,
            this.ServerDomain,
            this.ServerPassword});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(694, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(713, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Index
            // 
            this.Index.DataPropertyName = "Index";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.Index.DefaultCellStyle = dataGridViewCellStyle1;
            this.Index.HeaderText = "排序";
            this.Index.Name = "Index";
            this.Index.Width = 54;
            this.Index.ValueType = typeof(Int32);
            // 
            // Group
            // 
            this.Group.DataPropertyName = "Group";
            this.Group.HeaderText = "分组";
            this.Group.Name = "Group";
            this.Group.Width = 54;
            // 
            // ServerName
            // 
            this.ServerName.DataPropertyName = "ServerName";
            this.ServerName.HeaderText = "名称";
            this.ServerName.Name = "ServerName";
            this.ServerName.Width = 54;
            // 
            // ServerIp
            // 
            this.ServerIp.DataPropertyName = "ServerIp";
            this.ServerIp.HeaderText = "服务器";
            this.ServerIp.Name = "ServerIp";
            this.ServerIp.Width = 66;
            // 
            // ServerUserName
            // 
            this.ServerUserName.DataPropertyName = "ServerUserName";
            this.ServerUserName.HeaderText = "帐号";
            this.ServerUserName.Name = "ServerUserName";
            this.ServerUserName.Width = 54;
            // 
            // ServerDomain
            // 
            this.ServerDomain.DataPropertyName = "ServerDomain";
            this.ServerDomain.HeaderText = "域名";
            this.ServerDomain.Name = "ServerDomain";
            this.ServerDomain.Width = 54;
            // 
            // ServerPassword
            // 
            this.ServerPassword.DataPropertyName = "ServerPassword";
            this.ServerPassword.HeaderText = "密码";
            this.ServerPassword.Name = "ServerPassword";
            this.ServerPassword.Width = 54;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormConfig";
            this.Text = "FormConfig";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerDomain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerPassword;
    }
}