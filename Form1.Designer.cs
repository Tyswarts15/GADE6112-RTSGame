namespace RTSGame
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
            this.NewGames = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Map = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewGames
            // 
            this.NewGames.Location = new System.Drawing.Point(148, 318);
            this.NewGames.Name = "NewGames";
            this.NewGames.Size = new System.Drawing.Size(75, 23);
            this.NewGames.TabIndex = 0;
            this.NewGames.Text = "New Game";
            this.NewGames.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(360, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(261, 318);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 2;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Map
            // 
            this.Map.AutoSize = true;
            this.Map.Location = new System.Drawing.Point(221, 133);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(35, 13);
            this.Map.TabIndex = 3;
            this.Map.Text = "label1";
            this.Map.Click += new System.EventHandler(this.Map_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewGames);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RTS Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGames;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Label Map;
    }
}

