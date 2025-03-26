namespace Modile2BaiSo11_NguyenNgocTuTrinh
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.radioButtonTimesNewRoman = new System.Windows.Forms.RadioButton();
            this.radioButtonArial = new System.Windows.Forms.RadioButton();
            this.radioButtonTahoma = new System.Windows.Forms.RadioButton();
            this.radioButtonCourierNew = new System.Windows.Forms.RadioButton();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(27, 72);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(287, 272);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.Text = "WHAT FONT IS THIS?";
            // 
            // radioButtonTimesNewRoman
            // 
            this.radioButtonTimesNewRoman.AutoSize = true;
            this.radioButtonTimesNewRoman.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTimesNewRoman.Location = new System.Drawing.Point(350, 113);
            this.radioButtonTimesNewRoman.Name = "radioButtonTimesNewRoman";
            this.radioButtonTimesNewRoman.Size = new System.Drawing.Size(189, 27);
            this.radioButtonTimesNewRoman.TabIndex = 1;
            this.radioButtonTimesNewRoman.TabStop = true;
            this.radioButtonTimesNewRoman.Text = "Times New Roman";
            this.radioButtonTimesNewRoman.UseVisualStyleBackColor = true;
            this.radioButtonTimesNewRoman.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonArial
            // 
            this.radioButtonArial.AutoSize = true;
            this.radioButtonArial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonArial.Location = new System.Drawing.Point(350, 165);
            this.radioButtonArial.Name = "radioButtonArial";
            this.radioButtonArial.Size = new System.Drawing.Size(73, 28);
            this.radioButtonArial.TabIndex = 2;
            this.radioButtonArial.TabStop = true;
            this.radioButtonArial.Text = "Arial";
            this.radioButtonArial.UseVisualStyleBackColor = true;
            this.radioButtonArial.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonTahoma
            // 
            this.radioButtonTahoma.AutoSize = true;
            this.radioButtonTahoma.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTahoma.Location = new System.Drawing.Point(350, 219);
            this.radioButtonTahoma.Name = "radioButtonTahoma";
            this.radioButtonTahoma.Size = new System.Drawing.Size(111, 28);
            this.radioButtonTahoma.TabIndex = 3;
            this.radioButtonTahoma.TabStop = true;
            this.radioButtonTahoma.Text = "Tahoma";
            this.radioButtonTahoma.UseVisualStyleBackColor = true;
            this.radioButtonTahoma.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonCourierNew
            // 
            this.radioButtonCourierNew.AutoSize = true;
            this.radioButtonCourierNew.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCourierNew.Location = new System.Drawing.Point(350, 281);
            this.radioButtonCourierNew.Name = "radioButtonCourierNew";
            this.radioButtonCourierNew.Size = new System.Drawing.Size(163, 27);
            this.radioButtonCourierNew.TabIndex = 4;
            this.radioButtonCourierNew.TabStop = true;
            this.radioButtonCourierNew.Text = "Courier New";
            this.radioButtonCourierNew.UseVisualStyleBackColor = true;
            this.radioButtonCourierNew.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(279, 376);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 30);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập văn bản: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.radioButtonCourierNew);
            this.Controls.Add(this.radioButtonTahoma);
            this.Controls.Add(this.radioButtonArial);
            this.Controls.Add(this.radioButtonTimesNewRoman);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Font Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.RadioButton radioButtonTimesNewRoman;
        private System.Windows.Forms.RadioButton radioButtonArial;
        private System.Windows.Forms.RadioButton radioButtonTahoma;
        private System.Windows.Forms.RadioButton radioButtonCourierNew;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
    }
}
