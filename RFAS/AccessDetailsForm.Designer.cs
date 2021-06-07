namespace RFAS
{
    partial class AccessDetailsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.accessMatrixButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(251, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.SystemColors.Control;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.GridLines = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.Location = new System.Drawing.Point(146, 55);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(543, 354);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // accessMatrixButton
            // 
            this.accessMatrixButton.Location = new System.Drawing.Point(352, 415);
            this.accessMatrixButton.Name = "accessMatrixButton";
            this.accessMatrixButton.Size = new System.Drawing.Size(105, 23);
            this.accessMatrixButton.TabIndex = 3;
            this.accessMatrixButton.Text = "הצג טבלה מלאה";
            this.accessMatrixButton.UseVisualStyleBackColor = true;
            this.accessMatrixButton.Click += new System.EventHandler(this.accessMatrixButton_Click);
            // 
            // AccessDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accessMatrixButton);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label2);
            this.Name = "AccessDetailsForm";
            this.Text = "טבלאות גישה";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button accessMatrixButton;
    }
}