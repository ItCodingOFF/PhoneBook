
namespace WindowsFormsApp6
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnNew = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.bntEdit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCansel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(9, 12);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(112, 27);
			this.btnNew.TabIndex = 0;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(0, 88);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(288, 473);
			this.dataGridView1.TabIndex = 1;
			// 
			// bntEdit
			// 
			this.bntEdit.Location = new System.Drawing.Point(164, 12);
			this.bntEdit.Name = "bntEdit";
			this.bntEdit.Size = new System.Drawing.Size(112, 27);
			this.bntEdit.TabIndex = 2;
			this.bntEdit.Text = "Edit";
			this.bntEdit.UseVisualStyleBackColor = true;
			this.bntEdit.Click += new System.EventHandler(this.bntEdit_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(9, 45);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(112, 27);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCansel
			// 
			this.btnCansel.Location = new System.Drawing.Point(164, 45);
			this.btnCansel.Name = "btnCansel";
			this.btnCansel.Size = new System.Drawing.Size(112, 27);
			this.btnCansel.TabIndex = 4;
			this.btnCansel.Text = "Cansel";
			this.btnCansel.UseVisualStyleBackColor = true;
			this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(288, 561);
			this.Controls.Add(this.btnCansel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.bntEdit);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnNew);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "PhoneBook";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button bntEdit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCansel;
	}
}

