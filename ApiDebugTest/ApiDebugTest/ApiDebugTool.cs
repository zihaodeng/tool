using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using ApiDebug.Util;
using ApiDebug.RequestHelper;
using System.Runtime.InteropServices;
using ApiDebugTest.Common;

namespace ApiDebug
{
    /**
     * 界面规范
     * 标题：微软雅黑 12pt
     * 内容：微软雅黑 10pt
     * 主题颜色：蓝色
     * 主按钮颜色：蓝色
     * 辅按钮颜色：灰色
     */
    public partial class ApiDebugTool : Form
    {
        // 自定义默认标签
        private const string REPLACE_TAG = "已赋值";

        // 请求示例
        private const string EXAMPLE = @"{
    ""ID"": 10002,
    ""FileName"": ""photo.png"",
    ""FileContent"": ""$image1""
}";

        private ConcurrentDictionary<string, string> mapImage = new ConcurrentDictionary<string, string>();

        public ApiDebugTool()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 发起请求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fileSubmit_Click(object sender, EventArgs e)
        {
            if (rtb_Request.Text.Contains("$"))
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("请求参数存在未赋值的变量[$变量名]，您确定是否继续？", txt_Image.Text), "请确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
            }

            try
            {
                string strReqType = cbo_RequestType.Text;
                string strUrl = txt_Url.Text.Trim();
                string strRequest = rtb_Request.Text.Trim();
                string strPostData = ReplaceValueTmp(strRequest);
                ApiRequest request = new ApiRequest();
                rtb_Response.Text = request.NetRequest(strReqType, strUrl, strPostData);
            }
            catch (Exception ex)
            {
                rtb_Response.Text = string.Format("请求异常:{0}\n{1}", ex.Message,ex.StackTrace);
            }
        }

        /// <summary>
        /// 替换请求参数中的变量 标记为已赋值
        /// </summary>
        /// <param name="strRep"></param>
        /// <returns></returns>
        private string ReplaceValueTmp(string strRep)
        {
            foreach (KeyValuePair<string, string> item in mapImage)
            {
                string key = item.Key;
                string value = item.Value;
                strRep = strRep.ReplaceAll(string.Format("<{0}>{1}</{0}>", REPLACE_TAG, key), value);
            }
            return strRep;
        }

        /// <summary>
        /// 给对应变量添加附件（给变量赋值）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddImage_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!rtb_Request.Text.Contains(txt_Image.Text))
            {
                MessageBox.Show(string.Format("请求参数中找不到[{0}]变量，请按“$变量名”格式添加参数！", txt_Image.Text));
                return;
            }

            OpenFileDialog fileDialog = new OpenFileDialog();
            string base64 = string.Empty;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string strRequest = rtb_Request.Text;
                string strRep = txt_Image.Text;
                string fileExtens = Path.GetExtension(fileDialog.FileName);
                string fileName = fileDialog.FileName;
                byte[] buffur = new byte[0];
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader r = new BinaryReader(fs))
                    {
                        //将文件指针设置到文件开
                        r.BaseStream.Seek(0, SeekOrigin.Begin);    
                        buffur = r.ReadBytes((int)r.BaseStream.Length);
                    }
                }
                //double size = (buffur.Length / 1024.00) / 1024.00;//压缩前大小
                //byte[] bufferCompress = BaseFunc.Compress(buffur);
                //double sizeCompress = (bufferCompress.Length / 1024.00) / 1024.00;//压缩后大小
                base64 = Convert.ToBase64String(buffur);

                //记录添加附件的map $image1 -> base64
                string strNewTagValue = strRep.Substring(1, strRep.Length - 1);
                mapImage.AddOrUpdate(strNewTagValue, base64, (k, v) => { return base64; });

                //界面请求参数替换 $image1 -> <已赋值>image1</已赋值>
                string strNewValue = string.Format("<{0}>{1}</{0}>", REPLACE_TAG, strNewTagValue);

                rtb_Request.Text = strRequest.ReplaceAll(strRep, strNewValue);
            }
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApiDebugTool_Load(object sender, EventArgs e)
        {
            cbo_RequestType.SelectedIndex = 0;
            ShowExample();
        }

        /// <summary>
        /// 窗体拖拽
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            ApiDebugTool_MouseDown(this, e);
        }

        private void ApiDebugTool_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }

        /// <summary>
        /// 最小化窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 最大化窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 窗体绘制边框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApiDebugTool_Paint(object sender, PaintEventArgs e)
        {
            DrawBorder(e);
        }

        /// <summary>
        /// label分割线绘制边框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lab_Split_Paint(object sender, PaintEventArgs e)
        {
            DrawBorder(e);
        }

        /// <summary>
        /// 绘制边框
        /// </summary>
        /// <param name="e"></param>
        private void DrawBorder(PaintEventArgs e)
        {
            Rectangle myRectangle = new Rectangle(0, 0, this.Width, this.Height);
            ControlPaint.DrawBorder(e.Graphics, myRectangle,
                 Color.FromArgb(1, 122, 204), 1, ButtonBorderStyle.Solid,
                 Color.FromArgb(1, 122, 204), 1, ButtonBorderStyle.Solid,
                 Color.FromArgb(1, 122, 204), 1, ButtonBorderStyle.Solid,
                 Color.FromArgb(1, 122, 204), 1, ButtonBorderStyle.Solid
             );
        }

        /// <summary>
        /// 请求参数文本框 光标进入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtb_Request_Enter(object sender, EventArgs e)
        {
            if (rtb_Request.Text.Equals(EXAMPLE.ReplaceAll("\r","")))
            {
                rtb_Request.Clear();
                rtb_Request.ForeColor = Color.Black;
                rtb_Request.Font = new Font(new FontFamily("微软雅黑"), 9);
            }
        }

        /// <summary>
        /// 请求参数文本框 光标离开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtb_Request_Leave(object sender, EventArgs e)
        {
            if (rtb_Request.Text.Equals(""))
            {
                ShowExample();
            }
        }

        /// <summary>
        /// 显示请求示例
        /// </summary>
        private void ShowExample()
        {
            if (rtb_Request.Text.Equals(""))
            {
                rtb_Request.ForeColor = Color.Gray;
                rtb_Request.Font = new Font(new FontFamily("微软雅黑"), 9, FontStyle.Italic);
                rtb_Request.Text = EXAMPLE;
            }
        }
    }
}