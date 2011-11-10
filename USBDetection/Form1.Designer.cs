namespace USBDetection
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
            this.lb_USBDevices = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_InsertPath = new System.Windows.Forms.TextBox();
            this.txt_RemovePath = new System.Windows.Forms.TextBox();
            this.btn_InsertBrowse = new System.Windows.Forms.Button();
            this.btn_RemoveBrowse = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_InsertArgs = new System.Windows.Forms.TextBox();
            this.txt_RemoveArgs = new System.Windows.Forms.TextBox();
            this.ofd_Insert = new System.Windows.Forms.OpenFileDialog();
            this.ofd_Remove = new System.Windows.Forms.OpenFileDialog();
            this.cb_ProcessEvents = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_USBDevices
            // 
            this.lb_USBDevices.FormattingEnabled = true;
            this.lb_USBDevices.Location = new System.Drawing.Point(15, 25);
            this.lb_USBDevices.Name = "lb_USBDevices";
            this.lb_USBDevices.Size = new System.Drawing.Size(380, 95);
            this.lb_USBDevices.TabIndex = 0;
            this.lb_USBDevices.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_USBDevices_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Un-plug or Plug-in a device to list it";
            // 
            // txt_InsertPath
            // 
            this.txt_InsertPath.Location = new System.Drawing.Point(55, 53);
            this.txt_InsertPath.Name = "txt_InsertPath";
            this.txt_InsertPath.Size = new System.Drawing.Size(228, 20);
            this.txt_InsertPath.TabIndex = 2;
            // 
            // txt_RemovePath
            // 
            this.txt_RemovePath.Location = new System.Drawing.Point(55, 161);
            this.txt_RemovePath.Name = "txt_RemovePath";
            this.txt_RemovePath.Size = new System.Drawing.Size(228, 20);
            this.txt_RemovePath.TabIndex = 3;
            // 
            // btn_InsertBrowse
            // 
            this.btn_InsertBrowse.Location = new System.Drawing.Point(289, 53);
            this.btn_InsertBrowse.Name = "btn_InsertBrowse";
            this.btn_InsertBrowse.Size = new System.Drawing.Size(75, 20);
            this.btn_InsertBrowse.TabIndex = 4;
            this.btn_InsertBrowse.Text = "Browse";
            this.btn_InsertBrowse.UseVisualStyleBackColor = true;
            this.btn_InsertBrowse.Click += new System.EventHandler(this.btn_InsertBrowse_Click);
            // 
            // btn_RemoveBrowse
            // 
            this.btn_RemoveBrowse.Location = new System.Drawing.Point(289, 160);
            this.btn_RemoveBrowse.Name = "btn_RemoveBrowse";
            this.btn_RemoveBrowse.Size = new System.Drawing.Size(75, 20);
            this.btn_RemoveBrowse.TabIndex = 5;
            this.btn_RemoveBrowse.Text = "Browse";
            this.btn_RemoveBrowse.UseVisualStyleBackColor = true;
            this.btn_RemoveBrowse.Click += new System.EventHandler(this.btn_RemoveBrowse_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(289, 239);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_InsertArgs
            // 
            this.txt_InsertArgs.Location = new System.Drawing.Point(55, 90);
            this.txt_InsertArgs.Name = "txt_InsertArgs";
            this.txt_InsertArgs.Size = new System.Drawing.Size(256, 20);
            this.txt_InsertArgs.TabIndex = 7;
            // 
            // txt_RemoveArgs
            // 
            this.txt_RemoveArgs.Location = new System.Drawing.Point(55, 194);
            this.txt_RemoveArgs.Name = "txt_RemoveArgs";
            this.txt_RemoveArgs.Size = new System.Drawing.Size(256, 20);
            this.txt_RemoveArgs.TabIndex = 8;
            // 
            // ofd_Insert
            // 
            this.ofd_Insert.FileName = "openFileDialog1";
            this.ofd_Insert.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_Insert_FileOk);
            // 
            // ofd_Remove
            // 
            this.ofd_Remove.FileName = "openFileDialog1";
            this.ofd_Remove.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_Remove_FileOk);
            // 
            // cb_ProcessEvents
            // 
            this.cb_ProcessEvents.AutoSize = true;
            this.cb_ProcessEvents.Location = new System.Drawing.Point(30, 245);
            this.cb_ProcessEvents.Name = "cb_ProcessEvents";
            this.cb_ProcessEvents.Size = new System.Drawing.Size(100, 17);
            this.cb_ProcessEvents.TabIndex = 9;
            this.cb_ProcessEvents.Text = "Process Events";
            this.cb_ProcessEvents.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(380, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Args:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Args:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "On Insert";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "On Removal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_InsertPath);
            this.groupBox1.Controls.Add(this.txt_RemovePath);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_InsertBrowse);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_RemoveBrowse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_InsertArgs);
            this.groupBox1.Controls.Add(this.txt_RemoveArgs);
            this.groupBox1.Controls.Add(this.cb_ProcessEvents);
            this.groupBox1.Location = new System.Drawing.Point(15, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 273);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run External Processes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_USBDevices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_USBDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_InsertPath;
        private System.Windows.Forms.TextBox txt_RemovePath;
        private System.Windows.Forms.Button btn_InsertBrowse;
        private System.Windows.Forms.Button btn_RemoveBrowse;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_InsertArgs;
        private System.Windows.Forms.TextBox txt_RemoveArgs;
        private System.Windows.Forms.OpenFileDialog ofd_Insert;
        private System.Windows.Forms.OpenFileDialog ofd_Remove;
        private System.Windows.Forms.CheckBox cb_ProcessEvents;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

