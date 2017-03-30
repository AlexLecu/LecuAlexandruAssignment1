namespace OrderManagers
{
    partial class ViewOrders
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Orders";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(365, 28);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gridOrders
            // 
            this.gridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrders.Location = new System.Drawing.Point(1, 94);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.Size = new System.Drawing.Size(624, 342);
            this.gridOrders.TabIndex = 2;
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 437);
            this.Controls.Add(this.gridOrders);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Name = "ViewOrders";
            this.Text = "ViewOrders";
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView gridOrders;
    }
}