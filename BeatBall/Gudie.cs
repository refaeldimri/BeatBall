using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatBall
{
    class Gudie : Form
    {
        private Label lblGuide1;
        private Label lblGuide2;
        private Label lblGuide3;
        private Label lblBack;
        

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gudie));
            this.lblGuide1 = new System.Windows.Forms.Label();
            this.lblGuide2 = new System.Windows.Forms.Label();
            this.lblGuide3 = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGuide1
            // 
            this.lblGuide1.AutoSize = true;
            this.lblGuide1.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGuide1.ForeColor = System.Drawing.Color.Red;
            this.lblGuide1.Location = new System.Drawing.Point(593, 53);
            this.lblGuide1.Name = "lblGuide1";
            this.lblGuide1.Size = new System.Drawing.Size(294, 29);
            this.lblGuide1.TabIndex = 0;
            this.lblGuide1.Text = "In ordet to play just click\r\n";
            // 
            // lblGuide2
            // 
            this.lblGuide2.AutoSize = true;
            this.lblGuide2.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGuide2.ForeColor = System.Drawing.Color.White;
            this.lblGuide2.Location = new System.Drawing.Point(277, 112);
            this.lblGuide2.Name = "lblGuide2";
            this.lblGuide2.Size = new System.Drawing.Size(1031, 186);
            this.lblGuide2.TabIndex = 1;
            this.lblGuide2.Text = resources.GetString("lblGuide2.Text");
            // 
            // lblGuide3
            // 
            this.lblGuide3.AutoSize = true;
            this.lblGuide3.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGuide3.ForeColor = System.Drawing.Color.Red;
            this.lblGuide3.Location = new System.Drawing.Point(604, 298);
            this.lblGuide3.Name = "lblGuide3";
            this.lblGuide3.Size = new System.Drawing.Size(254, 58);
            this.lblGuide3.TabIndex = 2;
            this.lblGuide3.Text = "Enjoy and Good luck\r\n   by S.W.A.T team ©\r\n";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(22, 640);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(114, 46);
            this.lblBack.TabIndex = 3;
            this.lblBack.Text = "Back";
            // 
            // Gudie
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1540, 706);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblGuide3);
            this.Controls.Add(this.lblGuide2);
            this.Controls.Add(this.lblGuide1);
            this.Name = "Gudie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


    }
}
