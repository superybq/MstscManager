using System;

namespace MstscManager
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnBatOpen = new System.Windows.Forms.Button();
            this.txtDesktopwidth = new System.Windows.Forms.TextBox();
            this.txtDesktopheight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ServerUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Group,
            this.ServerName,
            this.ServerIp,
            this.btnOpen,
            this.ServerUserName,
            this.ServerDomain,
            this.ServerPassword});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(676, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(734, 415);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(54, 23);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "配置";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnBatOpen
            // 
            this.btnBatOpen.Location = new System.Drawing.Point(713, 356);
            this.btnBatOpen.Name = "btnBatOpen";
            this.btnBatOpen.Size = new System.Drawing.Size(75, 23);
            this.btnBatOpen.TabIndex = 2;
            this.btnBatOpen.Text = "批量打开";
            this.btnBatOpen.UseVisualStyleBackColor = true;
            this.btnBatOpen.Click += new System.EventHandler(this.btnBatOpen_Click);
            // 
            // txtDesktopwidth
            // 
            this.txtDesktopwidth.Location = new System.Drawing.Point(688, 48);
            this.txtDesktopwidth.Name = "txtDesktopwidth";
            this.txtDesktopwidth.Size = new System.Drawing.Size(100, 21);
            this.txtDesktopwidth.TabIndex = 3;
            this.txtDesktopwidth.Text = "1920";
            this.txtDesktopwidth.TextChanged += new System.EventHandler(this.txtDesktopwidth_TextChanged);
            // 
            // txtDesktopheight
            // 
            this.txtDesktopheight.Location = new System.Drawing.Point(688, 76);
            this.txtDesktopheight.Name = "txtDesktopheight";
            this.txtDesktopheight.Size = new System.Drawing.Size(100, 21);
            this.txtDesktopheight.TabIndex = 4;
            this.txtDesktopheight.Text = "1080";
            this.txtDesktopheight.TextChanged += new System.EventHandler(this.txtDesktopheight_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "分辨率";
            // 
            // Index
            // 
            this.Index.DataPropertyName = "Index";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.Index.DefaultCellStyle = dataGridViewCellStyle1;
            this.Index.HeaderText = "排序";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 54;
            // 
            // Group
            // 
            this.Group.DataPropertyName = "Group";
            this.Group.HeaderText = "分组";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Width = 54;
            // 
            // ServerName
            // 
            this.ServerName.DataPropertyName = "ServerName";
            this.ServerName.HeaderText = "名称";
            this.ServerName.Name = "ServerName";
            this.ServerName.ReadOnly = true;
            this.ServerName.Width = 54;
            // 
            // ServerIp
            // 
            this.ServerIp.DataPropertyName = "ServerIp";
            this.ServerIp.HeaderText = "服务器";
            this.ServerIp.Name = "ServerIp";
            this.ServerIp.ReadOnly = true;
            this.ServerIp.Width = 66;
            // 
            // btnOpen
            // 
            this.btnOpen.HeaderText = "";
            this.btnOpen.MinimumWidth = 20;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.ReadOnly = true;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseColumnTextForButtonValue = true;
            this.btnOpen.Width = 20;
            // 
            // ServerUserName
            // 
            this.ServerUserName.DataPropertyName = "ServerUserName";
            this.ServerUserName.HeaderText = "帐号";
            this.ServerUserName.Name = "ServerUserName";
            this.ServerUserName.ReadOnly = true;
            this.ServerUserName.Visible = false;
            this.ServerUserName.Width = 54;
            // 
            // ServerDomain
            // 
            this.ServerDomain.DataPropertyName = "ServerDomain";
            this.ServerDomain.HeaderText = "域名";
            this.ServerDomain.Name = "ServerDomain";
            this.ServerDomain.ReadOnly = true;
            this.ServerDomain.Visible = false;
            this.ServerDomain.Width = 54;
            // 
            // ServerPassword
            // 
            this.ServerPassword.DataPropertyName = "ServerPassword";
            this.ServerPassword.HeaderText = "密码";
            this.ServerPassword.Name = "ServerPassword";
            this.ServerPassword.ReadOnly = true;
            this.ServerPassword.Visible = false;
            this.ServerPassword.Width = 54;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesktopheight);
            this.Controls.Add(this.txtDesktopwidth);
            this.Controls.Add(this.btnBatOpen);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMain";
            this.Text = "远程桌面管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Open;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnBatOpen;
        private System.Windows.Forms.TextBox txtDesktopwidth;
        private System.Windows.Forms.TextBox txtDesktopheight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerIp;
        private System.Windows.Forms.DataGridViewButtonColumn btnOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerDomain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerPassword;
    }
}

