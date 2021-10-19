/*
 * Created by SharpDevelop.
 * User: LAB-09
 * Date: 18/10/2021
 * Time: 10:21 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Imagen_v2._
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pic_imagen = new System.Windows.Forms.PictureBox();
			this.btn_mostrar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_imagen
			// 
			this.pic_imagen.Location = new System.Drawing.Point(213, 41);
			this.pic_imagen.Name = "pic_imagen";
			this.pic_imagen.Size = new System.Drawing.Size(332, 276);
			this.pic_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_imagen.TabIndex = 0;
			this.pic_imagen.TabStop = false;
			// 
			// btn_mostrar
			// 
			this.btn_mostrar.Location = new System.Drawing.Point(227, 342);
			this.btn_mostrar.Name = "btn_mostrar";
			this.btn_mostrar.Size = new System.Drawing.Size(306, 63);
			this.btn_mostrar.TabIndex = 1;
			this.btn_mostrar.Text = "Mostrar";
			this.btn_mostrar.UseVisualStyleBackColor = true;
			this.btn_mostrar.Click += new System.EventHandler(this.Btn_mostrarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(799, 578);
			this.Controls.Add(this.btn_mostrar);
			this.Controls.Add(this.pic_imagen);
			this.Name = "MainForm";
			this.Text = "Imagen v2.0";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_mostrar;
		private System.Windows.Forms.PictureBox pic_imagen;
	}
}
