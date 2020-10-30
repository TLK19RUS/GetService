namespace ServiceGrid
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ServiceDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceStartMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceStartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.startLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.stopLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.restartLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.startLayoutPanel2.SuspendLayout();
            this.stopLayoutPanel3.SuspendLayout();
            this.restartLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceDisplayName,
            this.ServiceDescription,
            this.ServiceState,
            this.ServiceStartMode,
            this.ServiceStartName,
            this.ServiceName});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(227, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(711, 405);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // ServiceDisplayName
            // 
            this.ServiceDisplayName.DataPropertyName = "ServiceDisplayName";
            this.ServiceDisplayName.HeaderText = "Имя";
            this.ServiceDisplayName.Name = "ServiceDisplayName";
            this.ServiceDisplayName.ReadOnly = true;
            this.ServiceDisplayName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceDisplayName.Width = 200;
            // 
            // ServiceDescription
            // 
            this.ServiceDescription.DataPropertyName = "ServiceDescription";
            this.ServiceDescription.HeaderText = "Описание";
            this.ServiceDescription.Name = "ServiceDescription";
            this.ServiceDescription.ReadOnly = true;
            // 
            // ServiceState
            // 
            this.ServiceState.DataPropertyName = "ServiceState";
            this.ServiceState.HeaderText = "Состояние";
            this.ServiceState.Name = "ServiceState";
            this.ServiceState.ReadOnly = true;
            // 
            // ServiceStartMode
            // 
            this.ServiceStartMode.DataPropertyName = "ServiceStartMode";
            this.ServiceStartMode.HeaderText = "Тип запуска";
            this.ServiceStartMode.Name = "ServiceStartMode";
            this.ServiceStartMode.ReadOnly = true;
            // 
            // ServiceStartName
            // 
            this.ServiceStartName.DataPropertyName = "ServiceStartName";
            this.ServiceStartName.HeaderText = "Вход от имени";
            this.ServiceStartName.Name = "ServiceStartName";
            this.ServiceStartName.ReadOnly = true;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.HeaderText = "Имя службы";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.startLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.stopLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.restartLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(227, 405);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // startLayoutPanel2
            // 
            this.startLayoutPanel2.AutoSize = true;
            this.startLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.startLayoutPanel2.Controls.Add(this.linkLabel1);
            this.startLayoutPanel2.Controls.Add(this.label4);
            this.startLayoutPanel2.Location = new System.Drawing.Point(0, 39);
            this.startLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.startLayoutPanel2.Name = "startLayoutPanel2";
            this.startLayoutPanel2.Size = new System.Drawing.Size(108, 13);
            this.startLayoutPanel2.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 0);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Запустить";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "службу";
            // 
            // stopLayoutPanel3
            // 
            this.stopLayoutPanel3.AutoSize = true;
            this.stopLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.stopLayoutPanel3.Controls.Add(this.linkLabel2);
            this.stopLayoutPanel3.Controls.Add(this.label5);
            this.stopLayoutPanel3.Location = new System.Drawing.Point(0, 55);
            this.stopLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.stopLayoutPanel3.Name = "stopLayoutPanel3";
            this.stopLayoutPanel3.Size = new System.Drawing.Size(116, 13);
            this.stopLayoutPanel3.TabIndex = 6;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(3, 0);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(67, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Остановить";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "службу";
            // 
            // restartLayoutPanel4
            // 
            this.restartLayoutPanel4.AutoSize = true;
            this.restartLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.restartLayoutPanel4.Controls.Add(this.linkLabel3);
            this.restartLayoutPanel4.Controls.Add(this.label6);
            this.restartLayoutPanel4.Location = new System.Drawing.Point(0, 71);
            this.restartLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.restartLayoutPanel4.Name = "restartLayoutPanel4";
            this.restartLayoutPanel4.Size = new System.Drawing.Size(133, 13);
            this.restartLayoutPanel4.TabIndex = 6;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(3, 0);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(84, 13);
            this.linkLabel3.TabIndex = 4;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Перезапустить";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "службу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 467);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.startLayoutPanel2.ResumeLayout(false);
            this.startLayoutPanel2.PerformLayout();
            this.stopLayoutPanel3.ResumeLayout(false);
            this.stopLayoutPanel3.PerformLayout();
            this.restartLayoutPanel4.ResumeLayout(false);
            this.restartLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceStartMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceStartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel startLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel stopLayoutPanel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel restartLayoutPanel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label6;
    }
}

