namespace mdbook_gui.Forms
{
	partial class AboutForm
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
			this.author13Lb = new System.Windows.Forms.Label();
			this.author24Lb = new System.Windows.Forms.Label();
			this.websiteLb = new System.Windows.Forms.Label();
			this.versionLb = new System.Windows.Forms.Label();
			this.label58 = new System.Windows.Forms.Label();
			this.label69 = new System.Windows.Forms.Label();
			this.logo_image = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.logo_image)).BeginInit();
			this.SuspendLayout();
			// 
			// author13Lb
			// 
			this.author13Lb.AutoSize = true;
			this.author13Lb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.author13Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.author13Lb.Location = new System.Drawing.Point(18, 109);
			this.author13Lb.Name = "author13Lb";
			this.author13Lb.Size = new System.Drawing.Size(147, 17);
			this.author13Lb.TabIndex = 0;
			this.author13Lb.Text = "内卷  焦虑";
			this.author13Lb.Click += new System.EventHandler(this.Author13Lb_Click);
			// 
			// author24Lb
			// 
			this.author24Lb.AutoSize = true;
			this.author24Lb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.author24Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.author24Lb.Location = new System.Drawing.Point(168, 109);
			this.author24Lb.Name = "author24Lb";
			this.author24Lb.Size = new System.Drawing.Size(159, 17);
			this.author24Lb.TabIndex = 0;
			this.author24Lb.Text = "躺平. SF Wuang";
			this.author24Lb.Click += new System.EventHandler(this.Author24Lb_Click);
			// 
			// websiteLb
			// 
			this.websiteLb.AutoSize = true;
			this.websiteLb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.websiteLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.websiteLb.Location = new System.Drawing.Point(18, 138);
			this.websiteLb.Name = "websiteLb";
			this.websiteLb.Size = new System.Drawing.Size(246, 17);
			this.websiteLb.TabIndex = 0;
			this.websiteLb.Text = "同性交友社区";
			this.websiteLb.Click += new System.EventHandler(this.WebsiteLb_Click);
			// 
			// versionLb
			// 
			this.versionLb.AutoSize = true;
			this.versionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.versionLb.Location = new System.Drawing.Point(18, 76);
			this.versionLb.Name = "versionLb";
			this.versionLb.Size = new System.Drawing.Size(130, 17);
			this.versionLb.TabIndex = 0;
			this.versionLb.Text = "Version 0.4.9.0";
			// 
			// label58
			// 
			this.label58.AutoSize = true;
			this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label58.Location = new System.Drawing.Point(13, 13);
			this.label58.Name = "label58";
			this.label58.Size = new System.Drawing.Size(103, 27);
			this.label58.TabIndex = 1;
			this.label58.Text = "Mdbook Gui";
			// 
			// label69
			// 
			this.label69.AutoSize = true;
			this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label69.Location = new System.Drawing.Point(18, 53);
			this.label69.Name = "label69";
			this.label69.Size = new System.Drawing.Size(244, 17);
			this.label69.TabIndex = 0;
			this.label69.Text = "A friendly user interface for Mdbook";
			// 
			// logo_image
			// 
			this.logo_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.logo_image.Image = global::mdbook_gui.Resources.mdbook_image;
			this.logo_image.Location = new System.Drawing.Point(309, 13);
			this.logo_image.Name = "logo_image";
			this.logo_image.Size = new System.Drawing.Size(90, 90);
			this.logo_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logo_image.TabIndex = 2;
			this.logo_image.TabStop = false;
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 167);
			this.Controls.Add(this.logo_image);
			this.Controls.Add(this.label58);
			this.Controls.Add(this.label69);
			this.Controls.Add(this.versionLb);
			this.Controls.Add(this.websiteLb);
			this.Controls.Add(this.author24Lb);
			this.Controls.Add(this.author13Lb);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AboutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			this.Load += new System.EventHandler(this.AboutForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.logo_image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label author13Lb;
		private System.Windows.Forms.Label author24Lb;
		private System.Windows.Forms.Label websiteLb;
		private System.Windows.Forms.Label versionLb;
		private System.Windows.Forms.Label label58;
		private System.Windows.Forms.Label label69;
		private System.Windows.Forms.PictureBox logo_image;
	}
}