namespace KMPSearch
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
            this.buttonForChoiceFile = new System.Windows.Forms.Button();
            this.buttonForSearch = new System.Windows.Forms.Button();
            this.textBoxForSearch = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxForResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxForText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonForChoiceFile
            // 
            this.buttonForChoiceFile.Location = new System.Drawing.Point(88, 157);
            this.buttonForChoiceFile.Name = "buttonForChoiceFile";
            this.buttonForChoiceFile.Size = new System.Drawing.Size(283, 25);
            this.buttonForChoiceFile.TabIndex = 0;
            this.buttonForChoiceFile.Text = "Выбрать файл";
            this.buttonForChoiceFile.UseVisualStyleBackColor = true;
            this.buttonForChoiceFile.Click += new System.EventHandler(this.buttonForChoiceFile_Click);
            // 
            // buttonForSearch
            // 
            this.buttonForSearch.Enabled = false;
            this.buttonForSearch.Location = new System.Drawing.Point(88, 250);
            this.buttonForSearch.Name = "buttonForSearch";
            this.buttonForSearch.Size = new System.Drawing.Size(283, 38);
            this.buttonForSearch.TabIndex = 1;
            this.buttonForSearch.Text = "Найти";
            this.buttonForSearch.UseVisualStyleBackColor = true;
            this.buttonForSearch.Click += new System.EventHandler(this.buttonForSearch_Click);
            // 
            // textBoxForSearch
            // 
            this.textBoxForSearch.Enabled = false;
            this.textBoxForSearch.HideSelection = false;
            this.textBoxForSearch.Location = new System.Drawing.Point(88, 215);
            this.textBoxForSearch.Multiline = true;
            this.textBoxForSearch.Name = "textBoxForSearch";
            this.textBoxForSearch.Size = new System.Drawing.Size(283, 29);
            this.textBoxForSearch.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(171, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите подстроку";
            // 
            // textBoxForResult
            // 
            this.textBoxForResult.Enabled = false;
            this.textBoxForResult.Location = new System.Drawing.Point(94, 328);
            this.textBoxForResult.Name = "textBoxForResult";
            this.textBoxForResult.ReadOnly = true;
            this.textBoxForResult.Size = new System.Drawing.Size(267, 20);
            this.textBoxForResult.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(160, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Слово найдено в поизиции..";
            // 
            // textBoxForText
            // 
            this.textBoxForText.Location = new System.Drawing.Point(30, 23);
            this.textBoxForText.Multiline = true;
            this.textBoxForText.Name = "textBoxForText";
            this.textBoxForText.Size = new System.Drawing.Size(416, 128);
            this.textBoxForText.TabIndex = 6;
            this.textBoxForText.TextChanged += new System.EventHandler(this.textBoxForText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите текст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxForText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxForResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxForSearch);
            this.Controls.Add(this.buttonForSearch);
            this.Controls.Add(this.buttonForChoiceFile);
            this.Name = "Form1";
            this.Text = "Поск первого вхождения подстроки в текст";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonForChoiceFile;
        private System.Windows.Forms.Button buttonForSearch;
        private System.Windows.Forms.TextBox textBoxForSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxForResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxForText;
        private System.Windows.Forms.Label label3;
    }
}

