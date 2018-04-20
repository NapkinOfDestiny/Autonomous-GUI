namespace Autonomous_GUI
{
    partial class CustomMessageBoxStringInput
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label_message = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(64, 45);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(155, 20);
            this.textBox_input.TabIndex = 0;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Location = new System.Drawing.Point(70, 19);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(71, 13);
            this.label_message.TabIndex = 1;
            this.label_message.Text = "Example Text";
            this.label_message.Click += new System.EventHandler(this.label_message_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(89, 87);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // CustomMessageBoxStringInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 147);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.textBox_input);
            this.Name = "CustomMessageBoxStringInput";
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Button button_save;
    }
}