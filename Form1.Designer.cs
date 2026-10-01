namespace Loaf_Drawing_Program
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.close_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.ToolboxPanel = new System.Windows.Forms.Panel();
            this.colorbox = new System.Windows.Forms.PictureBox();
            this.brush_size = new System.Windows.Forms.NumericUpDown();
            this.eraser_button = new System.Windows.Forms.PictureBox();
            this.paintbrush_button = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ToolboxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brush_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintbrush_button)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TopPanel.Controls.Add(this.close_button);
            this.TopPanel.Controls.Add(this.clear_button);
            this.TopPanel.Controls.Add(this.save_button);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 42);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(769, 12);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(25, 23);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "x";
            this.close_button.UseVisualStyleBackColor = true;
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(688, 12);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 2;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(607, 12);
            this.save_button.Name = "save_button";
            this.save_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 1;
            this.save_button.Text = "save";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // canvasPanel
            // 
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(0, 42);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(800, 408);
            this.canvasPanel.TabIndex = 1;
            this.canvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // ToolboxPanel
            // 
            this.ToolboxPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ToolboxPanel.Controls.Add(this.colorbox);
            this.ToolboxPanel.Controls.Add(this.brush_size);
            this.ToolboxPanel.Controls.Add(this.eraser_button);
            this.ToolboxPanel.Controls.Add(this.paintbrush_button);
            this.ToolboxPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolboxPanel.Location = new System.Drawing.Point(0, 42);
            this.ToolboxPanel.Name = "ToolboxPanel";
            this.ToolboxPanel.Size = new System.Drawing.Size(83, 408);
            this.ToolboxPanel.TabIndex = 2;
            // 
            // colorbox
            // 
            this.colorbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorbox.Location = new System.Drawing.Point(12, 165);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(53, 50);
            this.colorbox.TabIndex = 3;
            this.colorbox.TabStop = false;
            // 
            // brush_size
            // 
            this.brush_size.Location = new System.Drawing.Point(11, 139);
            this.brush_size.Name = "brush_size";
            this.brush_size.Size = new System.Drawing.Size(54, 20);
            this.brush_size.TabIndex = 2;
            // 
            // eraser_button
            // 
            this.eraser_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eraser_button.Image = ((System.Drawing.Image)(resources.GetObject("eraser_button.Image")));
            this.eraser_button.Location = new System.Drawing.Point(12, 83);
            this.eraser_button.Name = "eraser_button";
            this.eraser_button.Size = new System.Drawing.Size(53, 50);
            this.eraser_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eraser_button.TabIndex = 1;
            this.eraser_button.TabStop = false;
            // 
            // paintbrush_button
            // 
            this.paintbrush_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paintbrush_button.Image = ((System.Drawing.Image)(resources.GetObject("paintbrush_button.Image")));
            this.paintbrush_button.Location = new System.Drawing.Point(12, 27);
            this.paintbrush_button.Name = "paintbrush_button";
            this.paintbrush_button.Size = new System.Drawing.Size(53, 50);
            this.paintbrush_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paintbrush_button.TabIndex = 0;
            this.paintbrush_button.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToolboxPanel);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ToolboxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brush_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintbrush_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.Panel ToolboxPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.PictureBox eraser_button;
        private System.Windows.Forms.PictureBox paintbrush_button;
        private System.Windows.Forms.NumericUpDown brush_size;
        private System.Windows.Forms.PictureBox colorbox;
    }
}

