namespace CarsAppDB
{
    partial class Form1
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
            this.listCarsMark = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listCarModel = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CarsMark";
            // 
            // listCarsMark
            // 
            this.listCarsMark.FormattingEnabled = true;
            this.listCarsMark.ItemHeight = 20;
            this.listCarsMark.Location = new System.Drawing.Point(88, 123);
            this.listCarsMark.Name = "listCarsMark";
            this.listCarsMark.Size = new System.Drawing.Size(120, 84);
            this.listCarsMark.TabIndex = 1;
            this.listCarsMark.SelectedIndexChanged += new System.EventHandler(this.listCarsMark_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CarModel";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listCarModel
            // 
            this.listCarModel.FormattingEnabled = true;
            this.listCarModel.ItemHeight = 20;
            this.listCarModel.Location = new System.Drawing.Point(474, 123);
            this.listCarModel.Name = "listCarModel";
            this.listCarModel.Size = new System.Drawing.Size(226, 84);
            this.listCarModel.TabIndex = 3;
            this.listCarModel.SelectedIndexChanged += new System.EventHandler(this.listCarModel_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listCarModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listCarsMark);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listCarsMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listCarModel;
    }
}

