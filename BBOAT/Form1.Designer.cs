namespace BBOAT
{
    partial class Form1
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
            button1=new Button();
            label1=new Label();
            button2=new Button();
            button3=new Button();
            label2=new Label();
            pictureBox1=new PictureBox();
            pictureBox2=new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location=new Point(658, 81);
            button1.Name="button1";
            button1.Size=new Size(97, 23);
            button1.TabIndex=0;
            button1.Text="Speedsee 1000";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(69, 9);
            label1.Name="label1";
            label1.Size=new Size(87, 15);
            label1.TabIndex=1;
            label1.Text="Обрана лодка:";
            // 
            // button2
            // 
            button2.Location=new Point(658, 110);
            button2.Name="button2";
            button2.Size=new Size(97, 23);
            button2.TabIndex=2;
            button2.Text="TRAL";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button3
            // 
            button3.Location=new Point(658, 139);
            button3.Name="button3";
            button3.Size=new Size(97, 23);
            button3.TabIndex=3;
            button3.Text="Windcutter 900";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(69, 35);
            label2.Name="label2";
            label2.Size=new Size(149, 15);
            label2.TabIndex=4;
            label2.Text="Максимальна швидкість: ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor=SystemColors.ActiveCaption;
            pictureBox1.Location=new Point(-1, 339);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(812, 117);
            pictureBox1.TabIndex=5;
            pictureBox1.TabStop=false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage=Properties.Resources._11;
            pictureBox2.Image=Properties.Resources._1;
            pictureBox2.Location=new Point(100, 289);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(100, 50);
            pictureBox2.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex=6;
            pictureBox2.TabStop=false;
            pictureBox2.Click+=pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name="Form1";
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}