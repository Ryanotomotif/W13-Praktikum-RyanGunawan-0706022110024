
namespace W13_Praktikum_RyanGunawan_0706022110024
{
	partial class Form_Player
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
			this.btn_Last = new System.Windows.Forms.Button();
			this.btn_Next = new System.Windows.Forms.Button();
			this.btn_Prev = new System.Windows.Forms.Button();
			this.btn_First = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.tBox_Nama = new System.Windows.Forms.TextBox();
			this.tBox_ID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.Box_birthDate = new System.Windows.Forms.DateTimePicker();
			this.cb_Team = new System.Windows.Forms.ComboBox();
			this.lbl_Status = new System.Windows.Forms.Label();
			this.cb_Nationality = new System.Windows.Forms.ComboBox();
			this.Nmbr_Team = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.Nmbr_Team)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Last
			// 
			this.btn_Last.Location = new System.Drawing.Point(364, 13);
			this.btn_Last.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Last.Name = "btn_Last";
			this.btn_Last.Size = new System.Drawing.Size(100, 28);
			this.btn_Last.TabIndex = 55;
			this.btn_Last.Text = ">>";
			this.btn_Last.UseVisualStyleBackColor = true;
			this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click_1);
			// 
			// btn_Next
			// 
			this.btn_Next.Location = new System.Drawing.Point(259, 13);
			this.btn_Next.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Next.Name = "btn_Next";
			this.btn_Next.Size = new System.Drawing.Size(100, 28);
			this.btn_Next.TabIndex = 54;
			this.btn_Next.Text = ">";
			this.btn_Next.UseVisualStyleBackColor = true;
			this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click_1);
			// 
			// btn_Prev
			// 
			this.btn_Prev.Location = new System.Drawing.Point(155, 13);
			this.btn_Prev.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Prev.Name = "btn_Prev";
			this.btn_Prev.Size = new System.Drawing.Size(100, 28);
			this.btn_Prev.TabIndex = 53;
			this.btn_Prev.Text = "<";
			this.btn_Prev.UseVisualStyleBackColor = true;
			this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click_1);
			// 
			// btn_First
			// 
			this.btn_First.Location = new System.Drawing.Point(47, 13);
			this.btn_First.Margin = new System.Windows.Forms.Padding(4);
			this.btn_First.Name = "btn_First";
			this.btn_First.Size = new System.Drawing.Size(100, 28);
			this.btn_First.TabIndex = 52;
			this.btn_First.Text = "<<";
			this.btn_First.UseVisualStyleBackColor = true;
			this.btn_First.Click += new System.EventHandler(this.btn_First_Click_1);
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(47, 287);
			this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(163, 28);
			this.btn_Save.TabIndex = 77;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// tBox_Nama
			// 
			this.tBox_Nama.Location = new System.Drawing.Point(184, 98);
			this.tBox_Nama.Margin = new System.Windows.Forms.Padding(4);
			this.tBox_Nama.Name = "tBox_Nama";
			this.tBox_Nama.Size = new System.Drawing.Size(259, 22);
			this.tBox_Nama.TabIndex = 72;
			// 
			// tBox_ID
			// 
			this.tBox_ID.Enabled = false;
			this.tBox_ID.Location = new System.Drawing.Point(184, 66);
			this.tBox_ID.Margin = new System.Windows.Forms.Padding(4);
			this.tBox_ID.Name = "tBox_ID";
			this.tBox_ID.Size = new System.Drawing.Size(132, 22);
			this.tBox_ID.TabIndex = 71;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(44, 229);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 17);
			this.label6.TabIndex = 70;
			this.label6.Text = "Team Number";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 197);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 17);
			this.label5.TabIndex = 69;
			this.label5.Text = "Team";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 165);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 17);
			this.label4.TabIndex = 68;
			this.label4.Text = "Nationally";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 133);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 17);
			this.label3.TabIndex = 67;
			this.label3.Text = "BirthDate";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 101);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 17);
			this.label2.TabIndex = 66;
			this.label2.Text = "Player Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 69);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 17);
			this.label1.TabIndex = 65;
			this.label1.Text = "Player ID";
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(231, 287);
			this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(176, 28);
			this.btn_Cancel.TabIndex = 78;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// Box_birthDate
			// 
			this.Box_birthDate.Location = new System.Drawing.Point(184, 128);
			this.Box_birthDate.Name = "Box_birthDate";
			this.Box_birthDate.Size = new System.Drawing.Size(259, 22);
			this.Box_birthDate.TabIndex = 79;
			// 
			// cb_Team
			// 
			this.cb_Team.FormattingEnabled = true;
			this.cb_Team.Location = new System.Drawing.Point(184, 197);
			this.cb_Team.Name = "cb_Team";
			this.cb_Team.Size = new System.Drawing.Size(223, 24);
			this.cb_Team.TabIndex = 80;
			// 
			// lbl_Status
			// 
			this.lbl_Status.AutoSize = true;
			this.lbl_Status.Location = new System.Drawing.Point(361, 234);
			this.lbl_Status.Name = "lbl_Status";
			this.lbl_Status.Size = new System.Drawing.Size(0, 17);
			this.lbl_Status.TabIndex = 81;
			// 
			// cb_Nationality
			// 
			this.cb_Nationality.FormattingEnabled = true;
			this.cb_Nationality.Location = new System.Drawing.Point(184, 165);
			this.cb_Nationality.Name = "cb_Nationality";
			this.cb_Nationality.Size = new System.Drawing.Size(223, 24);
			this.cb_Nationality.TabIndex = 83;
			// 
			// Nmbr_Team
			// 
			this.Nmbr_Team.Location = new System.Drawing.Point(184, 229);
			this.Nmbr_Team.Name = "Nmbr_Team";
			this.Nmbr_Team.Size = new System.Drawing.Size(138, 22);
			this.Nmbr_Team.TabIndex = 84;
			// 
			// Form_Player
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 426);
			this.Controls.Add(this.Nmbr_Team);
			this.Controls.Add(this.cb_Nationality);
			this.Controls.Add(this.lbl_Status);
			this.Controls.Add(this.cb_Team);
			this.Controls.Add(this.Box_birthDate);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.tBox_Nama);
			this.Controls.Add(this.tBox_ID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Last);
			this.Controls.Add(this.btn_Next);
			this.Controls.Add(this.btn_Prev);
			this.Controls.Add(this.btn_First);
			this.Name = "Form_Player";
			this.Text = "Player";
			this.Load += new System.EventHandler(this.FormPlayer_Load);
			((System.ComponentModel.ISupportInitialize)(this.Nmbr_Team)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Last;
		private System.Windows.Forms.Button btn_Next;
		private System.Windows.Forms.Button btn_Prev;
		private System.Windows.Forms.Button btn_First;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.TextBox tBox_Nama;
		private System.Windows.Forms.TextBox tBox_ID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.DateTimePicker Box_birthDate;
		private System.Windows.Forms.ComboBox cb_Team;
		private System.Windows.Forms.Label lbl_Status;
		private System.Windows.Forms.ComboBox cb_Nationality;
		private System.Windows.Forms.NumericUpDown Nmbr_Team;
	}
}

