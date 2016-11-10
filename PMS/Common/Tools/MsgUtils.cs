using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.Tools
{
    public static class MsgUtils
    {
        private static string _title = "生产管理系统";

        public static void ShowInfoMsg(string _msg)
        {
            MessageBox.Show(_msg, _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowWarnMsg(string _msg)
        {
            MessageBox.Show(_msg, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowErrorMsg(string _msg)
        {
            MessageBox.Show(_msg, _title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowQustMsg(string _msg, MessageBoxDefaultButton db)
        {
            return MessageBox.Show(_msg, _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, db);
        }
    }
}
