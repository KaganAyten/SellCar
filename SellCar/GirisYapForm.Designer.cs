
namespace SellCar
{
    partial class GirisYapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYapForm));
            this.girisYapLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.mailInput = new System.Windows.Forms.TextBox();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.sifreInput = new System.Windows.Forms.TextBox();
            this.girisYapButton = new System.Windows.Forms.Button();
            this.kapatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girisYapLabel
            // 
            this.girisYapLabel.AutoSize = true;
            this.girisYapLabel.Font = new System.Drawing.Font("Bebas Neue Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.girisYapLabel.Location = new System.Drawing.Point(27, 34);
            this.girisYapLabel.MaximumSize = new System.Drawing.Size(113, 41);
            this.girisYapLabel.MinimumSize = new System.Drawing.Size(113, 41);
            this.girisYapLabel.Name = "girisYapLabel";
            this.girisYapLabel.Size = new System.Drawing.Size(141, 51);
            this.girisYapLabel.TabIndex = 0;
            this.girisYapLabel.Text = "GİRİŞ YAP";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("Bebas Neue Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.mailLabel.Location = new System.Drawing.Point(35, 113);
            this.mailLabel.MaximumSize = new System.Drawing.Size(70, 36);
            this.mailLabel.MinimumSize = new System.Drawing.Size(70, 36);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(88, 45);
            this.mailLabel.TabIndex = 1;
            this.mailLabel.Text = "EMAIL";
            // 
            // mailInput
            // 
            this.mailInput.Font = new System.Drawing.Font("Avenir LT Std 55 Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mailInput.Location = new System.Drawing.Point(30, 156);
            this.mailInput.MaximumSize = new System.Drawing.Size(317, 39);
            this.mailInput.MinimumSize = new System.Drawing.Size(317, 39);
            this.mailInput.Name = "mailInput";
            this.mailInput.Size = new System.Drawing.Size(317, 39);
            this.mailInput.TabIndex = 2;
            this.mailInput.Text = "Mail adresini gir...";
            this.mailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.Font = new System.Drawing.Font("Bebas Neue Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sifreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.sifreLabel.Location = new System.Drawing.Point(36, 209);
            this.sifreLabel.MaximumSize = new System.Drawing.Size(64, 36);
            this.sifreLabel.MinimumSize = new System.Drawing.Size(64, 36);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(80, 45);
            this.sifreLabel.TabIndex = 3;
            this.sifreLabel.Text = "ŞİFRE";
            // 
            // sifreInput
            // 
            this.sifreInput.Font = new System.Drawing.Font("Avenir LT Std 55 Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sifreInput.Location = new System.Drawing.Point(30, 253);
            this.sifreInput.MaximumSize = new System.Drawing.Size(317, 39);
            this.sifreInput.MinimumSize = new System.Drawing.Size(317, 39);
            this.sifreInput.Name = "sifreInput";
            this.sifreInput.PasswordChar = '*';
            this.sifreInput.Size = new System.Drawing.Size(317, 39);
            this.sifreInput.TabIndex = 4;
            this.sifreInput.Text = "Şifreni gir";
            this.sifreInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // girisYapButton
            // 
            this.girisYapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.girisYapButton.BackColor = System.Drawing.Color.Black;
            this.girisYapButton.FlatAppearance.BorderSize = 0;
            this.girisYapButton.Font = new System.Drawing.Font("Bebas Neue Regular", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.girisYapButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(196)))), ((int)(((byte)(43)))));
            this.girisYapButton.Location = new System.Drawing.Point(33, 350);
            this.girisYapButton.Margin = new System.Windows.Forms.Padding(0);
            this.girisYapButton.MaximumSize = new System.Drawing.Size(311, 48);
            this.girisYapButton.MinimumSize = new System.Drawing.Size(311, 48);
            this.girisYapButton.Name = "girisYapButton";
            this.girisYapButton.Size = new System.Drawing.Size(311, 48);
            this.girisYapButton.TabIndex = 10;
            this.girisYapButton.Text = "GİRİŞ YAP";
            this.girisYapButton.UseVisualStyleBackColor = false;
            this.girisYapButton.Click += new System.EventHandler(this.girisYapButton_Click);
            // 
            // kapatButton
            // 
            this.kapatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.kapatButton.Font = new System.Drawing.Font("Avenir LT Std 55 Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kapatButton.ForeColor = System.Drawing.Color.White;
            this.kapatButton.Image = ((System.Drawing.Image)(resources.GetObject("kapatButton.Image")));
            this.kapatButton.Location = new System.Drawing.Point(280, 38);
            this.kapatButton.MaximumSize = new System.Drawing.Size(76, 30);
            this.kapatButton.MinimumSize = new System.Drawing.Size(76, 30);
            this.kapatButton.Name = "kapatButton";
            this.kapatButton.Size = new System.Drawing.Size(76, 30);
            this.kapatButton.TabIndex = 11;
            this.kapatButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kapatButton.UseVisualStyleBackColor = false;
            // 
            // GirisYapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 489);
            this.Controls.Add(this.kapatButton);
            this.Controls.Add(this.girisYapButton);
            this.Controls.Add(this.sifreInput);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.mailInput);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.girisYapLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(386, 489);
            this.MinimumSize = new System.Drawing.Size(386, 489);
            this.Name = "GirisYapForm";
            this.Text = "GirisYapForm";
            this.Load += new System.EventHandler(this.GirisYapForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label girisYapLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.TextBox mailInput;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.TextBox sifreInput;
        private System.Windows.Forms.Button girisYapButton;
        private System.Windows.Forms.Button kapatButton;
    }
}