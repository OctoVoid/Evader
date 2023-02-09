namespace Evader
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flypic = new Evader.CircularPictureBox();
            this.picture3 = new Evader.CircularPictureBox();
            this.picture2 = new Evader.CircularPictureBox();
            this.picture1 = new Evader.CircularPictureBox();
            this.flier = new Evader.CircularPictureBox();
            this.obs1 = new Evader.CircularPictureBox();
            this.obs3 = new Evader.CircularPictureBox();
            this.obs2 = new Evader.CircularPictureBox();
            this.obs4 = new Evader.CircularPictureBox();
            this.Inst2 = new System.Windows.Forms.Label();
            this.Inst1 = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.ground2 = new System.Windows.Forms.PictureBox();
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFirefly = new System.Windows.Forms.Button();
            this.buttonFly = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flypic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.flypic);
            this.panel1.Controls.Add(this.picture3);
            this.panel1.Controls.Add(this.picture2);
            this.panel1.Controls.Add(this.picture1);
            this.panel1.Controls.Add(this.flier);
            this.panel1.Controls.Add(this.obs1);
            this.panel1.Controls.Add(this.obs3);
            this.panel1.Controls.Add(this.obs2);
            this.panel1.Controls.Add(this.obs4);
            this.panel1.Controls.Add(this.Inst2);
            this.panel1.Controls.Add(this.Inst1);
            this.panel1.Controls.Add(this.end);
            this.panel1.Controls.Add(this.ground2);
            this.panel1.Controls.Add(this.ground1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 417);
            this.panel1.TabIndex = 0;
            // 
            // flypic
            // 
            this.flypic.Image = global::Evader.Properties.Resources.fly;
            this.flypic.Location = new System.Drawing.Point(395, 332);
            this.flypic.Name = "flypic";
            this.flypic.Size = new System.Drawing.Size(45, 50);
            this.flypic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flypic.TabIndex = 25;
            this.flypic.TabStop = false;
            // 
            // picture3
            // 
            this.picture3.Image = global::Evader.Properties.Resources.cobweb_3;
            this.picture3.Location = new System.Drawing.Point(337, 163);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(90, 100);
            this.picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture3.TabIndex = 24;
            this.picture3.TabStop = false;
            // 
            // picture2
            // 
            this.picture2.Image = global::Evader.Properties.Resources.cobweb_2;
            this.picture2.Location = new System.Drawing.Point(200, 163);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(90, 100);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture2.TabIndex = 23;
            this.picture2.TabStop = false;
            // 
            // picture1
            // 
            this.picture1.Image = global::Evader.Properties.Resources.cobweb_1;
            this.picture1.Location = new System.Drawing.Point(57, 163);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(90, 100);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1.TabIndex = 22;
            this.picture1.TabStop = false;
            // 
            // flier
            // 
            this.flier.Image = ((System.Drawing.Image)(resources.GetObject("flier.Image")));
            this.flier.Location = new System.Drawing.Point(273, 332);
            this.flier.Name = "flier";
            this.flier.Size = new System.Drawing.Size(45, 50);
            this.flier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flier.TabIndex = 21;
            this.flier.TabStop = false;
            // 
            // obs1
            // 
            this.obs1.Image = global::Evader.Properties.Resources.mushroom_1;
            this.obs1.Location = new System.Drawing.Point(200, 11);
            this.obs1.Name = "obs1";
            this.obs1.Size = new System.Drawing.Size(90, 100);
            this.obs1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obs1.TabIndex = 20;
            this.obs1.TabStop = false;
            // 
            // obs3
            // 
            this.obs3.Image = global::Evader.Properties.Resources.mushroom_2;
            this.obs3.Location = new System.Drawing.Point(337, 11);
            this.obs3.Name = "obs3";
            this.obs3.Size = new System.Drawing.Size(90, 100);
            this.obs3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obs3.TabIndex = 19;
            this.obs3.TabStop = false;
            // 
            // obs2
            // 
            this.obs2.Image = global::Evader.Properties.Resources.mushroom_3;
            this.obs2.Location = new System.Drawing.Point(57, 11);
            this.obs2.Name = "obs2";
            this.obs2.Size = new System.Drawing.Size(90, 100);
            this.obs2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obs2.TabIndex = 18;
            this.obs2.TabStop = false;
            // 
            // obs4
            // 
            this.obs4.Image = global::Evader.Properties.Resources.mushroom_2;
            this.obs4.Location = new System.Drawing.Point(1, 473);
            this.obs4.Name = "obs4";
            this.obs4.Size = new System.Drawing.Size(90, 100);
            this.obs4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obs4.TabIndex = 17;
            this.obs4.TabStop = false;
            // 
            // Inst2
            // 
            this.Inst2.AutoSize = true;
            this.Inst2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Inst2.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Inst2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Inst2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Inst2.Location = new System.Drawing.Point(273, 385);
            this.Inst2.Name = "Inst2";
            this.Inst2.Size = new System.Drawing.Size(167, 32);
            this.Inst2.TabIndex = 16;
            this.Inst2.Text = "Choose one:";
            this.Inst2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Inst1
            // 
            this.Inst1.AutoSize = true;
            this.Inst1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Inst1.Font = new System.Drawing.Font("Book Antiqua", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Inst1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Inst1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Inst1.Location = new System.Drawing.Point(57, 114);
            this.Inst1.Name = "Inst1";
            this.Inst1.Size = new System.Drawing.Size(370, 46);
            this.Inst1.TabIndex = 15;
            this.Inst1.Text = "Evade the obstacles!";
            this.Inst1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.end.Font = new System.Drawing.Font("Book Antiqua", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.end.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.end.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.end.Location = new System.Drawing.Point(17, 178);
            this.end.Margin = new System.Windows.Forms.Padding(0);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(443, 78);
            this.end.TabIndex = 7;
            this.end.Text = "GAME OVER";
            this.end.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ground2
            // 
            this.ground2.AccessibleName = "Ground2";
            this.ground2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground2.BackgroundImage")));
            this.ground2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground2.Location = new System.Drawing.Point(0, -420);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(475, 420);
            this.ground2.TabIndex = 1;
            this.ground2.TabStop = false;
            this.ground2.Tag = "";
            // 
            // ground1
            // 
            this.ground1.AccessibleName = "Ground1";
            this.ground1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground1.BackgroundImage")));
            this.ground1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground1.Location = new System.Drawing.Point(0, -3);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(475, 420);
            this.ground1.TabIndex = 0;
            this.ground1.TabStop = false;
            this.ground1.Tag = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tag = "timer1";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Image = global::Evader.Properties.Resources.ground;
            this.label1.Location = new System.Drawing.Point(0, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Survived for:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.time.Image = global::Evader.Properties.Resources.ground;
            this.time.Location = new System.Drawing.Point(141, 424);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(30, 23);
            this.time.TabIndex = 3;
            this.time.Tag = "timer1";
            this.time.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(177, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "s";
            // 
            // buttonFirefly
            // 
            this.buttonFirefly.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFirefly.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFirefly.Location = new System.Drawing.Point(236, 421);
            this.buttonFirefly.Name = "buttonFirefly";
            this.buttonFirefly.Size = new System.Drawing.Size(116, 26);
            this.buttonFirefly.TabIndex = 5;
            this.buttonFirefly.Text = "Play as a firefly";
            this.buttonFirefly.UseVisualStyleBackColor = true;
            this.buttonFirefly.Click += new System.EventHandler(this.buttonFirefly_Click);
            // 
            // buttonFly
            // 
            this.buttonFly.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFly.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFly.Location = new System.Drawing.Point(355, 421);
            this.buttonFly.Name = "buttonFly";
            this.buttonFly.Size = new System.Drawing.Size(117, 26);
            this.buttonFly.TabIndex = 6;
            this.buttonFly.Text = "Play as a fly";
            this.buttonFly.UseVisualStyleBackColor = true;
            this.buttonFly.Click += new System.EventHandler(this.buttonFly_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(24)))));
            this.BackgroundImage = global::Evader.Properties.Resources.ground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.buttonFly);
            this.Controls.Add(this.buttonFirefly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Evader";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveFlier);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StopFlier);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flypic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox ground2;
        private PictureBox ground1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label time;
        private Label label3;
        private Button buttonFirefly;
        private Button buttonFly;
        private Label end;
        private Label Inst2;
        private Label Inst1;
        private CircularPictureBox obs1;
        private CircularPictureBox obs3;
        private CircularPictureBox obs2;
        private CircularPictureBox obs4;
        private CircularPictureBox flier;
        private CircularPictureBox picture3;
        private CircularPictureBox picture2;
        private CircularPictureBox picture1;
        private CircularPictureBox flypic;
    }
}