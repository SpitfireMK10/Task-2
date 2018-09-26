namespace POE_Term_2
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupDisplay = new System.Windows.Forms.GroupBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnUnPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupDisplay
            // 
            this.groupDisplay.Location = new System.Drawing.Point(12, 12);
            this.groupDisplay.Name = "groupDisplay";
            this.groupDisplay.Size = new System.Drawing.Size(980, 851);
            this.groupDisplay.TabIndex = 0;
            this.groupDisplay.TabStop = false;
            this.groupDisplay.Text = "RTS";
            this.groupDisplay.Enter += new System.EventHandler(this.groupDisplay_Enter);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(1002, 205);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(159, 421);
            this.txtDisplay.TabIndex = 1;
            // 
            // txtTimer
            // 
            this.txtTimer.Location = new System.Drawing.Point(1002, 89);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(100, 29);
            this.txtTimer.TabIndex = 2;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(1002, 124);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(110, 35);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnUnPause
            // 
            this.btnUnPause.Location = new System.Drawing.Point(1002, 165);
            this.btnUnPause.Name = "btnUnPause";
            this.btnUnPause.Size = new System.Drawing.Size(110, 34);
            this.btnUnPause.TabIndex = 4;
            this.btnUnPause.Text = "UnPause";
            this.btnUnPause.UseVisualStyleBackColor = true;
            this.btnUnPause.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(998, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Turn:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1002, 828);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(110, 35);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1002, 787);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 915);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnPause);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.groupDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupDisplay;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnUnPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
    }
}

