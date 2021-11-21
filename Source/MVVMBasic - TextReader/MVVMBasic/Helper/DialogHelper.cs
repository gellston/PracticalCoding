using DevExpress.Xpf.Core;
using DevExpress.Xpf.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMBasic.Helper
{
    public class DialogHelper
    {

        static void ShowErrorMessage(string message)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                DXMessageBox.Show(message, "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            });

        }

        static public bool ShowConfirmMessage(string message)
        {
            bool check = false;
            Application.Current.Dispatcher.Invoke(() =>
            {
                var Result = DXMessageBox.Show(message, "Confirm", System.Windows.MessageBoxButton.YesNo, System.Windows.MessageBoxImage.Information);
                if (MessageBoxResult.Yes == Result) check = true;
                else check = false;
            });

            return check;
        }

        static public string OpenFolder()
        {
            DXFolderBrowserDialog dialog = new DXFolderBrowserDialog();
            if (dialog.ShowDialog() == false)
                throw new Exception("Folder is not selected");

            return dialog.SelectedPath;
        }

        static public string SaveFile(string filter)
        {
            DXSaveFileDialog dialog = new DXSaveFileDialog();
            dialog.Filter = filter;

            if (dialog.ShowDialog() == false)
                throw new Exception("File is not selected");

            return dialog.FileName;
        }

        static public string OpenFile(string filter)
        {
            DXOpenFileDialog dialog = new DXOpenFileDialog();
            dialog.Filter = filter;

            if (dialog.ShowDialog() == false)
                throw new Exception("File is not selected");

            return dialog.FileName;
        }

        static public string[] OpenFiles(string filter)
        {
            DXOpenFileDialog dialog = new DXOpenFileDialog();
            dialog.Filter = filter;

            if (dialog.ShowDialog() == false)
                throw new Exception("Files are not selected");

            return dialog.FileNames;
        }

    }
}
