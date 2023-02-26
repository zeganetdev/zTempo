using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace zTempo.Helpers
{
    internal static class ZMessage
    {
        static string title = "zTempo";
        internal static void Information(IWin32Window owner, string text)
        {
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar(text, 1200, "OK", false);
            SnackBarMessage.Show(owner);
        }

        internal static void Information(IWin32Window owner, string text, int duration)
        {
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar(text, duration, "OK", true);
            SnackBarMessage.Show(owner);
        }

        internal static void InformationModal(Form form, string text)
        {
            MaterialDialog materialDialog = new MaterialDialog(form, title, text, "OK", false, "", true);
            DialogResult result = materialDialog.ShowDialog(form);
        }

        internal static void Error(string text)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
