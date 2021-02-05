namespace ApiDebug
{
    partial class ApiDebugTool
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
            this.btn_fileSubmit = new System.Windows.Forms.Button();
            this.fBD_fileSubmit = new System.Windows.Forms.FolderBrowserDialog();
            this.rtb_Response = new System.Windows.Forms.RichTextBox();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.rtb_Request = new System.Windows.Forms.RichTextBox();
            this.txt_Image = new System.Windows.Forms.TextBox();
            this.btn_AddImage = new System.Windows.Forms.Button();
            this.cbo_RequestType = new System.Windows.Forms.ComboBox();
            this.pbx_Close = new System.Windows.Forms.PictureBox();
            this.pbx_Maximize = new System.Windows.Forms.PictureBox();
            this.pbx_Minimize = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lab_Title = new System.Windows.Forms.Label();
            this.lab_Split = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_fileSubmit
            // 
            this.btn_fileSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fileSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(152)))), ((int)(((byte)(240)))));
            this.btn_fileSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fileSubmit.FlatAppearance.BorderSize = 0;
            this.btn_fileSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.btn_fileSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fileSubmit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_fileSubmit.ForeColor = System.Drawing.Color.White;
            this.btn_fileSubmit.Location = new System.Drawing.Point(781, 45);
            this.btn_fileSubmit.Name = "btn_fileSubmit";
            this.btn_fileSubmit.Size = new System.Drawing.Size(93, 27);
            this.btn_fileSubmit.TabIndex = 2;
            this.btn_fileSubmit.Text = "发送";
            this.btn_fileSubmit.UseVisualStyleBackColor = false;
            this.btn_fileSubmit.Click += new System.EventHandler(this.btn_fileSubmit_Click);
            // 
            // rtb_Response
            // 
            this.rtb_Response.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Response.BackColor = System.Drawing.SystemColors.Window;
            this.rtb_Response.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb_Response.Location = new System.Drawing.Point(4, 27);
            this.rtb_Response.Name = "rtb_Response";
            this.rtb_Response.ReadOnly = true;
            this.rtb_Response.Size = new System.Drawing.Size(830, 305);
            this.rtb_Response.TabIndex = 6;
            this.rtb_Response.Text = "";
            // 
            // txt_Url
            // 
            this.txt_Url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Url.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Url.Location = new System.Drawing.Point(126, 47);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(648, 25);
            this.txt_Url.TabIndex = 1;
            this.txt_Url.Text = "http://localhost/api";
            // 
            // rtb_Request
            // 
            this.rtb_Request.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Request.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb_Request.Location = new System.Drawing.Point(4, 26);
            this.rtb_Request.Name = "rtb_Request";
            this.rtb_Request.Size = new System.Drawing.Size(828, 243);
            this.rtb_Request.TabIndex = 3;
            this.rtb_Request.Text = "";
            this.rtb_Request.Enter += new System.EventHandler(this.rtb_Request_Enter);
            this.rtb_Request.Leave += new System.EventHandler(this.rtb_Request_Leave);
            // 
            // txt_Image
            // 
            this.txt_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Image.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Image.Location = new System.Drawing.Point(4, 275);
            this.txt_Image.Name = "txt_Image";
            this.txt_Image.Size = new System.Drawing.Size(123, 25);
            this.txt_Image.TabIndex = 4;
            this.txt_Image.Text = "$image1";
            // 
            // btn_AddImage
            // 
            this.btn_AddImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_AddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AddImage.FlatAppearance.BorderSize = 0;
            this.btn_AddImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.btn_AddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddImage.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_AddImage.ForeColor = System.Drawing.Color.DimGray;
            this.btn_AddImage.Location = new System.Drawing.Point(132, 275);
            this.btn_AddImage.Name = "btn_AddImage";
            this.btn_AddImage.Size = new System.Drawing.Size(75, 25);
            this.btn_AddImage.TabIndex = 5;
            this.btn_AddImage.Text = "添加附件";
            this.btn_AddImage.UseVisualStyleBackColor = false;
            this.btn_AddImage.Click += new System.EventHandler(this.btn_AddImage_Click);
            // 
            // cbo_RequestType
            // 
            this.cbo_RequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_RequestType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_RequestType.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_RequestType.FormattingEnabled = true;
            this.cbo_RequestType.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.cbo_RequestType.Location = new System.Drawing.Point(35, 47);
            this.cbo_RequestType.Name = "cbo_RequestType";
            this.cbo_RequestType.Size = new System.Drawing.Size(80, 27);
            this.cbo_RequestType.TabIndex = 0;
            // 
            // pbx_Close
            // 
            this.pbx_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Close.Image = global::ApiDebugTest.Properties.Resources.close;
            this.pbx_Close.Location = new System.Drawing.Point(887, 6);
            this.pbx_Close.Name = "pbx_Close";
            this.pbx_Close.Size = new System.Drawing.Size(22, 22);
            this.pbx_Close.TabIndex = 7;
            this.pbx_Close.TabStop = false;
            this.pbx_Close.Click += new System.EventHandler(this.pbx_Close_Click);
            // 
            // pbx_Maximize
            // 
            this.pbx_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Maximize.Image = global::ApiDebugTest.Properties.Resources.maximize;
            this.pbx_Maximize.Location = new System.Drawing.Point(859, 6);
            this.pbx_Maximize.Name = "pbx_Maximize";
            this.pbx_Maximize.Size = new System.Drawing.Size(22, 22);
            this.pbx_Maximize.TabIndex = 8;
            this.pbx_Maximize.TabStop = false;
            this.pbx_Maximize.Click += new System.EventHandler(this.pbx_Maximize_Click);
            // 
            // pbx_Minimize
            // 
            this.pbx_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Minimize.Image = global::ApiDebugTest.Properties.Resources.minimize;
            this.pbx_Minimize.Location = new System.Drawing.Point(831, 6);
            this.pbx_Minimize.Name = "pbx_Minimize";
            this.pbx_Minimize.Size = new System.Drawing.Size(22, 22);
            this.pbx_Minimize.TabIndex = 9;
            this.pbx_Minimize.TabStop = false;
            this.pbx_Minimize.Click += new System.EventHandler(this.pbx_Minimize_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(35, 82);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Image);
            this.splitContainer1.Panel1.Controls.Add(this.rtb_Request);
            this.splitContainer1.Panel1.Controls.Add(this.btn_AddImage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.rtb_Response);
            this.splitContainer1.Size = new System.Drawing.Size(839, 653);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 10;
            // 
            // lab_Title
            // 
            this.lab_Title.AutoSize = true;
            this.lab_Title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Title.Location = new System.Drawing.Point(7, 9);
            this.lab_Title.Name = "lab_Title";
            this.lab_Title.Size = new System.Drawing.Size(100, 21);
            this.lab_Title.TabIndex = 11;
            this.lab_Title.Text = "API调试工具";
            // 
            // lab_Split
            // 
            this.lab_Split.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Split.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_Split.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_Split.Location = new System.Drawing.Point(3, 33);
            this.lab_Split.Name = "lab_Split";
            this.lab_Split.Size = new System.Drawing.Size(910, 1);
            this.lab_Split.TabIndex = 10;
            this.lab_Split.Text = "label2";
            this.lab_Split.Paint += new System.Windows.Forms.PaintEventHandler(this.lab_Split_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(2, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "响应结果";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(2, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "请求参数(application/json)";
            // 
            // ApiDebugTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(915, 765);
            this.Controls.Add(this.lab_Split);
            this.Controls.Add(this.lab_Title);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pbx_Minimize);
            this.Controls.Add(this.pbx_Maximize);
            this.Controls.Add(this.pbx_Close);
            this.Controls.Add(this.cbo_RequestType);
            this.Controls.Add(this.txt_Url);
            this.Controls.Add(this.btn_fileSubmit);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "ApiDebugTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "API测试工具";
            this.Load += new System.EventHandler(this.ApiDebugTool_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ApiDebugTool_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ApiDebugTool_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Minimize)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fileSubmit;
        private System.Windows.Forms.FolderBrowserDialog fBD_fileSubmit;
        private System.Windows.Forms.RichTextBox rtb_Response;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.RichTextBox rtb_Request;
        private System.Windows.Forms.TextBox txt_Image;
        private System.Windows.Forms.Button btn_AddImage;
        private System.Windows.Forms.ComboBox cbo_RequestType;
        private System.Windows.Forms.PictureBox pbx_Close;
        private System.Windows.Forms.PictureBox pbx_Maximize;
        private System.Windows.Forms.PictureBox pbx_Minimize;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lab_Title;
        private System.Windows.Forms.Label lab_Split;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

    }
}