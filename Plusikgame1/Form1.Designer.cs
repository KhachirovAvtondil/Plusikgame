namespace Plusikgame1
{
    partial class FormGame
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
            pictureBoxPlus = new PictureBox();
            pictureBoxMult = new PictureBox();
            labelTarget = new Label();
            labelUserNumber = new Label();
            labelSteps = new Label();
            buttonReset = new Button();
            buttonRandomNum = new Button();
            buttonSetNum = new Button();
            textBoxMyNumb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMult).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPlus
            // 
            pictureBoxPlus.Image = Properties.Resources.plus1;
            pictureBoxPlus.Location = new Point(95, 25);
            pictureBoxPlus.Name = "pictureBoxPlus";
            pictureBoxPlus.Size = new Size(149, 134);
            pictureBoxPlus.TabIndex = 0;
            pictureBoxPlus.TabStop = false;
            pictureBoxPlus.Click += pictureBoxPlus_Click;
            // 
            // pictureBoxMult
            // 
            pictureBoxMult.Image = Properties.Resources.mult;
            pictureBoxMult.Location = new Point(516, 25);
            pictureBoxMult.Name = "pictureBoxMult";
            pictureBoxMult.Size = new Size(149, 134);
            pictureBoxMult.TabIndex = 1;
            pictureBoxMult.TabStop = false;
            pictureBoxMult.Click += pictureBoxMult_Click;
            // 
            // labelTarget
            // 
            labelTarget.AutoSize = true;
            labelTarget.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTarget.Location = new Point(356, 43);
            labelTarget.Name = "labelTarget";
            labelTarget.Size = new Size(36, 30);
            labelTarget.TabIndex = 2;
            labelTarget.Text = "15";
            // 
            // labelUserNumber
            // 
            labelUserNumber.AutoSize = true;
            labelUserNumber.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelUserNumber.Location = new Point(369, 116);
            labelUserNumber.Name = "labelUserNumber";
            labelUserNumber.Size = new Size(23, 30);
            labelUserNumber.TabIndex = 3;
            labelUserNumber.Text = "1";
            // 
            // labelSteps
            // 
            labelSteps.AutoSize = true;
            labelSteps.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSteps.Location = new Point(12, 200);
            labelSteps.Name = "labelSteps";
            labelSteps.Size = new Size(237, 30);
            labelSteps.TabIndex = 4;
            labelSteps.Text = "Количество шагов: 0";
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonReset.Location = new Point(273, 289);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(160, 52);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "Сбросить";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonRandomNum
            // 
            buttonRandomNum.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRandomNum.Location = new Point(52, 289);
            buttonRandomNum.Name = "buttonRandomNum";
            buttonRandomNum.Size = new Size(145, 51);
            buttonRandomNum.TabIndex = 6;
            buttonRandomNum.Text = "Случайное число";
            buttonRandomNum.UseVisualStyleBackColor = true;
            buttonRandomNum.Click += buttonRandomNum_Click;
            // 
            // buttonSetNum
            // 
            buttonSetNum.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSetNum.Location = new Point(506, 289);
            buttonSetNum.Name = "buttonSetNum";
            buttonSetNum.Size = new Size(139, 51);
            buttonSetNum.TabIndex = 7;
            buttonSetNum.Text = "Загадать число";
            buttonSetNum.UseVisualStyleBackColor = true;
            buttonSetNum.Click += buttonSetNum_Click;
            // 
            // textBoxMyNumb
            // 
            textBoxMyNumb.Location = new Point(273, 260);
            textBoxMyNumb.Name = "textBoxMyNumb";
            textBoxMyNumb.Size = new Size(160, 23);
            textBoxMyNumb.TabIndex = 8;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(716, 353);
            Controls.Add(textBoxMyNumb);
            Controls.Add(buttonSetNum);
            Controls.Add(buttonRandomNum);
            Controls.Add(buttonReset);
            Controls.Add(labelSteps);
            Controls.Add(labelUserNumber);
            Controls.Add(labelTarget);
            Controls.Add(pictureBoxMult);
            Controls.Add(pictureBoxPlus);
            Name = "FormGame";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPlus;
        private PictureBox pictureBoxMult;
        private Label labelTarget;
        private Label labelUserNumber;
        private Label labelSteps;
        private Button buttonReset;
        private Button buttonRandomNum;
        private Button buttonSetNum;
        private TextBox textBoxMyNumb;
    }
}
