namespace MCCBounce
{
    partial class UIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb60Tick = new System.Windows.Forms.RadioButton();
            this.rb30Tick = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb60Tick);
            this.groupBox1.Controls.Add(this.rb30Tick);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickrate:";
            // 
            // rb60Tick
            // 
            this.rb60Tick.AutoSize = true;
            this.rb60Tick.Location = new System.Drawing.Point(53, 55);
            this.rb60Tick.Name = "rb60Tick";
            this.rb60Tick.Size = new System.Drawing.Size(97, 17);
            this.rb60Tick.TabIndex = 2;
            this.rb60Tick.Text = "60 tick (normal)";
            this.rb60Tick.UseVisualStyleBackColor = true;
            this.rb60Tick.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb30Tick
            // 
            this.rb30Tick.AutoSize = true;
            this.rb30Tick.Location = new System.Drawing.Point(53, 32);
            this.rb30Tick.Name = "rb30Tick";
            this.rb30Tick.Size = new System.Drawing.Size(110, 17);
            this.rb30Tick.TabIndex = 1;
            this.rb30Tick.Text = "30 tick (bouncing)";
            this.rb30Tick.UseVisualStyleBackColor = true;
            this.rb30Tick.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // UIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 127);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCCBounce";
            this.Load += new System.EventHandler(this.UIForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb60Tick;
        private System.Windows.Forms.RadioButton rb30Tick;
    }
}

