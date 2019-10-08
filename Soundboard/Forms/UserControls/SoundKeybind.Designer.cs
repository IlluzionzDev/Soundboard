namespace Soundboard.Forms.UserControls
{
    partial class SoundKeybind
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SoundName = new System.Windows.Forms.Label();
            this.Keybind = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoundName
            // 
            this.SoundName.AccessibleName = "SoundName";
            this.SoundName.Location = new System.Drawing.Point(101, 25);
            this.SoundName.Name = "SoundName";
            this.SoundName.Size = new System.Drawing.Size(107, 19);
            this.SoundName.TabIndex = 0;
            this.SoundName.Text = "Sound Name";
            this.SoundName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Keybind
            // 
            this.Keybind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Keybind.FlatAppearance.BorderSize = 0;
            this.Keybind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Keybind.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keybind.ForeColor = System.Drawing.Color.White;
            this.Keybind.Location = new System.Drawing.Point(249, 21);
            this.Keybind.Name = "Keybind";
            this.Keybind.Size = new System.Drawing.Size(171, 28);
            this.Keybind.TabIndex = 4;
            this.Keybind.Text = "None";
            this.Keybind.UseVisualStyleBackColor = false;
            this.Keybind.Click += new System.EventHandler(this.Keybind_Click);
            this.Keybind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybind_KeyDown);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.Location = new System.Drawing.Point(20, 21);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(47, 28);
            this.PlayButton.TabIndex = 5;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // SoundKeybind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.Keybind);
            this.Controls.Add(this.SoundName);
            this.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SoundKeybind";
            this.Size = new System.Drawing.Size(480, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SoundName;
        private System.Windows.Forms.Button Keybind;
        private System.Windows.Forms.Button PlayButton;
    }
}
