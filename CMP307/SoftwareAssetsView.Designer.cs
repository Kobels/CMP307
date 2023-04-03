namespace CMP307
{
    partial class SoftwareAssetsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.assetView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.softwareAssetView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.addSoftwareAsset = new Guna.UI2.WinForms.Guna2Button();
            this.editSoftwareAsset = new Guna.UI2.WinForms.Guna2Button();
            this.delSoftwareasset = new Guna.UI2.WinForms.Guna2Button();
            this.BackButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.assetView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareAssetView)).BeginInit();
            this.SuspendLayout();
            // 
            // assetView
            // 
            this.assetView.AllowUserToAddRows = false;
            this.assetView.AllowUserToDeleteRows = false;
            this.assetView.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.assetView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.assetView.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.assetView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.assetView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.assetView.DefaultCellStyle = dataGridViewCellStyle27;
            this.assetView.Enabled = false;
            this.assetView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.assetView.Location = new System.Drawing.Point(12, 12);
            this.assetView.Name = "assetView";
            this.assetView.ReadOnly = true;
            this.assetView.RowHeadersVisible = false;
            this.assetView.Size = new System.Drawing.Size(262, 259);
            this.assetView.TabIndex = 0;
            this.assetView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.assetView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.assetView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.assetView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.assetView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.assetView.ThemeStyle.BackColor = System.Drawing.Color.Gray;
            this.assetView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.assetView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.assetView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.assetView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.assetView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetView.ThemeStyle.HeaderStyle.Height = 4;
            this.assetView.ThemeStyle.ReadOnly = true;
            this.assetView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.assetView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.assetView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.assetView.ThemeStyle.RowsStyle.Height = 22;
            this.assetView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.assetView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // softwareAssetView
            // 
            this.softwareAssetView.AllowUserToAddRows = false;
            this.softwareAssetView.AllowUserToDeleteRows = false;
            this.softwareAssetView.AllowUserToResizeRows = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.softwareAssetView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.softwareAssetView.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.softwareAssetView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.softwareAssetView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.softwareAssetView.DefaultCellStyle = dataGridViewCellStyle30;
            this.softwareAssetView.Enabled = false;
            this.softwareAssetView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.softwareAssetView.Location = new System.Drawing.Point(280, 12);
            this.softwareAssetView.Name = "softwareAssetView";
            this.softwareAssetView.ReadOnly = true;
            this.softwareAssetView.RowHeadersVisible = false;
            this.softwareAssetView.Size = new System.Drawing.Size(322, 259);
            this.softwareAssetView.TabIndex = 1;
            this.softwareAssetView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.softwareAssetView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.softwareAssetView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.softwareAssetView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.softwareAssetView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.softwareAssetView.ThemeStyle.BackColor = System.Drawing.Color.Gray;
            this.softwareAssetView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.softwareAssetView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.softwareAssetView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.softwareAssetView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softwareAssetView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.softwareAssetView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.softwareAssetView.ThemeStyle.HeaderStyle.Height = 4;
            this.softwareAssetView.ThemeStyle.ReadOnly = true;
            this.softwareAssetView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.softwareAssetView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.softwareAssetView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softwareAssetView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.softwareAssetView.ThemeStyle.RowsStyle.Height = 22;
            this.softwareAssetView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.softwareAssetView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // addSoftwareAsset
            // 
            this.addSoftwareAsset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addSoftwareAsset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addSoftwareAsset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addSoftwareAsset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addSoftwareAsset.FillColor = System.Drawing.Color.LimeGreen;
            this.addSoftwareAsset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addSoftwareAsset.ForeColor = System.Drawing.Color.White;
            this.addSoftwareAsset.Location = new System.Drawing.Point(608, 12);
            this.addSoftwareAsset.Name = "addSoftwareAsset";
            this.addSoftwareAsset.Size = new System.Drawing.Size(180, 45);
            this.addSoftwareAsset.TabIndex = 2;
            this.addSoftwareAsset.Text = "Add software asset";
            this.addSoftwareAsset.Click += new System.EventHandler(this.addSoftwareAsset_Click);
            // 
            // editSoftwareAsset
            // 
            this.editSoftwareAsset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editSoftwareAsset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editSoftwareAsset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editSoftwareAsset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editSoftwareAsset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editSoftwareAsset.ForeColor = System.Drawing.Color.White;
            this.editSoftwareAsset.Location = new System.Drawing.Point(608, 80);
            this.editSoftwareAsset.Name = "editSoftwareAsset";
            this.editSoftwareAsset.Size = new System.Drawing.Size(180, 45);
            this.editSoftwareAsset.TabIndex = 3;
            this.editSoftwareAsset.Text = "edit software asset";
            this.editSoftwareAsset.Click += new System.EventHandler(this.editSoftwareAsset_Click);
            // 
            // delSoftwareasset
            // 
            this.delSoftwareasset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delSoftwareasset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delSoftwareasset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delSoftwareasset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delSoftwareasset.FillColor = System.Drawing.Color.Crimson;
            this.delSoftwareasset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delSoftwareasset.ForeColor = System.Drawing.Color.White;
            this.delSoftwareasset.Location = new System.Drawing.Point(608, 149);
            this.delSoftwareasset.Name = "delSoftwareasset";
            this.delSoftwareasset.Size = new System.Drawing.Size(180, 45);
            this.delSoftwareasset.TabIndex = 4;
            this.delSoftwareasset.Text = "delete software asset";
            this.delSoftwareasset.Click += new System.EventHandler(this.delSoftwareasset_Click);
            // 
            // BackButton
            // 
            this.BackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(608, 226);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(180, 45);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            // 
            // SoftwareAssetsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 335);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.delSoftwareasset);
            this.Controls.Add(this.editSoftwareAsset);
            this.Controls.Add(this.addSoftwareAsset);
            this.Controls.Add(this.softwareAssetView);
            this.Controls.Add(this.assetView);
            this.Name = "SoftwareAssetsView";
            this.Text = "SoftwareAssetsView";
            ((System.ComponentModel.ISupportInitialize)(this.assetView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareAssetView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView assetView;
        private Guna.UI2.WinForms.Guna2DataGridView softwareAssetView;
        private Guna.UI2.WinForms.Guna2Button addSoftwareAsset;
        private Guna.UI2.WinForms.Guna2Button editSoftwareAsset;
        private Guna.UI2.WinForms.Guna2Button delSoftwareasset;
        private Guna.UI2.WinForms.Guna2Button BackButton;
    }
}