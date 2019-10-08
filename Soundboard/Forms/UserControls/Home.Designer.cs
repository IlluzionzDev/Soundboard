using System.Windows.Forms;

namespace Soundboard.Forms.UserControls
{
    partial class Home
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
            this.Title = new System.Windows.Forms.Label();
            this.KeybindName = new System.Windows.Forms.TextBox();
            this.KeybindInput = new System.Windows.Forms.Button();
            this.SoundKeybinds = new System.Windows.Forms.FlowLayoutPanel();
            this.FileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Raleway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(450, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(203, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "SOUNDBOARD";
            // 
            // KeybindName
            // 
            this.KeybindName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.KeybindName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeybindName.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeybindName.ForeColor = System.Drawing.Color.White;
            this.KeybindName.Location = new System.Drawing.Point(517, 165);
            this.KeybindName.Name = "KeybindName";
            this.KeybindName.Size = new System.Drawing.Size(266, 18);
            this.KeybindName.TabIndex = 1;
            this.KeybindName.Text = "Sound Name";
            // 
            // KeybindInput
            // 
            this.KeybindInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.KeybindInput.FlatAppearance.BorderSize = 0;
            this.KeybindInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeybindInput.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeybindInput.ForeColor = System.Drawing.Color.White;
            this.KeybindInput.Location = new System.Drawing.Point(430, 207);
            this.KeybindInput.Name = "KeybindInput";
            this.KeybindInput.Size = new System.Drawing.Size(266, 28);
            this.KeybindInput.TabIndex = 3;
            this.KeybindInput.Text = "Set Keybind";
            this.KeybindInput.UseVisualStyleBackColor = false;
            this.KeybindInput.Click += new System.EventHandler(this.KeybindInput_Click);
            this.KeybindInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeybindInput_KeyDown);
            // 
            // SoundKeybinds
            // 
            this.SoundKeybinds.AutoScroll = true;
            this.SoundKeybinds.Location = new System.Drawing.Point(320, 241);
            this.SoundKeybinds.Name = "SoundKeybinds";
            this.SoundKeybinds.Size = new System.Drawing.Size(480, 419);
            this.SoundKeybinds.TabIndex = 4;
            // 
            // FileButton
            // 
            this.FileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FileButton.FlatAppearance.BorderSize = 0;
            this.FileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileButton.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileButton.ForeColor = System.Drawing.Color.White;
            this.FileButton.Location = new System.Drawing.Point(382, 161);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(125, 26);
            this.FileButton.TabIndex = 5;
            this.FileButton.Text = "Choose File";
            this.FileButton.UseVisualStyleBackColor = false;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.SoundKeybinds);
            this.Controls.Add(this.KeybindInput);
            this.Controls.Add(this.KeybindName);
            this.Controls.Add(this.Title);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1150, 663);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox KeybindName;
        private System.Windows.Forms.Button KeybindInput;
        private System.Windows.Forms.FlowLayoutPanel SoundKeybinds;
        private Button FileButton;
    }
}
