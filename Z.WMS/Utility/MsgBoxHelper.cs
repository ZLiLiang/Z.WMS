using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z.WMS
{
    public class MsgBoxHelper
    {
        /// <summary>
        /// 消息提示框  成功
        /// </summary>
        /// <param name="title"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static DialogResult MsgBoxShow(string title, string msg)
        {
            return MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Confirm问题询问框
        /// </summary>
        /// <param name="title"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static DialogResult MsgBoxConfirm(string title, string msg)
        {
            return MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /// <summary>
        /// 错误消息框
        /// </summary>
        /// <param name="title"></param>
        /// <param name="msg"></param>
        public static void MsgErrorShow(string title, string msg)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
