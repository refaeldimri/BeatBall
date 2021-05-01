using System;
using System.Drawing;

using System.Windows.Forms;

namespace BeatBall
{
    class InputForm : Form
    {
        // TextBox for insert a name //
        private TextBox tbxName;

        // Button for confirmation and add to table //
        private Button btnOK;

        // Button for cancellation and close the form  //
        private Button btnCancel;

        // Command to user to inset his name //
        private Label lblInst;

        // String input for player's name //
        private string lblText;
        private Button button1;
        private bool confirmed = false;

        //**** Constructor ****//
        public InputForm(string stringToShow)
        {
            this.lblText = stringToShow;
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblInst = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Height / 4);
            this.MinimumSize = this.ClientSize;
            this.MaximumSize = this.ClientSize;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblInst);
            this.Controls.Add(this.tbxName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width / 2, Screen.PrimaryScreen.Bounds.Height - this.Height / 2);


            // 
            // TbxName
            // 
            this.tbxName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbxName.Location = new System.Drawing.Point(this.ClientRectangle.Width/8,2*this.ClientRectangle.Width / 12);
            this.tbxName.Name = "TbxName";
            this.tbxName.Size = new System.Drawing.Size(10*this.ClientRectangle.Width/12, 44);
            this.tbxName.TabIndex = 2;
            // 
            // lblInst
            // 
            this.lblInst.BackColor = System.Drawing.Color.Transparent;
            this.lblInst.Font = new System.Drawing.Font("Miriam", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblInst.Location = new System.Drawing.Point(this.tbxName.Location.X, this.ClientRectangle.Width/12);
            this.lblInst.Name = "lblInst";
            this.lblInst.TabIndex = 1;
            this.lblInst.Text = lblText;
            // 
            // btnOK
            // 
           
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 33);
            this.btnOK.Text = "confirm";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            
            // 
            // btnCancell
            // 
        
            this.btnCancel.Name = "btnCancell";
            this.btnCancel.Size = new System.Drawing.Size(101, 34);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // InputForm
            // 


            this.btnOK.Location = new System.Drawing.Point(this.ClientRectangle.Width / 3 - this.btnOK.PreferredSize.Width, this.ClientRectangle.Height - this.btnOK.Bounds.Height - 15);
            this.btnCancel.Location = new System.Drawing.Point(this.ClientRectangle.Width-this.ClientRectangle.Width / 3 , this.ClientRectangle.Height - this.btnCancel.PreferredSize.Height - 15);
            this.lblInst.Size = new System.Drawing.Size(this.ClientRectangle.Width - this.ClientRectangle.Width/7, 23);

            this.Name = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            confirmed = false;
            this.Close();
            this.Hide();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 300);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblInst.Text = lblInst.Text.ToLower();
            if (this.lblInst.Text.Contains("name"))
            {
                Player.Name = tbxName.Text;
            }
            else if (this.lblInst.Text.Contains("email"))
            {
                Player.MailTo = tbxName.Text;
            }
            confirmed = true;
            this.Hide();
            this.Close();
        }

        public bool Start()
        {
            this.ShowDialog();
            return this.confirmed;
        }

    }
}